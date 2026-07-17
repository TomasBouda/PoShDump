using System;
using PoShDump.Html;
using PoShDump.Html.Extensions;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

namespace PoShDump.CmdLets
{
	[Cmdlet(VerbsData.Out, "Dump")]
	[OutputType(typeof(object))]
	[Alias("dmp")]
	public class OutDumpPSCmdlet : PSCmdlet
	{
		[ValidateNotNull]
		[Parameter(Mandatory = true, Position = 0, ValueFromPipeline = true)]
		public PSObject InputObject { get; set; }

		[Parameter(Mandatory = false)]
		[ValidateRange(0, 10)]
		public int Depth { get; set; } = 2;

		[Parameter(Mandatory = false)]
		public string Title { get; set; }
		
		[Parameter(Mandatory = false)]
		public string ResourcesDirectory { get; set; }
		
		[Parameter(Mandatory = false)]
		public string OutputDirectory { get; set; }
		
		[Parameter(Mandatory = false)]
		public SwitchParameter Show { get; set; }

		private HtmlPageGenerator HtmlGenerator { get; set; }
		private ObjectProcessor ObjectProcessor { get; set; }

		private IEnumerable<object> _objects = new List<object>();

		protected override void BeginProcessing()
		{
			var rootPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

			if (string.IsNullOrEmpty(ResourcesDirectory))
			{
				ResourcesDirectory = Path.Combine(rootPath, "resources");
			}
			if (string.IsNullOrEmpty(OutputDirectory))
			{
				OutputDirectory = Path.Combine(Path.GetTempPath(), "TomLabs", "PoShDump");
			}

			if (!Directory.Exists(OutputDirectory))
			{
				Directory.CreateDirectory(OutputDirectory);
			}
			
			HtmlGenerator = new HtmlPageGenerator(ResourcesDirectory);
			ObjectProcessor = new ObjectProcessor();
		}

		protected override void ProcessRecord()
		{
			// PassThru
			WriteObject(InputObject);

			_objects = _objects.Add(InputObject);
		}

		protected override void EndProcessing()
		{
			if (!_objects.Any())
			{
				return;
			}

			var objects = NormalizeInputObjects().ToArray();
			if (!objects.Any())
			{
				return;
			}

			if (objects.Length > 1)
			{
				Title = Title ?? $"{GetObjectTypeName(objects.First())} • Out-Dump";

				var sw = Stopwatch.StartNew();
				var dump = ObjectProcessor.DumpCollectionAsync(objects, Depth).GetAwaiter().GetResult();
				sw.Stop();

				// Host.UI.WriteLine(sw.Elapsed.ToString());

				var dumpPath = HtmlGenerator.Generate(dump, Title, OutputDirectory);

				if (Show.IsPresent)
				{
					OpenInDefaultApplication(dumpPath);
				}
			}
			else
			{
				var obj = objects.First();
				Title = Title ?? $"{GetObjectTypeName(obj)} • Out-Dump";

				var sw = Stopwatch.StartNew();
				var dump = ObjectProcessor.DumpObjectAsync(obj, Depth).GetAwaiter().GetResult();
				sw.Stop();

				// Host.UI.WriteLine(sw.Elapsed.ToString());

				var dumpPath = HtmlGenerator.Generate(dump, Title, OutputDirectory);
				
				if (Show.IsPresent)
				{
					OpenInDefaultApplication(dumpPath);
				}
			}
		}

		private IEnumerable<object> NormalizeInputObjects()
		{
			var objects = _objects.ToArray();
			var firstObject = objects.FirstOrDefault();
			var baseObject = (firstObject as PSObject)?.BaseObject ?? firstObject;

			if (objects.Length == 1 && baseObject is System.Collections.IEnumerable enumerable && !(baseObject is string))
			{
				return enumerable.Cast<object>();
			}

			return objects;
		}

		private static string GetObjectTypeName(object inputObject)
		{
			var baseObject = (inputObject as PSObject)?.BaseObject ?? inputObject;

			return baseObject?.GetType().FullName;
		}

		private static void OpenInDefaultApplication(string path)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = path,
				UseShellExecute = true
			});
		}
	}
}
