using PoShDump.Dump;
using PoShDump.Html;
using PoShDump.Html.Extensions;
using PoShDump.Model;
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

		/// <summary>
		/// Writes the dump model into the page as JSON as well as HTML, so that a tool rather than a
		/// person can read the dump. Off by default, because it roughly doubles the size of the file.
		/// </summary>
		[Parameter(Mandatory = false)]
		public SwitchParameter IncludeData { get; set; }

		private HtmlPageGenerator HtmlGenerator { get; set; }
		private ObjectWalker Walker { get; set; }
		private DumpHtmlRenderer Renderer { get; set; }

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
			Walker = new ObjectWalker();
			Renderer = new DumpHtmlRenderer();
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

			Title = Title ?? $"{GetObjectTypeName(objects.First())} \u2022 Out-Dump";

			// The object is walked once into a model; the HTML and the optional JSON are two views of it.
			var dump = objects.Length > 1
				? (DumpNode)Walker.WalkCollection(objects, Depth)
				: Walker.WalkObject(objects.First(), Depth);

			var data = IncludeData.IsPresent ? DumpJsonWriter.Write(dump) : null;
			var dumpPath = HtmlGenerator.Generate(Renderer.Render(dump), Title, OutputDirectory, data);

			if (Show.IsPresent)
			{
				OpenInDefaultApplication(dumpPath);
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
