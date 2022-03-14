using PoShDump.Html.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace PoShDump.Html.Core.Elements
{
	public abstract class HtmlNode : HtmlObject
	{
		protected IEnumerable<HtmlNode> Contents { get; private set; }

		internal HtmlNode(IEnumerable<HtmlNode> contents)
		{
			Contents = contents?.ToList();
		}

		public HtmlNode AddChild(HtmlNode child)
		{
			Contents = Contents.Add(child);

			return this;
		}
	}
}
