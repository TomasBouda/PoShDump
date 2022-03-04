using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Helpers;

namespace PoShDump.Html
{
	public class HtmlProcessor
	{
		private readonly HtmlElement ARROW_DOWN = H.icon("fa-solid fa-square-caret-down");

		public HtmlProcessor(string rootPath)
		{
			RootPath = rootPath;
		}

		public string RootPath { get; }

		public HtmlElement DumpObject(object input)
		{
			var inputType = input.GetType();
			var header = H.thead(
				H.th(ARROW_DOWN, inputType.Name).WithAttributes(a => a.Custom("colspan", 2))
				);

			var tableRows = new List<HtmlElement>();
			var properties = inputType.GetProperties();
			if (properties.Any())
			{
				foreach (var property in properties)
				{
					var value = property.GetValue(input);
					tableRows.Add(H.tr(
						H.td(H.span(property.Name).WithAttributes(a => a.title(property.PropertyType.FullName))),
									H.td(value)
						));
				}
			}

			return H.table(header, H.tbody(tableRows)).WithAttributes(a => a.@class("tbl-object collapsed"));
		}

		public void GetHtmlPage(HtmlElement element)
		{
			var template = File.ReadAllText(Path.Combine(RootPath, "resources\\out_template.html"));

			template = template
				.Replace("{Stylesheet}", H.linkCss(Path.Combine(RootPath, "resources\\default.css")).ToString())
				.Replace("{Body_Scripts}", Path.Combine(RootPath, "resources\\page.js"))
				.Replace("{Content}", element.ToString());

			var outputPath = Path.Combine(RootPath, "dump.html");
			File.WriteAllText(outputPath, template);
			Process.Start("cmd.exe ", @"/c " + outputPath); // TODO make multiplatform
		}
	}
}
