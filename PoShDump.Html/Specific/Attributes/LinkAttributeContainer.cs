using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Specific.Attributes
{
	public sealed class LinkAttributeContainer : HtmlAttributeContainer<LinkAttributeContainer>, IHtmlAttributeContainer
	{
		public LinkAttributeContainer()
		{
			Parent = this;
		}

		public LinkAttributeContainer rel(string value) => Custom(nameof(rel), value);
		public LinkAttributeContainer type(string value) => Custom(nameof(type), value);
		public LinkAttributeContainer href(string value) => Custom(nameof(href), value);
	}
}
