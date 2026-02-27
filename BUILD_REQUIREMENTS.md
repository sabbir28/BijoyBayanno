# What You Need to Build BijoyBayanno (C#)

To compile this project on your computer, you need the following.

---


## Quick Build Entry Points (from repo root)

Use the root CMake build system:

```bat
cmake --preset windows-default
cmake --build --preset build-csharp
```

To build both C++ and C# from root:

```bat
cmake --build --preset build-all
```

---

## 1. **Visual Studio** (recommended)

- **Visual Studio 2022** or **Visual Studio 2019** (Community edition is free).
- During setup, select the workload: **“.NET desktop development”**.
- This installs:
  - MSBuild
  - C# compiler
  - .NET Framework targeting packs
  - Windows Forms designer and libraries

**Download:** https://visualstudio.microsoft.com/downloads/

---

## 2. **.NET Framework** (usually installed with Visual Studio)

- The project targets **.NET Framework** (updated in the project to **v4.7.2** so it builds on current Windows).
- Windows 10/11 usually have a suitable .NET Framework already.
- If you build from command line without Visual Studio, install **.NET Framework 4.7.2 Developer Pack** or **4.8 Developer Pack**:
  - https://dotnet.microsoft.com/download/dotnet-framework

---

## 3. **How to build**

### Option A: From Visual Studio

1. Open `BijoyBayanno.sln` in Visual Studio.
2. Set configuration to **Debug** and platform to **x86** (top toolbar).
3. Press **Ctrl+Shift+B** or use **Build → Build Solution**.

### Option B: From command line (Developer Command Prompt or PowerShell)

1. Open **Developer Command Prompt for VS** or **Developer PowerShell for VS** (from Start menu, under Visual Studio).
2. Go to the solution folder:
   ```bat
   cd "d:\Progect\BijoyBayannoC#"
   ```
3. Run:
   ```bat
   msbuild BijoyBayanno.sln /p:Configuration=Debug /p:Platform=x86
   ```

---

## 4. **Summary checklist**

| Item | Purpose |
|------|--------|
| **Visual Studio** (with .NET desktop development) | Build and edit the C# WinForms project |
| **.NET Framework 4.7.2 or 4.8** | Runtime and libraries for the app |
| **Platform: x86** | Project is set to build for 32-bit (x86) |

---

## 5. **If you don’t want full Visual Studio**

You can use **Build Tools for Visual Studio** (no IDE):

- Download: https://visualstudio.microsoft.com/downloads/ → under “All Downloads” → **Build Tools for Visual Studio**.
- In the installer, select **“.NET desktop build tools”** (or similar workload that includes .NET Framework and Windows Forms).
- Then use **Developer Command Prompt for VS** and run the `msbuild` command above.

---

After installing these, the project in this folder should compile. The `.csproj` has been fixed (output type and invalid options) so the build can succeed.
