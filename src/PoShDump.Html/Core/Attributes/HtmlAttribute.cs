using System.Xml.Linq;
using PoShDump.Html.Core.Elements;

namespace PoShDump.Html.Core.Attributes
{
	public class HtmlAttribute : HtmlObject
	{
		public string Name { get; }

		public string Value { get; }

		public HtmlAttribute(string name, string value)
		{
			Name = name ?? throw new System.ArgumentNullException(nameof(name));

			Value = value;
		}

		public override XObject ToXml()
		{
			return new XAttribute(Name, Value ?? string.Empty);
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode() ^ (Value?.GetHashCode() ?? string.Empty.GetHashCode());
		}
	}
}
