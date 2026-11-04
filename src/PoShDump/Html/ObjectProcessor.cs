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
using System.Management.Automation;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;

namespace PoShDump.Html
{
	public class ObjectProcessor
	{
		private List<string> IgnoredTypes { get; }

		public ObjectProcessor()
		{
			IgnoredTypes = new List<string>
			{
				"System.DateTime",
				"System.String"
			};
		}

		public async Task<HtmlElement> DumpObjectAsync(object inputObject, int depth, bool collapsed = false, string tableClass = "tbl-object")
		{
			var displayObject = GetBaseObject(inputObject);
			var inputType = displayObject.GetType();
			var header = H.thead(
				H.th(ToggleControl(), H.nbsp(), inputType.Name).WithAttributes(a => a.colspan(2))
				);

			if (displayObject is Exception ex)
			{
				header.AddChild(H.tr(H.th(ex.Message)
					.WithAttributes(a => a.colspan(2))));
			}
			else if (displayObject.ToString().Length <= 50)
			{
				header.AddChild(H.tr(H.th(displayObject.ToString())
					.WithAttributes(a => a.colspan(2))));
			}

			var tableRows = new List<HtmlElement>();
			var properties = GetProperties(inputObject);

			if (properties.Any())
			{
				foreach (var property in properties)
				{
					tableRows.Add(H.tr(
						H.td(H.span(property.Name)).WithAttributes(a => a.title(property.TypeName)),
						H.td(await DumpPropertyValue(property, depth, true))
					));
				}
			}

			return H.table(header, H.tbody(tableRows)).WithAttributes(a => a.@class($"{tableClass} {(collapsed ? "collapsed" : "")}"));
		}

		public async Task<HtmlElement> DumpCollectionAsync(IEnumerable inputCollection, int depth, bool collapsed = false, string tableClass = "tbl-collection")
		{
			var tableRows = new List<HtmlElement>();
			var collectionType = inputCollection.GetType();

			var objectCollection = inputCollection.Cast<object>().ToList();
			var firstItem = objectCollection.FirstOrDefault();
			if (firstItem == null)
				return H.div("No elements");

			var properties = GetProperties(firstItem);


			foreach (var objectToDump in objectCollection)
			{
				var cells = new List<td>();
				foreach (var property in properties)
				{
					cells.Add(H.td(await DumpPropertyValue(property.ForObject(objectToDump), depth - 1, true)));
				}

				tableRows.Add(H.tr(cells));
			}

			var headers = properties.Select(p => H.th(p.Name).WithAttributes(a => a.title(p.TypeName)));
			var objectInfo = H.tr(H.th(ToggleControl(), H.nbsp(), $"{collectionType.Name} ({objectCollection.Count})").WithAttributes(a => a.colspan(properties.Count)));
			var thead = H.thead(objectInfo, headers);

			return H.table(thead, H.tbody(tableRows)).WithAttributes(t => t.@class($"{tableClass} {(collapsed ? "collapsed" : "")}"));
		}

		private static HtmlElement ToggleControl()
		{
			return H.span("[-]").WithAttributes(a => a.@class("toggle").title("Collapse or expand"));
		}

		public async Task<HtmlNode> DumpPropertyValue(DumpProperty property, int depth, bool collapsed)
		{
			try
			{
				var value = property.GetValue();

				if (value == null)
				{
					return H.span("null").WithAttributes(a => a.@class("value-null"));
				}

				var valueType = GetBaseObject(value).GetType();
				var stringValue = value.ToString().Trim();

				if (!valueType.IsPrimitive && !IgnoredTypes.Any(t => t.Equals(valueType.FullName)))
				{
					if (valueType.IsEnum)
					{
						return H.span(stringValue, H.nbsp()).WithAttributes(a => a.@class("value-enum"));
					}
					else if (depth > 0)
					{
						if (value is IEnumerable enumerable)
						{
							return await DumpCollectionAsync(enumerable, depth - 1, collapsed);
						}
						else
						{
							return await DumpObjectAsync(value, depth - 1, collapsed);
						}
					}
				}
				else if (value is string)
				{
					return H.span(stringValue).WithAttributes(a => a.@class("value-string"));
				}
				else if (value is bool booleanValue)
				{
					return H.span(stringValue).WithAttributes(a => a.@class($"value-{booleanValue.ToString().ToLower()}"));
				}

				return H.text(stringValue);
			}
			catch (TargetInvocationException tix)
			{
				if (depth > 0)
				{
					return await DumpObjectAsync(tix.InnerException, depth - 1, collapsed, "tbl-exception");
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
					return await DumpObjectAsync(ex, depth - 1, collapsed, "tbl-exception");
				}
				else
				{
					return H.text(ex.Message);
				}
			}
		}

		private static object GetBaseObject(object inputObject)
		{
			return (inputObject as PSObject)?.BaseObject ?? inputObject;
		}

		private static List<DumpProperty> GetProperties(object inputObject)
		{
			var psObject = inputObject as PSObject ?? PSObject.AsPSObject(inputObject);

			return psObject.Properties
				.Where(p => p.IsGettable)
				.Select(p => new DumpProperty(inputObject, p.Name, p.TypeNameOfValue))
				.ToList();
		}

		public class DumpProperty
		{
			private readonly object _inputObject;

			public DumpProperty(object inputObject, string name, string typeName)
			{
				_inputObject = inputObject;
				Name = name;
				TypeName = typeName;
			}

			public string Name { get; }
			public string TypeName { get; }

			public object GetValue()
			{
				var psObject = _inputObject as PSObject ?? PSObject.AsPSObject(_inputObject);

				return psObject.Properties[Name].Value;
			}

			public DumpProperty ForObject(object inputObject)
			{
				var psObject = inputObject as PSObject ?? PSObject.AsPSObject(inputObject);
				var property = psObject.Properties[Name];

				return new DumpProperty(inputObject, Name, property?.TypeNameOfValue ?? TypeName);
			}
		}
	}
}
