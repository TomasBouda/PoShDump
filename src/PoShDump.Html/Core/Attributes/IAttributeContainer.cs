using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoShDump.Html.Core.Attributes
{
	public interface IAttributeContainer<T> : IEnumerable<T> where T : HtmlAttribute, new()
	{
		IAttributeContainer<T> Add(T attribute);
		IAttributeContainer<T> Add(string name, object value);
	}
}
