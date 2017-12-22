hash xbuild 2>/dev/null || { echo >&2 "Mono [xbuid] is not installed.  Aborting."; exit 1; }
cd server
xbuild Server.sln
exit 0;
