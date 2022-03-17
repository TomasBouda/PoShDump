Import-Module "$PSScriptRoot\src\PoShDump\bin\Debug\netstandard2.0\PoShDump.dll"
# Get-Date | Out-Dump
Get-Process | Select-Object -First 1 | Sort-Object -Property Id | Out-Dump -Depth 3
# Out-Dump -InputObject (Get-Process | Select-Object -First 2)
# Get-Process -Name 'WindowsTerminal' | Select-Object -First 1 | Out-Dump -Depth 3

pause