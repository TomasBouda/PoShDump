# PoShDump

PoShDump is a PowerShell object inspector. Pipe any object to `Out-Dump` and it writes an interactive HTML dump that is easy to expand, collapse, search, share, and keep with troubleshooting notes.

## Install

After the module is published to PowerShell Gallery:

```powershell
Install-Module PoShDump -Scope CurrentUser
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

## Monetization

The module is a good fit for a free PowerShell Gallery release with optional monetization around it:

- donations or sponsorships from the generated HTML and project page
- paid support for teams that want customization or internal styling
- a Pro/internal edition with report templates, export bundles, branding, or redaction helpers

## License

MIT. See [LICENSE](LICENSE).
