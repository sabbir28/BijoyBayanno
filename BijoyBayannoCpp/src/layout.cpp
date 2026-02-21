#include "layout.h"
#include <algorithm>
#include <cctype>
#include <cstdio>
#include <windows.h>

namespace {

std::wstring trim(const std::wstring& s) {
  auto start = s.find_first_not_of(L" \t\r\n");
  if (start == std::wstring::npos) return L"";
  auto end = s.find_last_not_of(L" \t\r\n");
  return s.substr(start, end - start + 1);
}

std::wstring getTagContent(const std::wstring& line, const wchar_t* tag) {
  std::wstring open = L"<";
  open += tag;
  open += L">";
  std::wstring close = L"</";
  close += tag;
  close += L">";
  auto a = line.find(open);
  if (a == std::wstring::npos) return L"";
  a += open.size();
  auto b = line.find(close, a);
  if (b == std::wstring::npos) return L"";
  return trim(line.substr(a, b - a));
}

bool parseBool(const std::wstring& s) {
  std::wstring l = s;
  std::transform(l.begin(), l.end(), l.begin(), ::towlower);
  return l == L"true" || l == L"1" || l == L"yes";
}

int parseInt(const std::wstring& s) {
  return (int)wcstol(s.c_str(), nullptr, 10);
}

} // namespace

void Layout::clear() {
  key.clear();
  juk.clear();
}

bool Layout::loadFromFile(const wchar_t* filePath) {
  path = filePath;
  clear();
  FILE* f = _wfopen(filePath, L"r, ccs=UTF-8");
  if (!f) return false;

  wchar_t lineBuf[2048];
  auto getLine = [&]() -> std::wstring {
    if (!fgetws(lineBuf, 2048, f)) return L"";
    std::wstring w = lineBuf;
    if (!w.empty() && w.back() == L'\n') w.pop_back();
    if (!w.empty() && w.back() == L'\r') w.pop_back();
    return trim(w);
  };

  while (!feof(f)) {
    std::wstring wline = getLine();
    if (wline.empty()) continue;
    if (wline.find(L"<Name>") != std::wstring::npos) {
      name = getTagContent(wline, L"Name");
    } else if (wline.find(L"<Shortcut>") != std::wstring::npos) {
      // read next lines for Alt, Ctrl, Shift, KeyCode
      while (!feof(f)) {
        std::wstring sub = getLine();
        if (sub.find(L"</Shortcut>") != std::wstring::npos) break;
        if (sub.find(L"<Alt>") != std::wstring::npos) shortcut.alt = parseBool(getTagContent(sub, L"Alt"));
        else if (sub.find(L"<Ctrl>") != std::wstring::npos) shortcut.ctrl = parseBool(getTagContent(sub, L"Ctrl"));
        else if (sub.find(L"<Shift>") != std::wstring::npos) shortcut.shift = parseBool(getTagContent(sub, L"Shift"));
        else if (sub.find(L"<KeyCode>") != std::wstring::npos) shortcut.keyCode = parseInt(getTagContent(sub, L"KeyCode"));
      }
    } else if (wline.find(L"<IconName>") != std::wstring::npos) {
      iconName = getTagContent(wline, L"IconName");
    } else if (wline.find(L"<Key ") != std::wstring::npos) {
      int keyCode = 0;
      std::wstring normalOpt, shiftOpt;
      size_t kc = wline.find(L"KeyCode=\"");
      if (kc != std::wstring::npos) {
        kc += 9;
        size_t end = wline.find(L"\"", kc);
        if (end != std::wstring::npos) keyCode = parseInt(wline.substr(kc, end - kc));
      }
      size_t no = wline.find(L"Normal_Option=\"");
      if (no != std::wstring::npos) {
        no += 15;
        size_t end = wline.find(L"\"", no);
        if (end != std::wstring::npos) normalOpt = wline.substr(no, end - no);
      }
      size_t so = wline.find(L"Shift_Option=\"");
      if (so != std::wstring::npos) {
        so += 14;
        size_t end = wline.find(L"\"", so);
        if (end != std::wstring::npos) shiftOpt = wline.substr(so, end - so);
      }
      KeyMapping km;
      km.normalOption = normalOpt;
      km.shiftOption = shiftOpt;
      std::wstring norm = getLine();
      km.normal = getTagContent(norm, L"Normal");
      std::wstring sh = getLine();
      km.shift = getTagContent(sh, L"Shift");
      key[keyCode] = km;
    } else if (wline.find(L"<Juk>") != std::wstring::npos) {
      std::wstring seq = getLine();
      std::wstring seqVal = getTagContent(seq, L"Seq");
      std::wstring out = getLine();
      std::wstring outVal = getTagContent(out, L"Out");
      if (!seqVal.empty() || !outVal.empty()) juk[seqVal] = outVal;
    }
  }
  fclose(f);
  return !name.empty();
}

bool Layout::updateFromFile() {
  return loadFromFile(path.c_str());
}
