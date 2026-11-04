using System.Collections.Generic;

namespace PoShDump.Model
{
	/// <summary>
	/// A collection of objects as a table: one column per property of the first item, one row per item.
	/// A collection with no items has no columns and no rows.
	/// </summary>
	public sealed class DumpCollection : DumpNode
	{
		public DumpCollection(string typeName, int count, IList<DumpColumn> columns, IList<DumpRow> rows, bool collapsed)
		{
			TypeName = typeName;
			Count = count;
			Columns = columns ?? new List<DumpColumn>();
			Rows = rows ?? new List<DumpRow>();
			Collapsed = collapsed;
		}

		public string TypeName { get; }

		/// <summary>The number of items, which is also the number of rows.</summary>
		public int Count { get; }

		public IList<DumpColumn> Columns { get; }

		public IList<DumpRow> Rows { get; }

		/// <summary>Whether the table starts folded. Nested collections do; the root does not.</summary>
		public bool Collapsed { get; }

		public bool IsEmpty => Count == 0;
	}
}
