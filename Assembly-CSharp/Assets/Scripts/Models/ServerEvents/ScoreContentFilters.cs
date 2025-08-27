namespace Assets.Scripts.Models.ServerEvents;

public class ScoreContentFilters
{
	public ContentFilterLevel adult; //Field offset: 0x10
	public ContentFilterLevel codeSearch; //Field offset: 0x14
	public ContentFilterLevel child; //Field offset: 0x18

	public static ScoreContentFilters Default
	{
		 get { } //Length: 89
	}

	public ScoreContentFilters(ContentFilterLevel theOneRule) { }

	[JsonConstructor]
	public ScoreContentFilters(ContentFilterLevel adult, ContentFilterLevel codeSearch, ContentFilterLevel child) { }

	public static ScoreContentFilters get_Default() { }

}

