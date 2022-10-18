@ECHO OFF
ECHO Demo Automation Executed Started.



set dllpath=C:\Users\raees\source\repos\SQABootCampFinalProject\bin\Debug\SQABootCampFinalProject.dll
set trxerpath=C:\Users\raees\source\repos\SQABootCampFinalProject\bin\Debug\
set TestSummaryReport=C:\Users\raees\source\repos\SQABootCampFinalProject\TestSummaryReport

FOR /f %%a IN ('WMIC OS GET LocalDateTime ^| FIND "."') DO SET DTS=%%a
SET filename=%testcategory%_%DTS:~0,4%%DTS:~4,2%%DTS:~6,2%%DTS:~8,2%%DTS:~10,2%%DTS:~12,2%
echo %filename%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"


VSTest.Console.exe  %dllpath% /Logger:"trx;LogFileName=%TestSummaryReport%\%filename%\%filename%.trx"
cd %trxerpath%

TrxToHTML %TestSummaryReport%\%filename%\
PAUSE