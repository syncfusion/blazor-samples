@echo off
REM Diagram Category Sample List Updater
setlocal enabledelayedexpansion
set "scriptPath=%~dp0filter-samplelist.ps1"
set "filePath=Common\Pages\SampleList.cs"
set "category=Diagram"
if not exist "%filePath%" (echo Error: SampleList.cs not found at %filePath% & pause & exit /b 1)
echo Filtering SampleList.cs for %category% category...
echo.
powershell -NoProfile -ExecutionPolicy Bypass -File "%scriptPath%" -Category "%category%"
if %errorlevel% equ 0 (
    echo.
    echo Diagram category filter applied successfully!
    echo Included components: Diagram
    exit /b 0
) else (
    echo. & echo Error updating SampleList.cs
    echo. & pause
    exit /b 1
)
