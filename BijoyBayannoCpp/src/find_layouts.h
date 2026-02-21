#pragma once

#include "layout.h"
#include <vector>
#include <string>

bool FindLayouts(std::vector<Layout>& layouts, const std::wstring& appDir);
std::wstring GetAppDirectory();
