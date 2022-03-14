using System.Collections.Generic;

namespace PoShDump.Extensions
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> ToEnumerable<T>(this T input)
		{
			yield return input;
		}
	}
}
