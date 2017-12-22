@echo off
call getMeToBin.bat
if not exist game\nul call :NoRotux %~0
cd game
echo 0 > version.txt
echo 0 > testingVersion.txt
echo Finished fixing error in Rotux!
goto Done

:NoRotux
echo Missing file: %~0

:Done
echo Press any key to exit...
pause > nul
exit