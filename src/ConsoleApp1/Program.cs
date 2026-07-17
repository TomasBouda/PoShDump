// See https://aka.ms/new-console-template for more information

using PoShDump.Html;
using System.Diagnostics;

var op = new ObjectProcessor();
var hg = new HtmlPageGenerator(@"D:\Root\GIT\PoShDump\src\PoShDump\bin\Debug\netstandard2.0");

var proc = Process.GetProcesses().Take(25);
var sw = Stopwatch.StartNew();
var dump = await op.DumpCollectionAsync(proc, 2);
sw.Stop();

Console.WriteLine(sw.Elapsed.ToString());

hg.Generate(dump, "c#", @"D:\Root\GIT\PoShDump\src\PoShDump\bin\Debug\");