using PoShDump.Html.Core.Attributes;
using PoShDump.Html.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace PoShDump.Html.Core.Elements
{
	public abstract class HtmlElement : HtmlNode
	{
		public string Name { get; }

		protected virtual IEnumerable<HtmlAttribute> Attributes { get; set; } = new HashSet<HtmlAttribute>();

		protected HtmlElement(string name, params object[] contents) : base(GetNodes(contents))
		{
			Name = name;
		}

		protected HtmlElement(string name, IEnumerable<object> contents) : base(GetNodes(contents))
		{
			Name = name;
		}

		public HtmlElement AddAttribute(string name, object value)
		{
			Attributes = Attributes.Add(new HtmlAttribute(name, value));
			return this;
		}

		private static IEnumerable<HtmlNode> GetNodes(IEnumerable<object> contents)
		{
			IEnumerable<HtmlNode> joinedCollection = new List<HtmlNode>();
			foreach (var content in contents)
			{
				if (content is string str)
				{
					joinedCollection = joinedCollection.Add(new HtmlText(str));
				}
				else if (content is HtmlNode node)
				{
					joinedCollection = joinedCollection.Add(node);
				}
				else if (content is IEnumerable<HtmlNode> nodeCollection)
				{
					joinedCollection = joinedCollection?.Concat(nodeCollection);
				}
				else
				{
					joinedCollection = joinedCollection.Add(new HtmlText(content.ToString()));
				}
			}

			return joinedCollection;
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
