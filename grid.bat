@echo off
REM Grid Category Sample List Updater
REM This batch file updates SampleList.cs to show only Grid category components
REM Run this from the project root directory

setlocal enabledelayedexpansion

set "scriptPath=%~dp0filter-samplelist.ps1"
set "filePath=Common\Pages\SampleList.cs"
set "category=Grid"

if not exist "%filePath%" (
    echo Error: SampleList.cs not found at %filePath%
    echo.
    pause
    exit /b 1
)

echo Filtering SampleList.cs for %category% category...
echo.

powershell -NoProfile -ExecutionPolicy Bypass -File "%scriptPath%" -Category "%category%"

if %errorlevel% equ 0 (
    echo.
    echo Grid category filter applied successfully!
    echo Included components: DataGrid, TreeGrid, PivotTable
    exit /b 0
) else (
    echo.
    echo Error updating SampleList.cs
    echo.
    pause
    exit /b 1
)
