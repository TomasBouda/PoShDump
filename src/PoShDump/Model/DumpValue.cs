namespace PoShDump.Model
{
	/// <summary>
	/// A leaf of the dump tree: a value that is shown as text rather than as a table.
	/// </summary>
	public sealed class DumpValue : DumpNode
	{
		private DumpValue(DumpValueKind kind, string text, bool? boolean = null)
		{
			Kind = kind;
			Text = text;
			Boolean = boolean;
		}

		public DumpValueKind Kind { get; }

		/// <summary>The value as it is shown. Never null; a null value carries the text "null".</summary>
		public string Text { get; }

		/// <summary>Set only when <see cref="Kind"/> is <see cref="DumpValueKind.Boolean"/>.</summary>
		public bool? Boolean { get; }

		public static DumpValue FromNull() => new DumpValue(DumpValueKind.Null, "null");

		public static DumpValue FromText(string text) => new DumpValue(DumpValueKind.Text, text);

		public static DumpValue FromString(string text) => new DumpValue(DumpValueKind.String, text);

		public static DumpValue FromBoolean(bool value, string text) => new DumpValue(DumpValueKind.Boolean, text, value);

		public static DumpValue FromEnum(string text) => new DumpValue(DumpValueKind.Enum, text);
	}
}
