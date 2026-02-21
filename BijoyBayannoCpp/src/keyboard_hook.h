#pragma once

#include <windows.h>

bool KeyboardHook_Install(HINSTANCE hInstance);
void KeyboardHook_Uninstall();
void KeyboardHook_SetLayoutsReady(bool ready);
