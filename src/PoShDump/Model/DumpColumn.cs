namespace PoShDump.Model
{
	/// <summary>
	/// One column of a dumped collection, taken from the properties of its first item.
	/// </summary>
	public sealed class DumpColumn
	{
		public DumpColumn(string name, string typeName)
		{
			Name = name;
			TypeName = typeName;
		}

		public string Name { get; }

		public string TypeName { get; }
	}
}
