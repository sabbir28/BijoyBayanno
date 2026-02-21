#include "find_layouts.h"
#include "my_functions.h"
#include <windows.h>
#include <shlwapi.h>

#pragma comment(lib, "shlwapi.lib")

std::wstring GetAppDirectory() {
  wchar_t path[MAX_PATH] = {};
  if (GetModuleFileNameW(nullptr, path, MAX_PATH) == 0) return L"";
  PathRemoveFileSpecW(path);
  return my_functions::VerifyPath(path);
}

static void findXmlRecursive(const std::wstring& dir, std::vector<std::wstring>& out) {
  std::wstring search = dir + L"*";
  WIN32_FIND_DATAW fd = {};
  HANDLE h = FindFirstFileW(search.c_str(), &fd);
  if (h == INVALID_HANDLE_VALUE) return;
  do {
    if (fd.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) {
      if (wcscmp(fd.cFileName, L".") != 0 && wcscmp(fd.cFileName, L"..") != 0) {
        findXmlRecursive(dir + fd.cFileName + L"\\", out);
      }
    } else {
      if (wcsstr(fd.cFileName, L".xml") != nullptr)
        out.push_back(dir + fd.cFileName);
    }
  } while (FindNextFileW(h, &fd));
  FindClose(h);
}

bool FindLayouts(std::vector<Layout>& layouts, const std::wstring& appDir) {
  std::wstring layoutDir = appDir + L"Layouts\\";
  std::vector<std::wstring> files;
  findXmlRecursive(layoutDir, files);
  if (files.empty()) return false;
  layouts.clear();
  for (size_t i = 0; i < files.size(); i++) {
    Layout lay;
    if (lay.loadFromFile(files[i].c_str())) {
      lay.id = (int)i;
      layouts.push_back(std::move(lay));
    }
  }
  return !layouts.empty();
}
