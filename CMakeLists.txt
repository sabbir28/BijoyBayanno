cmake_minimum_required(VERSION 3.20)

project(BijoyBayannoMeta NONE)

option(BIJOY_ENABLE_CPP "Enable C++/Win32 project build" ON)
option(BIJOY_ENABLE_CSHARP "Enable C# solution build via MSBuild" ON)

if(BIJOY_ENABLE_CPP)
  add_subdirectory(BijoyBayannoCpp)

  add_custom_target(build_cpp
    DEPENDS bijoy_cpp_all
    COMMENT "Build C++ target (BijoyBayannoCpp/BijoyBayanno)"
  )
endif()

if(BIJOY_ENABLE_CSHARP)
  if(WIN32)
    find_program(BIJOY_MSBUILD_EXECUTABLE
      NAMES msbuild MSBuild
      DOC "MSBuild executable for building the C# solution"
    )

    if(BIJOY_MSBUILD_EXECUTABLE)
      set(BIJOY_CSHARP_CONFIG "Debug" CACHE STRING "C# solution configuration")
      set(BIJOY_CSHARP_PLATFORM "x86" CACHE STRING "C# solution platform")

      add_custom_target(build_csharp
        COMMAND "${BIJOY_MSBUILD_EXECUTABLE}" "${CMAKE_SOURCE_DIR}/BijoyBayanno.sln"
                /p:Configuration=${BIJOY_CSHARP_CONFIG}
                /p:Platform=${BIJOY_CSHARP_PLATFORM}
        WORKING_DIRECTORY "${CMAKE_SOURCE_DIR}"
        COMMENT "Build C# solution (BijoyBayanno.sln)"
        VERBATIM
      )
    else()
      message(WARNING "BIJOY_ENABLE_CSHARP=ON, but MSBuild was not found in PATH. 'build_csharp' target will not be available.")
    endif()
  else()
    message(WARNING "BIJOY_ENABLE_CSHARP is ignored on non-Windows hosts.")
  endif()
endif()

if(TARGET build_cpp AND TARGET build_csharp)
  add_custom_target(build_all
    DEPENDS build_cpp build_csharp
    COMMENT "Build both C++ and C# targets"
  )
elseif(TARGET build_cpp)
  add_custom_target(build_all
    DEPENDS build_cpp
    COMMENT "Build available C++ target"
  )
elseif(TARGET build_csharp)
  add_custom_target(build_all
    DEPENDS build_csharp
    COMMENT "Build available C# target"
  )
endif()
