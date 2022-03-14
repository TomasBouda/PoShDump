using PoShDump.Html.Core.Attributes;
using System;
using System.Collections.Generic;

namespace PoShDump.Html.Core.Elements
{
	public class HtmlElement<T> : HtmlElement
		where T : HtmlAttribute, new()
	{
		protected IAttributeContainer<T> AttributesContainer { get; set; } = new AttributeContainer<T>();

		protected override IEnumerable<HtmlAttribute> Attributes => AttributesContainer;

		public HtmlElement(string name, params object[] contents) : base(name, contents)
		{
		}

		public HtmlElement(string name, IEnumerable<object> contents) : base(name, contents)
		{
		}

		public virtual HtmlElement<T> WithAttributes(Action<IAttributeContainer<T>> modifier)
		{
			modifier(AttributesContainer);

			return this;
		}
	}
}