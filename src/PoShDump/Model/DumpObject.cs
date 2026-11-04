using System.Collections.Generic;

namespace PoShDump.Model
{
	/// <summary>
	/// A single object: its type, an optional one line summary, and its properties in the order the
	/// pipeline produced them.
	/// </summary>
	public sealed class DumpObject : DumpNode
	{
		public DumpObject(string typeName, string summary, IList<DumpMember> members, bool collapsed, bool isException)
		{
			TypeName = typeName;
			Summary = summary;
			Members = members ?? new List<DumpMember>();
			Collapsed = collapsed;
			IsException = isException;
		}

		public string TypeName { get; }

		/// <summary>
		/// The short line shown under the type: an exception message, or the object's own text when it is
		/// short enough to be worth showing. Null when there is nothing useful to say.
		/// </summary>
		public string Summary { get; }

		public IList<DumpMember> Members { get; }

		/// <summary>Whether the object starts folded. Nested objects do; the root does not.</summary>
		public bool Collapsed { get; }

		/// <summary>An exception reached while reading a value, rather than an ordinary object.</summary>
		public bool IsException { get; }
	}
}
