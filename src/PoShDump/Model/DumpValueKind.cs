namespace PoShDump.Model
{
	/// <summary>
	/// What a <see cref="DumpValue"/> holds. The renderer uses it to decide how the value is presented;
	/// it says nothing about the CLR type, which is carried by the member the value belongs to.
	/// </summary>
	public enum DumpValueKind
	{
		/// <summary>The value was null.</summary>
		Null,

		/// <summary>Anything without a presentation of its own: numbers, dates, unreachable objects.</summary>
		Text,

		/// <summary>A string, which is quoted when it is shown.</summary>
		String,

		/// <summary>A boolean. <see cref="DumpValue.Boolean"/> carries which one.</summary>
		Boolean,

		/// <summary>An enum member.</summary>
		Enum
	}
}
