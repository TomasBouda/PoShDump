namespace PoShDump.Model
{
	/// <summary>
	/// One node of a dump. A dump is a tree of these: a walker builds it from a PowerShell object, and a
	/// renderer turns it into HTML or JSON. Nothing in this namespace knows about either.
	/// </summary>
	public abstract class DumpNode
	{
	}
}
