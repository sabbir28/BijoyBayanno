#include "resource.h"
#include "app_state.h"
#include "layout.h"
#include "handle_info.h"
#include "find_layouts.h"
#include "keyboard_hook.h"
#include "my_functions.h"
#include <windows.h>
#include <shellapi.h>
#include <commctrl.h>
#include <string>

#pragma comment(lib, "comctl32.lib")
#pragma comment(lib, "shell32.lib")

#define WM_TRAYICON (WM_USER + 1)
#define ID_TRAY 2001

static HWND g_hwndMain = nullptr;
static NOTIFYICONDATAW g_nid = {};
static HMENU g_trayMenu = nullptr;
static bool g_showWindow = true;

static void ShowMainWindow(bool show) {
  g_showWindow = show;
  if (g_hwndMain) {
    ShowWindow(g_hwndMain, show ? SW_SHOW : SW_HIDE);
  }
}

static void OnTrayCommand(HWND hwnd, UINT id) {
  if (id == IDM_TRAY_EXIT) {
    PostQuitMessage(0);
    return;
  }
  if (id == IDM_TRAY_SHOW) {
    ShowMainWindow(true);
    return;
  }
  int layoutBase = IDM_TRAY_LAYOUT_BASE;
  if (id >= layoutBase && id < layoutBase + 100) {
    int index = id - layoutBase;
    AppState_SetCurrentLayout(index);
    Layout* lay = AppState_GetLayoutByIndex(index);
    if (lay) AddInfo(GetForegroundWindow(), lay);
  }
}

static LRESULT CALLBACK MainWndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam) {
  switch (msg) {
  case WM_CREATE: {
    g_nid.cbSize = sizeof(g_nid);
    g_nid.hWnd = hwnd;
    g_nid.uID = ID_TRAY;
    g_nid.uFlags = NIF_ICON | NIF_MESSAGE | NIF_TIP;
    g_nid.uCallbackMessage = WM_TRAYICON;
g_nid.hIcon = LoadIconW(nullptr, IDI_APPLICATION);
    wcscpy_s(g_nid.szTip, L"Bijoy Bayanno");
    Shell_NotifyIconW(NIM_ADD, &g_nid);
    g_trayMenu = CreatePopupMenu();
    AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_SHOW, L"&Show");
    AppendMenuW(g_trayMenu, MF_SEPARATOR, 0, nullptr);
    for (int i = 0; i < AppState_GetLayoutCount(); i++) {
      Layout* lay = AppState_GetLayoutByIndex(i);
      if (lay) AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_LAYOUT_BASE + i, lay->name.c_str());
    }
    AppendMenuW(g_trayMenu, MF_SEPARATOR, 0, nullptr);
    AppendMenuW(g_trayMenu, MF_STRING, IDM_TRAY_EXIT, L"E&xit");
    return 0;
  }
  case WM_TRAYICON:
    if (lParam == WM_RBUTTONUP) {
      POINT pt;
      GetCursorPos(&pt);
      SetForegroundWindow(hwnd);
      int cmd = TrackPopupMenu(g_trayMenu, TPM_RETURNCMD | TPM_NONBLOCKING, pt.x, pt.y, 0, hwnd, nullptr);
      if (cmd) OnTrayCommand(hwnd, cmd);
    }
    if (lParam == WM_LBUTTONDBLCLK) {
      ShowMainWindow(true);
    }
    return 0;
  case WM_CLOSE:
    ShowWindow(hwnd, SW_HIDE);
    return 0;
  case WM_DESTROY:
    Shell_NotifyIconW(NIM_DELETE, &g_nid);
    if (g_trayMenu) DestroyMenu(g_trayMenu);
    PostQuitMessage(0);
    return 0;
  }
  return DefWindowProcW(hwnd, msg, wParam, lParam);
}

HWND CreateMainWindow(HINSTANCE hInstance) {
  WNDCLASSEXW wc = {};
  wc.cbSize = sizeof(wc);
  wc.lpfnWndProc = MainWndProc;
  wc.hInstance = hInstance;
  wc.lpszClassName = L"BijoyBayannoMain";
  wc.hCursor = LoadCursor(nullptr, IDC_ARROW);
  RegisterClassExW(&wc);
  g_hwndMain = CreateWindowExW(0, wc.lpszClassName, L"Bijoy Bayanno",
    WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 320, 200,
    nullptr, nullptr, hInstance, nullptr);
  return g_hwndMain;
}
