using System.Collections.Generic;

namespace PoShDump.Html.Core.Attributes
{
	public interface IHtmlAttributeContainer
	{
		HashSet<HtmlAttribute> Attributes { get; }
	}
}
