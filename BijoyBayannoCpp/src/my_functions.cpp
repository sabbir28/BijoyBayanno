#include "my_functions.h"
#include <algorithm>
#include <shlwapi.h>

#pragma comment(lib, "shlwapi.lib")

namespace my_functions {

std::wstring Password = L"RN28T29SK1XMJ6XYLK24";

std::wstring VerifyPath(const std::wstring& path) {
  std::wstring p = path;
  if (!p.empty() && p.back() != L'\\') p += L'\\';
  return p;
}

std::wstring Encrypt(const std::wstring& number) {
  std::wstring s = number;
  std::transform(s.begin(), s.end(), s.begin(), ::towlower);
  std::reverse(s.begin(), s.end());
  std::wstring result;
  for (size_t i = 0, j = 0; i < s.size(); i++, j += 2) {
    int c = (int)s[i];
    int n = c + (int)j;
    while (n >= 10 || n < 0) {
      int a = n / 10, b = n % 10;
      if (n < 0) { a = (n - 9) / 10; b = n - a * 10; }
      n = (n / 10) + (n % 10);
      if (n < 0) n = -n;
      n %= 10;
    }
    result += (wchar_t)(L'0' + (n % 10));
  }
  size_t half = (result.size() + 1) / 2;
  std::wstring left = result.substr(0, half);
  std::wstring right = result.substr(half);
  std::reverse(left.begin(), left.end());
  std::reverse(right.begin(), right.end());
  return right + left;
}

std::wstring GetMachineId() {
  wchar_t name[256] = {};
  DWORD size = 256;
  if (GetComputerNameW(name, &size))
    return name;
  return L"PC";
}

bool Drag(HWND hwnd) {
  ReleaseCapture();
  SendMessageW(hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
  return true;
}

static const wchar_t* regPath = L"SOFTWARE\\BijoyBayanno\\Options";

int GetRegistryPassword(std::wstring& out) {
  HKEY hKey = nullptr;
  if (RegOpenKeyExW(HKEY_CURRENT_USER, regPath, 0, KEY_READ, &hKey) != ERROR_SUCCESS)
    return -1;
  wchar_t buf[256] = {};
  DWORD bufSize = sizeof(buf);
  DWORD type = 0;
  LSTATUS st = RegQueryValueExW(hKey, L"Password", nullptr, &type, (LPBYTE)buf, &bufSize);
  RegCloseKey(hKey);
  if (st != ERROR_SUCCESS) return -1;
  out = buf;
  return 0;
}

int SetRegistryPassword(const std::wstring& value) {
  HKEY hKey = nullptr;
  if (RegCreateKeyExW(HKEY_CURRENT_USER, regPath, 0, nullptr, 0, KEY_WRITE, nullptr, &hKey, nullptr) != ERROR_SUCCESS)
    return -1;
  std::string utf8(value.begin(), value.end());
  LSTATUS st = RegSetValueExW(hKey, L"Password", 0, REG_SZ, (const BYTE*)value.c_str(), (DWORD)((value.size() + 1) * sizeof(wchar_t)));
  RegCloseKey(hKey);
  return (st == ERROR_SUCCESS) ? 0 : -1;
}

} // namespace my_functions
