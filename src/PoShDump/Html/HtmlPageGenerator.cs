using PoShDump.Html.Core.Elements;
using PoShDump.Html.Helpers;
using System;
using System.Collections.Generic;
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

			template = template
				.Replace("{Stylesheet}", string.Join(Environment.NewLine, new List<HtmlNode>
				{
					H.LinkCss(new Uri(Path.Combine(ResourcesDirectory, "default.css")))
				}))
				.Replace("{Body_Scripts}", string.Join(Environment.NewLine, new List<HtmlNode>
				{
					H.LinkScript(new Uri(Path.Combine(ResourcesDirectory, "page.js")))
				}))
				.Replace("{Content}", element.ToString())
				.Replace("{Title}", title)
				.Replace("{Version}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);

			var dumpFile = Path.Combine(outputDirectory, $"dump-{DateTime.Now:yyyyMMdd_HHmmss}.html");
			File.WriteAllText(dumpFile, template);

			return dumpFile;
		}
	}
}
