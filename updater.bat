@ECHO OFF
::%1 is the installation directory
::%2 is the download directory
set dir=%1
rmdir /s /q %dir%
mkdir %dir%
copy %2\*.* %dir%
