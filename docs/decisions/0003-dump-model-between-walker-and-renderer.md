# 0003 - A dump model sits between the object walker and the HTML renderer

**Status:** accepted

**Date:** 2026-11-04

## Context

Until now `ObjectProcessor` read a PowerShell object and produced `HtmlElement` in one pass: it called
`PSObject.Properties`, decided what kind of value it had found, and built the table cell for it in the same
method. There was no representation of a dump anywhere in between.

That has three consequences:

- **Nothing but the HTML renderer can consume a dump.** The planned viewer application would have to parse
  the module's own HTML to get the data back out, which makes the HTML a de facto API: every styling change
  becomes a breaking change.
- **The PowerShell knowledge and the markup knowledge are mixed.** A change to how a boolean is displayed
  sits next to a change to how a property is read, so neither can be tested on its own.
- **The asynchrony was make-believe.** Every method was `async Task<HtmlElement>` and awaited the next one,
  but nothing was ever asynchronous. The `AsyncEnumerator` package was referenced, its namespace imported,
  and never used - while shipping four extra assemblies with the module.

## Decision

A dump is modelled explicitly. `PoShDump.Model` holds the model (`DumpObject`, `DumpCollection`, `DumpValue`
and the small types around them), and the work is split in three:

- `PoShDump.Dump.ObjectWalker` turns an object into a model. It is the only place that touches `PSObject`.
- `PoShDump.Html.DumpHtmlRenderer` turns a model into HTML. It knows nothing about PowerShell.
- `PoShDump.Model.DumpJsonWriter` turns a model into JSON, exposed through the new `-IncludeData` switch on
  `Out-Dump`, which writes the model into the page as a `<script type="application/json">` data island.

The walker is synchronous, and the `AsyncEnumerator` dependency is gone.

The split is behaviour neutral: the generated HTML is byte for byte what it was before, verified against
seven fixtures (scalars, nesting, collections, an empty collection, an exception, a non-PowerShell type and
depth 0) dumped before and after the change.

## Alternatives considered

- **Keep one pass and give the viewer an HTML parser.** Rejected: it ties the viewer to the markup, so the
  module could never restyle a dump without breaking it, and the viewer would have to reconstruct types and
  value kinds from CSS class names.
- **Put the model in a new `PoShDump.Core` project.** Rejected for now: the viewer will read the JSON, not
  reference the assembly, so a third project would buy nothing but another build output to ship. If a reader
  library ever becomes worth publishing, the model moves then - it has no dependency on the rest of the
  module.
- **Write the JSON into every dump.** Rejected: it roughly doubles the file size for the common case of
  reading a dump in a browser. `-IncludeData` makes it a feature the caller asks for instead of a cost
  everyone pays.
- **Use a JSON library.** Rejected: `netstandard2.0` has no JSON writer of its own, and the module's promise
  of "install and it works in both PowerShell hosts" is worth more than a few hundred lines of hand written
  writer. The module now ships two assemblies instead of six.

## Consequences

- A dump has a documented data shape (`poshdump-dump`, version 1) that a tool can read without parsing HTML.
  The version has to be raised whenever the shape changes in a way a reader would notice.
- The renderer can be changed freely, and the walker can be tested without a browser.
- The module ships four fewer assemblies and has no third party runtime dependency.
- A second renderer (Markdown, plain text, a terminal view) is now a matter of consuming the model.
- The model lives inside the `PoShDump` assembly, so a future reader library means moving these types, which
  is a breaking change for anyone who referenced the assembly directly. Nothing documented does.
