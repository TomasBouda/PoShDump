# Changelog

## Unreleased

### Features

- `Out-Dump -IncludeData` writes the dump into the page as JSON as well as HTML (a
  `<script type="application/json" id="poshdump-data">` data island, format `poshdump-dump` version 1), so a
  tool can read a dump without parsing its markup. Off by default, because it roughly doubles the file size.

### Changes

- Split the dump pipeline into an object walker (object to model), an HTML renderer (model to HTML) and a JSON
  writer (model to JSON), with an explicit dump model in between. The generated HTML is unchanged. Recorded as
  ADR 0003.
- Dropped the `AsyncEnumerator` dependency, which was referenced but never used: the module now ships two
  assemblies instead of six and has no third party runtime dependency.

## 1.0.0 — 2026-11-04

### Features

- Added a Pester test suite (`tests/PoShDump.Tests.ps1`), run by `Test-PoShDump.ps1` and by both pipelines.

### Changes

- Opened the source at `github.com/TomasBouda/PoShDump`, with GitHub Actions CI, contributing and security
  notes, and a screenshot in the README.
- Removed dead scratch files (`dump.html`, `debug.ps1`, `src/.idea`, two console projects) from the repository.
- Pointed the gallery metadata at the public GitHub repository `TomasBouda/PoShDump`.
- Recorded the open core decision (ADR 0001) and the self-contained dump decision (ADR 0002) in
  `docs/decisions`.
- Recorded in both project files why the module targets `netstandard2.0` instead of `net10.0`.

### Bug fixes

- Dumps now keep the property order of the input object instead of sorting the properties alphabetically, so
  `Select-Object Name, Id, Status` keeps its column order.
- Wide objects are readable: the dump scrolls inside its own container instead of overflowing the page, long
  string values are clamped and scroll in their cell, and the page no longer scrolls horizontally at 375 px.
- A dump is now a single self-contained file: the stylesheet and the script are inlined instead of being linked
  from the module's installation folder, so a dump still renders after it is copied or attached to a ticket.
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
