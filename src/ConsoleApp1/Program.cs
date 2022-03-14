// See https://aka.ms/new-console-template for more information

using PoShDump.Html.Core.Attributes;
using PoShDump.Html.Helpers;

H.a("abcd").WithAttributes(a => a.href("asd").title("ahoj").hreflang("dd")).ToConsole();

H.script("abcd").WithAttributes(d => d.title("")).ToConsole();

H.a("test").ToConsole();


public static class ext
{
	public enum test
	{
		One,
		Two,
		Three
	}
	public static void ToConsole(this object str)
	{
		Console.WriteLine(str);
	}
}