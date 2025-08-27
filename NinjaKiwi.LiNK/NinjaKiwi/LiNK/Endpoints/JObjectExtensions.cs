namespace NinjaKiwi.LiNK.Endpoints;

[Extension]
internal static class JObjectExtensions
{

	[Extension]
	public static void AddArrayIfNotEmpty(JObject jObject, string propertyName, IEnumerable<T> value) { }

	[Extension]
	public static void AddArrayIfNotNull(JObject jObject, string propertyName, IEnumerable<T> value) { }

	[Extension]
	public static void AddIfNotNull(JObject jObject, string propertyName, string value) { }

	[Extension]
	public static void AddIfTrue(JObject jObject, string propertyName, bool value) { }

}

