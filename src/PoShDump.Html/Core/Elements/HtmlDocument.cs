using System;

namespace PoShDump.Html.Core.Elements
{
	public class HtmlDocument : HtmlElement
	{
		public HtmlDocument(params HtmlNode[] contents) : base("html", contents)
		{
		}

		public override string ToString()
		{
			return "<!DOCTYPE html>" + Environment.NewLine + base.ToString();
		}
	}
}
