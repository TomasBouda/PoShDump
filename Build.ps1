$ErrorActionPreference = 'Stop'

$moduleName = 'PoShDump'
$moduleRoot = Join-Path $PSScriptRoot "output\$moduleName"
$binRoot = Join-Path $moduleRoot 'bin'
$projectPath = Join-Path $PSScriptRoot "src\$moduleName\$moduleName.csproj"
$metadataPath = Join-Path $PSScriptRoot "src\$moduleName\Metadata"

New-Item $moduleRoot -ItemType Directory -Force | Out-Null
New-Item $binRoot -ItemType Directory -Force | Out-Null

Copy-Item (Join-Path $metadataPath '*') $moduleRoot -Recurse -Force
Copy-Item (Join-Path $PSScriptRoot 'README.md') $moduleRoot -Force
Copy-Item (Join-Path $PSScriptRoot 'LICENSE') $moduleRoot -Force
Copy-Item (Join-Path $PSScriptRoot 'CHANGELOG.md') $moduleRoot -Force
Copy-Item (Join-Path $PSScriptRoot 'Examples') $moduleRoot -Recurse -Force

Get-ChildItem $binRoot -Force | Remove-Item -Recurse -Force
dotnet build $projectPath -o $binRoot -c Release

Get-ChildItem $binRoot -Include '*.pdb', '*.json', 'System.Management.Automation.dll' -Recurse |
	Remove-Item -Force

Test-ModuleManifest (Join-Path $moduleRoot "$moduleName.psd1") | Out-Null
Write-Host "Built $moduleName module at $moduleRoot"
