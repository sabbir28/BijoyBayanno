#pragma once

#define WIN32_LEAN_AND_MEAN
#include <windows.h>

namespace bijoy::platform::windows {

enum InputType { INPUT_MOUSE = 0, INPUT_KEYBOARD = 1, INPUT_HARDWARE = 2 };

enum KEYEVENTF {
  KEYEVENTF_EXTENDEDKEY = 0x0001,
  KEYEVENTF_KEYUP       = 0x0002,
  KEYEVENTF_UNICODE     = 0x0004,
  KEYEVENTF_SCANCODE    = 0x0008
};

#pragma pack(push, 1)
struct MOUSEINPUT {
  LONG dx;
  LONG dy;
  DWORD mouseData;
  DWORD dwFlags;
  DWORD time;
  ULONG_PTR dwExtraInfo;
};

struct KEYBDINPUT {
  WORD wVk;
  WORD wScan;
  DWORD dwFlags;
  DWORD time;
  ULONG_PTR dwExtraInfo;
};

struct HARDWAREINPUT {
  DWORD uMsg;
  WORD wParamL;
  WORD wParamH;
};

struct INPUT {
  DWORD type;
  union {
    MOUSEINPUT mi;
    KEYBDINPUT ki;
    HARDWAREINPUT hi;
  };
};
#pragma pack(pop)

UINT SendInput(UINT nInputs, INPUT* pInputs, int cbSize);
void DoKeyboard(DWORD flags, int scanCode);
void DoKeyboardVk(DWORD flags, WORD vk);

} // namespace bijoy::platform::windows
