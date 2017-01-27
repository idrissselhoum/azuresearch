REM java -jar [ScannerJar] -i [AppID] -e [IgnoreSystemErrors] -w [FailOnPolicyWarning] -s [ServerURL] [Target]

REM java -jar [ScannerJar] -i NYCJobs1 -a <admin:avanade1234!> -s http://lifecycle.azure-paas.com %1

echo %1
echo %2
echo %3
echo %4
echo %5
echo %6

REM java -jar %1 -i %2 -a ^<%3:%4^> -s %5 %6

java -jar %1 -i %2 -s %5 %6


