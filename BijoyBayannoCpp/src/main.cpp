#include "resource.h"
#include "app_state.h"
#include "find_layouts.h"
#include "keyboard_hook.h"
#include "dlg_registration.h"
#include "dlg_main.h"
#include <windows.h>
#include <commctrl.h>
#include <shellapi.h>

#pragma comment(lib, "comctl32.lib")

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPWSTR lpCmdLine, int nCmdShow) {
  (void)hPrevInstance;
  (void)lpCmdLine;
  (void)nCmdShow;

  INITCOMMONCONTROLSEX icc = { sizeof(icc), ICC_STANDARD_CLASSES };
  InitCommonControlsEx(&icc);

  std::wstring appDir = GetAppDirectory();
  if (!FindLayouts(g_layouts, appDir)) {
    MessageBoxW(nullptr, L"'Layouts' folder not found or no XML files.", L"Bijoy Bayanno", MB_OK | MB_ICONERROR);
    return 1;
  }

  if (!KeyboardHook_Install(hInstance)) {
    MessageBoxW(nullptr, L"Failed to install keyboard hook.", L"Bijoy Bayanno", MB_OK | MB_ICONERROR);
    return 1;
  }
  KeyboardHook_SetLayoutsReady(true);

  HWND hwndMain = CreateMainWindow(hInstance);
  if (!hwndMain) return 1;
  ShowWindow(hwndMain, SW_HIDE);

  HWND hwndSplash = nullptr;
  ShowRegistrationDialog(hwndMain, hwndSplash);
  ShowWindow(hwndMain, SW_SHOW);

  MSG msg;
  while (GetMessage(&msg, nullptr, 0, 0)) {
    TranslateMessage(&msg);
    DispatchMessage(&msg);
  }

  KeyboardHook_Uninstall();
  return (int)msg.wParam;
}
