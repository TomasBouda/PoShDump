using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Extensions;

namespace PoShDump.Html.Core.Attributes
{
	public class AttributeContainer<T> : IAttributeContainer<T> where T : HtmlAttribute, new()
	{
		protected IEnumerable<T> Attributes { get; set; } = Enumerable.Empty<T>();

		public AttributeContainer() { }

		public AttributeContainer(IEnumerable<T> attributes)
		{
			this.Attributes = attributes;
		}

		public IAttributeContainer<T> Add(T attribute)
		{
			Attributes = Attributes.Add(attribute);
			return this;
		}

		public IAttributeContainer<T> Add(string name, object value)
		{
			Attributes = Attributes.Add((T)Activator.CreateInstance(typeof(T), name, value));
			return this;
		}

		public IEnumerator<T> GetEnumerator()
		{
			return Attributes.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Attributes.GetEnumerator();
		}
	}
}
