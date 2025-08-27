namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class QueryObjectTerm : QueryObject
{
	public Dictionary<String, BoostSettings> term; //Field offset: 0x10

	public QueryObjectTerm() { }

}

