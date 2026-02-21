cmake_minimum_required(VERSION 3.14)
project(BijoyBayanno LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 17)

add_executable(BijoyBayanno WIN32
  src/main.cpp
  src/native_api.cpp
  src/keyboard_hook.cpp
  src/layout.cpp
  src/handle_info.cpp
  src/my_functions.cpp
  src/find_layouts.cpp
  src/dlg_registration.cpp
  src/dlg_main.cpp
  src/app_state.cpp
)

target_sources(BijoyBayanno PRIVATE src/app.rc)
enable_language(RC)

target_compile_definitions(BijoyBayanno PRIVATE UNICODE _UNICODE)
target_link_libraries(BijoyBayanno PRIVATE comctl32)

if(MSVC)
  target_compile_options(BijoyBayanno PRIVATE /W4)
else()
  target_compile_options(BijoyBayanno PRIVATE -Wall -Wextra)
endif()
