namespace PoShDump.Html.Core.Attributes
{
	public static class HtmlAttributeExtensionsBase
	{
		public static IAttributeContainer<T> Custom<T>(this IAttributeContainer<T> attributes, string name, object value) where T : HtmlAttribute, new()
		{
			return attributes.Add(name, value);
		}
	}
}
