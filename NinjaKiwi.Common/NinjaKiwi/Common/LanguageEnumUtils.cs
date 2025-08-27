namespace NinjaKiwi.Common;

[Extension]
public static class LanguageEnumUtils
{

	[Extension]
	public static Language Convert(SystemLanguage systemLanguage) { }

	public static Language GetLanguageFromBCP47(string language, string country, string variant) { }

	[Extension]
	public static string IETFTag(Language language) { }

	[Extension]
	public static bool IsRTLLanguage(Language language) { }

	private static Language SwitchChinese(string country, string variant) { }

	private static Language SwitchFrench(string country) { }

	private static Language SwitchPortuguese(string country) { }

	private static Language SwitchSpanish(string country) { }

}

