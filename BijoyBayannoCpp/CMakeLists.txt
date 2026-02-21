cmake_minimum_required(VERSION 3.14)
project(BijoyBayanno LANGUAGES CXX)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

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

option(BIJOY_INCLUDE_RESOURCES "Compile Win32 resource file (app.rc)" ON)
if(BIJOY_INCLUDE_RESOURCES)
  if(CMAKE_RC_COMPILER)
    enable_language(RC)
    target_sources(BijoyBayanno PRIVATE src/app.rc)
  else()
    message(WARNING "Resource compiler not found. Building without src/app.rc")
  endif()
endif()

target_compile_definitions(BijoyBayanno PRIVATE UNICODE _UNICODE)
target_link_libraries(BijoyBayanno PRIVATE comctl32)

if(MSVC)
  target_compile_options(BijoyBayanno PRIVATE /W4)
else()
  target_compile_options(BijoyBayanno PRIVATE -Wall -Wextra)
endif()
