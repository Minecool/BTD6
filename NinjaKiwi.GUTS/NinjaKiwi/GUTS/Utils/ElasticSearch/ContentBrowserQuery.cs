namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class ContentBrowserQuery : ElasticQuery
{
	[CompilerGenerated]
	private ContentType <ContentType>k__BackingField; //Field offset: 0x18

	[JsonIgnore]
	public private ContentType ContentType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ContentBrowserQuery(ContentType contentType) { }

	public ContentBrowserQuery(AdvancedSearchValues advancedSearchValues, ContentType contentType, bool includeSillyChallenges, bool isIdListQuery = false) { }

	[CompilerGenerated]
	public ContentType get_ContentType() { }

	private static string GetRoundsFilter(string comparer, int roundCount) { }

	private static string GetTimeFilter(AdvancedSearchValues advancedSearchValues, AdvSearchTimeSpan timeSpan) { }

	private string GetVersionFilter(AdvancedSearchValues advancedSearchValues) { }

	[CompilerGenerated]
	private void set_ContentType(ContentType value) { }

}

