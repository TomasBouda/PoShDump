using System.Collections;
using System.Collections.Generic;

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

		public static object First(this IEnumerable enumerable)
		{
			var enumerator = enumerable.GetEnumerator();
			enumerator.MoveNext();
			var first = enumerator.Current;
			enumerator.Reset();
			return first;
		}
	}
}
