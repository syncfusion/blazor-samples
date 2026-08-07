@echo off
REM Gantt Category Sample List Updater
setlocal enabledelayedexpansion
set "scriptPath=%~dp0filter-samplelist.ps1"
set "filePath=Common\Pages\SampleList.cs"
set "category=Gantt"
if not exist "%filePath%" (echo Error: SampleList.cs not found at %filePath% & pause & exit /b 1)
echo Filtering SampleList.cs for %category% category...
echo.
powershell -NoProfile -ExecutionPolicy Bypass -File "%scriptPath%" -Category "%category%"
if %errorlevel% equ 0 (
    echo.
    echo Gantt category filter applied successfully!
    echo Included components: GanttChart, Kanban
    exit /b 0
) else (
    echo. & echo Error updating SampleList.cs
    echo. & pause
    exit /b 1
)
