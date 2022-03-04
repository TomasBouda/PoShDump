using System.Collections.Generic;

namespace PoShDump.Html.Core.Attributes
{
	public abstract class BaseHtmlAttributeContainer
	{
		public HashSet<HtmlAttribute> Attributes { get; } = new HashSet<HtmlAttribute>();
	}

	public abstract class HtmlAttributesContainer<T> : BaseHtmlAttributeContainer
		where T : IHtmlAttributesContainer, new()
	{
		public T Parent { get; protected set; }

		public virtual T Add(string name, object value)
		{
			if (name == null) { throw new System.ArgumentNullException(nameof(name)); }

			Attributes.Add(new HtmlAttribute(name, value?.ToString()));

			return Parent;
		}

		public virtual T accesskey(string value) => Add(nameof(accesskey), value);
		public virtual T @class(string value) => Add(nameof(@class), value);
		public virtual T contenteditable(string value) => Add(nameof(contenteditable), value);
		public virtual T dir(string value) => Add(nameof(dir), value);
		public virtual T draggable(string value) => Add(nameof(draggable), value);
		public virtual T hidden(string value) => Add(nameof(hidden), value);
		public virtual T id(string value) => Add(nameof(id), value);
		public virtual T lang(string value) => Add(nameof(lang), value);
		public virtual T spellcheck(string value) => Add(nameof(spellcheck), value);
		public virtual T slot(string value) => Add(nameof(slot), value);
		public virtual T style(string value) => Add(nameof(style), value);
		public virtual T tabindex(string value) => Add(nameof(tabindex), value);
		public virtual T title(string value) => Add(nameof(title), value);
		public virtual T translate(string value) => Add(nameof(translate), value);
	}

	public sealed class HtmlAttributeContainer : HtmlAttributesContainer<HtmlAttributeContainer>, IHtmlAttributesContainer
	{
		public HtmlAttributeContainer()
		{
			Parent = this;
		}
	}
}
