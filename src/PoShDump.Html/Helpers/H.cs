using System;
using System.Collections.Generic;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Specific.Attributes;

namespace PoShDump.Html.Helpers
{
	public static class H
	{
		public static HtmlText text(string text) => new HtmlText(text);
		public static HtmlElement doc(params HtmlNode[] contents) => new HtmlDocument(contents);

		/// <summary>
		/// Non breakable space
		/// </summary>
		/// <returns></returns>
		public static HtmlText nbsp() => H.text("\u00A0");

		/// <summary>
		/// Font awesome icon
		/// </summary>
		/// <param name="cssClass"></param>
		/// <returns></returns>
		public static HtmlElement fa(string cssClass) => new HtmlElement("i", "").WithAttributes(a => a.@class(cssClass));

		public static HtmlElement<LinkAttributesContainer> linkCss(Uri href) => linkCss(href.AbsolutePath);
		public static HtmlElement<LinkAttributesContainer> linkCss(string href) => new HtmlElement<LinkAttributesContainer>("link")
			.WithAttributes(a =>
				a.rel("stylesheet")
				.type("text/css")
				.href(href));

		public static HtmlElement<ScriptAttributesContainer> script(Uri src) => script(src.AbsolutePath);
		public static HtmlElement<ScriptAttributesContainer> script(string src) => new HtmlElement<ScriptAttributesContainer>("script", string.Empty).WithAttributes(a => a.src(src));



		public static HtmlElement table(params object[] contents) => new HtmlElement("table", contents);

		public static HtmlElement thead(params object[] contents) => new HtmlElement("thead", contents);

		public static HtmlElement tbody(params object[] contents) => new HtmlElement("tbody", contents);
		public static HtmlElement tbody(IEnumerable<object> contents) => new HtmlElement("tbody", contents);

		public static HtmlElement tr(params object[] contents) => new HtmlElement("tr", contents);

		public static HtmlElement<ThAttributesContainer> th(params object[] contents) => new HtmlElement<ThAttributesContainer>("th", contents);

		public static HtmlElement<TdAttributesContainer> td(params object[] contents) => new HtmlElement<TdAttributesContainer>("td", contents);

		public static HtmlElement span(params object[] contents) => new HtmlElement("span", contents);

		public static HtmlElement i(params object[] contents) => new HtmlElement("i", contents);

		public static HtmlElement<AnchorAttributesContainer> a(params object[] contents) => new HtmlElement<AnchorAttributesContainer>("a", contents);
	}
}
