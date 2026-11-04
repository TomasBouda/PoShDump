using PoShDump.Html.Core.Elements;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace PoShDump.Html
{
	public class HtmlPageGenerator
	{
		/// <summary>
		/// The element the dump data island is written into, so a reader can find it by id.
		/// </summary>
		public const string DataElementId = "poshdump-data";

		public string ResourcesDirectory { get; }

		public HtmlPageGenerator(string resourcesDirectory)
		{
			ResourcesDirectory = resourcesDirectory;
		}

		/// <param name="data">
		/// The dump model as JSON, written into the page as a data island so that something other than a
		/// browser can read the dump. Left out when null.
		/// </param>
		public string Generate(HtmlNode content, string title, string outputDirectory, string data = null)
		{
			var template = File.ReadAllText(Path.Combine(ResourcesDirectory, "out_template.html"));

			// The stylesheet and the script are inlined, not linked: a dump has to stay readable
			// when it is copied to another machine or attached to a ticket.
			template = template
				.Replace("{Stylesheet}", "<style>" + Environment.NewLine + ReadResource("default.css") + Environment.NewLine + "</style>")
				.Replace("{Body_Scripts}", "<script>" + Environment.NewLine + ReadResource("page.js") + Environment.NewLine + "</script>")
				.Replace("{Content}", content.ToString())
				.Replace("{Data}", RenderData(data))
				.Replace("{Title}", title)
				.Replace("{Version}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);

			var dumpFile = Path.Combine(outputDirectory, $"dump-{DateTime.Now:yyyyMMdd_HHmmss}.html");
			File.WriteAllText(dumpFile, template);

			return dumpFile;
		}

		private static string RenderData(string data)
		{
			if (string.IsNullOrEmpty(data))
			{
				return string.Empty;
			}

			// The newline keeps the generated page tidy; nothing follows the placeholder but the page
			// script, which is on the same template line so that an omitted island leaves no blank line.
			return $"<script type=\"application/json\" id=\"{DataElementId}\">{data}</script>"
				+ Environment.NewLine
				+ "\t";
		}

		private string ReadResource(string fileName)
		{
			return File.ReadAllText(Path.Combine(ResourcesDirectory, fileName));
		}
	}
}
