# Build and import the local module first when running from the repository:
# .\Build.ps1
# Import-Module .\output\PoShDump\PoShDump.psd1 -Force

$outputDirectory = Join-Path $PSScriptRoot '..\dumps'

Get-Process |
	Select-Object -First 10 Name, Id, CPU, WorkingSet |
	Out-Dump -Title 'Process sample' -OutputDirectory $outputDirectory -Depth 2 -Show
