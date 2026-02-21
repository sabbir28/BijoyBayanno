#include "handle_info.h"
#include <windows.h>
#include <algorithm>

static std::vector<HandleInfo> layInfo;

bool AddInfo(HWND hwnd, Layout* layout) {
  for (auto it = layInfo.begin(); it != layInfo.end(); ) {
    if (it->handle == hwnd) {
      it = layInfo.erase(it);
    } else ++it;
  }
  layInfo.push_back({ hwnd, layout });
  for (auto it = layInfo.begin(); it != layInfo.end(); ) {
    if (!IsWindow(it->handle))
      it = layInfo.erase(it);
    else ++it;
  }
  return true;
}

Layout* FindInfo(HWND hwnd) {
  for (auto& e : layInfo) {
    if (e.handle == hwnd) return e.status;
  }
  return nullptr;
}

bool RemoveInfo(HWND hwnd) {
  for (auto it = layInfo.begin(); it != layInfo.end(); ++it) {
    if (it->handle == hwnd) {
      layInfo.erase(it);
      return true;
    }
  }
  return false;
}
