namespace UnityEngine.Purchasing.MiniJSON;

[Extension]
public static class MiniJsonExtensions
{

	[Extension]
	public static List<Object> ArrayListFromJson(string json) { }

	[Extension]
	public static string GetString(Dictionary<String, Object> dic, string key, string defaultValue = "") { }

	[Extension]
	public static Dictionary<String, Object> HashtableFromJson(string json) { }

	[Extension]
	public static string toJson(Dictionary<String, Object> obj) { }

	[Extension]
	public static string toJson(Dictionary<String, String> obj) { }

}

