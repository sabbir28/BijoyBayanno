#pragma once

#include "layout.h"
#include <vector>

extern std::vector<Layout> g_layouts;
extern int g_layoutCount;
extern int g_currentLayoutIndex;
extern int g_comLayoutSelectedIndex;

void AppState_SetCurrentLayout(int index);
int AppState_GetCurrentLayoutIndex();
Layout* AppState_GetCurrentLayout();
Layout* AppState_GetLayoutByIndex(int index);
int AppState_GetLayoutCount();
