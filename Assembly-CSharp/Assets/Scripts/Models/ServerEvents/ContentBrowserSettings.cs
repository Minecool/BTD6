namespace Assets.Scripts.Models.ServerEvents;

public class ContentBrowserSettings
{
	public int maxSaves; //Field offset: 0x10
	public String[][] verifiedAccounts; //Field offset: 0x18
	public bool canHkrsCreate; //Field offset: 0x20
	public bool requireAcctToLike; //Field offset: 0x21
	public Dictionary<ContentType, ChallengeBrowserTabSettings> tabSettings; //Field offset: 0x28
	public TimeSpan minSearchInterval; //Field offset: 0x30
	public TimeSpan minPageLoadInterval; //Field offset: 0x38
	public string defaultChallengeName; //Field offset: 0x40
	public string defaultPlayerName; //Field offset: 0x48
	public string newsBanner; //Field offset: 0x50
	public ChallengeEditorSettings editor; //Field offset: 0x58
	public FilterSettings filterSettings; //Field offset: 0x60
	public CacheDebug cacheDebug; //Field offset: 0x68
	public int maxFilterCount; //Field offset: 0x70
	public int maxListSize; //Field offset: 0x74
	public int maxCacheMb; //Field offset: 0x78
	public int maxCacheCount; //Field offset: 0x7C
	public Dictionary<String, ScoreContentFilters> storeFilterLevel; //Field offset: 0x80
	public AccoladesSettings accolades; //Field offset: 0x88

	public ContentBrowserSettings() { }

	public bool IsSelectionTypeEnabled(ContentType contentType, SelectionType selectionType) { }

	public void Validate() { }

}

