# BijoyBayanno

This repository contains two implementations of the BijoyBayanno desktop application:

- **C# WinForms legacy app** in `BijoyBayanno.exe/`
- **Modern C++/Win32 port** in `BijoyBayannoCpp/`

This repo now has a **CMake-based top-level build system** so you can drive both parts from one place.

---

## Repository Layout

- `CMakeLists.txt` - Main/root build system
- `CMakePresets.json` - Ready-to-use Windows configure/build presets
- `BijoyBayanno.sln` - Solution for the C# app (built through `build_csharp` target)
- `BijoyBayanno.exe/` - C# WinForms project
- `BijoyBayannoCpp/` - C++ implementation with CMake
- `BijoyBayannoCpp/LayoutEditor/` - Win32 layout editor prototype
- `BUILD_REQUIREMENTS.md` - C# build prerequisites

---

## Main Build System (CMake at repo root)

### Configure

```bat
cmake --preset windows-default
```

### Build targets

```bat
cmake --build --preset build-cpp
cmake --build --preset build-csharp
cmake --build --preset build-all
```

`build-all` builds everything available for the current environment.

---

## Separate Build Targets

The root CMake defines separate targets:

- `build_cpp` → builds the C++ targets from `BijoyBayannoCpp/` (main app + LayoutEditor prototype on Windows)
- `build_csharp` → builds `BijoyBayanno.sln` with MSBuild (Windows only)
- `build_all` → builds both

If you do not want one side, disable it during configure:

```bat
cmake -S . -B out/build/custom -DBIJOY_ENABLE_CPP=ON -DBIJOY_ENABLE_CSHARP=OFF
```

---

## Project-specific docs

- C# details: `BUILD_REQUIREMENTS.md`
- C++ details: `BijoyBayannoCpp/README.md`
