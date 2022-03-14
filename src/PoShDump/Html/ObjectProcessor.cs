using PoShDump.Html.Core.Attributes;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace PoShDump.Html
{
	public class ObjectProcessor
	{
		private readonly HtmlElement ARROW_DOWN = H.fa("fa-solid fa-square-caret-down");

		private List<string> IgnoredTypes { get; }

		public ObjectProcessor()
		{
			IgnoredTypes = new List<string>
			{
				"System.DateTime",
				"System.String"
			};
		}

		public HtmlElement DumpObject(object inputObject, int depth, bool collapsed = false, string tableClass = "tbl-object")
		{
			var inputType = inputObject.GetType();
			var header = H.thead(
				H.th(ARROW_DOWN, H.nbsp(), inputType.Name).WithAttributes(a => a.colspan(2))
				);

			if (inputObject is Exception ex)
			{
				header.AddChild(H.tr(H.th(ex.Message)
					.WithAttributes(a => a.colspan(2))));
			}
			else if (inputObject.ToString().Length <= 50)
			{
				header.AddChild(H.tr(H.th(inputObject.ToString())
					.WithAttributes(a => a.colspan(2))));
			}

			var tableRows = new List<HtmlElement>();
			var properties = inputType
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.GetMethod != null)
				.OrderBy(p => p.Name);

			if (properties.Any())
			{
				foreach (var property in properties)
				{
					tableRows.Add(H.tr(
						H.td(H.span(property.Name)).WithAttributes(a => a.title(property.PropertyType.FullName)),
									H.td(DumpPropertyValue(inputObject, property, depth, true))
						));
				}
			}

			return H.table(header, H.tbody(tableRows)).WithAttributes(a => a.@class($"{tableClass} {(collapsed ? "collapsed" : "")}"));
		}

		public HtmlElement DumpCollection(IEnumerable inputCollection, int depth, bool collapsed = false, string tableClass = "tbl-collection")
		{
			var tableRows = new List<HtmlElement>();
			var collectionType = inputCollection.GetType();
			List<PropertyInfo> properties = null;
			int count = 0;

			foreach (var collectionItem in inputCollection)
			{
				if (properties == null)
				{
					properties = collectionItem.GetType()
						.GetProperties(BindingFlags.Public | BindingFlags.Instance)
						.Where(p => p.GetMethod != null)
						.OrderBy(p => p.Name)
						.ToList();
				}

				var cells = new List<td>();
				foreach (var property in properties)
				{
					cells.Add(H.td(DumpPropertyValue(collectionItem, property, depth - 1, true)));
				}

				tableRows.Add(H.tr(cells));

				count++;
			}

			var headers = properties.Select(p => H.th(H.span(p.Name)).WithAttributes(a => a.title(p.PropertyType.FullName)));
			var objectInfo = H.tr(H.th(ARROW_DOWN, H.nbsp(), $"{collectionType.Name} ({count})").WithAttributes(a => a.colspan(properties.Count)));
			var thead = H.thead(objectInfo, headers);

			return H.table(thead, H.tbody(tableRows)).WithAttributes(t => t.@class($"{tableClass} {(collapsed ? "collapsed" : "")}"));
		}

		public HtmlNode DumpPropertyValue(object inputObject, PropertyInfo property, int depth, bool collapsed)
		{
			try
			{
				var value = inputObject.GetType().GetProperty(property.Name)?.GetValue(inputObject);

				if (value == null)
				{
					return H.span("null").WithAttributes(a => a.@class("value-null"));
				}

				var valueType = property.PropertyType;
				var encodedStringValue = HttpUtility.HtmlEncode(value.ToString().Trim());

				if (!valueType.IsPrimitive && !IgnoredTypes.Any(t => t.Equals(valueType.FullName)))
				{
					if (valueType.BaseType == typeof(Enum))
					{
						//var infoButton = H.a(H.fa("fa-solid fa-circle-info")).WithAttributes(a =>
						//	a.href($"https://docs.microsoft.com/cs-cz/dotnet/api/{valueType.FullName}")
						//		.target("_blank"));
						return H.span(encodedStringValue, H.nbsp()).WithAttributes(a => a.@class("value-enum").title("docs"));
					}
					else if (depth > 0)
					{
						if (value is IEnumerable enumerable)
						{
							return DumpCollection(enumerable, depth - 1, collapsed);
						}
						else
						{
							return DumpObject(value, depth - 1, collapsed);
						}
					}
				}
				else if (value is string)
				{
					return H.span(encodedStringValue).WithAttributes(a => a.@class("value-string"));
				}
				else if (value is bool booleanValue)
				{
					return H.span(encodedStringValue).WithAttributes(a => a.@class($"value-{booleanValue.ToString().ToLower()}"));
				}

				return H.text(encodedStringValue);
			}
			catch (TargetInvocationException tix)
			{
				if (depth > 0)
				{
					return DumpObject(tix.InnerException, depth - 1, collapsed, "tbl-exception");
				}
				else
				{
					return H.text(tix.Message);
				}
			}
			catch (Exception ex)
			{
				if (depth > 0)
				{
					return DumpObject(ex, depth - 1, collapsed, "tbl-exception");
				}
				else
				{
					return H.text(ex.Message);
				}
			}
		}
	}
}
