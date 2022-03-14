Import-Module "$PSScriptRoot\src\PoShDump\bin\Debug\netstandard2.0\PoShDump.dll"
# Get-Date | Out-Dump
# Get-Process | Select-Object -First 2 | Out-Dump
# Out-Dump -InputObject (Get-Process | Select-Object -First 2)
Get-Process -Name 'WindowsTerminal' | Select-Object -First 1 | Out-Dump

# pause