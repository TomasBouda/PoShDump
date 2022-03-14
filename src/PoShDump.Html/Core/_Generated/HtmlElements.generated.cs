using PoShDump.Html.Core.Elements;
using System.Collections.Generic;
using PoShDump.Html.Core.Attributes;
using System;
// ReSharper disable All

namespace PoShDump.Html.Core.Elements
{

	/// <summary>
	/// The &lt;a&gt; tag defines a hyperlink, which is used to link from one page to another.
	/// </summary>
	public class a : HtmlElement<aAttr>
	{
		public a(params object[] contents) : base("a", contents) { }

		public a(IEnumerable<object> contents) : base("a", contents) { }
	}


	/// <summary>
	/// The &lt;abbr&gt; tag defines an abbreviation or an acronym, like &quot;HTML&quot;, 
	/// &quot;CSS&quot;, "Mr.&quot;, 
	/// &quot;Dr.&quot;, &quot;ASAP&quot;, &quot;ATM&quot;.
	/// </summary>
	public class abbr : HtmlElement<HtmlAttribute>
	{
		public abbr(params object[] contents) : base("abbr", contents) { }

		public abbr(IEnumerable<object> contents) : base("abbr", contents) { }
	}


	/// <summary>
	/// The &lt;acronym&gt; tag was used in HTML 4 to define an acronym.
	/// </summary>
	[Obsolete("Deprecated")]
	public class acronym : HtmlElement<HtmlAttribute>
	{
		public acronym(params object[] contents) : base("acronym", contents) { }

		public acronym(IEnumerable<object> contents) : base("acronym", contents) { }
	}


	/// <summary>
	/// The contact information can be an email address, URL, physical address, phone 
	/// number, social media handle, etc.
	/// </summary>
	public class address : HtmlElement<HtmlAttribute>
	{
		public address(params object[] contents) : base("address", contents) { }

		public address(IEnumerable<object> contents) : base("address", contents) { }
	}


	/// <summary>
	/// The &lt;applet&gt; tag was used in HTML 4 to define an embedded applet (Plug-in).
	/// </summary>
	[Obsolete("Deprecated")]
	public class applet : HtmlElement<HtmlAttribute>
	{
		public applet(params object[] contents) : base("applet", contents) { }

		public applet(IEnumerable<object> contents) : base("applet", contents) { }
	}


	/// <summary>
	/// The &lt;area&gt; tag defines an area inside an image map (an image map is an image with clickable areas).
	/// </summary>
	public class area : HtmlElement<areaAttr>
	{
		public area(params object[] contents) : base("area", contents) { }

		public area(IEnumerable<object> contents) : base("area", contents) { }
	}


	/// <summary>
	/// The &lt;article&gt; tag specifies independent, self-contained content.
	/// </summary>
	public class article : HtmlElement<HtmlAttribute>
	{
		public article(params object[] contents) : base("article", contents) { }

		public article(IEnumerable<object> contents) : base("article", contents) { }
	}


	/// <summary>
	/// The &lt;aside&gt; tag defines some content aside from the content it is placed in.
	/// </summary>
	public class aside : HtmlElement<HtmlAttribute>
	{
		public aside(params object[] contents) : base("aside", contents) { }

		public aside(IEnumerable<object> contents) : base("aside", contents) { }
	}


	/// <summary>
	/// The &lt;audio&gt; tag contains one or more
	/// &lt;source&gt; tags 
	/// with different audio sources. The browser will choose the first source it 
	/// supports.
	/// </summary>
	public class audio : HtmlElement<audioAttr>
	{
		public audio(params object[] contents) : base("audio", contents) { }

		public audio(IEnumerable<object> contents) : base("audio", contents) { }
	}


	/// <summary>
	/// The &lt;b&gt; tag specifies bold text without any extra importance.
	/// </summary>
	public class b : HtmlElement<HtmlAttribute>
	{
		public b(params object[] contents) : base("b", contents) { }

		public b(IEnumerable<object> contents) : base("b", contents) { }
	}


	/// <summary>
	/// The &lt;base&gt; tag must have either an 
	/// href or a target attribute present, or both.
	/// </summary>
	public class @base : HtmlElement<@baseAttr>
	{
		public @base(params object[] contents) : base("base", contents) { }

		public @base(IEnumerable<object> contents) : base("base", contents) { }
	}


	/// <summary>
	/// The &lt;basefont&gt; tag was used in HTML 4 to specify a default text-color,
	/// font-size or font-family for all the text in an HTML document.
	/// </summary>
	[Obsolete("Deprecated")]
	public class basefont : HtmlElement<HtmlAttribute>
	{
		public basefont(params object[] contents) : base("basefont", contents) { }

		public basefont(IEnumerable<object> contents) : base("basefont", contents) { }
	}


	/// <summary>
	/// The &lt;bdi&gt; tag isolates a part of text that might be formatted in a different direction from other text outside it.
	/// </summary>
	public class bdi : HtmlElement<HtmlAttribute>
	{
		public bdi(params object[] contents) : base("bdi", contents) { }

		public bdi(IEnumerable<object> contents) : base("bdi", contents) { }
	}


	/// <summary>
	/// The &lt;bdo&gt; tag is used to override the current text direction.
	/// </summary>
	public class bdo : HtmlElement<bdoAttr>
	{
		public bdo(params object[] contents) : base("bdo", contents) { }

		public bdo(IEnumerable<object> contents) : base("bdo", contents) { }
	}


	/// <summary>
	/// The &lt;big&gt; tag was used in HTML 4 to define bigger text.
	/// </summary>
	[Obsolete("Deprecated")]
	public class big : HtmlElement<HtmlAttribute>
	{
		public big(params object[] contents) : base("big", contents) { }

		public big(IEnumerable<object> contents) : base("big", contents) { }
	}


	/// <summary>
	/// The &lt;blockquote&gt; tag specifies a section that is quoted from another source.
	/// </summary>
	public class blockquote : HtmlElement<blockquoteAttr>
	{
		public blockquote(params object[] contents) : base("blockquote", contents) { }

		public blockquote(IEnumerable<object> contents) : base("blockquote", contents) { }
	}


	/// <summary>
	/// The &lt;body&gt; tag defines the document's body.
	/// </summary>
	public class body : HtmlElement<HtmlAttribute>
	{
		public body(params object[] contents) : base("body", contents) { }

		public body(IEnumerable<object> contents) : base("body", contents) { }
	}


	/// <summary>
	/// The &lt;br&gt; tag inserts a single line break.
	/// </summary>
	public class br : HtmlElement<HtmlAttribute>
	{
		public br(params object[] contents) : base("br", contents) { }

		public br(IEnumerable<object> contents) : base("br", contents) { }
	}


	/// <summary>
	/// The &lt;button&gt; tag defines a clickable button.
	/// </summary>
	public class button : HtmlElement<buttonAttr>
	{
		public button(params object[] contents) : base("button", contents) { }

		public button(IEnumerable<object> contents) : base("button", contents) { }
	}


	/// <summary>
	/// The &lt;canvas&gt; tag is used to draw graphics, on the fly, via scripting (usually JavaScript).
	/// </summary>
	public class canvas : HtmlElement<canvasAttr>
	{
		public canvas(params object[] contents) : base("canvas", contents) { }

		public canvas(IEnumerable<object> contents) : base("canvas", contents) { }
	}


	/// <summary>
	/// The &lt;caption&gt; tag defines a table caption.
	/// </summary>
	public class caption : HtmlElement<HtmlAttribute>
	{
		public caption(params object[] contents) : base("caption", contents) { }

		public caption(IEnumerable<object> contents) : base("caption", contents) { }
	}


	/// <summary>
	/// The &lt;center&gt; tag was used in HTML4 to center-align text.
	/// </summary>
	[Obsolete("Deprecated")]
	public class center : HtmlElement<HtmlAttribute>
	{
		public center(params object[] contents) : base("center", contents) { }

		public center(IEnumerable<object> contents) : base("center", contents) { }
	}


	/// <summary>
	/// Note: A person's name is not the title of a work.
	/// </summary>
	public class cite : HtmlElement<HtmlAttribute>
	{
		public cite(params object[] contents) : base("cite", contents) { }

		public cite(IEnumerable<object> contents) : base("cite", contents) { }
	}


	/// <summary>
	/// The &lt;code&gt; tag is used to define a piece of computer code. 
	/// The content inside is displayed in the browser's default monospace font. 
	/// </summary>
	public class code : HtmlElement<HtmlAttribute>
	{
		public code(params object[] contents) : base("code", contents) { }

		public code(IEnumerable<object> contents) : base("code", contents) { }
	}


	/// <summary>
	/// The &lt;col&gt; tag specifies column properties for each column within a 
	/// &lt;colgroup&gt; element.
	/// </summary>
	public class col : HtmlElement<colAttr>
	{
		public col(params object[] contents) : base("col", contents) { }

		public col(IEnumerable<object> contents) : base("col", contents) { }
	}


	/// <summary>
	/// The &lt;colgroup&gt; tag specifies a group of one or more columns in a table for formatting.
	/// </summary>
	public class colgroup : HtmlElement<colgroupAttr>
	{
		public colgroup(params object[] contents) : base("colgroup", contents) { }

		public colgroup(IEnumerable<object> contents) : base("colgroup", contents) { }
	}


	/// <summary>
	/// This element provides both a machine-readable value for data processors, and 
	/// a human-readable value for rendering in a browser.
	/// </summary>
	public class data : HtmlElement<dataAttr>
	{
		public data(params object[] contents) : base("data", contents) { }

		public data(IEnumerable<object> contents) : base("data", contents) { }
	}


	/// <summary>
	/// The &lt;datalist&gt; tag is used to provide an &quot;autocomplete&quot; feature 
	/// for &lt;input&gt; 
	/// elements. Users will see a drop-down list of pre-defined options as they input data.
	/// </summary>
	public class datalist : HtmlElement<HtmlAttribute>
	{
		public datalist(params object[] contents) : base("datalist", contents) { }

		public datalist(IEnumerable<object> contents) : base("datalist", contents) { }
	}


	/// <summary>
	/// The &lt;dd&gt; tag is used in conjunction with &lt;dl&gt; 
	/// (defines a description list) and &lt;dt&gt; (defines 
	/// terms/names).
	/// </summary>
	public class dd : HtmlElement<HtmlAttribute>
	{
		public dd(params object[] contents) : base("dd", contents) { }

		public dd(IEnumerable<object> contents) : base("dd", contents) { }
	}


	/// <summary>
	/// The &lt;del&gt; tag defines text that has been deleted from a document. 
	/// Browsers will usually strike a line through deleted text.
	/// </summary>
	public class del : HtmlElement<delAttr>
	{
		public del(params object[] contents) : base("del", contents) { }

		public del(IEnumerable<object> contents) : base("del", contents) { }
	}


	/// <summary>
	/// The &lt;details&gt; tag specifies additional details that the user can 
	/// open and close on demand.
	/// </summary>
	public class details : HtmlElement<detailsAttr>
	{
		public details(params object[] contents) : base("details", contents) { }

		public details(IEnumerable<object> contents) : base("details", contents) { }
	}


	/// <summary>
	/// The &lt;dfn&gt; tag stands for the 
	/// &quot;definition element&quot;, and it specifies a term that is going to be defined within 
	/// the content.
	/// </summary>
	public class dfn : HtmlElement<HtmlAttribute>
	{
		public dfn(params object[] contents) : base("dfn", contents) { }

		public dfn(IEnumerable<object> contents) : base("dfn", contents) { }
	}


	/// <summary>
	/// The &lt;dialog&gt; element makes it easy to create popup dialogs and modals on a web page.
	/// </summary>
	public class dialog : HtmlElement<dialogAttr>
	{
		public dialog(params object[] contents) : base("dialog", contents) { }

		public dialog(IEnumerable<object> contents) : base("dialog", contents) { }
	}


	/// <summary>
	/// The &lt;dir&gt; tag was used in HTML 4 to list directory titles.
	/// </summary>
	[Obsolete("Deprecated")]
	public class dir : HtmlElement<HtmlAttribute>
	{
		public dir(params object[] contents) : base("dir", contents) { }

		public dir(IEnumerable<object> contents) : base("dir", contents) { }
	}


	/// <summary>
	/// The &lt;div&gt; tag defines a division or a section in an HTML document.
	/// </summary>
	public class div : HtmlElement<HtmlAttribute>
	{
		public div(params object[] contents) : base("div", contents) { }

		public div(IEnumerable<object> contents) : base("div", contents) { }
	}


	/// <summary>
	/// The &lt;dl&gt; tag is used in conjunction with &lt;dt&gt; (defines 
	/// terms/names) and 
	/// &lt;dd&gt; (describes each term/name).
	/// </summary>
	public class dl : HtmlElement<HtmlAttribute>
	{
		public dl(params object[] contents) : base("dl", contents) { }

		public dl(IEnumerable<object> contents) : base("dl", contents) { }
	}


	/// <summary>
	/// The &lt;dt&gt; tag is used in conjunction with &lt;dl&gt; (defines 
	/// a description list) and 
	/// &lt;dd&gt; (describes each term/name).
	/// </summary>
	public class dt : HtmlElement<HtmlAttribute>
	{
		public dt(params object[] contents) : base("dt", contents) { }

		public dt(IEnumerable<object> contents) : base("dt", contents) { }
	}


	/// <summary>
	/// A screen reader will pronounce the words in &lt;em&gt; 
	/// with an emphasis, using verbal stress.
	/// </summary>
	public class em : HtmlElement<HtmlAttribute>
	{
		public em(params object[] contents) : base("em", contents) { }

		public em(IEnumerable<object> contents) : base("em", contents) { }
	}


	/// <summary>
	/// The &lt;embed&gt; tag also supports the Global Attributes in HTML.
	/// </summary>
	public class embed : HtmlElement<embedAttr>
	{
		public embed(params object[] contents) : base("embed", contents) { }

		public embed(IEnumerable<object> contents) : base("embed", contents) { }
	}


	/// <summary>
	/// The &lt;fieldset&gt; tag is used to group related elements in a form.
	/// </summary>
	public class fieldset : HtmlElement<fieldsetAttr>
	{
		public fieldset(params object[] contents) : base("fieldset", contents) { }

		public fieldset(IEnumerable<object> contents) : base("fieldset", contents) { }
	}


	/// <summary>
	/// The &lt;figcaption&gt; tag defines a caption for a &lt;figure&gt; element.
	/// </summary>
	public class figcaption : HtmlElement<HtmlAttribute>
	{
		public figcaption(params object[] contents) : base("figcaption", contents) { }

		public figcaption(IEnumerable<object> contents) : base("figcaption", contents) { }
	}


	/// <summary>
	/// The &lt;figure&gt; tag specifies self-contained content, like illustrations, diagrams, photos, code listings, etc.
	/// </summary>
	public class figure : HtmlElement<HtmlAttribute>
	{
		public figure(params object[] contents) : base("figure", contents) { }

		public figure(IEnumerable<object> contents) : base("figure", contents) { }
	}


	/// <summary>
	/// The &lt;font&gt; tag was used in HTML 4 to specify the font face, font size, and color of text.
	/// </summary>
	[Obsolete("Deprecated")]
	public class font : HtmlElement<HtmlAttribute>
	{
		public font(params object[] contents) : base("font", contents) { }

		public font(IEnumerable<object> contents) : base("font", contents) { }
	}


	/// <summary>
	/// The &lt;footer&gt; tag defines a footer for a document or section.
	/// </summary>
	public class footer : HtmlElement<HtmlAttribute>
	{
		public footer(params object[] contents) : base("footer", contents) { }

		public footer(IEnumerable<object> contents) : base("footer", contents) { }
	}


	/// <summary>
	/// The &lt;form&gt; tag is used to create an HTML form for user input.
	/// </summary>
	public class form : HtmlElement<formAttr>
	{
		public form(params object[] contents) : base("form", contents) { }

		public form(IEnumerable<object> contents) : base("form", contents) { }
	}


	/// <summary>
	/// The &lt;frame&gt; tag was used in HTML 4 to define one particular window (frame) within a &lt;frameset&gt;.
	/// </summary>
	[Obsolete("Deprecated")]
	public class frame : HtmlElement<HtmlAttribute>
	{
		public frame(params object[] contents) : base("frame", contents) { }

		public frame(IEnumerable<object> contents) : base("frame", contents) { }
	}


	/// <summary>
	/// The &lt;frameset&gt; tag was used in HTML 4 to define a frameset.
	/// </summary>
	[Obsolete("Deprecated")]
	public class frameset : HtmlElement<HtmlAttribute>
	{
		public frameset(params object[] contents) : base("frameset", contents) { }

		public frameset(IEnumerable<object> contents) : base("frameset", contents) { }
	}


	/// <summary>
	/// The &lt;head&gt; element is a container for 
	/// metadata (data about data) and is placed between the &lt;html&gt; tag and the &lt;body&gt; 
	/// tag.
	/// </summary>
	public class head : HtmlElement<HtmlAttribute>
	{
		public head(params object[] contents) : base("head", contents) { }

		public head(IEnumerable<object> contents) : base("head", contents) { }
	}


	/// <summary>
	/// The &lt;header&gt; element represents a container for introductory content or 
	/// a set of navigational links.
	/// </summary>
	public class header : HtmlElement<HtmlAttribute>
	{
		public header(params object[] contents) : base("header", contents) { }

		public header(IEnumerable<object> contents) : base("header", contents) { }
	}


	/// <summary>
	/// The &lt;h1&gt; to &lt;h6&gt; tags are used to define HTML headings.
	/// </summary>
	public class hn : HtmlElement<HtmlAttribute>
	{
		public hn(params object[] contents) : base("hn", contents) { }

		public hn(IEnumerable<object> contents) : base("hn", contents) { }
	}


	/// <summary>
	/// The &lt;hr&gt; tag defines a thematic break in an HTML page (e.g. a shift of topic).
	/// </summary>
	public class hr : HtmlElement<HtmlAttribute>
	{
		public hr(params object[] contents) : base("hr", contents) { }

		public hr(IEnumerable<object> contents) : base("hr", contents) { }
	}


	/// <summary>
	/// The &lt;html&gt; tag is the container for all other HTML elements (except for the
	/// &lt;!DOCTYPE&gt; tag).
	/// </summary>
	public class html : HtmlElement<htmlAttr>
	{
		public html(params object[] contents) : base("html", contents) { }

		public html(IEnumerable<object> contents) : base("html", contents) { }
	}


	/// <summary>
	/// The &lt;i&gt; tag is often used to indicate a technical term, a phrase from another 
	/// language, a thought, a ship name, etc.
	/// </summary>
	public class i : HtmlElement<HtmlAttribute>
	{
		public i(params object[] contents) : base("i", contents) { }

		public i(IEnumerable<object> contents) : base("i", contents) { }
	}


	/// <summary>
	/// The &lt;iframe&gt; tag specifies an inline frame.
	/// </summary>
	public class iframe : HtmlElement<iframeAttr>
	{
		public iframe(params object[] contents) : base("iframe", contents) { }

		public iframe(IEnumerable<object> contents) : base("iframe", contents) { }
	}


	/// <summary>
	/// The &lt;img&gt; tag is used to embed an image in an HTML page.
	/// </summary>
	public class img : HtmlElement<imgAttr>
	{
		public img(params object[] contents) : base("img", contents) { }

		public img(IEnumerable<object> contents) : base("img", contents) { }
	}


	/// <summary>
	///  The &lt;input&gt; element is the most 
	/// important form element.
	/// </summary>
	public class input : HtmlElement<inputAttr>
	{
		public input(params object[] contents) : base("input", contents) { }

		public input(IEnumerable<object> contents) : base("input", contents) { }
	}


	/// <summary>
	/// Tip: Also look at the &lt;del&gt; tag to markup deleted text.
	/// </summary>
	public class ins : HtmlElement<insAttr>
	{
		public ins(params object[] contents) : base("ins", contents) { }

		public ins(IEnumerable<object> contents) : base("ins", contents) { }
	}


	/// <summary>
	/// The &lt;kbd&gt; tag is used to define keyboard input. 
	/// The content inside is displayed in the browser's default monospace font.
	/// </summary>
	public class kbd : HtmlElement<HtmlAttribute>
	{
		public kbd(params object[] contents) : base("kbd", contents) { }

		public kbd(IEnumerable<object> contents) : base("kbd", contents) { }
	}


	/// <summary>
	/// Proper use of labels with the elements above will benefit:
	/// </summary>
	public class label : HtmlElement<labelAttr>
	{
		public label(params object[] contents) : base("label", contents) { }

		public label(IEnumerable<object> contents) : base("label", contents) { }
	}


	/// <summary>
	/// The &lt;legend&gt; tag defines a caption for the &lt;fieldset&gt; element.
	/// </summary>
	public class legend : HtmlElement<HtmlAttribute>
	{
		public legend(params object[] contents) : base("legend", contents) { }

		public legend(IEnumerable<object> contents) : base("legend", contents) { }
	}


	/// <summary>
	/// The &lt;li&gt; tag defines a list item.
	/// </summary>
	public class li : HtmlElement<liAttr>
	{
		public li(params object[] contents) : base("li", contents) { }

		public li(IEnumerable<object> contents) : base("li", contents) { }
	}


	/// <summary>
	/// The &lt;link&gt; tag is most often used to link to external style sheets 
	/// or to add a favicon to your website.
	/// </summary>
	public class link : HtmlElement<linkAttr>
	{
		public link(params object[] contents) : base("link", contents) { }

		public link(IEnumerable<object> contents) : base("link", contents) { }
	}


	/// <summary>
	/// The &lt;main&gt; tag specifies the main content of a document.
	/// </summary>
	public class main : HtmlElement<HtmlAttribute>
	{
		public main(params object[] contents) : base("main", contents) { }

		public main(IEnumerable<object> contents) : base("main", contents) { }
	}


	/// <summary>
	/// The &lt;map&gt; tag is used to define an image map. An image map is an image with clickable areas.
	/// </summary>
	public class map : HtmlElement<mapAttr>
	{
		public map(params object[] contents) : base("map", contents) { }

		public map(IEnumerable<object> contents) : base("map", contents) { }
	}


	/// <summary>
	/// The numbers in the table specify the first browser version that fully supports the element.
	/// </summary>
	public class mark : HtmlElement<HtmlAttribute>
	{
		public mark(params object[] contents) : base("mark", contents) { }

		public mark(IEnumerable<object> contents) : base("mark", contents) { }
	}


	/// <summary>
	/// The &lt;meta&gt; tag defines metadata about an 
	/// HTML document. Metadata is data (information) about data.
	/// </summary>
	public class meta : HtmlElement<metaAttr>
	{
		public meta(params object[] contents) : base("meta", contents) { }

		public meta(IEnumerable<object> contents) : base("meta", contents) { }
	}


	/// <summary>
	/// Examples: Disk usage, the relevance of a query result, etc.
	/// </summary>
	public class meter : HtmlElement<meterAttr>
	{
		public meter(params object[] contents) : base("meter", contents) { }

		public meter(IEnumerable<object> contents) : base("meter", contents) { }
	}


	/// <summary>
	/// Notice that NOT all links of a document should be inside a &lt;nav&gt; element. The &lt;nav&gt; element is 
	/// intended only for major block of navigation links.
	/// </summary>
	public class nav : HtmlElement<HtmlAttribute>
	{
		public nav(params object[] contents) : base("nav", contents) { }

		public nav(IEnumerable<object> contents) : base("nav", contents) { }
	}


	/// <summary>
	/// The &lt;noframes&gt; tag was used in HTML 4 to act as a fallback tag for browsers that did not support frames.
	/// </summary>
	[Obsolete("Deprecated")]
	public class noframes : HtmlElement<HtmlAttribute>
	{
		public noframes(params object[] contents) : base("noframes", contents) { }

		public noframes(IEnumerable<object> contents) : base("noframes", contents) { }
	}


	/// <summary>
	/// The &lt;noscript&gt; element can be used in both &lt;head&gt; and &lt;body&gt;. When used inside &lt;head&gt;, 
	/// the &lt;noscript&gt; element could only contain &lt;link&gt;, 
	/// &lt;style&gt;, and &lt;meta&gt; elements.
	/// </summary>
	public class noscript : HtmlElement<HtmlAttribute>
	{
		public noscript(params object[] contents) : base("noscript", contents) { }

		public noscript(IEnumerable<object> contents) : base("noscript", contents) { }
	}


	/// <summary>
	/// The external resource can be a web page, a picture, a media player, or a plug-in application.
	/// </summary>
	public class @object : HtmlElement<@objectAttr>
	{
		public @object(params object[] contents) : base("object", contents) { }

		public @object(IEnumerable<object> contents) : base("object", contents) { }
	}


	/// <summary>
	/// The &lt;ol&gt; tag defines an ordered list. An ordered list can be numerical or alphabetical.
	/// </summary>
	public class ol : HtmlElement<olAttr>
	{
		public ol(params object[] contents) : base("ol", contents) { }

		public ol(IEnumerable<object> contents) : base("ol", contents) { }
	}


	/// <summary>
	/// If you have a long list of options, groups of related options are easier to handle for a user.
	/// </summary>
	public class optgroup : HtmlElement<optgroupAttr>
	{
		public optgroup(params object[] contents) : base("optgroup", contents) { }

		public optgroup(IEnumerable<object> contents) : base("optgroup", contents) { }
	}


	/// <summary>
	/// The &lt;option&gt; tag defines an option in a 
	/// select list.
	/// </summary>
	public class option : HtmlElement<optionAttr>
	{
		public option(params object[] contents) : base("option", contents) { }

		public option(IEnumerable<object> contents) : base("option", contents) { }
	}


	/// <summary>
	/// The numbers in the table specify the first browser version that fully supports the element.
	/// </summary>
	public class output : HtmlElement<outputAttr>
	{
		public output(params object[] contents) : base("output", contents) { }

		public output(IEnumerable<object> contents) : base("output", contents) { }
	}


	/// <summary>
	/// The &lt;p&gt; tag defines a paragraph.
	/// </summary>
	public class p : HtmlElement<HtmlAttribute>
	{
		public p(params object[] contents) : base("p", contents) { }

		public p(IEnumerable<object> contents) : base("p", contents) { }
	}


	/// <summary>
	/// The &lt;param&gt; tag is supported in all major browsers. However, the file format 
	/// defined in &lt;object&gt; may not be supported in all browsers.
	/// </summary>
	public class param : HtmlElement<paramAttr>
	{
		public param(params object[] contents) : base("param", contents) { }

		public param(IEnumerable<object> contents) : base("param", contents) { }
	}


	/// <summary>
	/// The most common use of the &lt;picture&gt; element will be for art direction in 
	/// responsive designs. Instead of having one image that is scaled up or down based 
	/// on the viewport width, multiple images can be designed to more nicely fill the 
	/// browser viewport.
	/// </summary>
	public class picture : HtmlElement<HtmlAttribute>
	{
		public picture(params object[] contents) : base("picture", contents) { }

		public picture(IEnumerable<object> contents) : base("picture", contents) { }
	}


	/// <summary>
	/// The &lt;pre&gt; tag defines preformatted text.
	/// </summary>
	public class pre : HtmlElement<HtmlAttribute>
	{
		public pre(params object[] contents) : base("pre", contents) { }

		public pre(IEnumerable<object> contents) : base("pre", contents) { }
	}


	/// <summary>
	/// Tip: Always add the &lt;label&gt; tag 
	/// for best accessibility practices!
	/// </summary>
	public class progress : HtmlElement<progressAttr>
	{
		public progress(params object[] contents) : base("progress", contents) { }

		public progress(IEnumerable<object> contents) : base("progress", contents) { }
	}


	/// <summary>
	/// The &lt;q&gt; tag defines a short quotation.
	/// </summary>
	public class q : HtmlElement<qAttr>
	{
		public q(params object[] contents) : base("q", contents) { }

		public q(IEnumerable<object> contents) : base("q", contents) { }
	}


	/// <summary>
	/// Use &lt;rp&gt; together with 
	/// &lt;ruby&gt; and &lt;rt&gt;: The &lt;ruby&gt; element consists of one or more characters that needs an 
	/// explanation/pronunciation, and an &lt;rt&gt; element that gives that information, and 
	/// an optional &lt;rp&gt; element that defines what to show for browsers that not support ruby annotations.
	/// </summary>
	public class rp : HtmlElement<HtmlAttribute>
	{
		public rp(params object[] contents) : base("rp", contents) { }

		public rp(IEnumerable<object> contents) : base("rp", contents) { }
	}


	/// <summary>
	/// Use &lt;rt&gt; together with 
	/// &lt;ruby&gt; and &lt;rp&gt;: The &lt;ruby&gt; element consists of one or more characters that needs an 
	/// explanation/pronunciation, and an &lt;rt&gt; element that gives that information, and 
	/// an optional &lt;rp&gt; element that defines what to show for browsers that not support ruby annotations.
	/// </summary>
	public class rt : HtmlElement<HtmlAttribute>
	{
		public rt(params object[] contents) : base("rt", contents) { }

		public rt(IEnumerable<object> contents) : base("rt", contents) { }
	}


	/// <summary>
	/// A ruby annotation is a small extra text, attached to the main text to 
	/// indicate the pronunciation or meaning of the corresponding characters. This kind 
	/// of annotation is often used in Japanese publications.
	/// </summary>
	public class ruby : HtmlElement<HtmlAttribute>
	{
		public ruby(params object[] contents) : base("ruby", contents) { }

		public ruby(IEnumerable<object> contents) : base("ruby", contents) { }
	}


	/// <summary>
	/// The &lt;s&gt; tag should not be used to define deleted text 
	/// in a document, use the 
	/// &lt;del&gt; 
	/// tag for that.
	/// </summary>
	public class s : HtmlElement<HtmlAttribute>
	{
		public s(params object[] contents) : base("s", contents) { }

		public s(IEnumerable<object> contents) : base("s", contents) { }
	}


	/// <summary>
	/// Tip: This tag is not deprecated. However, 
	/// it is possible to achieve richer effect by using CSS.
	/// </summary>
	public class samp : HtmlElement<HtmlAttribute>
	{
		public samp(params object[] contents) : base("samp", contents) { }

		public samp(IEnumerable<object> contents) : base("samp", contents) { }
	}


	/// <summary>
	/// The &lt;script&gt; element either contains 
	/// scripting statements, or it points to an external script file through the src attribute.
	/// </summary>
	public class script : HtmlElement<scriptAttr>
	{
		public script(params object[] contents) : base("script", contents) { }

		public script(IEnumerable<object> contents) : base("script", contents) { }
	}


	/// <summary>
	/// The numbers in the table specify the first browser version that fully supports the element.
	/// </summary>
	public class section : HtmlElement<HtmlAttribute>
	{
		public section(params object[] contents) : base("section", contents) { }

		public section(IEnumerable<object> contents) : base("section", contents) { }
	}


	/// <summary>
	/// The &lt;select&gt; element is used to create a drop-down list.
	/// </summary>
	public class select : HtmlElement<selectAttr>
	{
		public select(params object[] contents) : base("select", contents) { }

		public select(IEnumerable<object> contents) : base("select", contents) { }
	}


	/// <summary>
	/// The &lt;small&gt; tag defines smaller text (like 
	/// copyright and other side-comments).
	/// </summary>
	public class small : HtmlElement<HtmlAttribute>
	{
		public small(params object[] contents) : base("small", contents) { }

		public small(IEnumerable<object> contents) : base("small", contents) { }
	}


	/// <summary>
	/// The &lt;source&gt; tag is used to specify multiple media resources for media elements, such as 
	/// &lt;video&gt;, &lt;audio&gt;, 
	/// and &lt;picture&gt;.
	/// </summary>
	public class source : HtmlElement<sourceAttr>
	{
		public source(params object[] contents) : base("source", contents) { }

		public source(IEnumerable<object> contents) : base("source", contents) { }
	}


	/// <summary>
	/// The &lt;span&gt; tag is easily styled by CSS or 
	/// manipulated with JavaScript 
	/// using the class or id attribute.
	/// </summary>
	public class span : HtmlElement<HtmlAttribute>
	{
		public span(params object[] contents) : base("span", contents) { }

		public span(IEnumerable<object> contents) : base("span", contents) { }
	}


	/// <summary>
	/// The &lt;strike&gt; tag was used in HTML 4 to define strikethrough text.
	/// </summary>
	[Obsolete("Deprecated")]
	public class strike : HtmlElement<HtmlAttribute>
	{
		public strike(params object[] contents) : base("strike", contents) { }

		public strike(IEnumerable<object> contents) : base("strike", contents) { }
	}


	/// <summary>
	/// Tip: Use the &lt;b&gt; tag to specify bold 
	/// text without any extra importance!
	/// </summary>
	public class strong : HtmlElement<HtmlAttribute>
	{
		public strong(params object[] contents) : base("strong", contents) { }

		public strong(IEnumerable<object> contents) : base("strong", contents) { }
	}


	/// <summary>
	/// The &lt;style&gt; tag is used to define style information 
	/// (CSS) for a document.
	/// </summary>
	public class style : HtmlElement<styleAttr>
	{
		public style(params object[] contents) : base("style", contents) { }

		public style(IEnumerable<object> contents) : base("style", contents) { }
	}


	/// <summary>
	/// Tip: Use the &lt;sup&gt; tag to define 
	/// superscripted text. 
	/// </summary>
	public class sub : HtmlElement<HtmlAttribute>
	{
		public sub(params object[] contents) : base("sub", contents) { }

		public sub(IEnumerable<object> contents) : base("sub", contents) { }
	}


	/// <summary>
	/// The &lt;summary&gt; tag defines a visible heading for the &lt;details&gt; element.
	/// The heading can be clicked to view/hide the details.
	/// </summary>
	public class summary : HtmlElement<HtmlAttribute>
	{
		public summary(params object[] contents) : base("summary", contents) { }

		public summary(IEnumerable<object> contents) : base("summary", contents) { }
	}


	/// <summary>
	/// Tip: Use the &lt;sub&gt; tag to define subscript text. 
	/// </summary>
	public class sup : HtmlElement<HtmlAttribute>
	{
		public sup(params object[] contents) : base("sup", contents) { }

		public sup(IEnumerable<object> contents) : base("sup", contents) { }
	}


	/// <summary>
	/// The &lt;svg&gt; tag defines a container for SVG graphics.
	/// </summary>
	public class svg : HtmlElement<HtmlAttribute>
	{
		public svg(params object[] contents) : base("svg", contents) { }

		public svg(IEnumerable<object> contents) : base("svg", contents) { }
	}


	/// <summary>
	/// The &lt;table&gt; tag defines an HTML table.
	/// </summary>
	public class table : HtmlElement<HtmlAttribute>
	{
		public table(params object[] contents) : base("table", contents) { }

		public table(IEnumerable<object> contents) : base("table", contents) { }
	}


	/// <summary>
	/// The &lt;tbody&gt; tag is used to group the body content in an HTML table.
	/// </summary>
	public class tbody : HtmlElement<HtmlAttribute>
	{
		public tbody(params object[] contents) : base("tbody", contents) { }

		public tbody(IEnumerable<object> contents) : base("tbody", contents) { }
	}


	/// <summary>
	/// The &lt;td&gt; tag defines a standard data cell in an HTML table.
	/// </summary>
	public class td : HtmlElement<tdAttr>
	{
		public td(params object[] contents) : base("td", contents) { }

		public td(IEnumerable<object> contents) : base("td", contents) { }
	}


	/// <summary>
	/// The &lt;template&gt; tag is used as a 
	/// container to hold some HTML content hidden from the user when the page loads.
	/// </summary>
	public class template : HtmlElement<HtmlAttribute>
	{
		public template(params object[] contents) : base("template", contents) { }

		public template(IEnumerable<object> contents) : base("template", contents) { }
	}


	/// <summary>
	/// The &lt;textarea&gt; tag defines a multi-line text input control.
	/// </summary>
	public class textarea : HtmlElement<textareaAttr>
	{
		public textarea(params object[] contents) : base("textarea", contents) { }

		public textarea(IEnumerable<object> contents) : base("textarea", contents) { }
	}


	/// <summary>
	/// The &lt;tfoot&gt; tag is used to group footer content in an HTML table.
	/// </summary>
	public class tfoot : HtmlElement<HtmlAttribute>
	{
		public tfoot(params object[] contents) : base("tfoot", contents) { }

		public tfoot(IEnumerable<object> contents) : base("tfoot", contents) { }
	}


	/// <summary>
	/// The &lt;th&gt; tag defines a header cell in an HTML table.
	/// </summary>
	public class th : HtmlElement<thAttr>
	{
		public th(params object[] contents) : base("th", contents) { }

		public th(IEnumerable<object> contents) : base("th", contents) { }
	}


	/// <summary>
	/// The &lt;thead&gt; tag is used to group header content in an HTML table.
	/// </summary>
	public class thead : HtmlElement<HtmlAttribute>
	{
		public thead(params object[] contents) : base("thead", contents) { }

		public thead(IEnumerable<object> contents) : base("thead", contents) { }
	}


	/// <summary>
	/// The datetime attribute of this element is used 
	/// translate the time into a 
	/// machine-readable format so that browsers can offer to add date reminders through 
	/// the user's calendar, and search engines can 
	/// produce smarter search results.
	/// </summary>
	public class time : HtmlElement<timeAttr>
	{
		public time(params object[] contents) : base("time", contents) { }

		public time(IEnumerable<object> contents) : base("time", contents) { }
	}


	/// <summary>
	/// The &lt;title&gt; tag is required in HTML 
	/// documents! 
	/// </summary>
	public class title : HtmlElement<HtmlAttribute>
	{
		public title(params object[] contents) : base("title", contents) { }

		public title(IEnumerable<object> contents) : base("title", contents) { }
	}


	/// <summary>
	/// The &lt;tr&gt; tag defines a row in an HTML table.
	/// </summary>
	public class tr : HtmlElement<HtmlAttribute>
	{
		public tr(params object[] contents) : base("tr", contents) { }

		public tr(IEnumerable<object> contents) : base("tr", contents) { }
	}


	/// <summary>
	/// This element is used to specify subtitles, caption files or other files containing 
	/// text, that should be visible when the media is playing.
	/// </summary>
	public class track : HtmlElement<trackAttr>
	{
		public track(params object[] contents) : base("track", contents) { }

		public track(IEnumerable<object> contents) : base("track", contents) { }
	}


	/// <summary>
	/// The &lt;tt&gt; tag was used in HTML 4 to define teletype text.
	/// </summary>
	[Obsolete("Deprecated")]
	public class tt : HtmlElement<HtmlAttribute>
	{
		public tt(params object[] contents) : base("tt", contents) { }

		public tt(IEnumerable<object> contents) : base("tt", contents) { }
	}


	/// <summary>
	/// The &lt;u&gt; tag represents some text that 
	/// is unarticulated and styled differently 
	/// from normal text, such as misspelled words or proper names in Chinese text. The 
	/// content inside is typically displayed with an underline. You can change this 
	/// with CSS (see example below).&nbsp;
	/// </summary>
	public class u : HtmlElement<HtmlAttribute>
	{
		public u(params object[] contents) : base("u", contents) { }

		public u(IEnumerable<object> contents) : base("u", contents) { }
	}


	/// <summary>
	/// The &lt;ul&gt; tag defines an unordered (bulleted) list.
	/// </summary>
	public class ul : HtmlElement<HtmlAttribute>
	{
		public ul(params object[] contents) : base("ul", contents) { }

		public ul(IEnumerable<object> contents) : base("ul", contents) { }
	}


	/// <summary>
	/// Tip: This tag is not deprecated. However, 
	/// it is possible to achieve richer effect by using CSS.
	/// </summary>
	public class _var : HtmlElement<HtmlAttribute>
	{
		public _var(params object[] contents) : base("var", contents) { }

		public _var(IEnumerable<object> contents) : base("var", contents) { }
	}


	/// <summary>
	/// The &lt;video&gt; tag contains one or more
	/// &lt;source&gt; tags 
	/// with different video sources. The browser will choose the first source it 
	/// supports.
	/// </summary>
	public class video : HtmlElement<videoAttr>
	{
		public video(params object[] contents) : base("video", contents) { }

		public video(IEnumerable<object> contents) : base("video", contents) { }
	}


	/// <summary>
	/// Tip: When a word is too long, the browser might break it at the wrong place. 
	/// You can use the &lt;wbr&gt; element to add word break opportunities.
	/// </summary>
	public class wbr : HtmlElement<HtmlAttribute>
	{
		public wbr(params object[] contents) : base("wbr", contents) { }

		public wbr(IEnumerable<object> contents) : base("wbr", contents) { }
	}


}
