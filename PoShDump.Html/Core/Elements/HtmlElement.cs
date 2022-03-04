using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Core.Elements
{
	public class HtmlElement<T> : HtmlNode
		where T : IHtmlAttributeContainer, new()
	{
		public string Name { get; }

		protected virtual T AttributeContainer { get; } = new T();

		public HtmlElement(string name, params object[] contents) : base(GetNodes(contents))
		{
			Name = name;
		}

		public HtmlElement(string name, IEnumerable<object> contents) : base(GetNodes(contents))
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

		public virtual HtmlElement<T> WithAttributes(Action<T> options)
		{
			options(AttributeContainer);
			return this;
		}

		public override XObject ToXml()
		{
			var contents = Contents?.Select(c => c?.ToXml());
			var attributes = AttributeContainer.Attributes.Select(a => a.ToXml());

			var merged = attributes;
			if (contents != null)
			{
				merged = merged.Concat(contents);
			}

			return new XElement(Name, merged);
		}
	}

	public class HtmlElement : HtmlElement<HtmlAttributeContainer>
	{
		public HtmlElement(string name, params object[] contents) : base(name, contents)
		{
		}

		public HtmlElement(string name, IEnumerable<object> contents) : base(name, contents)
		{
		}

		public new HtmlElement WithAttributes(Action<HtmlAttributeContainer> options)
		{
			options(AttributeContainer);
			return this;
		}
	}
}
