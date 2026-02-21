#include "keyboard_hook.h"
#include "native_api.h"
#include "layout.h"
#include "handle_info.h"
#include "app_state.h"
#include <windows.h>
#include <map>
#include <string>

#define WH_KEYBOARD_LL 13

struct KBDLLHOOKSTRUCT {
  DWORD vkCode;
  DWORD scanCode;
  DWORD flags;
  DWORD time;
  ULONG_PTR dwExtraInfo;
};

static HHOOK g_hook = nullptr;
static HINSTANCE g_hInstance = nullptr;
static bool g_layoutsReady = false;

static bool GetKeyState(int vk) {
  return (GetAsyncKeyState(vk) & 0x8000) != 0;
}

static bool IsHooked(const KBDLLHOOKSTRUCT* hs) {
  bool ctrl = GetKeyState(VK_CONTROL);
  bool alt = GetKeyState(VK_MENU);
  bool shift = GetKeyState(VK_SHIFT);
  int n = AppState_GetLayoutCount();
  for (int i = 0; i < n; i++) {
    Layout* lay = AppState_GetLayoutByIndex(i);
    if (!lay) continue;
    if (ctrl == lay->shortcut.ctrl && alt == lay->shortcut.alt &&
        shift == lay->shortcut.shift && (DWORD)hs->vkCode == (DWORD)lay->shortcut.keyCode) {
      HWND fg = GetForegroundWindow();
      if (g_comLayoutSelectedIndex == i + 1) {
        RemoveInfo(fg);
        AppState_SetCurrentLayout(-1);
      } else {
        AppState_SetCurrentLayout(i);
        AddInfo(fg, lay);
      }
      return true;
    }
  }
  Layout* lay = AppState_GetCurrentLayout();
  if (!ctrl && !alt && lay) {
    auto it = lay->key.find((int)hs->vkCode);
    if (it != lay->key.end()) {
      bool useShift = shift;
      const std::wstring& out = useShift ? it->second.shift : it->second.normal;
      if (!out.empty()) {
        for (wchar_t c : out) {
          native::DoKeyBoard(native::KEYEVENTF_UNICODE, (int)c);
          native::DoKeyBoard(native::KEYEVENTF_KEYUP | native::KEYEVENTF_UNICODE, (int)c);
        }
        return true;
      }
    }
  }
  return false;
}

static LRESULT CALLBACK LowLevelKeyboardProc(int nCode, WPARAM wParam, LPARAM lParam) {
  if (nCode == HC_ACTION && g_layoutsReady && lParam) {
    KBDLLHOOKSTRUCT* hs = (KBDLLHOOKSTRUCT*)lParam;
    if (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) {
      if (IsHooked(hs))
        return 1;
    }
  }
  return CallNextHookEx(g_hook, nCode, wParam, lParam);
}

bool KeyboardHook_Install(HINSTANCE hInstance) {
  g_hInstance = hInstance;
  g_hook = SetWindowsHookExW(WH_KEYBOARD_LL, LowLevelKeyboardProc, hInstance, 0);
  return g_hook != nullptr;
}

void KeyboardHook_Uninstall() {
  if (g_hook) {
    UnhookWindowsHookEx(g_hook);
    g_hook = nullptr;
  }
}

void KeyboardHook_SetLayoutsReady(bool ready) {
  g_layoutsReady = ready;
}
