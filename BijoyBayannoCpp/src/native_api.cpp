#include "native_api.h"

namespace native {

UINT SendInput(UINT nInputs, INPUT* pInputs, int cbSize) {
  return ::SendInput(nInputs, pInputs, cbSize);
}

void DoKeyBoard(DWORD flags, int scanCode) {
  INPUT input = {};
  input.type = INPUT_KEYBOARD;
  input.ki.wVk = 0;
  input.ki.wScan = (WORD)scanCode;
  input.ki.dwFlags = flags;
  input.ki.time = 0;
  input.ki.dwExtraInfo = 0;
  ::SendInput(1, &input, sizeof(INPUT));
}

void DoKeyBoardVk(DWORD flags, WORD vk) {
  INPUT input = {};
  input.type = INPUT_KEYBOARD;
  input.ki.wVk = vk;
  input.ki.wScan = 0;
  input.ki.dwFlags = flags;
  input.ki.time = 0;
  input.ki.dwExtraInfo = 0;
  ::SendInput(1, &input, sizeof(INPUT));
}

} // namespace native
