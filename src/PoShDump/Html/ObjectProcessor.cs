using Dasync.Collections;
using PoShDump.Html.Core.Attributes;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Extensions;
using PoShDump.Html.Helpers;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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

		public async Task<HtmlElement> DumpObject(object inputObject, int depth, bool collapsed = false, string tableClass = "tbl-object")
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

			var tableRows = new ConcurrentBag<HtmlElement>();
			var properties = inputType
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.GetMethod != null)
				.OrderBy(p => p.Name)
				.ToList();

			if (properties.Any())
			{
				await properties.ParallelForEachAsync(async property =>
				{
					tableRows.Add(H.tr(
						H.td(H.span(property.Name)).WithAttributes(a => a.title(property.PropertyType.FullName)),
						H.td(await DumpPropertyValue(inputObject, property, depth, true))
					));
				});
			}

			return H.table(header, H.tbody(tableRows)).WithAttributes(a => a.@class($"{tableClass} {(collapsed ? "collapsed" : "")}"));
		}

		public async Task<HtmlElement> DumpCollection(IEnumerable inputCollection, int depth, bool collapsed = false, string tableClass = "tbl-collection")
		{
			var tableRows = new ConcurrentBag<HtmlElement>();
			var collectionType = inputCollection.GetType();
			int count = 0;

			var objectCollection = inputCollection.Cast<object>().ToList();
			var firstItem = objectCollection.First();
			if (firstItem == null)
				return H.div("No elements");

			var properties = firstItem.GetType()
				.GetProperties(BindingFlags.Public | BindingFlags.Instance)
				.Where(p => p.GetMethod != null)
				.OrderBy(p => p.Name)
				.ToList();


			await objectCollection.ParallelForEachAsync(async objectToDump =>
			{
				var cells = new List<td>();
				foreach (var property in properties)
				{
					cells.Add(H.td(await DumpPropertyValue(objectToDump, property, depth - 1, true)));
				}

				tableRows.Add(H.tr(cells));

				count++;
			});

			var headers = properties.Select(p => H.th(p.Name).WithAttributes(a => a.title(p.PropertyType.FullName)));
			var objectInfo = H.tr(H.th(ARROW_DOWN, H.nbsp(), $"{collectionType.Name} ({count})").WithAttributes(a => a.colspan(properties.Count)));
			var thead = H.thead(objectInfo, headers);

			return H.table(thead, H.tbody(tableRows)).WithAttributes(t => t.@class($"{tableClass} {(collapsed ? "collapsed" : "")}"));
		}

		public async Task<HtmlNode> DumpPropertyValue(object inputObject, PropertyInfo property, int depth, bool collapsed)
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
						return H.span(encodedStringValue, H.nbsp()).WithAttributes(a => a.@class("value-enum"));
					}
					else if (depth > 0)
					{
						if (value is IEnumerable enumerable)
						{
							return await DumpCollection(enumerable, depth - 1, collapsed);
						}
						else
						{
							return await DumpObject(value, depth - 1, collapsed);
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
					return await DumpObject(tix.InnerException, depth - 1, collapsed, "tbl-exception");
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
					return await DumpObject(ex, depth - 1, collapsed, "tbl-exception");
				}
				else
				{
					return H.text(ex.Message);
				}
			}
		}
	}
}
