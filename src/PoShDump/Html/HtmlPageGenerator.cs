using PoShDump.Html.Core.Elements;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace PoShDump.Html
{
	public class HtmlPageGenerator
	{
		public string ResourcesDirectory { get; }

		public HtmlPageGenerator(string resourcesDirectory)
		{
			ResourcesDirectory = resourcesDirectory;
		}

		public string Generate(HtmlElement element, string title, string outputDirectory)
		{
			var template = File.ReadAllText(Path.Combine(ResourcesDirectory, "out_template.html"));

			// The stylesheet and the script are inlined, not linked: a dump has to stay readable
			// when it is copied to another machine or attached to a ticket.
			template = template
				.Replace("{Stylesheet}", "<style>" + Environment.NewLine + ReadResource("default.css") + Environment.NewLine + "</style>")
				.Replace("{Body_Scripts}", "<script>" + Environment.NewLine + ReadResource("page.js") + Environment.NewLine + "</script>")
				.Replace("{Content}", element.ToString())
				.Replace("{Title}", title)
				.Replace("{Version}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);

			var dumpFile = Path.Combine(outputDirectory, $"dump-{DateTime.Now:yyyyMMdd_HHmmss}.html");
			File.WriteAllText(dumpFile, template);

			return dumpFile;
		}

		private string ReadResource(string fileName)
		{
			return File.ReadAllText(Path.Combine(ResourcesDirectory, fileName));
		}
	}
}
