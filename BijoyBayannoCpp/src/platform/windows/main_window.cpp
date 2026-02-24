#include "platform/windows/main_window.h"

#include "core/app_state.h"
#include "core/window_layout_binding.h"
#include "platform/windows/resource.h"

#include <commctrl.h>
#include <shellapi.h>
#include <windows.h>

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
NOTIFYICONDATAW g_notifyIcon = {};
HMENU g_trayMenu = nullptr;

void SetMainWindowVisible(bool visible) {
  if (g_mainWindow) {
    ShowWindow(g_mainWindow, visible ? SW_SHOW : SW_HIDE);
  }
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
    const int index = static_cast<int>(id - IDM_TRAY_LAYOUT_BASE);
    bijoy::core::SetCurrentLayout(index);
    if (auto* layout = bijoy::core::GetLayoutByIndex(index)) {
      bijoy::core::AddWindowLayoutBinding(GetForegroundWindow(), layout);
    }
  }
}

LRESULT CALLBACK MainWindowProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam) {
  switch (msg) {
    case WM_CREATE: {
      g_notifyIcon.cbSize = sizeof(g_notifyIcon);
      g_notifyIcon.hWnd = hwnd;
      g_notifyIcon.uID = ID_TRAY;
      g_notifyIcon.uFlags = NIF_ICON | NIF_MESSAGE | NIF_TIP;
      g_notifyIcon.uCallbackMessage = kTrayIconMessage;
      g_notifyIcon.hIcon = LoadIconW(nullptr, IDI_APPLICATION);
      wcscpy_s(g_notifyIcon.szTip, L"Bijoy Bayanno");
      Shell_NotifyIconW(NIM_ADD, &g_notifyIcon);

      g_trayMenu = CreatePopupMenu();
      AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_SHOW, L"&Show");
      AppendMenuW(g_trayMenu, MF_SEPARATOR, 0, nullptr);
      for (int i = 0; i < bijoy::core::GetLayoutCount(); ++i) {
        if (auto* layout = bijoy::core::GetLayoutByIndex(i)) {
          AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_LAYOUT_BASE + i, layout->name.c_str());
        }
      }
      AppendMenuW(g_trayMenu, MF_SEPARATOR, 0, nullptr);
      AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_EXIT, L"E&xit");
      return 0;
    }
    case kTrayIconMessage:
      if (lParam == WM_RBUTTONUP) {
        POINT pt;
        GetCursorPos(&pt);
        SetForegroundWindow(hwnd);
        const int cmd = TrackPopupMenu(g_trayMenu, TPM_RETURNCMD | TPM_NONBLOCKING, pt.x, pt.y, 0, hwnd, nullptr);
        if (cmd) {
          OnTrayCommand(static_cast<UINT>(cmd));
        }
      } else if (lParam == WM_LBUTTONDBLCLK) {
        SetMainWindowVisible(true);
      }
      return 0;
    case WM_CLOSE:
      ShowWindow(hwnd, SW_HIDE);
      return 0;
    case WM_DESTROY:
      Shell_NotifyIconW(NIM_DELETE, &g_notifyIcon);
      if (g_trayMenu) {
        DestroyMenu(g_trayMenu);
      }
      PostQuitMessage(0);
      return 0;
    default:
      return DefWindowProcW(hwnd, msg, wParam, lParam);
  }
}

} // namespace

HWND CreateMainWindow(HINSTANCE hInstance) {
  WNDCLASSEXW windowClass = {};
  windowClass.cbSize = sizeof(windowClass);
  windowClass.lpfnWndProc = MainWindowProc;
  windowClass.hInstance = hInstance;
  windowClass.lpszClassName = L"BijoyBayannoMain";
  windowClass.hCursor = LoadCursor(nullptr, IDC_ARROW);
  RegisterClassExW(&windowClass);

  g_mainWindow = CreateWindowExW(
      0,
      windowClass.lpszClassName,
      L"Bijoy Bayanno",
      WS_OVERLAPPEDWINDOW,
      CW_USEDEFAULT,
      CW_USEDEFAULT,
      320,
      200,
      nullptr,
      nullptr,
      hInstance,
      nullptr);
  return g_mainWindow;
}

} // namespace bijoy::platform::windows
