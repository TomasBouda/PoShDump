# Contributing

Thanks for looking. Issues and pull requests are welcome.

## Getting the module running

```powershell
.\Build.ps1
Import-Module .\output\PoShDump\PoShDump.psd1 -Force
```

`Build.ps1` compiles the C# projects in `src` and assembles the module into `output\PoShDump`, which is the same
layout that is published to the PowerShell Gallery.

Before opening a pull request, run the tests - the script builds the module and runs the Pester suite in `tests`
against the build output:

```powershell
.\Test-PoShDump.ps1
```

## What to know before changing things

- The module targets `netstandard2.0` on purpose, so it loads in Windows PowerShell 5.1 as well as PowerShell 7.
  Language features and packages that need a newer target are out.
- A generated dump has to work offline: no CDN, no external JavaScript or CSS. Everything is inlined or shipped
  in `src/PoShDump/resources`.
- Every dependency added to the binary module is a potential assembly conflict inside somebody else's
  PowerShell session. Prefer writing the small piece yourself.
- Architectural decisions live in [docs/decisions](docs/decisions/README.md). If your change makes one, add a
  record in the same pull request.
- User-facing changes get a bullet in `CHANGELOG.md` under `## Unreleased`.

## Style

Code, comments, commit messages and documentation are in English. Tabs for indentation in PowerShell and C#,
matching the files around you.
