using PoShDump.Html.Core.Elements;
using System.Collections.Generic;
using System;

namespace PoShDump.Html.Helpers
{
	public partial struct H
	{
		/// <summary>
		/// The &lt;a&gt; tag defines a hyperlink, which is used to link from one page to another.
		/// </summary>
		public static a a(params object[] contents) => new a(contents);

		/// <summary>
		/// The &lt;a&gt; tag defines a hyperlink, which is used to link from one page to another.
		/// </summary>
		public static a a(IEnumerable<object> contents) => new a(contents);

		/// <summary>
		/// The &lt;abbr&gt; tag defines an abbreviation or an acronym, like &quot;HTML&quot;, 
		/// &quot;CSS&quot;, "Mr.&quot;, 
		/// &quot;Dr.&quot;, &quot;ASAP&quot;, &quot;ATM&quot;.
		/// </summary>
		public static abbr abbr(params object[] contents) => new abbr(contents);

		/// <summary>
		/// The &lt;abbr&gt; tag defines an abbreviation or an acronym, like &quot;HTML&quot;, 
		/// &quot;CSS&quot;, "Mr.&quot;, 
		/// &quot;Dr.&quot;, &quot;ASAP&quot;, &quot;ATM&quot;.
		/// </summary>
		public static abbr abbr(IEnumerable<object> contents) => new abbr(contents);

		/// <summary>
		/// The &lt;acronym&gt; tag was used in HTML 4 to define an acronym.
		/// </summary>
		[Obsolete("Deprecated")]
		public static acronym acronym(params object[] contents) => new acronym(contents);

		/// <summary>
		/// The &lt;acronym&gt; tag was used in HTML 4 to define an acronym.
		/// </summary>
		[Obsolete("Deprecated")]
		public static acronym acronym(IEnumerable<object> contents) => new acronym(contents);

		/// <summary>
		/// The &lt;address&gt; tag defines the contact information for the author/owner of a document 
		/// or an article.
		/// </summary>
		public static address address(params object[] contents) => new address(contents);

		/// <summary>
		/// The &lt;address&gt; tag defines the contact information for the author/owner of a document 
		/// or an article.
		/// </summary>
		public static address address(IEnumerable<object> contents) => new address(contents);

		/// <summary>
		/// The &lt;applet&gt; tag was used in HTML 4 to define an embedded applet (Plug-in).
		/// </summary>
		[Obsolete("Deprecated")]
		public static applet applet(params object[] contents) => new applet(contents);

		/// <summary>
		/// The &lt;applet&gt; tag was used in HTML 4 to define an embedded applet (Plug-in).
		/// </summary>
		[Obsolete("Deprecated")]
		public static applet applet(IEnumerable<object> contents) => new applet(contents);

		/// <summary>
		/// The &lt;area&gt; tag defines an area inside an image map (an image map is an image with clickable areas).
		/// </summary>
		public static area area(params object[] contents) => new area(contents);

		/// <summary>
		/// The &lt;area&gt; tag defines an area inside an image map (an image map is an image with clickable areas).
		/// </summary>
		public static area area(IEnumerable<object> contents) => new area(contents);

		/// <summary>
		/// The &lt;article&gt; tag specifies independent, self-contained content.
		/// </summary>
		public static article article(params object[] contents) => new article(contents);

		/// <summary>
		/// The &lt;article&gt; tag specifies independent, self-contained content.
		/// </summary>
		public static article article(IEnumerable<object> contents) => new article(contents);

		/// <summary>
		/// The &lt;aside&gt; tag defines some content aside from the content it is placed in.
		/// </summary>
		public static aside aside(params object[] contents) => new aside(contents);

		/// <summary>
		/// The &lt;aside&gt; tag defines some content aside from the content it is placed in.
		/// </summary>
		public static aside aside(IEnumerable<object> contents) => new aside(contents);

		/// <summary>
		/// The &lt;audio&gt; tag is used to embed sound 
		/// content in a document, such as music or other audio streams.
		/// </summary>
		public static audio audio(params object[] contents) => new audio(contents);

		/// <summary>
		/// The &lt;audio&gt; tag is used to embed sound 
		/// content in a document, such as music or other audio streams.
		/// </summary>
		public static audio audio(IEnumerable<object> contents) => new audio(contents);

		/// <summary>
		/// The &lt;b&gt; tag specifies bold text without any extra importance.
		/// </summary>
		public static b b(params object[] contents) => new b(contents);

		/// <summary>
		/// The &lt;b&gt; tag specifies bold text without any extra importance.
		/// </summary>
		public static b b(IEnumerable<object> contents) => new b(contents);

		/// <summary>
		/// The &lt;base&gt; tag specifies the base URL 
		/// and/or target for all relative URLs in a document.
		/// </summary>
		public static @base @base(params object[] contents) => new @base(contents);

		/// <summary>
		/// The &lt;base&gt; tag specifies the base URL 
		/// and/or target for all relative URLs in a document.
		/// </summary>
		public static @base @base(IEnumerable<object> contents) => new @base(contents);

		/// <summary>
		/// The &lt;basefont&gt; tag was used in HTML 4 to specify a default text-color,
		/// font-size or font-family for all the text in an HTML document.
		/// </summary>
		[Obsolete("Deprecated")]
		public static basefont basefont(params object[] contents) => new basefont(contents);

		/// <summary>
		/// The &lt;basefont&gt; tag was used in HTML 4 to specify a default text-color,
		/// font-size or font-family for all the text in an HTML document.
		/// </summary>
		[Obsolete("Deprecated")]
		public static basefont basefont(IEnumerable<object> contents) => new basefont(contents);

		/// <summary>
		/// BDI stands for Bi-Directional Isolation.
		/// </summary>
		public static bdi bdi(params object[] contents) => new bdi(contents);

		/// <summary>
		/// BDI stands for Bi-Directional Isolation.
		/// </summary>
		public static bdi bdi(IEnumerable<object> contents) => new bdi(contents);

		/// <summary>
		/// BDO stands for Bi-Directional Override.
		/// </summary>
		public static bdo bdo(params object[] contents) => new bdo(contents);

		/// <summary>
		/// BDO stands for Bi-Directional Override.
		/// </summary>
		public static bdo bdo(IEnumerable<object> contents) => new bdo(contents);

		/// <summary>
		/// The &lt;big&gt; tag was used in HTML 4 to define bigger text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static big big(params object[] contents) => new big(contents);

		/// <summary>
		/// The &lt;big&gt; tag was used in HTML 4 to define bigger text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static big big(IEnumerable<object> contents) => new big(contents);

		/// <summary>
		/// The &lt;blockquote&gt; tag specifies a section that is quoted from another source.
		/// </summary>
		public static blockquote blockquote(params object[] contents) => new blockquote(contents);

		/// <summary>
		/// The &lt;blockquote&gt; tag specifies a section that is quoted from another source.
		/// </summary>
		public static blockquote blockquote(IEnumerable<object> contents) => new blockquote(contents);

		/// <summary>
		/// The &lt;body&gt; tag defines the document's body.
		/// </summary>
		public static body body(params object[] contents) => new body(contents);

		/// <summary>
		/// The &lt;body&gt; tag defines the document's body.
		/// </summary>
		public static body body(IEnumerable<object> contents) => new body(contents);

		/// <summary>
		/// The &lt;br&gt; tag inserts a single line break.
		/// </summary>
		public static br br(params object[] contents) => new br(contents);

		/// <summary>
		/// The &lt;br&gt; tag inserts a single line break.
		/// </summary>
		public static br br(IEnumerable<object> contents) => new br(contents);

		/// <summary>
		/// The &lt;button&gt; tag defines a clickable button.
		/// </summary>
		public static button button(params object[] contents) => new button(contents);

		/// <summary>
		/// The &lt;button&gt; tag defines a clickable button.
		/// </summary>
		public static button button(IEnumerable<object> contents) => new button(contents);

		/// <summary>
		/// The &lt;canvas&gt; tag is used to draw graphics, on the fly, via scripting (usually JavaScript).
		/// </summary>
		public static canvas canvas(params object[] contents) => new canvas(contents);

		/// <summary>
		/// The &lt;canvas&gt; tag is used to draw graphics, on the fly, via scripting (usually JavaScript).
		/// </summary>
		public static canvas canvas(IEnumerable<object> contents) => new canvas(contents);

		/// <summary>
		/// The &lt;caption&gt; tag defines a table caption.
		/// </summary>
		public static caption caption(params object[] contents) => new caption(contents);

		/// <summary>
		/// The &lt;caption&gt; tag defines a table caption.
		/// </summary>
		public static caption caption(IEnumerable<object> contents) => new caption(contents);

		/// <summary>
		/// The &lt;center&gt; tag was used in HTML4 to center-align text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static center center(params object[] contents) => new center(contents);

		/// <summary>
		/// The &lt;center&gt; tag was used in HTML4 to center-align text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static center center(IEnumerable<object> contents) => new center(contents);

		/// <summary>
		/// The &lt;cite&gt; tag defines the title of a 
		/// creative work (e.g. a book, a poem, a song, a movie, a painting, a sculpture, etc.).
		/// </summary>
		public static cite cite(params object[] contents) => new cite(contents);

		/// <summary>
		/// The &lt;cite&gt; tag defines the title of a 
		/// creative work (e.g. a book, a poem, a song, a movie, a painting, a sculpture, etc.).
		/// </summary>
		public static cite cite(IEnumerable<object> contents) => new cite(contents);

		/// <summary>
		/// The &lt;code&gt; tag is used to define a piece of computer code. 
		/// The content inside is displayed in the browser's default monospace font. 
		/// </summary>
		public static code code(params object[] contents) => new code(contents);

		/// <summary>
		/// The &lt;code&gt; tag is used to define a piece of computer code. 
		/// The content inside is displayed in the browser's default monospace font. 
		/// </summary>
		public static code code(IEnumerable<object> contents) => new code(contents);

		/// <summary>
		/// The &lt;col&gt; tag specifies column properties for each column within a 
		/// &lt;colgroup&gt; element.
		/// </summary>
		public static col col(params object[] contents) => new col(contents);

		/// <summary>
		/// The &lt;col&gt; tag specifies column properties for each column within a 
		/// &lt;colgroup&gt; element.
		/// </summary>
		public static col col(IEnumerable<object> contents) => new col(contents);

		/// <summary>
		/// The &lt;colgroup&gt; tag specifies a group of one or more columns in a table for formatting.
		/// </summary>
		public static colgroup colgroup(params object[] contents) => new colgroup(contents);

		/// <summary>
		/// The &lt;colgroup&gt; tag specifies a group of one or more columns in a table for formatting.
		/// </summary>
		public static colgroup colgroup(IEnumerable<object> contents) => new colgroup(contents);

		/// <summary>
		/// The &lt;data&gt; tag is used to add a machine-readable 
		/// translation of a given content.
		/// </summary>
		public static data data(params object[] contents) => new data(contents);

		/// <summary>
		/// The &lt;data&gt; tag is used to add a machine-readable 
		/// translation of a given content.
		/// </summary>
		public static data data(IEnumerable<object> contents) => new data(contents);

		/// <summary>
		/// The &lt;datalist&gt; tag specifies a list of pre-defined options for an &lt;input&gt; element.
		/// </summary>
		public static datalist datalist(params object[] contents) => new datalist(contents);

		/// <summary>
		/// The &lt;datalist&gt; tag specifies a list of pre-defined options for an &lt;input&gt; element.
		/// </summary>
		public static datalist datalist(IEnumerable<object> contents) => new datalist(contents);

		/// <summary>
		/// The &lt;dd&gt; tag is used to describe a term/name in a description list.
		/// </summary>
		public static dd dd(params object[] contents) => new dd(contents);

		/// <summary>
		/// The &lt;dd&gt; tag is used to describe a term/name in a description list.
		/// </summary>
		public static dd dd(IEnumerable<object> contents) => new dd(contents);

		/// <summary>
		/// The &lt;del&gt; tag defines text that has been deleted from a document. 
		/// Browsers will usually strike a line through deleted text.
		/// </summary>
		public static del del(params object[] contents) => new del(contents);

		/// <summary>
		/// The &lt;del&gt; tag defines text that has been deleted from a document. 
		/// Browsers will usually strike a line through deleted text.
		/// </summary>
		public static del del(IEnumerable<object> contents) => new del(contents);

		/// <summary>
		/// The &lt;details&gt; tag specifies additional details that the user can 
		/// open and close on demand.
		/// </summary>
		public static details details(params object[] contents) => new details(contents);

		/// <summary>
		/// The &lt;details&gt; tag specifies additional details that the user can 
		/// open and close on demand.
		/// </summary>
		public static details details(IEnumerable<object> contents) => new details(contents);

		/// <summary>
		/// The &lt;dfn&gt; tag stands for the 
		/// &quot;definition element&quot;, and it specifies a term that is going to be defined within 
		/// the content.
		/// </summary>
		public static dfn dfn(params object[] contents) => new dfn(contents);

		/// <summary>
		/// The &lt;dfn&gt; tag stands for the 
		/// &quot;definition element&quot;, and it specifies a term that is going to be defined within 
		/// the content.
		/// </summary>
		public static dfn dfn(IEnumerable<object> contents) => new dfn(contents);

		/// <summary>
		/// The &lt;dialog&gt; tag defines a dialog box or 
		/// subwindow.
		/// </summary>
		public static dialog dialog(params object[] contents) => new dialog(contents);

		/// <summary>
		/// The &lt;dialog&gt; tag defines a dialog box or 
		/// subwindow.
		/// </summary>
		public static dialog dialog(IEnumerable<object> contents) => new dialog(contents);

		/// <summary>
		/// The &lt;dir&gt; tag was used in HTML 4 to list directory titles.
		/// </summary>
		[Obsolete("Deprecated")]
		public static dir dir(params object[] contents) => new dir(contents);

		/// <summary>
		/// The &lt;dir&gt; tag was used in HTML 4 to list directory titles.
		/// </summary>
		[Obsolete("Deprecated")]
		public static dir dir(IEnumerable<object> contents) => new dir(contents);

		/// <summary>
		/// The &lt;div&gt; tag defines a division or a section in an HTML document.
		/// </summary>
		public static div div(params object[] contents) => new div(contents);

		/// <summary>
		/// The &lt;div&gt; tag defines a division or a section in an HTML document.
		/// </summary>
		public static div div(IEnumerable<object> contents) => new div(contents);

		/// <summary>
		/// The &lt;dl&gt; tag defines a description list.
		/// </summary>
		public static dl dl(params object[] contents) => new dl(contents);

		/// <summary>
		/// The &lt;dl&gt; tag defines a description list.
		/// </summary>
		public static dl dl(IEnumerable<object> contents) => new dl(contents);

		/// <summary>
		/// The &lt;dt&gt; tag defines a term/name in a description list.
		/// </summary>
		public static dt dt(params object[] contents) => new dt(contents);

		/// <summary>
		/// The &lt;dt&gt; tag defines a term/name in a description list.
		/// </summary>
		public static dt dt(IEnumerable<object> contents) => new dt(contents);

		/// <summary>
		/// The &lt;em&gt; tag is used to define emphasized text. 
		/// The content inside is typically displayed in italic.
		/// </summary>
		public static em em(params object[] contents) => new em(contents);

		/// <summary>
		/// The &lt;em&gt; tag is used to define emphasized text. 
		/// The content inside is typically displayed in italic.
		/// </summary>
		public static em em(IEnumerable<object> contents) => new em(contents);

		/// <summary>
		/// The &lt;embed&gt; tag defines a container for an external resource, 
		/// such as a web page, a picture, a media player, or a plug-in application.
		/// </summary>
		public static embed embed(params object[] contents) => new embed(contents);

		/// <summary>
		/// The &lt;embed&gt; tag defines a container for an external resource, 
		/// such as a web page, a picture, a media player, or a plug-in application.
		/// </summary>
		public static embed embed(IEnumerable<object> contents) => new embed(contents);

		/// <summary>
		/// The &lt;fieldset&gt; tag is used to group related elements in a form.
		/// </summary>
		public static fieldset fieldset(params object[] contents) => new fieldset(contents);

		/// <summary>
		/// The &lt;fieldset&gt; tag is used to group related elements in a form.
		/// </summary>
		public static fieldset fieldset(IEnumerable<object> contents) => new fieldset(contents);

		/// <summary>
		/// The &lt;figcaption&gt; tag defines a caption for a &lt;figure&gt; element.
		/// </summary>
		public static figcaption figcaption(params object[] contents) => new figcaption(contents);

		/// <summary>
		/// The &lt;figcaption&gt; tag defines a caption for a &lt;figure&gt; element.
		/// </summary>
		public static figcaption figcaption(IEnumerable<object> contents) => new figcaption(contents);

		/// <summary>
		/// The &lt;figure&gt; tag specifies self-contained content, like illustrations, diagrams, photos, code listings, etc.
		/// </summary>
		public static figure figure(params object[] contents) => new figure(contents);

		/// <summary>
		/// The &lt;figure&gt; tag specifies self-contained content, like illustrations, diagrams, photos, code listings, etc.
		/// </summary>
		public static figure figure(IEnumerable<object> contents) => new figure(contents);

		/// <summary>
		/// The &lt;font&gt; tag was used in HTML 4 to specify the font face, font size, and color of text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static font font(params object[] contents) => new font(contents);

		/// <summary>
		/// The &lt;font&gt; tag was used in HTML 4 to specify the font face, font size, and color of text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static font font(IEnumerable<object> contents) => new font(contents);

		/// <summary>
		/// The &lt;footer&gt; tag defines a footer for a document or section.
		/// </summary>
		public static footer footer(params object[] contents) => new footer(contents);

		/// <summary>
		/// The &lt;footer&gt; tag defines a footer for a document or section.
		/// </summary>
		public static footer footer(IEnumerable<object> contents) => new footer(contents);

		/// <summary>
		/// The &lt;form&gt; tag is used to create an HTML form for user input.
		/// </summary>
		public static form form(params object[] contents) => new form(contents);

		/// <summary>
		/// The &lt;form&gt; tag is used to create an HTML form for user input.
		/// </summary>
		public static form form(IEnumerable<object> contents) => new form(contents);

		/// <summary>
		/// The &lt;frame&gt; tag was used in HTML 4 to define one particular window (frame) within a &lt;frameset&gt;.
		/// </summary>
		[Obsolete("Deprecated")]
		public static frame frame(params object[] contents) => new frame(contents);

		/// <summary>
		/// The &lt;frame&gt; tag was used in HTML 4 to define one particular window (frame) within a &lt;frameset&gt;.
		/// </summary>
		[Obsolete("Deprecated")]
		public static frame frame(IEnumerable<object> contents) => new frame(contents);

		/// <summary>
		/// The &lt;frameset&gt; tag was used in HTML 4 to define a frameset.
		/// </summary>
		[Obsolete("Deprecated")]
		public static frameset frameset(params object[] contents) => new frameset(contents);

		/// <summary>
		/// The &lt;frameset&gt; tag was used in HTML 4 to define a frameset.
		/// </summary>
		[Obsolete("Deprecated")]
		public static frameset frameset(IEnumerable<object> contents) => new frameset(contents);

		/// <summary>
		/// The &lt;head&gt; element is a container for 
		/// metadata (data about data) and is placed between the &lt;html&gt; tag and the &lt;body&gt; 
		/// tag.
		/// </summary>
		public static head head(params object[] contents) => new head(contents);

		/// <summary>
		/// The &lt;head&gt; element is a container for 
		/// metadata (data about data) and is placed between the &lt;html&gt; tag and the &lt;body&gt; 
		/// tag.
		/// </summary>
		public static head head(IEnumerable<object> contents) => new head(contents);

		/// <summary>
		/// The &lt;header&gt; element represents a container for introductory content or 
		/// a set of navigational links.
		/// </summary>
		public static header header(params object[] contents) => new header(contents);

		/// <summary>
		/// The &lt;header&gt; element represents a container for introductory content or 
		/// a set of navigational links.
		/// </summary>
		public static header header(IEnumerable<object> contents) => new header(contents);

		/// <summary>
		/// The &lt;h1&gt; to &lt;h6&gt; tags are used to define HTML headings.
		/// </summary>
		public static hn hn(params object[] contents) => new hn(contents);

		/// <summary>
		/// The &lt;h1&gt; to &lt;h6&gt; tags are used to define HTML headings.
		/// </summary>
		public static hn hn(IEnumerable<object> contents) => new hn(contents);

		/// <summary>
		/// The &lt;hr&gt; tag defines a thematic break in an HTML page (e.g. a shift of topic).
		/// </summary>
		public static hr hr(params object[] contents) => new hr(contents);

		/// <summary>
		/// The &lt;hr&gt; tag defines a thematic break in an HTML page (e.g. a shift of topic).
		/// </summary>
		public static hr hr(IEnumerable<object> contents) => new hr(contents);

		/// <summary>
		/// The &lt;html&gt; tag represents the root of an HTML document.
		/// </summary>
		public static html html(params object[] contents) => new html(contents);

		/// <summary>
		/// The &lt;html&gt; tag represents the root of an HTML document.
		/// </summary>
		public static html html(IEnumerable<object> contents) => new html(contents);

		/// <summary>
		/// The &lt;i&gt; tag defines a part of text in an alternate voice or mood. 
		/// The content inside is typically displayed in italic.
		/// </summary>
		public static i i(params object[] contents) => new i(contents);

		/// <summary>
		/// The &lt;i&gt; tag defines a part of text in an alternate voice or mood. 
		/// The content inside is typically displayed in italic.
		/// </summary>
		public static i i(IEnumerable<object> contents) => new i(contents);

		/// <summary>
		/// The &lt;iframe&gt; tag specifies an inline frame.
		/// </summary>
		public static iframe iframe(params object[] contents) => new iframe(contents);

		/// <summary>
		/// The &lt;iframe&gt; tag specifies an inline frame.
		/// </summary>
		public static iframe iframe(IEnumerable<object> contents) => new iframe(contents);

		/// <summary>
		/// The &lt;img&gt; tag is used to embed an image in an HTML page.
		/// </summary>
		public static img img(params object[] contents) => new img(contents);

		/// <summary>
		/// The &lt;img&gt; tag is used to embed an image in an HTML page.
		/// </summary>
		public static img img(IEnumerable<object> contents) => new img(contents);

		/// <summary>
		/// The &lt;input&gt; tag specifies an input field where the user can enter data.
		/// </summary>
		public static input input(params object[] contents) => new input(contents);

		/// <summary>
		/// The &lt;input&gt; tag specifies an input field where the user can enter data.
		/// </summary>
		public static input input(IEnumerable<object> contents) => new input(contents);

		/// <summary>
		/// The &lt;ins&gt; tag defines a text that has been inserted into a document. Browsers will 
		/// usually underline inserted text.
		/// </summary>
		public static ins ins(params object[] contents) => new ins(contents);

		/// <summary>
		/// The &lt;ins&gt; tag defines a text that has been inserted into a document. Browsers will 
		/// usually underline inserted text.
		/// </summary>
		public static ins ins(IEnumerable<object> contents) => new ins(contents);

		/// <summary>
		/// The &lt;kbd&gt; tag is used to define keyboard input. 
		/// The content inside is displayed in the browser's default monospace font.
		/// </summary>
		public static kbd kbd(params object[] contents) => new kbd(contents);

		/// <summary>
		/// The &lt;kbd&gt; tag is used to define keyboard input. 
		/// The content inside is displayed in the browser's default monospace font.
		/// </summary>
		public static kbd kbd(IEnumerable<object> contents) => new kbd(contents);

		/// <summary>
		/// The &lt;label&gt; tag defines a label for several elements:
		/// </summary>
		public static label label(params object[] contents) => new label(contents);

		/// <summary>
		/// The &lt;label&gt; tag defines a label for several elements:
		/// </summary>
		public static label label(IEnumerable<object> contents) => new label(contents);

		/// <summary>
		/// The &lt;legend&gt; tag defines a caption for the &lt;fieldset&gt; element.
		/// </summary>
		public static legend legend(params object[] contents) => new legend(contents);

		/// <summary>
		/// The &lt;legend&gt; tag defines a caption for the &lt;fieldset&gt; element.
		/// </summary>
		public static legend legend(IEnumerable<object> contents) => new legend(contents);

		/// <summary>
		/// The &lt;li&gt; tag defines a list item.
		/// </summary>
		public static li li(params object[] contents) => new li(contents);

		/// <summary>
		/// The &lt;li&gt; tag defines a list item.
		/// </summary>
		public static li li(IEnumerable<object> contents) => new li(contents);

		/// <summary>
		/// The &lt;link&gt; tag defines the 
		/// relationship between the current document and an external 
		/// resource.
		/// </summary>
		public static link link(params object[] contents) => new link(contents);

		/// <summary>
		/// The &lt;link&gt; tag defines the 
		/// relationship between the current document and an external 
		/// resource.
		/// </summary>
		public static link link(IEnumerable<object> contents) => new link(contents);

		/// <summary>
		/// The &lt;main&gt; tag specifies the main content of a document.
		/// </summary>
		public static main main(params object[] contents) => new main(contents);

		/// <summary>
		/// The &lt;main&gt; tag specifies the main content of a document.
		/// </summary>
		public static main main(IEnumerable<object> contents) => new main(contents);

		/// <summary>
		/// The &lt;map&gt; tag is used to define an image map. An image map is an image with clickable areas.
		/// </summary>
		public static map map(params object[] contents) => new map(contents);

		/// <summary>
		/// The &lt;map&gt; tag is used to define an image map. An image map is an image with clickable areas.
		/// </summary>
		public static map map(IEnumerable<object> contents) => new map(contents);

		/// <summary>
		/// The &lt;mark&gt; tag defines text that 
		/// should be marked or highlighted.
		/// </summary>
		public static mark mark(params object[] contents) => new mark(contents);

		/// <summary>
		/// The &lt;mark&gt; tag defines text that 
		/// should be marked or highlighted.
		/// </summary>
		public static mark mark(IEnumerable<object> contents) => new mark(contents);

		/// <summary>
		/// The &lt;meta&gt; tag defines metadata about an 
		/// HTML document. Metadata is data (information) about data.
		/// </summary>
		public static meta meta(params object[] contents) => new meta(contents);

		/// <summary>
		/// The &lt;meta&gt; tag defines metadata about an 
		/// HTML document. Metadata is data (information) about data.
		/// </summary>
		public static meta meta(IEnumerable<object> contents) => new meta(contents);

		/// <summary>
		/// The &lt;meter&gt; tag defines a scalar measurement within a known range, or a fractional value. This is also known as a gauge.
		/// </summary>
		public static meter meter(params object[] contents) => new meter(contents);

		/// <summary>
		/// The &lt;meter&gt; tag defines a scalar measurement within a known range, or a fractional value. This is also known as a gauge.
		/// </summary>
		public static meter meter(IEnumerable<object> contents) => new meter(contents);

		/// <summary>
		/// The &lt;nav&gt; tag defines a set of navigation links.
		/// </summary>
		public static nav nav(params object[] contents) => new nav(contents);

		/// <summary>
		/// The &lt;nav&gt; tag defines a set of navigation links.
		/// </summary>
		public static nav nav(IEnumerable<object> contents) => new nav(contents);

		/// <summary>
		/// The &lt;noframes&gt; tag was used in HTML 4 to act as a fallback tag for browsers that did not support frames.
		/// </summary>
		[Obsolete("Deprecated")]
		public static noframes noframes(params object[] contents) => new noframes(contents);

		/// <summary>
		/// The &lt;noframes&gt; tag was used in HTML 4 to act as a fallback tag for browsers that did not support frames.
		/// </summary>
		[Obsolete("Deprecated")]
		public static noframes noframes(IEnumerable<object> contents) => new noframes(contents);

		/// <summary>
		/// The &lt;noscript&gt; tag defines an alternate content 
		/// to be displayed to users that have disabled scripts in their browser or have a browser that doesn't support script.
		/// </summary>
		public static noscript noscript(params object[] contents) => new noscript(contents);

		/// <summary>
		/// The &lt;noscript&gt; tag defines an alternate content 
		/// to be displayed to users that have disabled scripts in their browser or have a browser that doesn't support script.
		/// </summary>
		public static noscript noscript(IEnumerable<object> contents) => new noscript(contents);

		/// <summary>
		/// The &lt;object&gt; tag defines a container for an external resource.
		/// </summary>
		public static @object @object(params object[] contents) => new @object(contents);

		/// <summary>
		/// The &lt;object&gt; tag defines a container for an external resource.
		/// </summary>
		public static @object @object(IEnumerable<object> contents) => new @object(contents);

		/// <summary>
		/// The &lt;ol&gt; tag defines an ordered list. An ordered list can be numerical or alphabetical.
		/// </summary>
		public static ol ol(params object[] contents) => new ol(contents);

		/// <summary>
		/// The &lt;ol&gt; tag defines an ordered list. An ordered list can be numerical or alphabetical.
		/// </summary>
		public static ol ol(IEnumerable<object> contents) => new ol(contents);

		/// <summary>
		/// The &lt;optgroup&gt; tag is used to group related options 
		/// in a &lt;select&gt; element (drop-down list).
		/// </summary>
		public static optgroup optgroup(params object[] contents) => new optgroup(contents);

		/// <summary>
		/// The &lt;optgroup&gt; tag is used to group related options 
		/// in a &lt;select&gt; element (drop-down list).
		/// </summary>
		public static optgroup optgroup(IEnumerable<object> contents) => new optgroup(contents);

		/// <summary>
		/// The &lt;option&gt; tag defines an option in a 
		/// select list.
		/// </summary>
		public static option option(params object[] contents) => new option(contents);

		/// <summary>
		/// The &lt;option&gt; tag defines an option in a 
		/// select list.
		/// </summary>
		public static option option(IEnumerable<object> contents) => new option(contents);

		/// <summary>
		/// The &lt;output&gt; tag is used to represent the result of a calculation (like one performed by a script).
		/// </summary>
		public static output output(params object[] contents) => new output(contents);

		/// <summary>
		/// The &lt;output&gt; tag is used to represent the result of a calculation (like one performed by a script).
		/// </summary>
		public static output output(IEnumerable<object> contents) => new output(contents);

		/// <summary>
		/// The &lt;p&gt; tag defines a paragraph.
		/// </summary>
		public static p p(params object[] contents) => new p(contents);

		/// <summary>
		/// The &lt;p&gt; tag defines a paragraph.
		/// </summary>
		public static p p(IEnumerable<object> contents) => new p(contents);

		/// <summary>
		/// The &lt;param&gt; tag is used to define parameters for an
		/// &lt;object&gt; element.
		/// </summary>
		public static param param(params object[] contents) => new param(contents);

		/// <summary>
		/// The &lt;param&gt; tag is used to define parameters for an
		/// &lt;object&gt; element.
		/// </summary>
		public static param param(IEnumerable<object> contents) => new param(contents);

		/// <summary>
		/// The &lt;picture&gt; tag gives web developers more flexibility in specifying 
		/// image resources.
		/// </summary>
		public static picture picture(params object[] contents) => new picture(contents);

		/// <summary>
		/// The &lt;picture&gt; tag gives web developers more flexibility in specifying 
		/// image resources.
		/// </summary>
		public static picture picture(IEnumerable<object> contents) => new picture(contents);

		/// <summary>
		/// The &lt;pre&gt; tag defines preformatted text.
		/// </summary>
		public static pre pre(params object[] contents) => new pre(contents);

		/// <summary>
		/// The &lt;pre&gt; tag defines preformatted text.
		/// </summary>
		public static pre pre(IEnumerable<object> contents) => new pre(contents);

		/// <summary>
		/// The &lt;progress&gt; tag represents the 
		/// completion progress of a task.
		/// </summary>
		public static progress progress(params object[] contents) => new progress(contents);

		/// <summary>
		/// The &lt;progress&gt; tag represents the 
		/// completion progress of a task.
		/// </summary>
		public static progress progress(IEnumerable<object> contents) => new progress(contents);

		/// <summary>
		/// The &lt;q&gt; tag defines a short quotation.
		/// </summary>
		public static q q(params object[] contents) => new q(contents);

		/// <summary>
		/// The &lt;q&gt; tag defines a short quotation.
		/// </summary>
		public static q q(IEnumerable<object> contents) => new q(contents);

		/// <summary>
		/// The &lt;rp&gt; tag can be used to provide parentheses around a ruby text, to 
		/// be shown by browsers that do not support ruby annotations.
		/// </summary>
		public static rp rp(params object[] contents) => new rp(contents);

		/// <summary>
		/// The &lt;rp&gt; tag can be used to provide parentheses around a ruby text, to 
		/// be shown by browsers that do not support ruby annotations.
		/// </summary>
		public static rp rp(IEnumerable<object> contents) => new rp(contents);

		/// <summary>
		/// The &lt;rt&gt; tag defines an explanation or pronunciation of characters (for East Asian typography) in a ruby annotation.
		/// </summary>
		public static rt rt(params object[] contents) => new rt(contents);

		/// <summary>
		/// The &lt;rt&gt; tag defines an explanation or pronunciation of characters (for East Asian typography) in a ruby annotation.
		/// </summary>
		public static rt rt(IEnumerable<object> contents) => new rt(contents);

		/// <summary>
		/// The &lt;ruby&gt; tag specifies a ruby annotation.
		/// </summary>
		public static ruby ruby(params object[] contents) => new ruby(contents);

		/// <summary>
		/// The &lt;ruby&gt; tag specifies a ruby annotation.
		/// </summary>
		public static ruby ruby(IEnumerable<object> contents) => new ruby(contents);

		/// <summary>
		/// The &lt;s&gt; tag specifies text that is no longer correct, accurate or relevant. 
		/// The text will be displayed with a line through it.
		/// </summary>
		public static s s(params object[] contents) => new s(contents);

		/// <summary>
		/// The &lt;s&gt; tag specifies text that is no longer correct, accurate or relevant. 
		/// The text will be displayed with a line through it.
		/// </summary>
		public static s s(IEnumerable<object> contents) => new s(contents);

		/// <summary>
		/// The &lt;samp&gt; tag is used to define sample output from a computer program. 
		/// The content inside is displayed in the browser's default monospace font.
		/// </summary>
		public static samp samp(params object[] contents) => new samp(contents);

		/// <summary>
		/// The &lt;samp&gt; tag is used to define sample output from a computer program. 
		/// The content inside is displayed in the browser's default monospace font.
		/// </summary>
		public static samp samp(IEnumerable<object> contents) => new samp(contents);

		/// <summary>
		/// The &lt;script&gt; tag is used to embed a client-side script (JavaScript).
		/// </summary>
		public static script script(params object[] contents) => new script(contents);

		/// <summary>
		/// The &lt;script&gt; tag is used to embed a client-side script (JavaScript).
		/// </summary>
		public static script script(IEnumerable<object> contents) => new script(contents);

		/// <summary>
		/// The &lt;section&gt; tag defines a section in a document.
		/// </summary>
		public static section section(params object[] contents) => new section(contents);

		/// <summary>
		/// The &lt;section&gt; tag defines a section in a document.
		/// </summary>
		public static section section(IEnumerable<object> contents) => new section(contents);

		/// <summary>
		/// The &lt;select&gt; element is used to create a drop-down list.
		/// </summary>
		public static select select(params object[] contents) => new select(contents);

		/// <summary>
		/// The &lt;select&gt; element is used to create a drop-down list.
		/// </summary>
		public static select select(IEnumerable<object> contents) => new select(contents);

		/// <summary>
		/// The &lt;small&gt; tag defines smaller text (like 
		/// copyright and other side-comments).
		/// </summary>
		public static small small(params object[] contents) => new small(contents);

		/// <summary>
		/// The &lt;small&gt; tag defines smaller text (like 
		/// copyright and other side-comments).
		/// </summary>
		public static small small(IEnumerable<object> contents) => new small(contents);

		/// <summary>
		/// The &lt;source&gt; tag is used to specify multiple media resources for media elements, such as 
		/// &lt;video&gt;, &lt;audio&gt;, 
		/// and &lt;picture&gt;.
		/// </summary>
		public static source source(params object[] contents) => new source(contents);

		/// <summary>
		/// The &lt;source&gt; tag is used to specify multiple media resources for media elements, such as 
		/// &lt;video&gt;, &lt;audio&gt;, 
		/// and &lt;picture&gt;.
		/// </summary>
		public static source source(IEnumerable<object> contents) => new source(contents);

		/// <summary>
		/// The &lt;span&gt; tag is an inline container used to 
		/// mark up a part of a text, or a part of a document.
		/// </summary>
		public static span span(params object[] contents) => new span(contents);

		/// <summary>
		/// The &lt;span&gt; tag is an inline container used to 
		/// mark up a part of a text, or a part of a document.
		/// </summary>
		public static span span(IEnumerable<object> contents) => new span(contents);

		/// <summary>
		/// The &lt;strike&gt; tag was used in HTML 4 to define strikethrough text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static strike strike(params object[] contents) => new strike(contents);

		/// <summary>
		/// The &lt;strike&gt; tag was used in HTML 4 to define strikethrough text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static strike strike(IEnumerable<object> contents) => new strike(contents);

		/// <summary>
		/// The &lt;strong&gt; tag is used to define 
		/// text with strong importance. The content inside is typically displayed in
		/// bold.
		/// </summary>
		public static strong strong(params object[] contents) => new strong(contents);

		/// <summary>
		/// The &lt;strong&gt; tag is used to define 
		/// text with strong importance. The content inside is typically displayed in
		/// bold.
		/// </summary>
		public static strong strong(IEnumerable<object> contents) => new strong(contents);

		/// <summary>
		/// The &lt;style&gt; tag is used to define style information 
		/// (CSS) for a document.
		/// </summary>
		public static style style(params object[] contents) => new style(contents);

		/// <summary>
		/// The &lt;style&gt; tag is used to define style information 
		/// (CSS) for a document.
		/// </summary>
		public static style style(IEnumerable<object> contents) => new style(contents);

		/// <summary>
		/// The &lt;sub&gt; tag defines subscript text. Subscript text appears half a character below the 
		/// normal line, and is sometimes rendered in a smaller font. Subscript text can be used for chemical formulas, like H2O.
		/// </summary>
		public static sub sub(params object[] contents) => new sub(contents);

		/// <summary>
		/// The &lt;sub&gt; tag defines subscript text. Subscript text appears half a character below the 
		/// normal line, and is sometimes rendered in a smaller font. Subscript text can be used for chemical formulas, like H2O.
		/// </summary>
		public static sub sub(IEnumerable<object> contents) => new sub(contents);

		/// <summary>
		/// The &lt;summary&gt; tag defines a visible heading for the &lt;details&gt; element.
		/// The heading can be clicked to view/hide the details.
		/// </summary>
		public static summary summary(params object[] contents) => new summary(contents);

		/// <summary>
		/// The &lt;summary&gt; tag defines a visible heading for the &lt;details&gt; element.
		/// The heading can be clicked to view/hide the details.
		/// </summary>
		public static summary summary(IEnumerable<object> contents) => new summary(contents);

		/// <summary>
		/// The &lt;sup&gt; tag defines superscript text. Superscript text appears half a character above the 
		/// normal line, and is sometimes rendered in a smaller font. Superscript text can be used for footnotes, like WWW[1].
		/// </summary>
		public static sup sup(params object[] contents) => new sup(contents);

		/// <summary>
		/// The &lt;sup&gt; tag defines superscript text. Superscript text appears half a character above the 
		/// normal line, and is sometimes rendered in a smaller font. Superscript text can be used for footnotes, like WWW[1].
		/// </summary>
		public static sup sup(IEnumerable<object> contents) => new sup(contents);

		/// <summary>
		/// The &lt;svg&gt; tag defines a container for SVG graphics.
		/// </summary>
		public static svg svg(params object[] contents) => new svg(contents);

		/// <summary>
		/// The &lt;svg&gt; tag defines a container for SVG graphics.
		/// </summary>
		public static svg svg(IEnumerable<object> contents) => new svg(contents);

		/// <summary>
		/// The &lt;table&gt; tag defines an HTML table.
		/// </summary>
		public static table table(params object[] contents) => new table(contents);

		/// <summary>
		/// The &lt;table&gt; tag defines an HTML table.
		/// </summary>
		public static table table(IEnumerable<object> contents) => new table(contents);

		/// <summary>
		/// The &lt;tbody&gt; tag is used to group the body content in an HTML table.
		/// </summary>
		public static tbody tbody(params object[] contents) => new tbody(contents);

		/// <summary>
		/// The &lt;tbody&gt; tag is used to group the body content in an HTML table.
		/// </summary>
		public static tbody tbody(IEnumerable<object> contents) => new tbody(contents);

		/// <summary>
		/// The &lt;td&gt; tag defines a standard data cell in an HTML table.
		/// </summary>
		public static td td(params object[] contents) => new td(contents);

		/// <summary>
		/// The &lt;td&gt; tag defines a standard data cell in an HTML table.
		/// </summary>
		public static td td(IEnumerable<object> contents) => new td(contents);

		/// <summary>
		/// The &lt;template&gt; tag is used as a 
		/// container to hold some HTML content hidden from the user when the page loads.
		/// </summary>
		public static template template(params object[] contents) => new template(contents);

		/// <summary>
		/// The &lt;template&gt; tag is used as a 
		/// container to hold some HTML content hidden from the user when the page loads.
		/// </summary>
		public static template template(IEnumerable<object> contents) => new template(contents);

		/// <summary>
		/// The &lt;textarea&gt; tag defines a multi-line text input control.
		/// </summary>
		public static textarea textarea(params object[] contents) => new textarea(contents);

		/// <summary>
		/// The &lt;textarea&gt; tag defines a multi-line text input control.
		/// </summary>
		public static textarea textarea(IEnumerable<object> contents) => new textarea(contents);

		/// <summary>
		/// The &lt;tfoot&gt; tag is used to group footer content in an HTML table.
		/// </summary>
		public static tfoot tfoot(params object[] contents) => new tfoot(contents);

		/// <summary>
		/// The &lt;tfoot&gt; tag is used to group footer content in an HTML table.
		/// </summary>
		public static tfoot tfoot(IEnumerable<object> contents) => new tfoot(contents);

		/// <summary>
		/// The &lt;th&gt; tag defines a header cell in an HTML table.
		/// </summary>
		public static th th(params object[] contents) => new th(contents);

		/// <summary>
		/// The &lt;th&gt; tag defines a header cell in an HTML table.
		/// </summary>
		public static th th(IEnumerable<object> contents) => new th(contents);

		/// <summary>
		/// The &lt;thead&gt; tag is used to group header content in an HTML table.
		/// </summary>
		public static thead thead(params object[] contents) => new thead(contents);

		/// <summary>
		/// The &lt;thead&gt; tag is used to group header content in an HTML table.
		/// </summary>
		public static thead thead(IEnumerable<object> contents) => new thead(contents);

		/// <summary>
		/// The &lt;time&gt; tag defines a specific time 
		/// (or datetime).
		/// </summary>
		public static time time(params object[] contents) => new time(contents);

		/// <summary>
		/// The &lt;time&gt; tag defines a specific time 
		/// (or datetime).
		/// </summary>
		public static time time(IEnumerable<object> contents) => new time(contents);

		/// <summary>
		/// The &lt;title&gt; tag defines the title of the document. 
		/// The title must be text-only, and it is shown in the browser's title bar or in 
		/// the page's tab.
		/// </summary>
		public static title title(params object[] contents) => new title(contents);

		/// <summary>
		/// The &lt;title&gt; tag defines the title of the document. 
		/// The title must be text-only, and it is shown in the browser's title bar or in 
		/// the page's tab.
		/// </summary>
		public static title title(IEnumerable<object> contents) => new title(contents);

		/// <summary>
		/// The &lt;tr&gt; tag defines a row in an HTML table.
		/// </summary>
		public static tr tr(params object[] contents) => new tr(contents);

		/// <summary>
		/// The &lt;tr&gt; tag defines a row in an HTML table.
		/// </summary>
		public static tr tr(IEnumerable<object> contents) => new tr(contents);

		/// <summary>
		/// The &lt;track&gt; tag specifies text tracks for 
		/// &lt;audio&gt; or &lt;video&gt; 
		/// elements.
		/// </summary>
		public static track track(params object[] contents) => new track(contents);

		/// <summary>
		/// The &lt;track&gt; tag specifies text tracks for 
		/// &lt;audio&gt; or &lt;video&gt; 
		/// elements.
		/// </summary>
		public static track track(IEnumerable<object> contents) => new track(contents);

		/// <summary>
		/// The &lt;tt&gt; tag was used in HTML 4 to define teletype text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static tt tt(params object[] contents) => new tt(contents);

		/// <summary>
		/// The &lt;tt&gt; tag was used in HTML 4 to define teletype text.
		/// </summary>
		[Obsolete("Deprecated")]
		public static tt tt(IEnumerable<object> contents) => new tt(contents);

		/// <summary>
		/// The &lt;u&gt; tag represents some text that 
		/// is unarticulated and styled differently 
		/// from normal text, such as misspelled words or proper names in Chinese text. The 
		/// content inside is typically displayed with an underline. You can change this 
		/// with CSS (see example below).&nbsp;
		/// </summary>
		public static u u(params object[] contents) => new u(contents);

		/// <summary>
		/// The &lt;u&gt; tag represents some text that 
		/// is unarticulated and styled differently 
		/// from normal text, such as misspelled words or proper names in Chinese text. The 
		/// content inside is typically displayed with an underline. You can change this 
		/// with CSS (see example below).&nbsp;
		/// </summary>
		public static u u(IEnumerable<object> contents) => new u(contents);

		/// <summary>
		/// The &lt;ul&gt; tag defines an unordered (bulleted) list.
		/// </summary>
		public static ul ul(params object[] contents) => new ul(contents);

		/// <summary>
		/// The &lt;ul&gt; tag defines an unordered (bulleted) list.
		/// </summary>
		public static ul ul(IEnumerable<object> contents) => new ul(contents);

		/// <summary>
		/// The &lt;var&gt; tag is used to defines a variable 
		/// in programming or in a mathematical expression. The content inside is typically 
		/// displayed in italic.
		/// </summary>
		public static _var @var(params object[] contents) => new _var(contents);

		/// <summary>
		/// The &lt;var&gt; tag is used to defines a variable 
		/// in programming or in a mathematical expression. The content inside is typically 
		/// displayed in italic.
		/// </summary>
		public static _var @var(IEnumerable<object> contents) => new _var(contents);

		/// <summary>
		/// The &lt;video&gt; tag is used to embed video 
		/// content in a document, such as a movie clip or other video streams.
		/// </summary>
		public static video video(params object[] contents) => new video(contents);

		/// <summary>
		/// The &lt;video&gt; tag is used to embed video 
		/// content in a document, such as a movie clip or other video streams.
		/// </summary>
		public static video video(IEnumerable<object> contents) => new video(contents);

		/// <summary>
		/// The &lt;wbr&gt; (Word Break Opportunity) tag specifies where in a text it would be ok to add a line-break.
		/// </summary>
		public static wbr wbr(params object[] contents) => new wbr(contents);

		/// <summary>
		/// The &lt;wbr&gt; (Word Break Opportunity) tag specifies where in a text it would be ok to add a line-break.
		/// </summary>
		public static wbr wbr(IEnumerable<object> contents) => new wbr(contents);


	}
}
