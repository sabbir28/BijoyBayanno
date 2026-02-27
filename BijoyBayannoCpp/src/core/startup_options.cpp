#include "core/startup_options.h"

#include <windows.h>

namespace bijoy::core {
namespace {

constexpr wchar_t kOptionsKey[] = L"SOFTWARE\\BijoyEkushe\\Options";

int ReadDwordValue(HKEY key, const wchar_t* valueName, int fallback) {
  DWORD data = 0;
  DWORD dataSize = sizeof(data);
  DWORD valueType = 0;
  const LONG status = RegGetValueW(key, nullptr, valueName, RRF_RT_REG_DWORD, &valueType, &data, &dataSize);
  if (status != ERROR_SUCCESS) {
    return fallback;
  }
  return static_cast<int>(data);
}

bool ReadBoolValue(HKEY key, const wchar_t* valueName, bool fallback) {
  return ReadDwordValue(key, valueName, fallback ? 1 : 0) != 0;
}

} // namespace

StartupOptions LoadStartupOptions() {
  StartupOptions options;

  HKEY key = nullptr;
  const LONG openStatus = RegOpenKeyExW(HKEY_CURRENT_USER, kOptionsKey, 0, KEY_READ, &key);
  if (openStatus != ERROR_SUCCESS) {
    return options;
  }

  options.defaultLayout = ReadDwordValue(key, L"DefaultLayout", options.defaultLayout);
  options.mainWindowLeft = ReadDwordValue(key, L"Position", options.mainWindowLeft);
  options.mainWindowTop = ReadDwordValue(key, L"Top", options.mainWindowTop);
  options.layoutActivationMode = ReadBoolValue(key, L"LAM", options.layoutActivationMode);
  options.trayMode = ReadBoolValue(key, L"TrayMode", options.trayMode);
  options.applicationMode = ReadDwordValue(key, L"ApplicationMode", options.applicationMode);

  RegCloseKey(key);
  return options;
}

} // namespace bijoy::core
