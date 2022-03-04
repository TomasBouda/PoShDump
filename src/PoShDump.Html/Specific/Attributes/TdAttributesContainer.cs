using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Specific.Attributes
{
	public class TdAttributesContainer : HtmlAttributesContainer<TdAttributesContainer>, IHtmlAttributesContainer
	{
		public TdAttributesContainer()
		{
			Parent = this;
		}

		public TdAttributesContainer colspan(int value) => Add(nameof(colspan), value);
		public TdAttributesContainer headers(string value) => Add(nameof(headers), value);
		public TdAttributesContainer rowspan(int value) => Add(nameof(rowspan), value);
	}
}
