cmake_minimum_required(VERSION 3.14)
project(BijoyBayanno LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

set(BIJOY_BUILD_ROOT "${CMAKE_SOURCE_DIR}/build")
set(BIJOY_RUNTIME_OUTPUT_DIR "${BIJOY_BUILD_ROOT}/bin")
set(BIJOY_DATA_DIR "${BIJOY_BUILD_ROOT}/data")

file(MAKE_DIRECTORY "${BIJOY_RUNTIME_OUTPUT_DIR}")
file(MAKE_DIRECTORY "${BIJOY_DATA_DIR}")
file(MAKE_DIRECTORY "${BIJOY_BUILD_ROOT}/temp")

add_executable(BijoyBayanno WIN32
  src/app/main.cpp
  src/core/app_state.cpp
  src/core/keyboard_hook_service.cpp
  src/core/layout.cpp
  src/core/layout_discovery.cpp
  src/core/window_layout_binding.cpp
  src/platform/windows/main_window.cpp
  src/platform/windows/native_input.cpp
  src/platform/windows/registration_dialog.cpp
)

option(BIJOY_INCLUDE_RESOURCES "Compile Win32 resource file (app.rc)" ON)
if(BIJOY_INCLUDE_RESOURCES)
  if(CMAKE_RC_COMPILER)
    enable_language(RC)
    target_sources(BijoyBayanno PRIVATE src/platform/windows/app.rc)
  else()
    message(WARNING "Resource compiler not found. Building without src/platform/windows/app.rc")
  endif()
endif()

target_include_directories(BijoyBayanno PRIVATE include)
target_compile_definitions(BijoyBayanno PRIVATE UNICODE _UNICODE BIJOY_DATA_DIR=L"${BIJOY_DATA_DIR}/")
target_link_libraries(BijoyBayanno PRIVATE comctl32 shell32 shlwapi)

set_target_properties(BijoyBayanno PROPERTIES
  RUNTIME_OUTPUT_DIRECTORY "${BIJOY_RUNTIME_OUTPUT_DIR}"
)

if(MSVC)
  target_compile_options(BijoyBayanno PRIVATE /W4)
else()
  target_compile_options(BijoyBayanno PRIVATE -Wall -Wextra)
endif()
