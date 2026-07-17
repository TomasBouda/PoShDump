$ErrorActionPreference = 'Stop'

$moduleName = 'PoShDump'
$source = Join-Path $PSScriptRoot "output\$moduleName"
$destinationRoot = Join-Path ([Environment]::GetFolderPath('MyDocuments')) 'PowerShell\Modules'
$destination = Join-Path $destinationRoot $moduleName

& (Join-Path $PSScriptRoot 'Build.ps1')

New-Item $destinationRoot -ItemType Directory -Force | Out-Null
Copy-Item $source $destinationRoot -Recurse -Force

Write-Host "Installed $moduleName locally at $destination"
