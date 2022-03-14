using PoShDump.Html.Core.Elements;
using PoShDump.Html.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PoShDump.Html
{
	public class HtmlPageGenerator
	{
		public string RootPath { get; }

		public HtmlPageGenerator(string rootPath)
		{
			RootPath = rootPath;
		}

		public void Generate(HtmlElement element, string title)
		{
			var template = File.ReadAllText(Path.Combine(RootPath, "resources\\out_template.html"));

			template = template
				.Replace("{Stylesheet}", string.Join(Environment.NewLine, new List<HtmlNode>
				{
					H.LinkCss(Path.Combine(RootPath, "resources\\default.css"))
				}))
				.Replace("{Body_Scripts}", string.Join(Environment.NewLine, new List<HtmlNode>
				{
					H.LinkScript(Path.Combine(RootPath, "resources\\page.js"))
				}))
				.Replace("{Content}", element.ToString())
				.Replace("{Title}", title);

			var outputPath = Path.Combine(RootPath, "dump.html");
			File.WriteAllText(outputPath, template);
			Process.Start("cmd.exe ", @"/c " + outputPath); // TODO make multiplatform
		}
	}
}
