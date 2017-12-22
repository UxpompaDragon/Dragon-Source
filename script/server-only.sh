hash mono 2>/dev/null || { echo >&2 "Mono [runtime] is not installed.  Aborting."; exit 1; }
sudo /opt/lampp/lampp stop
sudo /opt/lampp/lampp startmysql
sudo x-terminal-emulator -e "script/server.sh" --window-with-profile=W
sudo x-terminal-emulator -e "script/wserver.sh" --window-with-profile=S
cd client
exit 0;
