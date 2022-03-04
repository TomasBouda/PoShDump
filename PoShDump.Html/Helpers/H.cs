using System.Collections.Generic;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Specific.Attributes;

namespace PoShDump.Html.Helpers
{
	public static class H
	{
		public static HtmlText text(string text) => new HtmlText(text);
		public static HtmlElement doc(params HtmlNode[] contents) => new HtmlDocument(contents);

		public static HtmlElement<LinkAttributeContainer> linkCss(string href) => new HtmlElement<LinkAttributeContainer>("link")
			.WithAttributes(a => a.rel("stylesheet").type("text/css").href(href));

		public static HtmlElement icon(string cssClass) => new HtmlElement("i", "").WithAttributes(a => a.@class(cssClass));

		public static HtmlElement table(params object[] contents) => new HtmlElement("table", contents);

		public static HtmlElement thead(params object[] contents) => new HtmlElement("thead", contents);

		public static HtmlElement tbody(params object[] contents) => new HtmlElement("tbody", contents);
		public static HtmlElement tbody(IEnumerable<object> contents) => new HtmlElement("tbody", contents);

		public static HtmlElement tr(params object[] contents) => new HtmlElement("tr", contents);

		public static HtmlElement th(params object[] contents) => new HtmlElement("th", contents);

		public static HtmlElement td(params object[] contents) => new HtmlElement("td", contents);

		public static HtmlElement span(params object[] contents) => new HtmlElement("span", contents);

		public static HtmlElement i(params object[] contents) => new HtmlElement("i", contents);
	}
}
