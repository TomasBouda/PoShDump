using PoShDump.Html;
using PoShDump.Html.Extensions;
using System.Collections.Generic;
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
		public int Depth { get; set; } = 2;

		public string Title { get; set; }

		private HtmlPageGenerator HtmlGenerator { get; set; }
		private ObjectProcessor ObjectProcessor { get; set; }

		private IEnumerable<object> _objects = new List<object>();

		protected override void BeginProcessing()
		{
			HtmlGenerator = new HtmlPageGenerator(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
			ObjectProcessor = new ObjectProcessor();
		}

		protected override void ProcessRecord()
		{
			WriteObject(InputObject);

			_objects = _objects.Add(InputObject.BaseObject);
		}

		protected override void EndProcessing()
		{

			if (_objects.Count() > 1 || _objects.First().GetType().IsArray)
			{
				if (_objects.First().GetType().IsArray)
				{
					_objects = _objects.First() as IEnumerable<object>;
				}

				var baseObjects = _objects.Cast<PSObject>().Select(p => p.BaseObject);

				HtmlGenerator.Generate(ObjectProcessor.DumpCollection(baseObjects, Depth), "TODO");
			}
			else
			{
				var obj = _objects.First();
				Title = Title ?? $"Out-Dump • {obj.GetType()}";
				HtmlGenerator.Generate(ObjectProcessor.DumpObject(obj, Depth), Title);
			}

		}
	}
}
