namespace PoShDump.Model
{
	/// <summary>
	/// One property of a dumped object: the name and declared type the pipeline reported, and the value.
	/// </summary>
	public sealed class DumpMember
	{
		public DumpMember(string name, string typeName, DumpNode value)
		{
			Name = name;
			TypeName = typeName;
			Value = value;
		}

		public string Name { get; }

		/// <summary>The type PowerShell reports for the property, shown as the cell's tooltip.</summary>
		public string TypeName { get; }

		public DumpNode Value { get; }
	}
}
