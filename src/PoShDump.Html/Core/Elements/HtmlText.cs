using System.Xml.Linq;

namespace PoShDump.Html.Core.Elements
{
	public class HtmlText : HtmlNode
	{
		public string Text { get; }

		public HtmlText(string text) : base(null)
		{
			Text = text;
		}

		public override XObject ToXml()
		{
			return new XText(Text);
		}
	}
}
