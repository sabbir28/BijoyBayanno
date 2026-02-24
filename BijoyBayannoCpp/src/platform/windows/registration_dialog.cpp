#include "platform/windows/registration_dialog.h"

#include "platform/windows/resource.h"
#include "utils/system_utils.h"

#include <commctrl.h>
#include <string>
#include <windows.h>

#pragma comment(lib, "comctl32.lib")

namespace bijoy::platform::windows {

namespace {

HWND g_hwndSplash = nullptr;

std::wstring GetDialogItemText(HWND dialog, int id) {
  HWND control = GetDlgItem(dialog, id);
  if (!control) return L"";

  const int len = GetWindowTextLengthW(control) + 1;
  if (len <= 1) return L"";

  std::wstring value(len, 0);
  GetWindowTextW(control, &value[0], len);
  value.resize(len - 1);
  return value;
}

INT_PTR CALLBACK RegistrationDialogProc(HWND dialog, UINT msg, WPARAM wParam, LPARAM lParam) {
  (void)lParam;
  switch (msg) {
    case WM_INITDIALOG: {
      std::wstring saved;
      bijoy::utils::GetRegistryPassword(saved);
      if (saved == bijoy::utils::Password) {
        ShowWindow(dialog, SW_HIDE);
        if (g_hwndSplash) ShowWindow(g_hwndSplash, SW_SHOW);
        return TRUE;
      }
      SetDlgItemTextW(dialog, IDC_ID_EDIT, bijoy::utils::GetMachineId().c_str());
      return TRUE;
    }
    case WM_CLOSE:
      EndDialog(dialog, 0);
      return TRUE;
    case WM_COMMAND:
      if (LOWORD(wParam) == IDOK_BTN) {
        const std::wstring pass = GetDialogItemText(dialog, IDC_PASSWORD_EDIT) +
                                  GetDialogItemText(dialog, IDC_PASSWORD1) +
                                  GetDialogItemText(dialog, IDC_PASSWORD2) +
                                  GetDialogItemText(dialog, IDC_PASSWORD3) +
                                  GetDialogItemText(dialog, IDC_PASSWORD4);
        if (pass.size() > 2 && pass == bijoy::utils::Password) {
          bijoy::utils::SetRegistryPassword(bijoy::utils::Password);
          ShowWindow(dialog, SW_HIDE);
          if (g_hwndSplash) ShowWindow(g_hwndSplash, SW_SHOW);
          EndDialog(dialog, 1);
        } else {
          MessageBoxW(dialog, L"Wrong Password", L"Bijoy Bayanno", MB_OK | MB_ICONERROR);
        }
        return TRUE;
      }
      if (LOWORD(wParam) == IDCANCEL_BTN) {
        EndDialog(dialog, 0);
        return TRUE;
      }
      break;
  }
  return FALSE;
}

} // namespace

int ShowRegistrationDialog(HWND hParent, HWND hwndSplash) {
  g_hwndSplash = hwndSplash;
  return static_cast<int>(DialogBoxW(GetModuleHandle(nullptr), MAKEINTRESOURCEW(IDD_REGISTRATION), hParent, RegistrationDialogProc));
}

} // namespace bijoy::platform::windows
