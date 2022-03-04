using System.Collections.Generic;
using System.Linq;

namespace PoShDump.Html.Core.Elements
{
	public abstract class HtmlNode : HtmlObject
	{
		protected IEnumerable<HtmlNode> Contents { get; private set; }

		protected HtmlNode(IEnumerable<HtmlNode> contents)
		{
			Contents = contents?.ToList();
		}

		public HtmlNode AddChild(HtmlNode child)
		{
			Contents = Contents.Concat(new List<HtmlNode> { child });

			return this;
		}
	}
}
