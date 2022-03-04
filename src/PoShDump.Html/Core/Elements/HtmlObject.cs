using System.Xml.Linq;

namespace PoShDump.Html.Core.Elements
{
	public abstract class HtmlObject
	{
		public virtual XObject ToXml()
		{
			return null;
		}

		public override string ToString()
		{
			return "" + ToXml();
		}
	}
}
