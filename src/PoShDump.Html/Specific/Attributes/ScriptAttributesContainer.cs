using PoShDump.Html.Core.Attributes;

namespace PoShDump.Html.Specific.Attributes
{
	public class ScriptAttributesContainer : HtmlAttributesContainer<ScriptAttributesContainer>, IHtmlAttributesContainer
	{
		public ScriptAttributesContainer()
		{
			Parent = this;
		}

		public ScriptAttributesContainer async() => Add(nameof(async), "");
		public ScriptAttributesContainer crossorigin(string value) => Add(nameof(crossorigin), value);
		public ScriptAttributesContainer defer(string value) => Add(nameof(defer), value);
		public ScriptAttributesContainer integrity(string value) => Add(nameof(integrity), value);
		public ScriptAttributesContainer nomodule(bool value) => Add(nameof(nomodule), value);
		public ScriptAttributesContainer referrerpolicy(string value) => Add(nameof(referrerpolicy), value);
		public ScriptAttributesContainer src(string value) => Add(nameof(src), value);
		public ScriptAttributesContainer type(string value) => Add(nameof(type), value);
	}
}
