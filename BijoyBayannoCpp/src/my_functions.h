#pragma once

#include <string>
#include <windows.h>

namespace my_functions {

extern std::wstring Password;

std::wstring VerifyPath(const std::wstring& path);
std::wstring Encrypt(const std::wstring& number);
std::wstring GetMachineId();
bool Drag(HWND hwnd);
int GetRegistryPassword(std::wstring& out);
int SetRegistryPassword(const std::wstring& value);

} // namespace my_functions
