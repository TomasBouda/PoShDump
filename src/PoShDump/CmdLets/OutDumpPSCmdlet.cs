using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using PoShDump.Html;

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
		public int Depth { get; set; } = 2;

		public string Title { get; set; }

		private HtmlPageGenerator HtmlGenerator { get; set; }
		private ObjectProcessor ObjectProcessor { get; set; }

		private List<object> objects = new List<object>();

		protected override void BeginProcessing()
		{
			HtmlGenerator = new HtmlPageGenerator(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
			ObjectProcessor = new ObjectProcessor();
		}

		protected override void ProcessRecord()
		{
			WriteObject(InputObject);

			objects.Add(InputObject.BaseObject);
		}

		protected override void EndProcessing()
		{

			if (objects.Count > 1 || objects.First().GetType().IsArray)
			{

			}
			else
			{
				var obj = objects.First();
				Title = Title ?? $"Out-Dump • {obj.GetType()}";
				HtmlGenerator.Generate(ObjectProcessor.DumpObject(obj, Depth), Title);
			}

		}
	}
}
