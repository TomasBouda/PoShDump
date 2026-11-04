using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PoShDump.Model
{
	/// <summary>
	/// Writes a dump model as JSON, so that something other than a browser can read a dump. Hand written
	/// rather than taken from a library: netstandard2.0 has no JSON writer of its own, and the module is
	/// not worth another dependency for a few hundred lines of output.
	/// </summary>
	public static class DumpJsonWriter
	{
		/// <summary>
		/// Identifies the payload for a reader and tells it which shape to expect. Raise
		/// <see cref="FormatVersion"/> whenever the shape changes in a way a reader would notice.
		/// </summary>
		public const string FormatName = "poshdump-dump";

		public const int FormatVersion = 1;

		public static string Write(DumpNode root)
		{
			var builder = new StringBuilder();

			builder.Append("{");
			WriteProperty(builder, "format", FormatName);
			builder.Append(",");
			WriteRawProperty(builder, "version", FormatVersion.ToString(CultureInfo.InvariantCulture));
			builder.Append(",");
			WriteName(builder, "root");
			WriteNode(builder, root);
			builder.Append("}");

			return builder.ToString();
		}

		private static void WriteNode(StringBuilder builder, DumpNode node)
		{
			switch (node)
			{
				case DumpObject dumpObject:
					WriteObject(builder, dumpObject);
					break;
				case DumpCollection dumpCollection:
					WriteCollection(builder, dumpCollection);
					break;
				case DumpValue dumpValue:
					WriteValue(builder, dumpValue);
					break;
				default:
					builder.Append("null");
					break;
			}
		}

		private static void WriteObject(StringBuilder builder, DumpObject dumpObject)
		{
			builder.Append("{");
			WriteProperty(builder, "kind", "object");
			builder.Append(",");
			WriteProperty(builder, "typeName", dumpObject.TypeName);
			builder.Append(",");
			WriteProperty(builder, "summary", dumpObject.Summary);
			builder.Append(",");
			WriteRawProperty(builder, "exception", Boolean(dumpObject.IsException));
			builder.Append(",");
			WriteRawProperty(builder, "collapsed", Boolean(dumpObject.Collapsed));
			builder.Append(",");
			WriteName(builder, "members");

			builder.Append("[");
			for (var i = 0; i < dumpObject.Members.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(",");
				}

				var member = dumpObject.Members[i];

				builder.Append("{");
				WriteProperty(builder, "name", member.Name);
				builder.Append(",");
				WriteProperty(builder, "typeName", member.TypeName);
				builder.Append(",");
				WriteName(builder, "value");
				WriteNode(builder, member.Value);
				builder.Append("}");
			}

			builder.Append("]}");
		}

		private static void WriteCollection(StringBuilder builder, DumpCollection dumpCollection)
		{
			builder.Append("{");
			WriteProperty(builder, "kind", "collection");
			builder.Append(",");
			WriteProperty(builder, "typeName", dumpCollection.TypeName);
			builder.Append(",");
			WriteRawProperty(builder, "count", dumpCollection.Count.ToString(CultureInfo.InvariantCulture));
			builder.Append(",");
			WriteRawProperty(builder, "collapsed", Boolean(dumpCollection.Collapsed));
			builder.Append(",");
			WriteName(builder, "columns");

			builder.Append("[");
			for (var i = 0; i < dumpCollection.Columns.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(",");
				}

				var column = dumpCollection.Columns[i];

				builder.Append("{");
				WriteProperty(builder, "name", column.Name);
				builder.Append(",");
				WriteProperty(builder, "typeName", column.TypeName);
				builder.Append("}");
			}

			builder.Append("],");
			WriteName(builder, "rows");
			WriteRows(builder, dumpCollection.Rows);
			builder.Append("}");
		}

		private static void WriteRows(StringBuilder builder, IList<DumpRow> rows)
		{
			builder.Append("[");
			for (var i = 0; i < rows.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(",");
				}

				var cells = rows[i].Cells;

				builder.Append("[");
				for (var cell = 0; cell < cells.Count; cell++)
				{
					if (cell > 0)
					{
						builder.Append(",");
					}

					WriteNode(builder, cells[cell]);
				}

				builder.Append("]");
			}

			builder.Append("]");
		}

		private static void WriteValue(StringBuilder builder, DumpValue value)
		{
			builder.Append("{");
			WriteProperty(builder, "kind", "value");
			builder.Append(",");
			WriteProperty(builder, "valueKind", value.Kind.ToString().ToLowerInvariant());
			builder.Append(",");
			WriteProperty(builder, "text", value.Text);

			if (value.Boolean.HasValue)
			{
				builder.Append(",");
				WriteRawProperty(builder, "boolean", Boolean(value.Boolean.Value));
			}

			builder.Append("}");
		}

		private static string Boolean(bool value)
		{
			return value ? "true" : "false";
		}

		private static void WriteName(StringBuilder builder, string name)
		{
			WriteString(builder, name);
			builder.Append(":");
		}

		private static void WriteProperty(StringBuilder builder, string name, string value)
		{
			WriteName(builder, name);
			WriteString(builder, value);
		}

		private static void WriteRawProperty(StringBuilder builder, string name, string value)
		{
			WriteName(builder, name);
			builder.Append(value);
		}

		private static void WriteString(StringBuilder builder, string value)
		{
			if (value == null)
			{
				builder.Append("null");
				return;
			}

			builder.Append(Quote);

			foreach (var character in value)
			{
				switch (character)
				{
					case Quote:
						builder.Append(Backslash).Append(Quote);
						break;
					case Backslash:
						builder.Append(Backslash).Append(Backslash);
						break;
					// The payload is embedded in a <script> element, where a literal "</script>" would end
					// it early. Escaping the angle brackets and the ampersand keeps the page intact whatever
					// the dumped data contains.
					case '<':
					case '>':
					case '&':
						AppendEscaped(builder, character);
						break;
					default:
						// Control characters and the two line separators that break JavaScript string
						// literals are escaped; everything else is written as it is, because the file is
						// UTF-8 and a reader needs no help with the rest.
						if (character < Space || character == LineSeparator || character == ParagraphSeparator)
						{
							AppendEscaped(builder, character);
						}
						else
						{
							builder.Append(character);
						}

						break;
				}
			}

			builder.Append(Quote);
		}

		private static void AppendEscaped(StringBuilder builder, char character)
		{
			builder
				.Append(Backslash)
				.Append('u')
				.Append(((int)character).ToString("x4", CultureInfo.InvariantCulture));
		}

		private const char Quote = '"';
		private const char Backslash = (char)92;
		private const char Space = (char)32;
		private const char LineSeparator = (char)0x2028;
		private const char ParagraphSeparator = (char)0x2029;
	}
}
