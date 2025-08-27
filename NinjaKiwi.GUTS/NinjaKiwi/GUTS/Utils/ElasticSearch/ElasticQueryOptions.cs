namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class ElasticQueryOptions
{
	public List<Object> sort; //Field offset: 0x10
	public string search_type; //Field offset: 0x18

	public ElasticQueryOptions(SearchType searchType = 0) { }

	public ElasticQueryOptions SortBy(string property, SortType sortType = 1) { }

	public ElasticQueryOptions SortByScore(SortType sortType = 1) { }

	public ElasticQueryOptions SortByScript(string source, SortType sortType = 1) { }

}

