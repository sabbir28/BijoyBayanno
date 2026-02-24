#include "platform/windows/native_input.h"

namespace bijoy::platform::windows {

UINT SendInput(UINT nInputs, INPUT* pInputs, int cbSize) {
  return ::SendInput(nInputs, pInputs, cbSize);
}

void DoKeyboard(DWORD flags, int scanCode) {
  INPUT input = {};
  input.type = INPUT_KEYBOARD;
  input.ki.wVk = 0;
  input.ki.wScan = static_cast<WORD>(scanCode);
  input.ki.dwFlags = flags;
  ::SendInput(1, &input, sizeof(INPUT));
}

void DoKeyboardVk(DWORD flags, WORD vk) {
  INPUT input = {};
  input.type = INPUT_KEYBOARD;
  input.ki.wVk = vk;
  input.ki.wScan = 0;
  input.ki.dwFlags = flags;
  ::SendInput(1, &input, sizeof(INPUT));
}

} // namespace bijoy::platform::windows
