---
name: Bug report
about: Something in the dump is wrong, missing, or crashes
labels: bug
---

**What happened**

**What you expected**

**How to reproduce** - the pipeline you ran, ideally shortened to the smallest case:

```powershell
Get-Something | Out-Dump -Depth 2
```

**Environment**

- PoShDump version: `(Get-Module PoShDump).Version`
- PowerShell: `$PSVersionTable.PSVersion` and edition (Desktop / Core)
- OS:

**The dump**, if you can share it - strip anything sensitive first.
