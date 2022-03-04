using System.Diagnostics;
using System.IO;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Helpers;

namespace PoShDump.Html
{
	public class HtmlPageGenerator
	{
		public string RootPath { get; }

		public HtmlPageGenerator(string rootPath)
		{
			RootPath = rootPath;
		}

		public void Generate(BaseHtmlElement element, string title)
		{
			var template = File.ReadAllText(Path.Combine(RootPath, "resources\\out_template.html"));

			template = template
				.Replace("{Stylesheet}", H.linkCss(Path.Combine(RootPath, "resources\\default.css")).ToString())
				.Replace("{Body_Scripts}", H.script(Path.Combine(RootPath, "resources\\page.js")).ToString())
				.Replace("{Content}", element.ToString())
				.Replace("{Title}", title);

			var outputPath = Path.Combine(RootPath, "dump.html");
			File.WriteAllText(outputPath, template);
			Process.Start("cmd.exe ", @"/c " + outputPath); // TODO make multiplatform
		}
	}
}
