# Architectural decisions

One record per decision, in the order they were made. A decision is never rewritten - a change of mind gets a
new record that supersedes the old one, so the reasoning stays readable.

| # | Decision | Status | Date |
| --- | --- | --- | --- |
| [0001](0001-open-core-distribution.md) | Distribute PoShDump as open core | accepted | 2026-11-04 |
| [0002](0002-self-contained-dumps.md) | A dump is a single self-contained HTML file | accepted | 2026-11-04 |
| [0003](0003-dump-model-between-walker-and-renderer.md) | A dump model sits between the object walker and the HTML renderer | accepted | 2026-11-04 |

Decisions still to be written down: the own minimal HTML builder instead of HyperLinq, and `netstandard2.0` for
Windows PowerShell 5.1 compatibility.
