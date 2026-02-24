#include "utils/system_utils.h"

#include <algorithm>

namespace bijoy::utils {

std::wstring Password = L"RN28T29SK1XMJ6XYLK24";

std::wstring EnsureTrailingBackslash(const std::wstring& path) {
  std::wstring normalized = path;
  if (!normalized.empty() && normalized.back() != L'\\') {
    normalized += L'\\';
  }
  return normalized;
}

std::wstring Encrypt(const std::wstring& number) {
  std::wstring value = number;
  std::transform(value.begin(), value.end(), value.begin(), ::towlower);
  std::reverse(value.begin(), value.end());

  std::wstring result;
  for (size_t i = 0, j = 0; i < value.size(); ++i, j += 2) {
    int n = static_cast<int>(value[i]) + static_cast<int>(j);
    while (n >= 10 || n < 0) {
      n = (n / 10) + (n % 10);
      if (n < 0) n = -n;
      n %= 10;
    }
    result += static_cast<wchar_t>(L'0' + (n % 10));
  }

  const size_t half = (result.size() + 1) / 2;
  std::wstring left = result.substr(0, half);
  std::wstring right = result.substr(half);
  std::reverse(left.begin(), left.end());
  std::reverse(right.begin(), right.end());
  return right + left;
}

std::wstring GetMachineId() {
  wchar_t name[256] = {};
  DWORD size = 256;
  return GetComputerNameW(name, &size) ? name : L"PC";
}

bool Drag(HWND hwnd) {
  ReleaseCapture();
  SendMessageW(hwnd, WM_NCLBUTTONDOWN, HTCAPTION, 0);
  return true;
}

namespace {

constexpr const wchar_t* kRegistryPath = L"SOFTWARE\\BijoyBayanno\\Options";

} // namespace

int GetRegistryPassword(std::wstring& out) {
  HKEY key = nullptr;
  if (RegOpenKeyExW(HKEY_CURRENT_USER, kRegistryPath, 0, KEY_READ, &key) != ERROR_SUCCESS) {
    return -1;
  }

  wchar_t buffer[256] = {};
  DWORD size = sizeof(buffer);
  DWORD type = 0;
  const LSTATUS status = RegQueryValueExW(key, L"Password", nullptr, &type, reinterpret_cast<LPBYTE>(buffer), &size);
  RegCloseKey(key);

  if (status != ERROR_SUCCESS) {
    return -1;
  }

  out = buffer;
  return 0;
}

int SetRegistryPassword(const std::wstring& value) {
  HKEY key = nullptr;
  if (RegCreateKeyExW(HKEY_CURRENT_USER, kRegistryPath, 0, nullptr, 0, KEY_WRITE, nullptr, &key, nullptr) != ERROR_SUCCESS) {
    return -1;
  }

  const LSTATUS status = RegSetValueExW(
      key,
      L"Password",
      0,
      REG_SZ,
      reinterpret_cast<const BYTE*>(value.c_str()),
      static_cast<DWORD>((value.size() + 1) * sizeof(wchar_t)));
  RegCloseKey(key);
  return status == ERROR_SUCCESS ? 0 : -1;
}

} // namespace bijoy::utils
