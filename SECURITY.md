# Security policy

## Reporting a vulnerability

Report anything security relevant privately through GitHub's
[security advisories](https://github.com/TomasBouda/PoShDump/security/advisories/new), not as a public issue.

## What PoShDump does with your data

PoShDump runs locally and writes a self-contained HTML file. It sends nothing anywhere, loads nothing from the
internet when the dump is opened, and has no telemetry.

**A dump contains whatever was in the objects you piped into it.** If those objects carry connection strings,
tokens, passwords or personal data, the HTML carries them too, in plain text. Read a dump before attaching it
to a ticket or sharing it with somebody else.
