BeforeAll {
	$repoRoot = Split-Path -Parent $PSScriptRoot
	$modulePath = Join-Path $repoRoot 'output\PoShDump\PoShDump.psd1'

	if (-not (Test-Path $modulePath)) {
		throw "Module not built. Run Build.ps1 first (expected $modulePath)."
	}

	Import-Module $modulePath -Force

	$script:testRoot = Join-Path ([System.IO.Path]::GetTempPath()) "PoShDump-Tests-$([guid]::NewGuid())"
	New-Item $script:testRoot -ItemType Directory -Force | Out-Null

	function New-DumpDirectory {
		$directory = Join-Path $script:testRoot ([guid]::NewGuid())
		New-Item $directory -ItemType Directory -Force | Out-Null
		return $directory
	}

	function Get-DumpContent {
		param([string] $Directory)

		$dump = Get-ChildItem $Directory -Filter 'dump-*.html' | Select-Object -First 1
		if (-not $dump) {
			throw "No dump was written to $Directory."
		}

		return Get-Content $dump.FullName -Raw
	}
}

AfterAll {
	Remove-Module PoShDump -Force -ErrorAction SilentlyContinue
	if ($script:testRoot -and (Test-Path $script:testRoot)) {
		Remove-Item $script:testRoot -Recurse -Force -ErrorAction SilentlyContinue
	}
}

Describe 'Module' {
	It 'exports Out-Dump' {
		(Get-Command Out-Dump -Module PoShDump) | Should -Not -BeNullOrEmpty
	}

	It 'exports the dmp alias' {
		(Get-Alias dmp).ResolvedCommandName | Should -Be 'Out-Dump'
	}
}

Describe 'Out-Dump' {
	It 'writes a dump into the output directory' {
		$directory = New-DumpDirectory
		[pscustomobject]@{ Name = 'Alpha' } | Out-Dump -OutputDirectory $directory | Out-Null

		Get-ChildItem $directory -Filter 'dump-*.html' | Should -HaveCount 1
	}

	It 'passes the input object through the pipeline' {
		$directory = New-DumpDirectory
		$source = [pscustomobject]@{ Name = 'Alpha' }

		$output = $source | Out-Dump -OutputDirectory $directory

		$output.Name | Should -Be 'Alpha'
	}

	It 'uses the given title as the page title' {
		$directory = New-DumpDirectory
		[pscustomobject]@{ Name = 'Alpha' } | Out-Dump -OutputDirectory $directory -Title 'My dump' | Out-Null

		Get-DumpContent $directory | Should -Match '<title>My dump</title>'
	}

	It 'renders one row per item of a collection' {
		$directory = New-DumpDirectory
		1..3 | ForEach-Object { [pscustomobject]@{ Name = "Item $_" } } |
			Out-Dump -OutputDirectory $directory | Out-Null

		$content = Get-DumpContent $directory
		foreach ($index in 1..3) {
			$content | Should -Match "Item $index"
		}
	}

	It 'renders a null property without failing' {
		$directory = New-DumpDirectory
		[pscustomobject]@{ Name = 'Alpha'; Missing = $null } | Out-Dump -OutputDirectory $directory | Out-Null

		Get-DumpContent $directory | Should -Match 'Missing'
	}

	It 'renders a nested object' {
		$directory = New-DumpDirectory
		[pscustomobject]@{
			Name    = 'Alpha'
			Address = [pscustomobject]@{ City = 'Brno' }
		} | Out-Dump -OutputDirectory $directory -Depth 3 | Out-Null

		Get-DumpContent $directory | Should -Match 'Brno'
	}
}

Describe 'Property order' {
	It 'keeps the declaration order of a single object' {
		$directory = New-DumpDirectory
		[pscustomobject]@{
			Id = 1; Customer = 'Acme'; Items = 3; Total = 64.3; Paid = $true
		} | Out-Dump -OutputDirectory $directory | Out-Null

		$content = Get-DumpContent $directory
		$positions = 'Id', 'Customer', 'Items', 'Total', 'Paid' | ForEach-Object { $content.IndexOf(">$_<") }

		$positions | Should -Not -Contain ([int]-1)
		for ($i = 1; $i -lt $positions.Count; $i++) {
			$positions[$i] | Should -BeGreaterThan $positions[$i - 1]
		}
	}

	It 'keeps the column order chosen by Select-Object' {
		$directory = New-DumpDirectory
		1..2 | ForEach-Object { [pscustomobject]@{ Zebra = $_; Alpha = $_; Monkey = $_ } } |
			Select-Object Zebra, Alpha, Monkey |
			Out-Dump -OutputDirectory $directory | Out-Null

		$content = Get-DumpContent $directory
		$positions = 'Zebra', 'Alpha', 'Monkey' | ForEach-Object { $content.IndexOf(">$_<") }

		$positions | Should -Not -Contain ([int]-1)
		for ($i = 1; $i -lt $positions.Count; $i++) {
			$positions[$i] | Should -BeGreaterThan $positions[$i - 1]
		}
	}
}

Describe 'Dump page' {
	BeforeAll {
		$script:pageDirectory = New-DumpDirectory
		Get-Process -Id $PID | Select-Object Name, Id, Path, Company, Description |
			Out-Dump -OutputDirectory $script:pageDirectory | Out-Null
		$script:page = Get-DumpContent $script:pageDirectory
	}

	It 'is self contained' {
		$script:page | Should -Not -Match 'file:///'
		$script:page | Should -Not -Match '<link rel="stylesheet"'
		$script:page | Should -Match '(?s)<style>.+</style>'
		$script:page | Should -Match '(?s)<script>.+</script>'
	}

	It 'wraps the dump in a scrollable container' {
		$script:page | Should -Match '<div class="dump">'
		$script:page | Should -Match '\.dump\s*\{[^}]*overflow-x:\s*auto'
	}

	It 'stamps the module version into the footer' {
		$script:page | Should -Match 'PoShDump v\d+\.\d+\.\d+'
	}
}
