using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Specific.Attributes
{
	public class ThAttributesContainer : HtmlAttributesContainer<ThAttributesContainer>, IHtmlAttributesContainer
	{
		public ThAttributesContainer()
		{
			Parent = this;
		}

		public ThAttributesContainer colspan(int value) => Add(nameof(colspan), value);
		public ThAttributesContainer headers(string value) => Add(nameof(headers), value);
		public ThAttributesContainer rowspan(int value) => Add(nameof(rowspan), value);
		public ThAttributesContainer abbr(string value) => Add(nameof(abbr), value);
		public ThAttributesContainer scope(string value) => Add(nameof(scope), value);
	}
}
