using PoShDump.Html.Core.Attributes;
using PoShDump.Html.Core.Elements;
using System;

namespace PoShDump.Html.Helpers
{
	public partial struct H
	{
		public static HtmlText text(string text) => new HtmlText(text);
		public static HtmlElement doc(params HtmlNode[] contents) => new HtmlDocument(contents);

		/// <summary>
		/// Non breakable space
		/// </summary>
		/// <returns></returns>
		public static HtmlText nbsp() => H.text("\u00A0");

		///// <summary>
		///// Font awesome icon
		///// </summary>
		///// <param name="cssClass"></param>
		///// <returns></returns>
		public static HtmlElement<HtmlAttribute> fa(string cssClass) => new HtmlElement<HtmlAttribute>("i", "").WithAttributes(a => a.@class(cssClass));

		public static HtmlElement<linkAttr> LinkCss(Uri href) => LinkCss(href.AbsoluteUri);
		public static HtmlElement<linkAttr> LinkCss(string href) => new link()
			.WithAttributes(a =>
				a.rel("stylesheet")
				.type("text/css")
				.href(href));

		public static HtmlElement<scriptAttr> LinkScript(Uri src) => LinkScript(src.AbsoluteUri);
		public static HtmlElement<scriptAttr> LinkScript(string src) => new script(string.Empty).WithAttributes(a => a.src(src));
	}
}
