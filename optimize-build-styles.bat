@echo off

rem Resolve the target folder relative to this .bat file’s location
set "TARGET=%~dp0Common\wwwroot\styles\component-samples"
set "ROOT=%~dp0"

echo Target: "%TARGET%"

if exist "%TARGET%" (
  echo Removing all subfolders except "home-page" from "component-samples" folder...
  pushd "%TARGET%"
  for /d %%D in (*) do (
    if not "%%~nD"=="home-page" (
      rmdir /s /q "%%~fD"
      if exist "%%~fD" (
        echo Failed to remove the folder: "%%~fD". It may be in use or require elevated permissions.
        pause
        popd
        exit /b 1
      )
    ) else (
      echo Skipping folder: "%%~fD"
    )
  )
  popd
  echo Subfolders removed successfully except "home-page".
) else (
  echo Folder not found. Nothing to remove.
)

echo.
for /r "%ROOT%" %%F in (*.csproj) do (
  if not "%%~nxF"=="AssetMinifier.csproj" (
    echo Updating DefineConstants in: "%%~fF"
    powershell -NoProfile -ExecutionPolicy Bypass -Command ^
    "$csproj = '%%~fF';" ^
    "if (-not (Test-Path $csproj)) { Write-Host 'Project file not found:' $csproj; exit 1 }" ^
    "$xml = New-Object System.Xml.XmlDocument; $xml.PreserveWhitespace = $true; $xml.Load($csproj);" ^
    "$pg = $xml.Project.PropertyGroup | Where-Object { $_.Condition -match 'Debug\|AnyCPU' } | Select-Object -First 1;" ^
    "if (-not $pg) { Write-Host 'Debug|AnyCPU PropertyGroup not found.'; exit 1 }" ^
    "$defNode = $pg.SelectSingleNode('DefineConstants');" ^
    "if ($defNode) {" ^
    "  $defs = [string]$defNode.InnerText;" ^
    "} else {" ^
    "  $defs = ''" ^
    "}" ^
    "$parts = @(); if ($defs) { $parts = $defs -split ';' | ForEach-Object { $_.Trim() } | Where-Object { $_ } }" ^
    "if ($parts -notcontains 'BUILD_ENV') { $parts += 'BUILD_ENV'; $pg.DefineConstants = ($parts -join ';'); $xml.Save($csproj); Write-Host 'Added BUILD_ENV to DefineConstants.' } else { Write-Host 'BUILD_ENV already present in DefineConstants.' }"

    if errorlevel 1 (
      echo Failed to update DefineConstants.
      pause
      exit /b 1
    )
  )
)
echo Done.
