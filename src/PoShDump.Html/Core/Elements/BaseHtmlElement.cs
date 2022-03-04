using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Core.Elements
{
	public abstract class BaseHtmlElement : HtmlNode
	{
		public string Name { get; }

		protected virtual HashSet<HtmlAttribute> Attributes { get; }

		protected BaseHtmlElement(string name, params object[] contents) : base(GetNodes(contents))
		{
			Name = name;
		}

		protected BaseHtmlElement(string name, IEnumerable<object> contents) : base(GetNodes(contents))
		{
			Name = name;
		}

		private static IEnumerable<HtmlNode> GetNodes(IEnumerable<object> contents)
		{
			return contents?.Select(c =>
			{
				if (c is string str)
				{
					return new HtmlText(str);
				}
				else if (c is HtmlNode node)
				{
					return node;
				}
				else
				{
					return new HtmlText(c.ToString());
				}
			});
		}

		public override XObject ToXml()
		{
			var contents = Contents?.Select(c => c?.ToXml());
			var attributes = Attributes.Select(a => a?.ToXml());

			var merged = attributes;
			if (contents != null)
			{
				merged = merged.Concat(contents);
			}

			return new XElement(Name, merged);
		}
	}
}
