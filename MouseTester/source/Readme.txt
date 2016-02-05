Please be sure you have installed Qt library from https://www.qt.io/
1) Create .pro file via qmake
Command: X:\path\to\qt\Qt5.*.*\bin\qmake.exe -project
Sample: C:\Qt\Qt5.5.1\bin\qmake.exe -project
2) Create Makefile
Command: X:\path\to\qt\Qt5.*.*\bin\qmake.exe
Sample: C:\Qt\Qt5.5.1\bin\qmake.exe
3) Build project via MinGW
Command: X:\path\to\qt\Qt5.*.*\Tools\mingw*_32\bin\mingw32-make.exe
Sample: C:\Qt\Qt5.5.1\Tools\mingw492_32\bin\mingw32-make.exe