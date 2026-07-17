param(
	[Parameter(Mandatory = $true)]
	[string] $NuGetApiKey,

	[Parameter(Mandatory = $false)]
	[string] $Repository = 'PSGallery',

	[Parameter(Mandatory = $false)]
	[switch] $WhatIf
)

$ErrorActionPreference = 'Stop'

$moduleName = 'PoShDump'
$modulePath = Join-Path $PSScriptRoot "output\$moduleName"
$manifestPath = Join-Path $modulePath "$moduleName.psd1"

& (Join-Path $PSScriptRoot 'Build.ps1')

Test-ModuleManifest $manifestPath | Out-Null
Publish-Module -Path $modulePath -Repository $Repository -NuGetApiKey $NuGetApiKey -WhatIf:$WhatIf
