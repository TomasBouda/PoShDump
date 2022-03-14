using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Core.Attributes
{
	public static class HtmlAttributeExtensions
	{
		/// <summary>
		/// Specifies an abbreviated version of the content in a header cell
		/// </summary>
		public static IAttributeContainer<T> abbr<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IabbrAttribute, new() => attributes.Add("abbr", value);

		/// <summary>
		/// Specifies a filter for what file types the user can pick from the file 
		///     input dialog box (only for type=&quot;file&quot;)
		/// </summary>
		public static IAttributeContainer<T> accept<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IacceptAttribute, new() => attributes.Add("accept", value);

		/// <summary>
		/// Specifies the character encodings that are to be used for the form submission
		/// </summary>
		public static IAttributeContainer<T> accept_charset<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, Iaccept_charsetAttribute, new() => attributes.Add("accept-charset", value);

		/// <summary>
		/// Specifies where to send the form-data when a form is submitted
		/// </summary>
		public static IAttributeContainer<T> action<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IactionAttribute, new() => attributes.Add("action", value);

		/// <summary>
		/// Specifies a feature policy for the &lt;iframe&gt;
		/// </summary>
		public static IAttributeContainer<T> allow<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IallowAttribute, new() => attributes.Add("allow", value);

		/// <summary>
		/// Set to true if the &lt;iframe&gt; can activate fullscreen mode by calling the 
		///     requestFullscreen() method
		/// </summary>
		public static IAttributeContainer<T> allowfullscreen<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IallowfullscreenAttribute, new() => attributes.Add("allowfullscreen", value);

		/// <summary>
		/// Set to true if a cross-origin &lt;iframe&gt; should be allowed to invoke the 
		///     Payment Request API
		/// </summary>
		public static IAttributeContainer<T> allowpaymentrequest<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IallowpaymentrequestAttribute, new() => attributes.Add("allowpaymentrequest", value);

		/// <summary>
		/// Specifies an alternate text for the area. Required if the href attribute is present
		/// </summary>
		public static IAttributeContainer<T> alt<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IaltAttribute, new() => attributes.Add("alt", value);

		/// <summary>
		/// Specifies that the script is downloaded in parallel to parsing the page, 
		///     and executed as soon as it is available (before parsing completes) (only for external scripts)
		/// </summary>
		public static IAttributeContainer<T> async<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IasyncAttribute, new() => attributes.Add("async", value);

		/// <summary>
		/// Specifies whether a form should have autocomplete on or off
		/// </summary>
		public static IAttributeContainer<T> autocomplete<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IautocompleteAttribute, new() => attributes.Add("autocomplete", value);

		/// <summary>
		/// Specifies that a button should automatically get focus when the page loads
		/// </summary>
		public static IAttributeContainer<T> autofocus<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IautofocusAttribute, new() => attributes.Add("autofocus", value);

		/// <summary>
		/// Specifies that the audio will start playing as soon as it is ready
		/// </summary>
		public static IAttributeContainer<T> autoplay<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IautoplayAttribute, new() => attributes.Add("autoplay", value);

		/// <summary>
		/// Specifies the source of the quotation
		/// </summary>
		public static IAttributeContainer<T> cite<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IciteAttribute, new() => attributes.Add("cite", value);

		/// <summary>
		/// Specifies the visible width of a text area
		/// </summary>
		public static IAttributeContainer<T> cols<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcolsAttribute, new() => attributes.Add("cols", value);

		/// <summary>
		/// Specifies the number of columns a cell should span
		/// </summary>
		public static IAttributeContainer<T> colspan<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcolspanAttribute, new() => attributes.Add("colspan", value);

		/// <summary>
		/// Specifies the value associated with the http-equiv or name attribute
		/// </summary>
		public static IAttributeContainer<T> content<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcontentAttribute, new() => attributes.Add("content", value);

		/// <summary>
		/// Specifies that audio controls should be displayed (such as a play/pause button etc)
		/// </summary>
		public static IAttributeContainer<T> controls<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcontrolsAttribute, new() => attributes.Add("controls", value);

		/// <summary>
		/// Specifies the coordinates of the area
		/// </summary>
		public static IAttributeContainer<T> coords<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcoordsAttribute, new() => attributes.Add("coords", value);

		/// <summary>
		/// Allow images from third-party sites that allow cross-origin access to be used with canvas
		/// </summary>
		public static IAttributeContainer<T> crossorigin<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcrossoriginAttribute, new() => attributes.Add("crossorigin", value);

		/// <summary>
		/// Specifies the URL of the resource to be used by the object
		/// </summary>
		public static IAttributeContainer<T> data<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdataAttribute, new() => attributes.Add("data", value);

		/// <summary>
		/// Specifies the date and time of when the text was deleted/changed
		/// </summary>
		public static IAttributeContainer<T> datetime<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdatetimeAttribute, new() => attributes.Add("datetime", value);

		/// <summary>
		/// Specifies that the track is to be enabled if the user's preferences do not indicate that another track would be more appropriate
		/// </summary>
		public static IAttributeContainer<T> @default<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdefaultAttribute, new() => attributes.Add("default", value);

		/// <summary>
		/// Specifies that the script is downloaded in parallel to parsing the page, 
		///     and executed after the page has finished parsing (only for external scripts)
		/// </summary>
		public static IAttributeContainer<T> defer<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdeferAttribute, new() => attributes.Add("defer", value);

		/// <summary>
		/// Specifies that the text direction will be submitted
		/// </summary>
		public static IAttributeContainer<T> dirname<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdirnameAttribute, new() => attributes.Add("dirname", value);

		/// <summary>
		/// Specifies that a button should be disabled
		/// </summary>
		public static IAttributeContainer<T> disabled<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdisabledAttribute, new() => attributes.Add("disabled", value);

		/// <summary>
		/// Specifies that the target will be downloaded when a user clicks on the hyperlink
		/// </summary>
		public static IAttributeContainer<T> download<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IdownloadAttribute, new() => attributes.Add("download", value);

		/// <summary>
		/// Specifies how the form-data should be encoded when submitting it to the server (only for method=&quot;post&quot;)
		/// </summary>
		public static IAttributeContainer<T> enctype<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IenctypeAttribute, new() => attributes.Add("enctype", value);

		/// <summary>
		/// Specifies the id of the form element the label should be bound to
		/// </summary>
		public static IAttributeContainer<T> @for<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IforAttribute, new() => attributes.Add("for", value);

		/// <summary>
		/// Specifies which form the button belongs to
		/// </summary>
		public static IAttributeContainer<T> form<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IformAttribute, new() => attributes.Add("form", value);

		/// <summary>
		/// Specifies where to send the form-data when a form is submitted. Only for type=&quot;submit&quot;
		/// </summary>
		public static IAttributeContainer<T> formaction<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IformactionAttribute, new() => attributes.Add("formaction", value);

		/// <summary>
		/// Specifies how form-data should be encoded before sending it to a server. Only for type=&quot;submit&quot;
		/// </summary>
		public static IAttributeContainer<T> formenctype<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IformenctypeAttribute, new() => attributes.Add("formenctype", value);

		/// <summary>
		/// Specifies how to send the form-data (which HTTP method to use). Only for type=&quot;submit&quot;
		/// </summary>
		public static IAttributeContainer<T> formmethod<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IformmethodAttribute, new() => attributes.Add("formmethod", value);

		/// <summary>
		/// Specifies that the form-data should not be validated on submission. Only for type=&quot;submit&quot; 
		/// </summary>
		public static IAttributeContainer<T> formnovalidate<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IformnovalidateAttribute, new() => attributes.Add("formnovalidate", value);

		/// <summary>
		/// Specifies where to display the response after submitting the form. Only for type=&quot;submit&quot;
		/// </summary>
		public static IAttributeContainer<T> formtarget<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IformtargetAttribute, new() => attributes.Add("formtarget", value);

		/// <summary>
		/// Specifies one or more header cells a cell is related to
		/// </summary>
		public static IAttributeContainer<T> headers<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IheadersAttribute, new() => attributes.Add("headers", value);

		/// <summary>
		/// Specifies the height of the canvas. Default value is 150
		/// </summary>
		public static IAttributeContainer<T> height<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IheightAttribute, new() => attributes.Add("height", value);

		/// <summary>
		/// Specifies the range that is considered to be a high value
		/// </summary>
		public static IAttributeContainer<T> high<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IhighAttribute, new() => attributes.Add("high", value);

		/// <summary>
		/// Specifies the URL of the page the link goes to
		/// </summary>
		public static IAttributeContainer<T> href<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IhrefAttribute, new() => attributes.Add("href", value);

		/// <summary>
		/// Specifies the language of the linked document
		/// </summary>
		public static IAttributeContainer<T> hreflang<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IhreflangAttribute, new() => attributes.Add("hreflang", value);

		/// <summary>
		/// Provides an HTTP header for the information/value of the content attribute
		/// </summary>
		public static IAttributeContainer<T> http_equiv<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, Ihttp_equivAttribute, new() => attributes.Add("http-equiv", value);

		/// <summary>
		/// Specifies the character encoding for the HTML document 
		/// </summary>
		public static IAttributeContainer<T> charset<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcharsetAttribute, new() => attributes.Add("charset", value);

		/// <summary>
		/// Specifies that an &lt;input&gt; element should be pre-selected when the page loads (for type=&quot;checkbox&quot; or type=&quot;radio&quot;)
		/// </summary>
		public static IAttributeContainer<T> @checked<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IcheckedAttribute, new() => attributes.Add("checked", value);

		/// <summary>
		/// Allows a browser to check the fetched script to ensure that the code is 
		///     never loaded if the source has been manipulated
		/// </summary>
		public static IAttributeContainer<T> integrity<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IintegrityAttribute, new() => attributes.Add("integrity", value);

		/// <summary>
		/// Specifies an image as a server-side image map
		/// </summary>
		public static IAttributeContainer<T> ismap<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IismapAttribute, new() => attributes.Add("ismap", value);

		/// <summary>
		/// Specifies the kind of text track
		/// </summary>
		public static IAttributeContainer<T> kind<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IkindAttribute, new() => attributes.Add("kind", value);

		/// <summary>
		/// Specifies a label for an option-group
		/// </summary>
		public static IAttributeContainer<T> label<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IlabelAttribute, new() => attributes.Add("label", value);

		/// <summary>
		/// Refers to a &lt;datalist&gt; element that contains pre-defined options for an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> list<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IlistAttribute, new() => attributes.Add("list", value);

		/// <summary>
		/// Specifies whether a browser should load an iframe immediately or to 
		///     defer loading of iframes until some conditions are met
		/// </summary>
		public static IAttributeContainer<T> loading<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IloadingAttribute, new() => attributes.Add("loading", value);

		/// <summary>
		/// Specifies a URL to a detailed description of an image
		/// </summary>
		public static IAttributeContainer<T> longdesc<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IlongdescAttribute, new() => attributes.Add("longdesc", value);

		/// <summary>
		/// Specifies that the audio will start over again, every time it is finished
		/// </summary>
		public static IAttributeContainer<T> loop<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IloopAttribute, new() => attributes.Add("loop", value);

		/// <summary>
		/// Specifies the range that is considered to be a low value
		/// </summary>
		public static IAttributeContainer<T> low<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IlowAttribute, new() => attributes.Add("low", value);

		/// <summary>
		/// Specifies the maximum value for an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> max<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ImaxAttribute, new() => attributes.Add("max", value);

		/// <summary>
		/// Specifies the maximum number of characters allowed in an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> maxlength<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ImaxlengthAttribute, new() => attributes.Add("maxlength", value);

		/// <summary>
		/// Specifies what media/device the linked document is optimized for
		/// </summary>
		public static IAttributeContainer<T> media<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ImediaAttribute, new() => attributes.Add("media", value);

		/// <summary>
		/// Specifies the HTTP method to use when sending form-data
		/// </summary>
		public static IAttributeContainer<T> method<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ImethodAttribute, new() => attributes.Add("method", value);

		/// <summary>
		/// Specifies a minimum value for an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> min<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IminAttribute, new() => attributes.Add("min", value);

		/// <summary>
		/// Specifies the minimum number of characters required in an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> minlength<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IminlengthAttribute, new() => attributes.Add("minlength", value);

		/// <summary>
		/// Specifies that a user can enter more than one value in an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> multiple<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ImultipleAttribute, new() => attributes.Add("multiple", value);

		/// <summary>
		/// Specifies that the audio output should be muted
		/// </summary>
		public static IAttributeContainer<T> muted<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ImutedAttribute, new() => attributes.Add("muted", value);

		/// <summary>
		/// Specifies a name for the button
		/// </summary>
		public static IAttributeContainer<T> name<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, InameAttribute, new() => attributes.Add("name", value);

		/// <summary>
		/// Specifies that the script should not be executed in browsers supporting
		///     ES2015 modules 
		/// </summary>
		public static IAttributeContainer<T> nomodule<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, InomoduleAttribute, new() => attributes.Add("nomodule", value);

		/// <summary>
		/// Specifies that the form should not be validated when submitted
		/// </summary>
		public static IAttributeContainer<T> novalidate<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, InovalidateAttribute, new() => attributes.Add("novalidate", value);

		/// <summary>
		/// Specifies that the details should be visible (open) to the user
		/// </summary>
		public static IAttributeContainer<T> open<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IopenAttribute, new() => attributes.Add("open", value);

		/// <summary>
		/// Specifies what value is the optimal value for the gauge
		/// </summary>
		public static IAttributeContainer<T> optimum<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IoptimumAttribute, new() => attributes.Add("optimum", value);

		/// <summary>
		/// Specifies a regular expression that an &lt;input&gt; element's value is checked against
		/// </summary>
		public static IAttributeContainer<T> pattern<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IpatternAttribute, new() => attributes.Add("pattern", value);

		/// <summary>
		/// Specifies a space-separated list of URLs to which, when the link is 
		///     followed, post requests with the body ping will be sent by the browser (in 
		///     the background). Typically used for tracking.
		/// </summary>
		public static IAttributeContainer<T> ping<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IpingAttribute, new() => attributes.Add("ping", value);

		/// <summary>
		/// Specifies a short hint that describes the expected value of an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> placeholder<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IplaceholderAttribute, new() => attributes.Add("placeholder", value);

		/// <summary>
		/// Specifies an image to be shown while the video is downloading, or until the user hits the play button
		/// </summary>
		public static IAttributeContainer<T> poster<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IposterAttribute, new() => attributes.Add("poster", value);

		/// <summary>
		/// Specifies if and how the author thinks the audio should be loaded when the page loads
		/// </summary>
		public static IAttributeContainer<T> preload<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IpreloadAttribute, new() => attributes.Add("preload", value);

		/// <summary>
		/// Specifies that an input field is read-only
		/// </summary>
		public static IAttributeContainer<T> @readonly<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IreadonlyAttribute, new() => attributes.Add("readonly", value);

		/// <summary>
		/// Specifies which referrer information to send with the link
		/// </summary>
		public static IAttributeContainer<T> referrerpolicy<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IreferrerpolicyAttribute, new() => attributes.Add("referrerpolicy", value);

		/// <summary>
		/// Specifies the relationship between the current document and the linked document
		/// </summary>
		public static IAttributeContainer<T> rel<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IrelAttribute, new() => attributes.Add("rel", value);

		/// <summary>
		/// Specifies that an input field must be filled out before submitting the form
		/// </summary>
		public static IAttributeContainer<T> required<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IrequiredAttribute, new() => attributes.Add("required", value);

		/// <summary>
		/// Specifies that the list order should be reversed (9,8,7...)
		/// </summary>
		public static IAttributeContainer<T> reversed<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IreversedAttribute, new() => attributes.Add("reversed", value);

		/// <summary>
		/// Specifies the visible number of lines in a text area
		/// </summary>
		public static IAttributeContainer<T> rows<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IrowsAttribute, new() => attributes.Add("rows", value);

		/// <summary>
		/// Sets the number of rows a cell should span
		/// </summary>
		public static IAttributeContainer<T> rowspan<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IrowspanAttribute, new() => attributes.Add("rowspan", value);

		/// <summary>
		/// Enables an extra set of restrictions for the content in an &lt;iframe&gt;
		/// </summary>
		public static IAttributeContainer<T> sandbox<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsandboxAttribute, new() => attributes.Add("sandbox", value);

		/// <summary>
		/// Specifies whether a header cell is a header for a column, row, or group of columns or rows 
		/// </summary>
		public static IAttributeContainer<T> scope<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IscopeAttribute, new() => attributes.Add("scope", value);

		/// <summary>
		/// Specifies that an option should be pre-selected when the page loads
		/// </summary>
		public static IAttributeContainer<T> selected<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IselectedAttribute, new() => attributes.Add("selected", value);

		/// <summary>
		/// Specifies the shape of the area
		/// </summary>
		public static IAttributeContainer<T> shape<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IshapeAttribute, new() => attributes.Add("shape", value);

		/// <summary>
		/// Specifies the width, in characters, of an &lt;input&gt; element
		/// </summary>
		public static IAttributeContainer<T> size<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsizeAttribute, new() => attributes.Add("size", value);

		/// <summary>
		/// Specifies image sizes for different page layouts
		/// </summary>
		public static IAttributeContainer<T> sizes<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsizesAttribute, new() => attributes.Add("sizes", value);

		/// <summary>
		/// Specifies the number of columns a &lt;col&gt; element should span
		/// </summary>
		public static IAttributeContainer<T> span<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IspanAttribute, new() => attributes.Add("span", value);

		/// <summary>
		/// Specifies the URL of the audio file
		/// </summary>
		public static IAttributeContainer<T> src<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsrcAttribute, new() => attributes.Add("src", value);

		/// <summary>
		/// Specifies the HTML content of the page to show in the &lt;iframe&gt;
		/// </summary>
		public static IAttributeContainer<T> srcdoc<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsrcdocAttribute, new() => attributes.Add("srcdoc", value);

		/// <summary>
		/// Specifies the language of the track text data (required if kind=&quot;subtitles&quot;)
		/// </summary>
		public static IAttributeContainer<T> srclang<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsrclangAttribute, new() => attributes.Add("srclang", value);

		/// <summary>
		/// Specifies a list of image files to use in different situations
		/// </summary>
		public static IAttributeContainer<T> srcset<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IsrcsetAttribute, new() => attributes.Add("srcset", value);

		/// <summary>
		/// Specifies the start value of an ordered list
		/// </summary>
		public static IAttributeContainer<T> start<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IstartAttribute, new() => attributes.Add("start", value);

		/// <summary>
		/// Specifies the interval between legal numbers in an input field
		/// </summary>
		public static IAttributeContainer<T> step<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IstepAttribute, new() => attributes.Add("step", value);

		/// <summary>
		/// Specifies where to open the linked document
		/// </summary>
		public static IAttributeContainer<T> target<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ItargetAttribute, new() => attributes.Add("target", value);

		/// <summary>
		/// Specifies the media type of the linked document
		/// </summary>
		public static IAttributeContainer<T> type<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ItypeAttribute, new() => attributes.Add("type", value);

		/// <summary>
		/// Specifies whether the type attribute and the actual content of the 
		///     resource must match to be displayed
		/// </summary>
		public static IAttributeContainer<T> typemustmatch<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, ItypemustmatchAttribute, new() => attributes.Add("typemustmatch", value);

		/// <summary>
		/// Specifies an image as a client-side image map
		/// </summary>
		public static IAttributeContainer<T> usemap<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IusemapAttribute, new() => attributes.Add("usemap", value);

		/// <summary>
		/// Specifies an initial value for the button
		/// </summary>
		public static IAttributeContainer<T> value<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IvalueAttribute, new() => attributes.Add("value", value);

		/// <summary>
		/// Specifies the width of the canvas Default value is 300
		/// </summary>
		public static IAttributeContainer<T> width<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IwidthAttribute, new() => attributes.Add("width", value);

		/// <summary>
		/// Specifies how the text in a text area is to be wrapped when submitted in a form
		/// </summary>
		public static IAttributeContainer<T> wrap<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IwrapAttribute, new() => attributes.Add("wrap", value);

		/// <summary>
		/// Specifies the XML namespace attribute (If you need your content to conform to XHTML)
		/// </summary>
		public static IAttributeContainer<T> xmlns<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, IxmlnsAttribute, new() => attributes.Add("xmlns", value);

		/// <summary>
		/// Specifies a shortcut key to activate/focus an element
		/// </summary>
		public static IAttributeContainer<T> accesskey<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("accesskey", value);

		/// <summary>
		/// Specifies one or more classnames for an element (refers to a class in a style sheet)
		/// </summary>
		public static IAttributeContainer<T> @class<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("class", value);

		/// <summary>
		/// Specifies whether the content 
		/// of an element is editable or not
		/// </summary>
		public static IAttributeContainer<T> contenteditable<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("contenteditable", value);

		/// <summary>
		/// Specifies the text direction for the content in an element
		/// </summary>
		public static IAttributeContainer<T> dir<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("dir", value);

		/// <summary>
		/// Specifies whether an element is draggable or not
		/// </summary>
		public static IAttributeContainer<T> draggable<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("draggable", value);

		/// <summary>
		/// Specifies that an element is not yet, or is no longer, relevant
		/// </summary>
		public static IAttributeContainer<T> hidden<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("hidden", value);

		/// <summary>
		/// Specifies a unique id for an element
		/// </summary>
		public static IAttributeContainer<T> @id<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("id", value);

		/// <summary>
		/// Specifies the language of the element's content
		/// </summary>
		public static IAttributeContainer<T> lang<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("lang", value);

		/// <summary>
		/// Specifies whether the element is to have its spelling and grammar checked or 
		/// not
		/// </summary>
		public static IAttributeContainer<T> spellcheck<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("spellcheck", value);

		/// <summary>
		/// Specifies an inline CSS style for an element
		/// </summary>
		public static IAttributeContainer<T> style<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("style", value);

		/// <summary>
		/// Specifies the tabbing order of an element
		/// </summary>
		public static IAttributeContainer<T> tabindex<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("tabindex", value);

		/// <summary>
		/// Specifies extra information about an element
		/// </summary>
		public static IAttributeContainer<T> title<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("title", value);

		/// <summary>
		/// Specifies whether the content of an element should be translated or not
		/// </summary>
		public static IAttributeContainer<T> translate<T>(this IAttributeContainer<T> attributes, object value) where T : HtmlAttribute, new() => attributes.Add("translate", value);

	}
}
