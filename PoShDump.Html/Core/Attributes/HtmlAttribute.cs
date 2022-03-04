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
			Name = name;
			Value = value;
		}

		public override XObject ToXml()
		{
			return new XAttribute(Name, Value);
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode() ^ Value.GetHashCode();
		}
	}
}
