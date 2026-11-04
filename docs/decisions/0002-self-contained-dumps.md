# 0002 - A dump is a single self-contained HTML file

- **Status:** accepted
- **Date:** 2026-11-04

## Context

`HtmlPageGenerator` wrote the stylesheet and the script into the page as links to the module's own
installation folder:

```html
<link rel="stylesheet" href="file:///C:/Users/.../PoShDump/bin/resources/default.css" />
<script src="file:///C:/Users/.../PoShDump/bin/resources/page.js"></script>
```

That works on the machine that produced the dump and nowhere else. Copy the file to another machine, attach it
to a ticket, or uninstall the module, and the page loses its styling and its collapse behaviour. The README
already promised the opposite - "a dump is a single self-contained file" - so the promise was false.

It matters beyond correctness: ADR [0001](0001-open-core-distribution.md) makes the dump footer the product's
distribution channel, and a dump only travels if it still renders where it lands.

The constraints are modest. `default.css` and `page.js` together are a few kilobytes, the icons are already
inlined as base64 data URIs, and the dump is generated on the spot rather than served, so page weight costs
nothing but disk.

## Decision

The generator inlines the stylesheet and the script into the generated page (`<style>` and `<script>` with the
file contents) instead of linking them. A dump never loads anything from disk or from the network when it is
opened.

## Alternatives considered

- **Copy `resources` next to the dump.** Keeps the files separate and cacheable, but a dump stops being one
  file: moving or mailing it means remembering a folder, which is exactly the failure being fixed.
- **Embed the resources into the assembly and still write them out.** Same problem, more machinery.
- **Load the stylesheet from a CDN.** Smallest page, but breaks on an air-gapped server, leaks the fact that a
  dump was opened, and rots when the URL changes. The whole point of the tool is that it works offline.

## Consequences

- Every dump carries its own copy of the stylesheet and the script, so page size grows by a few kilobytes and
  many dumps cannot share a browser cache. Neither matters at this size.
- Dumps written by different module versions render with the stylesheet of the version that wrote them. That
  is a feature for an archived dump, and it means a CSS fix does not retroactively repair old dumps.
- A future viewer application cannot assume an external data file next to the page: whatever it reads has to be
  inside the dump itself, which points at embedding a JSON data island rather than a sidecar file.
- The resources still have to ship with the module, because the generator reads them at dump time.
