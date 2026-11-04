using PoShDump.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

namespace PoShDump.Dump
{
	/// <summary>
	/// Turns a PowerShell object into a <see cref="DumpNode"/> tree. This is the only part of PoShDump that
	/// touches <see cref="PSObject"/>; everything downstream works on the model.
	/// </summary>
	public class ObjectWalker
	{
		/// <summary>
		/// Types that are not primitive but are still shown as a single value rather than opened up.
		/// </summary>
		private static readonly string[] AtomicTypes =
		{
			"System.DateTime",
			"System.String"
		};

		/// <summary>
		/// A summary longer than this is noise rather than a label, so it is left out.
		/// </summary>
		private const int MaximumSummaryLength = 50;

		public DumpObject WalkObject(object inputObject, int depth)
		{
			return WalkObject(inputObject, depth, false, false);
		}

		public DumpCollection WalkCollection(IEnumerable inputCollection, int depth)
		{
			return WalkCollection(inputCollection, depth, false);
		}

		private DumpObject WalkObject(object inputObject, int depth, bool collapsed, bool isException)
		{
			var displayObject = GetBaseObject(inputObject);
			var members = GetProperties(inputObject)
				.Select(property => new DumpMember(property.Name, property.TypeName, WalkValue(property, depth, true)))
				.ToList();

			return new DumpObject(displayObject.GetType().Name, GetSummary(displayObject), members, collapsed, isException);
		}

		private DumpCollection WalkCollection(IEnumerable inputCollection, int depth, bool collapsed)
		{
			var typeName = inputCollection.GetType().Name;
			var items = inputCollection.Cast<object>().ToList();
			var firstItem = items.FirstOrDefault();

			if (firstItem == null)
			{
				// Nothing to take the columns from, so the table has none.
				return new DumpCollection(typeName, items.Count, null, null, collapsed);
			}

			// The first item decides the columns: a pipeline hands over objects of one shape.
			var properties = GetProperties(firstItem);

			var columns = properties
				.Select(property => new DumpColumn(property.Name, property.TypeName))
				.ToList();

			var rows = items
				.Select(item => new DumpRow(properties
					.Select(property => WalkValue(property.ForObject(item), depth - 1, true))
					.ToList()))
				.ToList();

			return new DumpCollection(typeName, items.Count, columns, rows, collapsed);
		}

		private DumpNode WalkValue(DumpProperty property, int depth, bool collapsed)
		{
			try
			{
				var value = property.GetValue();

				if (value == null)
				{
					return DumpValue.FromNull();
				}

				var valueType = GetBaseObject(value).GetType();
				var text = value.ToString().Trim();

				if (!valueType.IsPrimitive && !AtomicTypes.Contains(valueType.FullName))
				{
					if (valueType.IsEnum)
					{
						return DumpValue.FromEnum(text);
					}

					if (depth > 0)
					{
						return value is IEnumerable enumerable
							? (DumpNode)WalkCollection(enumerable, depth - 1, collapsed)
							: WalkObject(value, depth - 1, collapsed, false);
					}
				}
				else if (value is string)
				{
					return DumpValue.FromString(text);
				}
				else if (value is bool booleanValue)
				{
					return DumpValue.FromBoolean(booleanValue, text);
				}

				return DumpValue.FromText(text);
			}
			catch (TargetInvocationException exception)
			{
				return WalkFailure(exception.InnerException, exception.Message, depth, collapsed);
			}
			catch (Exception exception)
			{
				return WalkFailure(exception, exception.Message, depth, collapsed);
			}
		}

		/// <summary>
		/// A property that threw when it was read. With depth left the exception is dumped like any other
		/// object, so the reason is visible; otherwise only its message is.
		/// </summary>
		private DumpNode WalkFailure(Exception exception, string message, int depth, bool collapsed)
		{
			return depth > 0
				? (DumpNode)WalkObject(exception, depth - 1, collapsed, true)
				: DumpValue.FromText(message);
		}

		private static string GetSummary(object displayObject)
		{
			if (displayObject is Exception exception)
			{
				return exception.Message;
			}

			var text = displayObject.ToString();

			return text.Length <= MaximumSummaryLength ? text : null;
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

		/// <summary>
		/// A property of one object, read lazily so that a property which throws can be caught per value.
		/// </summary>
		private class DumpProperty
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

			/// <summary>The same property read from another item of the same collection.</summary>
			public DumpProperty ForObject(object inputObject)
			{
				var psObject = inputObject as PSObject ?? PSObject.AsPSObject(inputObject);
				var property = psObject.Properties[Name];

				return new DumpProperty(inputObject, Name, property?.TypeNameOfValue ?? TypeName);
			}
		}
	}
}
