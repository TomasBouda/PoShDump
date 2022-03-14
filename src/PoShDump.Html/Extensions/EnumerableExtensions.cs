using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoShDump.Html.Extensions
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> Add<T>(this IEnumerable<T> e, T value)
		{
			foreach (var cur in e)
			{
				yield return cur;
			}
			yield return value;
		}
	}
}
