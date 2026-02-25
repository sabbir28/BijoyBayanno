#include "platform/windows/main_window.h"

#include "core/app_state.h"
#include "core/window_layout_binding.h"
#include "platform/windows/resource.h"

#include <commctrl.h>
#include <shellapi.h>
#include <windows.h>

#ifdef _MSC_VER
// Link required Windows system libraries when building with MSVC
#pragma comment(lib, "comctl32.lib")
#pragma comment(lib, "shell32.lib")
#endif

// Compatibility fallback for older SDKs
#ifndef TPM_NONBLOCKING
#define TPM_NONBLOCKING 0x0000L
#endif

namespace bijoy::platform::windows {

    namespace {

// -----------------------------------------------------------------------------
// Custom message ID used by the tray icon callback
// -----------------------------------------------------------------------------
        constexpr UINT kTrayIconMessage = WM_USER + 1;

// -----------------------------------------------------------------------------
// Global UI state (owned by the UI thread)
// -----------------------------------------------------------------------------
        HWND g_mainWindow = nullptr;        // Main application window
        NOTIFYICONDATAW g_notifyIcon = {};  // System tray icon descriptor
        HMENU g_trayMenu = nullptr;         // Tray context menu

// -----------------------------------------------------------------------------
// Shows or hides the main application window
// -----------------------------------------------------------------------------
        void SetMainWindowVisible(bool visible) {
            if (g_mainWindow) {
                ShowWindow(g_mainWindow, visible ? SW_SHOW : SW_HIDE);
            }
        }

// -----------------------------------------------------------------------------
// Handles tray menu commands
// -----------------------------------------------------------------------------
        void OnTrayCommand(UINT id) {

            // Exit application
            if (id == IDM_TRAY_EXIT) {
                PostQuitMessage(0);
                return;
            }

            // Restore main window
            if (id == IDM_TRAY_SHOW) {
                SetMainWindowVisible(true);
                return;
            }

            // Layout selection commands
            if (id >= IDM_TRAY_LAYOUT_BASE &&
                id < IDM_TRAY_LAYOUT_BASE + 100) {

                const int index = static_cast<int>(id - IDM_TRAY_LAYOUT_BASE);

                // Update active layout
                bijoy::core::SetCurrentLayout(index);

                // Bind layout to the currently focused window
                if (auto* layout =
                        bijoy::core::GetLayoutByIndex(index)) {
                    bijoy::core::AddWindowLayoutBinding(
                            GetForegroundWindow(),
                            layout);
                }
            }
        }

// -----------------------------------------------------------------------------
// Main window procedure
// Owns tray icon lifecycle and window behavior
// -----------------------------------------------------------------------------
        LRESULT CALLBACK MainWindowProc(
                HWND hwnd,
                UINT msg,
                WPARAM wParam,
                LPARAM lParam) {

            switch (msg) {

                // -------------------------------------------------------------------------
                // Window creation
                // Initializes tray icon and context menu
                // -------------------------------------------------------------------------
                case WM_CREATE: {

                    // Configure system tray icon
                    g_notifyIcon.cbSize = sizeof(g_notifyIcon);
                    g_notifyIcon.hWnd = hwnd;
                    g_notifyIcon.uID = ID_TRAY;
                    g_notifyIcon.uFlags =
                            NIF_ICON | NIF_MESSAGE | NIF_TIP;
                    g_notifyIcon.uCallbackMessage =
                            kTrayIconMessage;
                    g_notifyIcon.hIcon =
                            LoadIconW(nullptr, IDI_APPLICATION);
                    wcscpy_s(g_notifyIcon.szTip,
                             L"Bijoy Bayanno");

                    Shell_NotifyIconW(NIM_ADD, &g_notifyIcon);

                    // Build tray context menu
                    g_trayMenu = CreatePopupMenu();
                    AppendMenuW(
                            g_trayMenu,
                            MF_STRING,
                            IDM_TRAY_SHOW,
                            L"&Show");

                    AppendMenuW(
                            g_trayMenu,
                            MF_SEPARATOR,
                            0,
                            nullptr);

                    // Populate keyboard layout options dynamically
                    for (int i = 0;
                         i < bijoy::core::GetLayoutCount();
                         ++i) {
                        if (auto* layout =
                                bijoy::core::GetLayoutByIndex(i)) {
                            AppendMenuW(
                                    g_trayMenu,
                                    MF_STRING,
                                    IDM_TRAY_LAYOUT_BASE + i,
                                    layout->name.c_str());
                        }
                    }

                    AppendMenuW(
                            g_trayMenu,
                            MF_SEPARATOR,
                            0,
                            nullptr);

                    AppendMenuW(
                            g_trayMenu,
                            MF_STRING,
                            IDM_TRAY_EXIT,
                            L"E&xit");

                    return 0;
                }

                    // -------------------------------------------------------------------------
                    // Tray icon interaction
                    // -------------------------------------------------------------------------
                case kTrayIconMessage:

                    // Right-click → context menu
                    if (lParam == WM_RBUTTONUP) {
                        POINT pt;
                        GetCursorPos(&pt);
                        SetForegroundWindow(hwnd);

                        const int command = TrackPopupMenu(
                                g_trayMenu,
                                TPM_RETURNCMD | TPM_NONBLOCKING,
                                pt.x,
                                pt.y,
                                0,
                                hwnd,
                                nullptr);

                        if (command) {
                            OnTrayCommand(
                                    static_cast<UINT>(command));
                        }
                    }

                        // Double left-click → restore window
                    else if (lParam == WM_LBUTTONDBLCLK) {
                        SetMainWindowVisible(true);
                    }
                    return 0;

                    // -------------------------------------------------------------------------
                    // Intercept close to minimize to tray
                    // -------------------------------------------------------------------------
                case WM_CLOSE:
                    ShowWindow(hwnd, SW_HIDE);
                    return 0;

                    // -------------------------------------------------------------------------
                    // Final teardown
                    // -------------------------------------------------------------------------
                case WM_DESTROY:
                    Shell_NotifyIconW(NIM_DELETE, &g_notifyIcon);
                    if (g_trayMenu) {
                        DestroyMenu(g_trayMenu);
                    }
                    PostQuitMessage(0);
                    return 0;

                default:
                    return DefWindowProcW(hwnd, msg, wParam, lParam);
            }
        }

    }  // namespace

// -----------------------------------------------------------------------------
// Registers and creates the main application window
// Returns the window handle or nullptr on failure
// -----------------------------------------------------------------------------
    HWND CreateMainWindow(HINSTANCE hInstance) {

        WNDCLASSEXW windowClass = {};
        windowClass.cbSize = sizeof(windowClass);
        windowClass.lpfnWndProc = MainWindowProc;
        windowClass.hInstance = hInstance;
        windowClass.lpszClassName =
                L"BijoyBayannoMain";
        windowClass.hCursor =
                LoadCursor(nullptr, IDC_ARROW);

        RegisterClassExW(&windowClass);

        // https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-createwindowexw
        g_mainWindow = CreateWindowExW(
                0,
                windowClass.lpszClassName,
                L"Bijoy Bayanno",
                WS_OVERLAPPEDWINDOW,
                CW_USEDEFAULT,
                CW_USEDEFAULT,
                320,
                200,
                nullptr,
                nullptr,
                hInstance,
                nullptr
        );

        return g_mainWindow;
    }

}  // namespace bijoy::platform::windows