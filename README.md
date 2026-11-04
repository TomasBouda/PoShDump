# PoShDump

PoShDump is a PowerShell object inspector. Pipe any object to `Out-Dump` and it writes an interactive HTML dump that is easy to expand, collapse, search, share, and keep with troubleshooting notes.

## Install

PoShDump is on the PowerShell Gallery. Until `1.0.0` is released, only a prerelease is published there, so the
install needs `-AllowPrerelease`:

```powershell
Install-Module PoShDump -Scope CurrentUser -AllowPrerelease
```

For local development:

```powershell
.\Build.ps1
Import-Module .\output\PoShDump\PoShDump.psd1 -Force
```

## Usage

Create an HTML dump in the default temp directory:

```powershell
Get-Process | Select-Object -First 10 | Out-Dump
```

Create a dump in a specific folder:

```powershell
Get-Service | Out-Dump -OutputDirectory .\dumps -Title 'Services'
```

Create a dump and open it in the default browser:

```powershell
Get-ChildItem $HOME | Out-Dump -Depth 3 -Show
```

`Out-Dump` passes input objects through the pipeline, so it can be inserted into existing commands while still producing the HTML dump.

## Parameters

| Parameter | Description |
| --- | --- |
| `-Depth` | Controls how deeply nested objects are expanded. Default: `2`. |
| `-Title` | Sets the generated HTML page title. |
| `-OutputDirectory` | Folder where `dump-*.html` is written. Default: temp folder under `TomLabs\PoShDump`. |
| `-ResourcesDirectory` | Overrides the CSS/JS resource folder. Mostly useful for development. |
| `-Show` | Opens the generated HTML file with the operating system default application. |

## Build, Test, Publish

```powershell
.\Build.ps1
.\Test-PoShDump.ps1
.\Publish.ps1 -NuGetApiKey '<your-gallery-api-key>' -WhatIf
```

Remove `-WhatIf` only when the preview output looks right.

## Azure Pipeline Release

The repository includes `azure-pipelines.yml`.

Configure a secret pipeline variable named `PSGalleryApiKey`, then create a release tag to publish:

```powershell
git tag v1.0.0-preview1
git push origin v1.0.0-preview1
```

The pipeline builds and smoke-tests every `master` push and pull request. Publishing to PowerShell Gallery only runs for tags starting with `v`.

## Decisions

PoShDump is open core: the module is free and MIT licensed, and the architectural decisions behind it are
recorded in [docs/decisions](docs/decisions/README.md), starting with
[ADR 0001 - Distribute PoShDump as open core](docs/decisions/0001-open-core-distribution.md).

## License

MIT. See [LICENSE](LICENSE).
