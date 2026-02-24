#include "platform/windows/registration_dialog.h"

#include "platform/windows/resource.h"
#include "utils/system_utils.h"

#include <commctrl.h>
#include <string>
#include <windows.h>

#ifdef _MSC_VER
// Ensure common controls library is linked when building with MSVC
#pragma comment(lib, "comctl32.lib")
#endif

namespace bijoy::platform::windows {

    namespace {

// -----------------------------------------------------------------------------
// Handle to the splash screen window
// Used to toggle visibility after successful registration
// -----------------------------------------------------------------------------
        HWND g_hwndSplash = nullptr;

// -----------------------------------------------------------------------------
// Reads text content from a dialog control by ID
// Returns an empty string if the control is missing or empty
// -----------------------------------------------------------------------------
        std::wstring GetDialogItemText(HWND dialog, int id) {
            HWND control = GetDlgItem(dialog, id);
            if (!control) {
                return L"";
            }

            // Determine required buffer size (includes null terminator)
            const int length = GetWindowTextLengthW(control) + 1;
            if (length <= 1) {
                return L"";
            }

            // Retrieve control text
            std::wstring value(length, L'\0');
            GetWindowTextW(control, &value[0], length);

            // Trim trailing null terminator
            value.resize(length - 1);
            return value;
        }

// -----------------------------------------------------------------------------
// Dialog procedure for registration / license validation
// Controls dialog lifecycle and user interaction
// -----------------------------------------------------------------------------
        INT_PTR CALLBACK RegistrationDialogProc(
                HWND dialog,
                UINT msg,
                WPARAM wParam,
                LPARAM lParam) {

            (void)lParam;

            switch (msg) {

                // -------------------------------------------------------------------------
                // Dialog initialization
                // - Checks existing registry registration
                // - Skips dialog if already registered
                // - Pre-fills machine ID for display
                // -------------------------------------------------------------------------
                case WM_INITDIALOG: {
                    std::wstring savedPassword;
                    bijoy::utils::GetRegistryPassword(savedPassword);

                    // Auto-bypass registration if password already matches
                    if (savedPassword == bijoy::utils::Password) {
                        ShowWindow(dialog, SW_HIDE);
                        if (g_hwndSplash) {
                            ShowWindow(g_hwndSplash, SW_SHOW);
                        }
                        return TRUE;
                    }

                    // Display machine identifier to the user
                    SetDlgItemTextW(
                            dialog,
                            IDC_ID_EDIT,
                            bijoy::utils::GetMachineId().c_str());

                    return TRUE;
                }

                    // -------------------------------------------------------------------------
                    // Dialog close (window close button)
                    // Treated as registration cancel
                    // -------------------------------------------------------------------------
                case WM_CLOSE:
                    EndDialog(dialog, 0);
                    return TRUE;

                    // -------------------------------------------------------------------------
                    // Command handling (buttons, controls)
                    // -------------------------------------------------------------------------
                case WM_COMMAND:

                    // -----------------------------------------------------------------------
                    // OK / Register button
                    // Collects segmented password input and validates it
                    // -----------------------------------------------------------------------
                    if (LOWORD(wParam) == IDOK_BTN) {

                        // Assemble password from multiple input fields
                        const std::wstring enteredPassword =
                                GetDialogItemText(dialog, IDC_PASSWORD_EDIT) +
                                GetDialogItemText(dialog, IDC_PASSWORD1) +
                                GetDialogItemText(dialog, IDC_PASSWORD2) +
                                GetDialogItemText(dialog, IDC_PASSWORD3) +
                                GetDialogItemText(dialog, IDC_PASSWORD4);

                        // Validate against internal password seed
                        if (enteredPassword.size() > 2 &&
                            enteredPassword == bijoy::utils::Password) {

                            // Persist registration state
                            bijoy::utils::SetRegistryPassword(
                                    bijoy::utils::Password);

                            // Transition to splash screen
                            ShowWindow(dialog, SW_HIDE);
                            if (g_hwndSplash) {
                                ShowWindow(g_hwndSplash, SW_SHOW);
                            }

                            EndDialog(dialog, 1);
                        } else {
                            MessageBoxW(
                                    dialog,
                                    L"Wrong Password",
                                    L"Bijoy Bayanno",
                                    MB_OK | MB_ICONERROR);
                        }
                        return TRUE;
                    }

                    // -----------------------------------------------------------------------
                    // Cancel button
                    // Terminates application startup
                    // -----------------------------------------------------------------------
                    if (LOWORD(wParam) == IDCANCEL_BTN) {
                        EndDialog(dialog, 0);
                        return TRUE;
                    }
                    break;
            }

            return FALSE;
        }

    }  // namespace

// -----------------------------------------------------------------------------
// Displays the modal registration dialog
// Returns:
//   1 → registration successful
//   0 → cancelled or failed
// -----------------------------------------------------------------------------
    int ShowRegistrationDialog(HWND hParent, HWND hwndSplash) {
        g_hwndSplash = hwndSplash;

        return static_cast<int>(
                DialogBoxW(
                        GetModuleHandle(nullptr),
                        MAKEINTRESOURCEW(IDD_REGISTRATION),
                        hParent,
                        RegistrationDialogProc));
    }

}  // namespace bijoy::platform::windows