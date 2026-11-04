using PoShDump.Html.Core.Attributes;
using PoShDump.Html.Core.Elements;
using PoShDump.Html.Extensions;
using PoShDump.Html.Helpers;
using PoShDump.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PoShDump.Html
{
	/// <summary>
	/// Renders a <see cref="DumpNode"/> tree as HTML. It knows nothing about PowerShell; everything it needs
	/// is already in the model.
	/// </summary>
	public class DumpHtmlRenderer
	{
		public HtmlNode Render(DumpNode node)
		{
			switch (node)
			{
				case DumpObject dumpObject:
					return RenderObject(dumpObject);
				case DumpCollection dumpCollection:
					return RenderCollection(dumpCollection);
				case DumpValue dumpValue:
					return RenderValue(dumpValue);
				default:
					throw new ArgumentOutOfRangeException(nameof(node), $"Unknown dump node: {node?.GetType().Name ?? "null"}.");
			}
		}

		private HtmlNode RenderObject(DumpObject dumpObject)
		{
			var header = H.thead(
				H.th(ToggleControl(), H.nbsp(), dumpObject.TypeName).WithAttributes(a => a.colspan(2)));

			if (dumpObject.Summary != null)
			{
				header.AddChild(H.tr(H.th(dumpObject.Summary).WithAttributes(a => a.colspan(2))));
			}

			var rows = dumpObject.Members
				.Select(member => H.tr(
					H.td(H.span(member.Name)).WithAttributes(a => a.title(member.TypeName)),
					H.td(Render(member.Value))))
				.ToList();

			var tableClass = dumpObject.IsException ? "tbl-exception" : "tbl-object";

			return H.table(header, H.tbody(rows))
				.WithAttributes(a => a.@class(TableClass(tableClass, dumpObject.Collapsed)));
		}

		private HtmlNode RenderCollection(DumpCollection dumpCollection)
		{
			if (!dumpCollection.Columns.Any())
			{
				return H.div("No elements");
			}

			var caption = H.tr(H.th(ToggleControl(), H.nbsp(), $"{dumpCollection.TypeName} ({dumpCollection.Count})")
				.WithAttributes(a => a.colspan(dumpCollection.Columns.Count)));

			var headers = dumpCollection.Columns
				.Select(column => H.th(column.Name).WithAttributes(a => a.title(column.TypeName)));

			var rows = dumpCollection.Rows
				.Select(row => H.tr(row.Cells.Select(cell => H.td(Render(cell))).ToList()))
				.ToList();

			return H.table(H.thead(caption, headers), H.tbody(rows))
				.WithAttributes(a => a.@class(TableClass("tbl-collection", dumpCollection.Collapsed)));
		}

		private static HtmlNode RenderValue(DumpValue value)
		{
			switch (value.Kind)
			{
				case DumpValueKind.Null:
					return H.span(value.Text).WithAttributes(a => a.@class("value-null"));
				case DumpValueKind.String:
					return H.span(value.Text).WithAttributes(a => a.@class("value-string"));
				case DumpValueKind.Boolean:
					return H.span(value.Text)
						.WithAttributes(a => a.@class($"value-{value.Boolean.ToString().ToLower()}"));
				case DumpValueKind.Enum:
					return H.span(value.Text, H.nbsp()).WithAttributes(a => a.@class("value-enum"));
				default:
					return H.text(value.Text);
			}
		}

		private static HtmlElement ToggleControl()
		{
			return H.span("[-]").WithAttributes(a => a.@class("toggle").title("Collapse or expand"));
		}

		private static string TableClass(string name, bool collapsed)
		{
			return $"{name} {(collapsed ? "collapsed" : "")}";
		}
	}
}
