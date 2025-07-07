@echo off
echo Building System Diagnostics App...
cd SystemDiagnosticsApp
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true
echo.
echo Executable created at: bin\Release\net9.0-windows\win-x64\publish\SystemDiagnosticsApp.exe
pause