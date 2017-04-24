param(
	[Parameter(Mandatory=$true)]
    [string]$SourceFolder,
	[Parameter(Mandatory=$true)]
    [string]$TargetFolder
)

Write-Host "Source: $SourceFolder"
Write-Host "Target: $TargetFolder"
Write-Host "Source Folder Content:" -ForegroundColor Green
ls -Recurse $SourceFolder

If (Test-Path $TargetFolder -PathType Container)
{
	Write-Host "Copy Acceptance Tests Files" -ForegroundColor Green
	Copy-item "$SourceFolder\NYCJobs\NYCJobsWeb.AcceptanceTests\bin\Release\" -Destination $TargetFolder\AcceptanceTests -Recurse

	Write-Host "Copy Test Settings file" -ForegroundColor Green
	Copy-item "$SourceFolder\NYCJobs\NYCJobsWeb.AcceptanceTests.runsettings" -Destination $TargetFolder\AcceptanceTests

	Write-Host "Copy ARM Scripts" -ForegroundColor Green
	Copy-item "$SourceFolder\NYCJobs\Azure\" -Destination $TargetFolder\Azure -Recurse

	Write-Host "Copy Deployment Scripts" -ForegroundColor Green
	Copy-item "$SourceFolder\NYCJobs\Deploy\" -Destination $TargetFolder\Deploy -Recurse

	Write-Host "Copy Performance Tests" -ForegroundColor Green
	Copy-item "$SourceFolder\NYCJobs\NYCJobsWeb.PerformanceTests\" -Destination $TargetFolder\PerformanceTests -Recurse
}
Else
{
	Write-Host "$TargetFolder does not exist"
}