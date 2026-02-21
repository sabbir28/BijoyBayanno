#include "app_state.h"

std::vector<Layout> g_layouts;
int g_layoutCount = 0;
int g_currentLayoutIndex = -1;
int g_comLayoutSelectedIndex = 0;

void AppState_SetCurrentLayout(int index) {
  g_currentLayoutIndex = index;
  g_comLayoutSelectedIndex = index < 0 ? 0 : index + 1;
}

int AppState_GetCurrentLayoutIndex() {
  return g_currentLayoutIndex;
}

Layout* AppState_GetCurrentLayout() {
  if (g_currentLayoutIndex < 0 || g_currentLayoutIndex >= (int)g_layouts.size())
    return nullptr;
  return &g_layouts[g_currentLayoutIndex];
}

Layout* AppState_GetLayoutByIndex(int index) {
  if (index < 0 || index >= (int)g_layouts.size()) return nullptr;
  return &g_layouts[index];
}

int AppState_GetLayoutCount() {
  return (int)g_layouts.size();
}
