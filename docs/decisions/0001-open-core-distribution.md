# 0001 - Distribute PoShDump as open core

- **Status:** accepted
- **Date:** 2026-11-04

## Context

PoShDump is published on PowerShell Gallery as `1.0.0-preview1` (since 2026-07-17, 15 downloads of that
version), while the source lives in a private Azure DevOps repository. The goal for the project changed: it
should earn money, not only exist.

Constraints that shape the decision:

- PowerShell Gallery has no payment mechanism. A paid module means licence keys and closed binaries, or
  distribution outside the Gallery entirely.
- The Gallery is, however, the only cheap discovery channel a PowerShell module has.
- The free competition is strong where PoShDump is today: PSWriteHTML has 7.6M downloads and is actively
  released. "Pipeline objects to HTML" on its own is not a product.
- The module manifest advertised `github.com/TomasBouda/Out-Dump`, which does not exist - the Gallery page
  had a dead project link and no icon, so even the free funnel leaked.
- Every generated dump already carries a footer with the product name, version and a link, and dumps are
  made to be shared. That is an unusual built-in distribution channel.

## Decision

PoShDump is open core. The module stays free and MIT licensed, its source becomes a public GitHub repository
`TomasBouda/PoShDump` (the same way PoShLog lives at `github.com/PoShLog/PoShLog`), and it keeps being
published to PowerShell Gallery. Revenue comes from a paid layer above the dump - redaction of secrets,
diffing two dumps, branded report bundles and hosted sharing - sold separately, not from the module itself.
The Gallery metadata (`ProjectUri`, `LicenseUri`, `IconUri`) therefore points at that GitHub repository.

## Alternatives considered

- **Closed paid-only product, distributed through apps.tomlabs.cz.** Reaches a price list sooner, but starts
  from no audience (15 preview downloads) and gives up the Gallery, so the realistic outcome is no sales.
  PowerShell users are also reluctant to load closed binary modules into their pipelines.
- **Keep the source private and point the Gallery links at a page on tomasbouda.cz.** Fixes the dead links
  without opening the code, but a project page with no repository behind it wins no trust and no
  contributions, and the page does not exist yet either.
- **Stay free and monetize through donations or sponsorship only.** Predictable, and predictably small; it
  does not answer the goal.

## Consequences

- The Azure DevOps repository becomes the mirror, not the home: pushing to GitHub becomes part of the release
  routine, and anything secret must never enter this repository.
- The free module has to be genuinely finished and discoverable first: a stable `1.0.0` is a prerequisite,
  because `Install-Module PoShDump` currently fails while only a prerelease exists.
- The paid layer has to be designed so that it can be withheld without crippling the free module, which rules
  out putting the value into the dump format itself.
- The dump footer becomes a product surface and has to stay in the free module.
- The Gallery links break until the GitHub repository is created, so the repository has to exist before the
  next `Publish-Module`.
