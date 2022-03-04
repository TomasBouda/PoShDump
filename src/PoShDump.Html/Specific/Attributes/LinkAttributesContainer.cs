using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Specific.Attributes
{
	public sealed class LinkAttributesContainer : HtmlAttributesContainer<LinkAttributesContainer>, IHtmlAttributesContainer
	{
		public LinkAttributesContainer()
		{
			Parent = this;
		}

		public LinkAttributesContainer crossorigin(string value) => Add(nameof(crossorigin), value);
		public LinkAttributesContainer href(string value) => Add(nameof(href), value);
		public LinkAttributesContainer hreflang(string value) => Add(nameof(hreflang), value);
		public LinkAttributesContainer media(string value) => Add(nameof(media), value);
		public LinkAttributesContainer referrerpolicy(string value) => Add(nameof(referrerpolicy), value);
		public LinkAttributesContainer rel(string value) => Add(nameof(rel), value);
		public LinkAttributesContainer sizes(string value) => Add(nameof(sizes), value);
		public LinkAttributesContainer type(string value) => Add(nameof(type), value);
	}
}
