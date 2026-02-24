#include "platform/windows/splash_screen.h"

#include <algorithm>
#include <chrono>
#include <future>
#include <string>
#include <windowsx.h>

namespace bijoy::platform::windows {
namespace {

constexpr wchar_t kSplashClassName[] = L"BijoyBayannoSplash";
constexpr UINT_PTR kSplashTimerId = 1;
constexpr int kTickMs = 10;
constexpr BYTE kFadeStepAlpha = 5;
constexpr int kMinVisibleMs = 1000;

class SplashScreenController {
public:
  SplashScreenController(SplashInitTask initTask, SplashCompletedCallback onCompleted)
      : initTask_(std::move(initTask)), onCompleted_(std::move(onCompleted)) {}

  HWND Create(HINSTANCE instance, HWND owner) {
    RegisterWindowClass(instance);

    hwnd_ = CreateWindowExW(WS_EX_LAYERED | WS_EX_TOPMOST,
                            kSplashClassName,
                            L"Splash",
                            WS_POPUP,
                            0,
                            0,
                            237,
                            240,
                            owner,
                            nullptr,
                            instance,
                            this);
    return hwnd_;
  }

private:
  static void RegisterWindowClass(HINSTANCE instance) {
    static bool registered = false;
    if (registered) return;

    WNDCLASSEXW wc = {};
    wc.cbSize = sizeof(wc);
    wc.lpfnWndProc = &SplashScreenController::WndProc;
    wc.hInstance = instance;
    wc.lpszClassName = kSplashClassName;
    wc.hCursor = LoadCursorW(nullptr, IDC_ARROW);
    wc.hbrBackground = reinterpret_cast<HBRUSH>(COLOR_WINDOW + 1);
    RegisterClassExW(&wc);
    registered = true;
  }

  static LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam) {
    SplashScreenController* self = reinterpret_cast<SplashScreenController*>(GetWindowLongPtrW(hwnd, GWLP_USERDATA));

    if (msg == WM_NCCREATE) {
      const auto* cs = reinterpret_cast<CREATESTRUCTW*>(lParam);
      auto* controller = static_cast<SplashScreenController*>(cs->lpCreateParams);
      SetWindowLongPtrW(hwnd, GWLP_USERDATA, reinterpret_cast<LONG_PTR>(controller));
      controller->hwnd_ = hwnd;
      return TRUE;
    }

    if (!self) {
      return DefWindowProcW(hwnd, msg, wParam, lParam);
    }

    switch (msg) {
      case WM_CREATE:
        return self->OnCreate();
      case WM_TIMER:
        self->OnTimer(static_cast<UINT_PTR>(wParam));
        return 0;
      case WM_PAINT:
        self->OnPaint();
        return 0;
      case WM_DESTROY:
        KillTimer(hwnd, kSplashTimerId);
        return 0;
      case WM_NCDESTROY:
        self->OnDestroyed();
        delete self;
        return 0;
      default:
        return DefWindowProcW(hwnd, msg, wParam, lParam);
    }
  }

  LRESULT OnCreate() {
    alpha_ = 0;
    SetLayeredWindowAttributes(hwnd_, 0, alpha_, LWA_ALPHA);
    CenterOnScreen();

    startTime_ = std::chrono::steady_clock::now();
    if (initTask_) {
      initFuture_ = std::async(std::launch::async, initTask_);
    } else {
      initCompleted_ = true;
    }

    SetTimer(hwnd_, kSplashTimerId, kTickMs, nullptr);
    ShowWindow(hwnd_, SW_SHOW);
    UpdateWindow(hwnd_);
    return 0;
  }

  void OnTimer(UINT_PTR timerId) {
    if (timerId != kSplashTimerId) return;

    if (!initCompleted_ && initFuture_.valid() && initFuture_.wait_for(std::chrono::seconds(0)) == std::future_status::ready) {
      initFuture_.get();
      initCompleted_ = true;
    }

    if (alpha_ < 255) {
      alpha_ = static_cast<BYTE>((std::min)(255, static_cast<int>(alpha_) + static_cast<int>(kFadeStepAlpha)));
      SetLayeredWindowAttributes(hwnd_, 0, alpha_, LWA_ALPHA);
      return;
    }

    const auto elapsedMs = std::chrono::duration_cast<std::chrono::milliseconds>(
                               std::chrono::steady_clock::now() - startTime_)
                               .count();
    if (initCompleted_ && elapsedMs >= kMinVisibleMs) {
      DestroyWindow(hwnd_);
    }
  }

  void OnPaint() {
    PAINTSTRUCT ps;
    HDC hdc = BeginPaint(hwnd_, &ps);

    RECT rect;
    GetClientRect(hwnd_, &rect);

    HBRUSH bgBrush = CreateSolidBrush(RGB(245, 245, 245));
    FillRect(hdc, &rect, bgBrush);
    DeleteObject(bgBrush);

    SetBkMode(hdc, TRANSPARENT);
    SetTextColor(hdc, RGB(51, 51, 51));

    HFONT titleFont = CreateFontW(30, 0, 0, 0, FW_BOLD, FALSE, FALSE, FALSE, DEFAULT_CHARSET,
                                  OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS, CLEARTYPE_QUALITY,
                                  DEFAULT_PITCH | FF_SWISS, L"Segoe UI");
    HFONT bodyFont = CreateFontW(16, 0, 0, 0, FW_NORMAL, FALSE, FALSE, FALSE, DEFAULT_CHARSET,
                                 OUT_DEFAULT_PRECIS, CLIP_DEFAULT_PRECIS, CLEARTYPE_QUALITY,
                                 DEFAULT_PITCH | FF_SWISS, L"Segoe UI");

    HGDIOBJ oldFont = SelectObject(hdc, titleFont);
    RECT titleRect = rect;
    titleRect.top = 60;
    DrawTextW(hdc, L"বিজয়", -1, &titleRect, DT_CENTER | DT_SINGLELINE);

    SelectObject(hdc, bodyFont);
    RECT subtitleRect = rect;
    subtitleRect.top = 120;
    DrawTextW(hdc, L"Bijoy Bayanno", -1, &subtitleRect, DT_CENTER | DT_SINGLELINE);

    SelectObject(hdc, oldFont);
    DeleteObject(titleFont);
    DeleteObject(bodyFont);

    EndPaint(hwnd_, &ps);
  }

  void OnDestroyed() {
    if (onCompleted_) {
      onCompleted_();
    }
  }

  void CenterOnScreen() {
    RECT rect;
    GetWindowRect(hwnd_, &rect);
    const int width = rect.right - rect.left;
    const int height = rect.bottom - rect.top;

    const int x = (GetSystemMetrics(SM_CXSCREEN) - width) / 2;
    const int y = (GetSystemMetrics(SM_CYSCREEN) - height) / 2;
    SetWindowPos(hwnd_, HWND_TOPMOST, x, y, width, height, SWP_SHOWWINDOW);
  }

  HWND hwnd_ = nullptr;
  BYTE alpha_ = 0;
  bool initCompleted_ = false;
  SplashInitTask initTask_;
  SplashCompletedCallback onCompleted_;
  std::future<void> initFuture_;
  std::chrono::steady_clock::time_point startTime_;
};

} // namespace

HWND ShowSplashScreen(HINSTANCE hInstance,
                      HWND owner,
                      SplashInitTask initTask,
                      SplashCompletedCallback onCompleted) {
  auto* controller = new SplashScreenController(std::move(initTask), std::move(onCompleted));
  return controller->Create(hInstance, owner);
}

} // namespace bijoy::platform::windows
