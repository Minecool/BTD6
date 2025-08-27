namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class ContentBrowserTrendingQuery : ContentBrowserQuery
{
	internal class Trending
	{
		public Int32[] dayWeights; //Field offset: 0x10

		public Trending() { }

	}

	public Trending trending; //Field offset: 0x20

	public ContentBrowserTrendingQuery(Int32[] dayWeights, AdvancedSearchValues advancedSearchValues, ContentType contentType, bool includeSillyChallenges) { }

}

