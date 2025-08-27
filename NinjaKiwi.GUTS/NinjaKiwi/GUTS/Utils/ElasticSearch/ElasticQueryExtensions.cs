namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

[Extension]
public static class ElasticQueryExtensions
{

	[Extension]
	public static T AddFieldRequirement(T query, string property) { }

	[Extension]
	public static T AddMatch(T query, QueryType queryType, string property, object value, int minimumShouldMatch = 1, bool boostExactMatch = false) { }

	[Extension]
	public static T AddPainlessScript(T query, QueryType queryType, string scriptValue, int minimumShouldMatch = 1) { }

}

