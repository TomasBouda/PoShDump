using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Specific.Attributes
{
	public class AnchorAttributesContainer : HtmlAttributesContainer<AnchorAttributesContainer>, IHtmlAttributesContainer
	{
		public AnchorAttributesContainer()
		{
			Parent = this;
		}

		public AnchorAttributesContainer download(string value) => Add(nameof(download), value);
		public AnchorAttributesContainer href(string value) => Add(nameof(href), value);
		public AnchorAttributesContainer hreflang(string value) => Add(nameof(hreflang), value);
		public AnchorAttributesContainer media(string value) => Add(nameof(media), value);
		public AnchorAttributesContainer ping(string value) => Add(nameof(ping), value);
		public AnchorAttributesContainer referrerpolicy(string value) => Add(nameof(referrerpolicy), value);
		public AnchorAttributesContainer rel(string value) => Add(nameof(rel), value);
		public AnchorAttributesContainer target(string value) => Add(nameof(target), value);
		public AnchorAttributesContainer type(string value) => Add(nameof(type), value);
	}
}
