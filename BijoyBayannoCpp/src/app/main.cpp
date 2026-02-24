#include "core/app_state.h"
#include "core/keyboard_hook_service.h"
#include "core/layout_discovery.h"
#include "platform/windows/main_window.h"
#include "platform/windows/registration_dialog.h"

#include <commctrl.h>
#include <windows.h>

int WINAPI wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPWSTR lpCmdLine, int nCmdShow) {
  (void)hPrevInstance;
  (void)lpCmdLine;
  (void)nCmdShow;

  INITCOMMONCONTROLSEX icc = {sizeof(icc), ICC_STANDARD_CLASSES};
  InitCommonControlsEx(&icc);

  const std::wstring appDir = bijoy::core::GetAppDirectory();
  if (!bijoy::core::FindLayouts(bijoy::core::g_layouts, appDir)) {
    MessageBoxW(nullptr, L"'Layouts' folder not found or no XML files.", L"Bijoy Bayanno", MB_OK | MB_ICONERROR);
    return 1;
  }

  if (!bijoy::core::InstallKeyboardHook(hInstance)) {
    MessageBoxW(nullptr, L"Failed to install keyboard hook.", L"Bijoy Bayanno", MB_OK | MB_ICONERROR);
    return 1;
  }
  bijoy::core::SetLayoutsReady(true);

  HWND mainWindow = bijoy::platform::windows::CreateMainWindow(hInstance);
  if (!mainWindow) {
    return 1;
  }
  ShowWindow(mainWindow, SW_HIDE);

  HWND splashWindow = nullptr;
  bijoy::platform::windows::ShowRegistrationDialog(mainWindow, splashWindow);
  ShowWindow(mainWindow, SW_SHOW);

  MSG msg;
  while (GetMessage(&msg, nullptr, 0, 0)) {
    TranslateMessage(&msg);
    DispatchMessage(&msg);
  }

  bijoy::core::UninstallKeyboardHook();
  return static_cast<int>(msg.wParam);
}
