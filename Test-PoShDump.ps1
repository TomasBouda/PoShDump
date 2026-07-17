$ErrorActionPreference = 'Stop'

$moduleName = 'PoShDump'
$modulePath = Join-Path $PSScriptRoot "output\$moduleName\$moduleName.psd1"
$outputDirectory = Join-Path ([System.IO.Path]::GetTempPath()) "$moduleName-SmokeTest"

& (Join-Path $PSScriptRoot 'Build.ps1')

if (Test-Path $outputDirectory) {
	Remove-Item $outputDirectory -Recurse -Force
}

New-Item $outputDirectory -ItemType Directory -Force | Out-Null
Import-Module $modulePath -Force

$items = @(
	[pscustomobject]@{ Name = 'Alpha'; Count = 1; Enabled = $true },
	[pscustomobject]@{ Name = 'Beta'; Count = 2; Enabled = $false }
)

$items | Out-Dump -OutputDirectory $outputDirectory | Out-Null

$dump = Get-ChildItem $outputDirectory -Filter 'dump-*.html' | Select-Object -First 1
if (-not $dump) {
	throw 'Smoke test failed: no dump HTML was generated.'
}

Write-Host "Smoke test generated $($dump.FullName)"
