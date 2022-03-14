using PoShDump.Html.Core.Elements;
using System.Xml.Linq;

namespace PoShDump.Html.Core.Attributes
{
	public class HtmlAttribute : HtmlObject
	{
		public string Name { get; }

		public string Value { get; }

		public HtmlAttribute()
		{

		}

		public HtmlAttribute(string name, object value)
		{
			Name = name ?? throw new System.ArgumentNullException(nameof(name));

			Value = value?.ToString();
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
