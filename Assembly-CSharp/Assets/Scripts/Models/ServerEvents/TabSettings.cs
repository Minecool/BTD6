namespace Assets.Scripts.Models.ServerEvents;

public class TabSettings
{
	public int minLikes; //Field offset: 0x10
	public int minWins; //Field offset: 0x14
	public int maxWins; //Field offset: 0x18
	public int minLosses; //Field offset: 0x1C
	public int maxLosses; //Field offset: 0x20
	public int minPlays; //Field offset: 0x24
	public int minPlaysUnique; //Field offset: 0x28
	public int minAttempts; //Field offset: 0x2C
	public int maxPages; //Field offset: 0x30
	public float minWinRate; //Field offset: 0x34
	public float maxWinRate; //Field offset: 0x38
	public bool includeOldVersions; //Field offset: 0x3C
	public bool morePlaysThanLikes; //Field offset: 0x3D
	public TabSettingsSorting sorting; //Field offset: 0x40
	public int maxAttempts; //Field offset: 0x48
	public int maxLossesUnique; //Field offset: 0x4C
	public int minLossesUnique; //Field offset: 0x50
	public int maxWinsUnique; //Field offset: 0x54
	public int minWinsUnique; //Field offset: 0x58
	public int minRestarts; //Field offset: 0x5C
	public int maxLikes; //Field offset: 0x60
	public int maxPlays; //Field offset: 0x64
	public int maxPlaysUnique; //Field offset: 0x68
	public int maxRestarts; //Field offset: 0x6C
	public string customQueryScript; //Field offset: 0x70
	public SearchType searchType; //Field offset: 0x78
	public WinRateDisplayType winRateDisplayType; //Field offset: 0x7C
	public bool hideCompleted; //Field offset: 0x80
	public bool isEnabled; //Field offset: 0x81

	public TabSettings() { }

}

