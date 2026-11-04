<#
.SYNOPSIS
	Builds the module and runs the Pester test suite against the built output.
#>
[CmdletBinding()]
param(
	[switch] $SkipBuild
)

$ErrorActionPreference = 'Stop'

if (-not $SkipBuild) {
	& (Join-Path $PSScriptRoot 'Build.ps1')
}

$pester = Get-Module Pester -ListAvailable |
	Where-Object { $_.Version -ge [version]'5.0.0' } |
	Sort-Object Version -Descending |
	Select-Object -First 1

if (-not $pester) {
	Write-Host 'Installing Pester 5...'
	Install-Module Pester -MinimumVersion 5.0.0 -Scope CurrentUser -Force -SkipPublisherCheck
	$pester = Get-Module Pester -ListAvailable |
		Where-Object { $_.Version -ge [version]'5.0.0' } |
		Sort-Object Version -Descending |
		Select-Object -First 1
}

Import-Module $pester.Path -Force

$configuration = New-PesterConfiguration
$configuration.Run.Path = Join-Path $PSScriptRoot 'tests'
$configuration.Run.Throw = $true
$configuration.Output.Verbosity = 'Detailed'

Invoke-Pester -Configuration $configuration
