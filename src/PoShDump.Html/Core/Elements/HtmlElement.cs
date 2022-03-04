using System;
using System.Collections.Generic;
using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Core.Elements
{
	public class HtmlElement<T> : BaseHtmlElement
		where T : IHtmlAttributesContainer, new()
	{
		protected virtual T AttributeContainer { get; } = new T();

		protected override HashSet<HtmlAttribute> Attributes => AttributeContainer.Attributes;

		public HtmlElement(string name, params object[] contents) : base(name, contents)
		{
		}

		public HtmlElement(string name, IEnumerable<object> contents) : base(name, contents)
		{
		}

		public virtual HtmlElement<T> WithAttributes(Action<T> options)
		{
			options(AttributeContainer);
			return this;
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
