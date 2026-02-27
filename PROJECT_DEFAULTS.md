# Project Defaults

This repository now includes a few baseline project-level defaults:

- `.gitignore` for CMake, Visual Studio, and temporary files.
- `.editorconfig` for consistent UTF-8 + LF formatting and 2-space indentation.
- `LICENSE` with the MIT license text.

## Runtime defaults

- Main bar is kept at the top edge (`Top` defaults to `0`).
- Vertical dragging is constrained to top (`0` or `1`), and the bar snaps back to top if moved down.
- Layout XML discovery checks `data/layout` (plus legacy fallback directories).
