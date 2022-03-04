using System.Collections.Generic;

namespace PoShDump.Html.Core.Attributes
{
	public interface IHtmlAttributesContainer
	{
		HashSet<HtmlAttribute> Attributes { get; }
	}
}
