#include "resource.h"
#include "my_functions.h"
#include "find_layouts.h"
#include <windows.h>
#include <commctrl.h>
#include <string>

#pragma comment(lib, "comctl32.lib")

static HWND g_hwndSplash = nullptr;

static std::wstring GetDlgItemTextW(HWND hDlg, int id) {
  HWND c = GetDlgItem(hDlg, id);
  if (!c) return L"";
  int len = GetWindowTextLengthW(c) + 1;
  if (len <= 1) return L"";
  std::wstring s(len, 0);
  GetWindowTextW(c, &s[0], len);
  s.resize(len - 1);
  return s;
}

static void SetDlgItemTextStr(HWND hDlg, int id, const std::wstring& text) {
  SetDlgItemTextW(hDlg, id, text.c_str());
}

static INT_PTR CALLBACK RegistrationDlgProc(HWND hDlg, UINT msg, WPARAM wParam, LPARAM lParam) {
  (void)lParam;
  switch (msg) {
  case WM_INITDIALOG: {
    std::wstring saved;
    my_functions::GetRegistryPassword(saved);
    if (saved == my_functions::Password) {
      ShowWindow(hDlg, SW_HIDE);
      if (g_hwndSplash) ShowWindow(g_hwndSplash, SW_SHOW);
      return TRUE;
    }
    std::wstring machineId = my_functions::GetMachineId();
    SetDlgItemTextStr(hDlg, IDC_ID_EDIT, machineId);
    return TRUE;
  }
  case WM_CLOSE:
    EndDialog(hDlg, 0);
    return TRUE;
  case WM_COMMAND:
    if (LOWORD(wParam) == IDOK_BTN) {
      std::wstring p1 = GetDlgItemTextW(hDlg, IDC_PASSWORD_EDIT);
      std::wstring p2 = GetDlgItemTextW(hDlg, IDC_PASSWORD1);
      std::wstring p3 = GetDlgItemTextW(hDlg, IDC_PASSWORD2);
      std::wstring p4 = GetDlgItemTextW(hDlg, IDC_PASSWORD3);
      std::wstring p5 = GetDlgItemTextW(hDlg, IDC_PASSWORD4);
      std::wstring passColl = p1 + p2 + p3 + p4 + p5;
      if (p1.length() > 2 && passColl == my_functions::Password) {
        my_functions::SetRegistryPassword(my_functions::Password);
        ShowWindow(hDlg, SW_HIDE);
        if (g_hwndSplash) ShowWindow(g_hwndSplash, SW_SHOW);
        EndDialog(hDlg, 1);
      } else {
        MessageBoxW(hDlg, L"Wrong Password", L"Bijoy Bayanno", MB_OK | MB_ICONERROR);
      }
      return TRUE;
    }
    if (LOWORD(wParam) == IDCANCEL_BTN) {
      EndDialog(hDlg, 0);
      return TRUE;
    }
    break;
  }
  return FALSE;
}

int ShowRegistrationDialog(HWND hParent, HWND hwndSplash) {
  g_hwndSplash = hwndSplash;
  return (int)DialogBoxW(GetModuleHandle(nullptr), MAKEINTRESOURCEW(IDD_REGISTRATION), hParent, RegistrationDlgProc);
}
