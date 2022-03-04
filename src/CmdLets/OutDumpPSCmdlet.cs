using System.Management.Automation;
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
		public int Depth { get; set; }

		private HtmlProcessor _htmlProcessor { get; set; }

		protected override void BeginProcessing()
		{
			_htmlProcessor = new HtmlProcessor(MyInvocation.PSScriptRoot);
		}

		protected override void ProcessRecord()
		{
			//WriteObject();
			_htmlProcessor.GetHtmlPage(_htmlProcessor.DumpObject(InputObject.BaseObject));
		}

		protected override void EndProcessing()
		{
		}
	}
}
