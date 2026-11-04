# Changelog

## Unreleased

### Changes

- Opened the source at `github.com/TomasBouda/PoShDump`, with GitHub Actions CI, contributing and security
  notes, and a screenshot in the README.
- Removed dead scratch files (`dump.html`, `debug.ps1`, `src/.idea`, two console projects) from the repository.
- Pointed the gallery metadata at the public GitHub repository `TomasBouda/PoShDump`.
- Recorded the open core decision in `docs/decisions` (ADR 0001).

### Bug fixes

- Fixed the install instructions in the README: while only a prerelease is published, `Install-Module PoShDump`
  needs `-AllowPrerelease`.
- Fixed the dead project, license and icon links on the PowerShell Gallery page, which pointed at a repository
  that does not exist.

## 1.0.0-preview1 — 2026-07-17

### Features

- Added `Out-Dump`, which writes an interactive HTML dump of the piped objects and passes them through.
- Added PowerShell Gallery metadata and publish scripts.

### Changes

- Made the generated HTML work without external JavaScript dependencies.
- Added README, license, changelog, example, and smoke test script.

### Bug fixes

- Added safer handling for pipeline arrays and collection dumps.
