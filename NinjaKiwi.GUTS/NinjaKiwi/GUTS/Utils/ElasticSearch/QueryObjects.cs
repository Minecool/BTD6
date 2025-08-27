namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class QueryObjects
{
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public List<QueryObject> must; //Field offset: 0x10
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public List<QueryObject> must_not; //Field offset: 0x18
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public List<QueryObject> filter; //Field offset: 0x20
	[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
	public List<QueryObject> should; //Field offset: 0x28
	[JsonProperty(DefaultValueHandling = DefaultValueHandling::Ignore (1))]
	public int minimum_should_match; //Field offset: 0x30

	public QueryObjects() { }

	public List<QueryObject> GetQueryObjects(QueryType queryType) { }

	public void Initialize(QueryType queryType) { }

	public void Initialize(QueryType queryType, int minimumShouldMatch) { }

}

