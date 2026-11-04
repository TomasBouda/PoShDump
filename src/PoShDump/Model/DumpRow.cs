using System.Collections.Generic;

namespace PoShDump.Model
{
	/// <summary>
	/// One item of a collection, with a cell per column of the table it belongs to.
	/// </summary>
	public sealed class DumpRow
	{
		public DumpRow(IList<DumpNode> cells)
		{
			Cells = cells ?? new List<DumpNode>();
		}

		public IList<DumpNode> Cells { get; }
	}
}
