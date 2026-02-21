#pragma once

#include "layout.h"
#include <vector>
#include <windows.h>

struct HandleInfo {
  HWND handle = nullptr;
  Layout* status = nullptr;
};

bool AddInfo(HWND hwnd, Layout* layout);
Layout* FindInfo(HWND hwnd);
bool RemoveInfo(HWND hwnd);
