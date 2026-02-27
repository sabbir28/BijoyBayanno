#include "platform/windows/main_window.h"

#include "core/app_state.h"
#include "core/layout_discovery.h"
#include "core/window_layout_binding.h"
#include "platform/windows/resource.h"

#include <commctrl.h>
#include <shellapi.h>
#include <string>
#include <windows.h>
#include <windowsx.h>

#ifdef _MSC_VER
#pragma comment(lib, "comctl32.lib")
#pragma comment(lib, "shell32.lib")
#endif

#ifndef TPM_NONBLOCKING
#define TPM_NONBLOCKING 0x0000L
#endif

namespace bijoy::platform::windows {

namespace {

constexpr UINT kTrayIconMessage = WM_USER + 1;
HWND g_mainWindow = nullptr;
HWND g_layoutCombo = nullptr;
HWND g_layoutIcon = nullptr;
HWND g_optionsButton = nullptr;
HWND g_layoutEditorButton = nullptr;
HWND g_minimizeButton = nullptr;
HWND g_closeButton = nullptr;
HWND g_tooltipWindow = nullptr;

NOTIFYICONDATAW g_notifyIcon = {};
HMENU g_trayMenu = nullptr;
HICON g_defaultIcon = nullptr;
HICON g_layoutDisplayIcon = nullptr;
HICON g_windowClassIconLarge = nullptr;
HICON g_windowClassIconSmall = nullptr;
bool g_ownsDefaultIcon = false;
int g_requestedWindowTop = 0;

constexpr int kForcedTopY = 0;

void SnapWindowToTop(HWND hwnd) {
  if (!hwnd) {
    return;
  }

  RECT windowRect = {};
  if (!GetWindowRect(hwnd, &windowRect)) {
    return;
  }

  SetWindowPos(
      hwnd,
      nullptr,
      windowRect.left,
      kForcedTopY,
      0,
      0,
      SWP_NOSIZE | SWP_NOZORDER | SWP_NOACTIVATE);
}


std::wstring BuildPath(const std::wstring& base, const wchar_t* relative) {
  std::wstring path = base;
  path += relative;
  return path;
}

std::wstring BuildPath(const std::wstring& base, const std::wstring& relative) {
  std::wstring path = base;
  path += relative;
  return path;
}

HICON LoadIconFromPath(const std::wstring& path, int width, int height) {
  return static_cast<HICON>(LoadImageW(
      nullptr,
      path.c_str(),
      IMAGE_ICON,
      width,
      height,
      LR_LOADFROMFILE));
}

HICON LoadAppIconFromData(int width, int height) {
  const std::wstring appDir = bijoy::core::GetAppDirectory();

  const std::wstring binIconPath = BuildPath(appDir, L"Bijoy.ico");
  if (HICON icon = LoadIconFromPath(binIconPath, width, height)) {
    return icon;
  }

  const std::wstring dataIconPath = BuildPath(appDir, L"..\\data\\Bijoy.ico");
  return LoadIconFromPath(dataIconPath, width, height);
}

HICON LoadLayoutIcon(const bijoy::core::Layout* layout) {
  if (!layout || layout->iconName.empty()) {
    return nullptr;
  }

  std::wstring iconName = layout->iconName;
  const bool hasIcoExt =
      iconName.size() > 4 &&
      _wcsicmp(iconName.c_str() + iconName.size() - 4, L".ico") == 0;
  if (!hasIcoExt) {
    iconName += L".ico";
  }

  const std::wstring appDir = bijoy::core::GetAppDirectory();
  const std::wstring iconPaths[] = {
      BuildPath(appDir, std::wstring(L"Icons\\") + iconName),
      BuildPath(appDir, std::wstring(L"..\\data\\Icons\\") + iconName),
  };

  for (const auto& iconPath : iconPaths) {
    if (HICON icon = LoadIconFromPath(iconPath, 16, 16)) {
      return icon;
    }
  }

  return nullptr;
}

void SetMainWindowVisible(bool visible) {
  if (!g_mainWindow) {
    return;
  }
  ShowWindow(g_mainWindow, visible ? SW_SHOW : SW_HIDE);
}

void ReleaseLayoutDisplayIcon() {
  if (g_layoutDisplayIcon && g_layoutDisplayIcon != g_defaultIcon) {
    DestroyIcon(g_layoutDisplayIcon);
  }
  g_layoutDisplayIcon = nullptr;
}

void SelectLayout(int index) {
  bijoy::core::SetCurrentLayout(index);

  if (g_layoutCombo) {
    SendMessageW(g_layoutCombo, CB_SETCURSEL, static_cast<WPARAM>(index), 0);
  }

  ReleaseLayoutDisplayIcon();
  HICON icon = nullptr;
  if (auto* layout = bijoy::core::GetLayoutByIndex(index)) {
    icon = LoadLayoutIcon(layout);
    bijoy::core::AddWindowLayoutBinding(GetForegroundWindow(), layout);
  }

  if (!icon) {
    icon = g_defaultIcon;
  }

  g_layoutDisplayIcon = icon;

  if (g_layoutIcon) {
    SendMessageW(g_layoutIcon, STM_SETIMAGE, IMAGE_ICON, reinterpret_cast<LPARAM>(icon));
  }

  g_notifyIcon.hIcon = icon;
  Shell_NotifyIconW(NIM_MODIFY, &g_notifyIcon);

  if (g_trayMenu) {
    CheckMenuRadioItem(
        g_trayMenu,
        IDM_TRAY_LAYOUT_BASE,
        IDM_TRAY_LAYOUT_BASE + bijoy::core::GetLayoutCount() - 1,
        IDM_TRAY_LAYOUT_BASE + index,
        MF_BYCOMMAND);
  }
}

void AddTooltip(HWND tool, const wchar_t* text) {
  if (!g_tooltipWindow || !tool || !text) {
    return;
  }

  TOOLINFOW toolInfo = {};
  toolInfo.cbSize = sizeof(toolInfo);
  toolInfo.uFlags = TTF_SUBCLASS;
  toolInfo.hwnd = g_mainWindow;
  toolInfo.uId = reinterpret_cast<UINT_PTR>(tool);
  toolInfo.lpszText = const_cast<LPWSTR>(text);
  toolInfo.rect = {};

  SendMessageW(g_tooltipWindow, TTM_ADDTOOLW, 0, reinterpret_cast<LPARAM>(&toolInfo));
}

void PopulateLayoutCombo() {
  if (!g_layoutCombo) {
    return;
  }

  SendMessageW(g_layoutCombo, CB_RESETCONTENT, 0, 0);

  for (int i = 0; i < bijoy::core::GetLayoutCount(); ++i) {
    if (const auto* layout = bijoy::core::GetLayoutByIndex(i)) {
      SendMessageW(g_layoutCombo, CB_ADDSTRING, 0, reinterpret_cast<LPARAM>(layout->name.c_str()));
    }
  }

  if (bijoy::core::GetLayoutCount() > 0) {
    int currentIndex = bijoy::core::GetCurrentLayoutIndex();
    if (currentIndex < 0 || currentIndex >= bijoy::core::GetLayoutCount()) {
      currentIndex = 0;
    }
    SelectLayout(currentIndex);
  }
}

void BuildTrayMenu() {
  if (g_trayMenu) {
    DestroyMenu(g_trayMenu);
  }

  g_trayMenu = CreatePopupMenu();

  AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_SHOW, L"&Show");
  AppendMenuW(g_trayMenu, MF_SEPARATOR, 0, nullptr);

  for (int i = 0; i < bijoy::core::GetLayoutCount(); ++i) {
    if (const auto* layout = bijoy::core::GetLayoutByIndex(i)) {
      AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_LAYOUT_BASE + i, layout->name.c_str());
    }
  }

  AppendMenuW(g_trayMenu, MF_SEPARATOR, 0, nullptr);
  AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_EXIT, L"E&xit");
}

void OnTrayCommand(UINT id) {
  if (id == IDM_TRAY_EXIT) {
    PostQuitMessage(0);
    return;
  }

  if (id == IDM_TRAY_SHOW) {
    SetMainWindowVisible(true);
    return;
  }

  if (id >= IDM_TRAY_LAYOUT_BASE && id < IDM_TRAY_LAYOUT_BASE + 100) {
    SelectLayout(static_cast<int>(id - IDM_TRAY_LAYOUT_BASE));
  }
}

LRESULT CALLBACK MainWindowProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam) {
  switch (msg) {
    case WM_CREATE: {
      g_defaultIcon = LoadAppIconFromData(16, 16);
      g_ownsDefaultIcon = g_defaultIcon != nullptr;
      if (!g_defaultIcon) {
        g_defaultIcon = LoadIconW(nullptr, IDI_APPLICATION);
      }
      g_layoutDisplayIcon = g_defaultIcon;

      g_layoutIcon = CreateWindowExW(
          0,
          L"STATIC",
          nullptr,
          WS_CHILD | WS_VISIBLE | SS_ICON,
          10,
          9,
          16,
          16,
          hwnd,
          reinterpret_cast<HMENU>(IDC_LAYOUT_ICON),
          nullptr,
          nullptr);
      SendMessageW(g_layoutIcon, STM_SETIMAGE, IMAGE_ICON, reinterpret_cast<LPARAM>(g_defaultIcon));

      g_layoutCombo = CreateWindowExW(
          0,
          WC_COMBOBOXW,
          nullptr,
          WS_CHILD | WS_VISIBLE | CBS_DROPDOWNLIST | WS_VSCROLL,
          34,
          5,
          180,
          300,
          hwnd,
          reinterpret_cast<HMENU>(IDC_LAYOUT_COMBO),
          nullptr,
          nullptr);

      g_optionsButton = CreateWindowExW(
          0,
          WC_BUTTONW,
          L"Options",
          WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
          220,
          5,
          60,
          24,
          hwnd,
          reinterpret_cast<HMENU>(IDC_OPTIONS_BUTTON),
          nullptr,
          nullptr);

      g_layoutEditorButton = CreateWindowExW(
          0,
          WC_BUTTONW,
          L"Layout Editor",
          WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
          284,
          5,
          88,
          24,
          hwnd,
          reinterpret_cast<HMENU>(IDC_LAYOUT_EDITOR_BUTTON),
          nullptr,
          nullptr);

      g_minimizeButton = CreateWindowExW(
          0,
          WC_BUTTONW,
          L"_",
          WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
          376,
          5,
          24,
          24,
          hwnd,
          reinterpret_cast<HMENU>(IDC_MINIMIZE_BUTTON),
          nullptr,
          nullptr);

      g_closeButton = CreateWindowExW(
          0,
          WC_BUTTONW,
          L"X",
          WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON,
          404,
          5,
          24,
          24,
          hwnd,
          reinterpret_cast<HMENU>(IDC_CLOSE_BUTTON),
          nullptr,
          nullptr);

      g_tooltipWindow = CreateWindowExW(
          WS_EX_TOPMOST,
          TOOLTIPS_CLASSW,
          nullptr,
          WS_POPUP | TTS_ALWAYSTIP,
          CW_USEDEFAULT,
          CW_USEDEFAULT,
          CW_USEDEFAULT,
          CW_USEDEFAULT,
          hwnd,
          nullptr,
          nullptr,
          nullptr);

      SendMessageW(g_tooltipWindow, TTM_SETMAXTIPWIDTH, 0, 300);
      SendMessageW(g_tooltipWindow, TTM_SETDELAYTIME, TTDT_INITIAL, 350);
      AddTooltip(g_layoutCombo, L"Select keyboard layout");
      AddTooltip(g_optionsButton, L"Open Options dialog");
      AddTooltip(g_layoutEditorButton, L"Open Layout Editor");
      AddTooltip(g_minimizeButton, L"Minimize to system tray");
      AddTooltip(g_closeButton, L"Close Bijoy Bayanno");

      g_notifyIcon.cbSize = sizeof(g_notifyIcon);
      g_notifyIcon.hWnd = hwnd;
      g_notifyIcon.uID = ID_TRAY;
      g_notifyIcon.uFlags = NIF_ICON | NIF_MESSAGE | NIF_TIP;
      g_notifyIcon.uCallbackMessage = kTrayIconMessage;
      g_notifyIcon.hIcon = g_defaultIcon;
      wcscpy_s(g_notifyIcon.szTip, L"Bijoy Bayanno");
      Shell_NotifyIconW(NIM_ADD, &g_notifyIcon);

      BuildTrayMenu();
      PopulateLayoutCombo();
      return 0;
    }

    case WM_COMMAND: {
      const UINT controlId = LOWORD(wParam);
      const UINT notifyCode = HIWORD(wParam);

      if (controlId == IDC_LAYOUT_COMBO && notifyCode == CBN_SELCHANGE) {
        const int selected = static_cast<int>(SendMessageW(g_layoutCombo, CB_GETCURSEL, 0, 0));
        if (selected >= 0) {
          SelectLayout(selected);
        }
        return 0;
      }

      if (controlId == IDC_OPTIONS_BUTTON) {
        MessageBoxW(hwnd, L"Options dialog is not implemented yet.", L"Bijoy Bayanno", MB_OK | MB_ICONINFORMATION);
        return 0;
      }

      if (controlId == IDC_LAYOUT_EDITOR_BUTTON) {
        MessageBoxW(hwnd, L"Layout Editor is not implemented yet.", L"Bijoy Bayanno", MB_OK | MB_ICONINFORMATION);
        return 0;
      }

      if (controlId == IDC_MINIMIZE_BUTTON) {
        SetMainWindowVisible(false);
        return 0;
      }

      if (controlId == IDC_CLOSE_BUTTON) {
        PostQuitMessage(0);
        return 0;
      }

      break;
    }

    case kTrayIconMessage:
      if (lParam == WM_RBUTTONUP) {
        POINT pt;
        GetCursorPos(&pt);
        SetForegroundWindow(hwnd);

        const int command = TrackPopupMenu(
            g_trayMenu,
            TPM_RETURNCMD | TPM_NONBLOCKING,
            pt.x,
            pt.y,
            0,
            hwnd,
            nullptr);

        if (command) {
          OnTrayCommand(static_cast<UINT>(command));
        }
      } else if (lParam == WM_LBUTTONDBLCLK) {
        SetMainWindowVisible(true);
      }
      return 0;

    case WM_LBUTTONDOWN: {
      const POINT cursorPoint = {GET_X_LPARAM(lParam), GET_Y_LPARAM(lParam)};
      HWND childAtPoint = ChildWindowFromPointEx(hwnd, cursorPoint, CWP_SKIPINVISIBLE | CWP_SKIPDISABLED);
      if (!childAtPoint || childAtPoint == hwnd) {
        ReleaseCapture();
        SendMessageW(hwnd, WM_SYSCOMMAND, SC_MOVE | HTCAPTION, 0);
        return 0;
      }
      break;
    }

    case WM_WINDOWPOSCHANGING: {
      auto* windowPos = reinterpret_cast<WINDOWPOS*>(lParam);
      if (windowPos != nullptr && (windowPos->flags & SWP_NOMOVE) == 0) {
        if (windowPos->y > 1) {
          windowPos->y = kForcedTopY;
        }
      }
      break;
    }

    case WM_EXITSIZEMOVE:
      SnapWindowToTop(hwnd);
      return 0;

    case WM_CLOSE:
      SetMainWindowVisible(false);
      return 0;

    case WM_DESTROY:
      Shell_NotifyIconW(NIM_DELETE, &g_notifyIcon);
      if (g_trayMenu) {
        DestroyMenu(g_trayMenu);
        g_trayMenu = nullptr;
      }
      ReleaseLayoutDisplayIcon();
      if (g_ownsDefaultIcon && g_defaultIcon) {
        DestroyIcon(g_defaultIcon);
      }
      g_defaultIcon = nullptr;
      g_ownsDefaultIcon = false;
      if (g_windowClassIconLarge) {
        DestroyIcon(g_windowClassIconLarge);
        g_windowClassIconLarge = nullptr;
      }
      if (g_windowClassIconSmall) {
        DestroyIcon(g_windowClassIconSmall);
        g_windowClassIconSmall = nullptr;
      }
      PostQuitMessage(0);
      return 0;

    default:
      return DefWindowProcW(hwnd, msg, wParam, lParam);
  }

  return DefWindowProcW(hwnd, msg, wParam, lParam);
}

} // namespace

HWND CreateMainWindow(HINSTANCE hInstance) {
  g_windowClassIconLarge = LoadAppIconFromData(32, 32);
  g_windowClassIconSmall = LoadAppIconFromData(16, 16);

  WNDCLASSEXW windowClass = {};
  windowClass.cbSize = sizeof(windowClass);
  windowClass.lpfnWndProc = MainWindowProc;
  windowClass.hInstance = hInstance;
  windowClass.lpszClassName = L"BijoyBayannoMain";
  windowClass.hIcon = g_windowClassIconLarge;
  windowClass.hIconSm = g_windowClassIconSmall;
  windowClass.hCursor = LoadCursor(nullptr, IDC_ARROW);
  windowClass.hbrBackground = reinterpret_cast<HBRUSH>(COLOR_BTNFACE + 1);

  RegisterClassExW(&windowClass);

  g_mainWindow = CreateWindowExW(
      WS_EX_TOOLWINDOW | WS_EX_TOPMOST,
      windowClass.lpszClassName,
      L"Bijoy Bayanno",
      WS_POPUPWINDOW,
      CW_USEDEFAULT,
      g_requestedWindowTop,
      440,
      40,
      nullptr,
      nullptr,
      hInstance,
      nullptr);

  return g_mainWindow;
}

void SetMainWindowInitialPosition(int left, int top) {
  g_requestedWindowTop = (top <= 1) ? top : kForcedTopY;

  if (g_mainWindow) {
    const int targetLeft = left >= 0 ? left : 0;
    SetWindowPos(
        g_mainWindow,
        nullptr,
        targetLeft,
        g_requestedWindowTop,
        0,
        0,
        SWP_NOSIZE | SWP_NOZORDER | SWP_NOACTIVATE);
  }
}

} // namespace bijoy::platform::windows
