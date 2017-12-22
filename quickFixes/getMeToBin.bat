@echo off
set back=%cd%
cd ..
if exist server\nul goto serverMode
cd %back%
echo Rotux source was not found, running in binary mode...
if exist Rotux\nul cd Rotux
if not exist bin\nul goto NoRotux
cd bin
goto End

:serverMode
echo Rotux source was found, searching for binary files...
cd server
if not exist bin\nul goto NoRotux
cd bin
set i=0
if exist Release\nul set /a i=%i%+1
if exist Debug\nul set /a i=%i%+1
if "%i%"=="1" goto PickOne
if "%i%"=="2" goto LetUser
goto NoRotux

:PickOne
echo One binary folder was found...
if exist Release\nul cd Release
if exist Debug\nul cd Debug
goto End

:LetUser
echo Two binary folders were found:
echo ?1 Release
echo ?2 Debug
echo If you type in incorrect input, Debug will be chosen!
set /p folder=?
if "%folder%"=="1" cd Release
if "%folder%"=="2" cd Debug
if exist Debug\nul cd Debug
goto End

:NoRotux
echo Rotux was not compiled correctly or was not found!

:Done
echo Press any key to exit...
pause > nul
exit
:End
echo Bin folder is: %cd%