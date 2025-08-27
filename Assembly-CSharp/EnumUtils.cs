//Type is in global namespace

[Extension]
public static class EnumUtils
{

	[Extension]
	public static T GetAttribute(Enum enumValue) { }

	public static T[] GetValues() { }

	[Extension]
	public static bool TryGetAttribute(Enum enumValue, out T attribute) { }

}

