namespace Assets.Scripts.Models.ServerEvents;

public class ServerSettings
{
	public string imageUrlPrefix; //Field offset: 0x10
	public Quality quality; //Field offset: 0x18
	public Dictionary<String, Boolean> newMapIcon; //Field offset: 0x20
	public NewsPanel newsPanelPriority; //Field offset: 0x28
	public int dailyResetUTCOffset; //Field offset: 0x30
	public int mkFullRespecCost; //Field offset: 0x34
	public string rateMePopupVersion; //Field offset: 0x38
	public int dataBackupPeriodSeconds; //Field offset: 0x40
	public int playSessionChecksPerBackup; //Field offset: 0x44
	public Coop coop; //Field offset: 0x48
	public TimeSpan skuCacheLife; //Field offset: 0x50
	public SaveFile saveFile; //Field offset: 0x58
	public bool forceQuitOnException; //Field offset: 0x60
	public int heroBoosterLevel; //Field offset: 0x64
	public int cursorUpdateInterval; //Field offset: 0x68
	public MainMenuPriority mainMenuPriority; //Field offset: 0x70
	public Int32[] heroBoosterMMcosts; //Field offset: 0x78
	public AnalyticsSku analytics; //Field offset: 0x80
	public ContentBrowserSettings contentBrowser; //Field offset: 0x88
	public String[] newTowers; //Field offset: 0x90
	public Dictionary<String, TowerUnlockData> towerUnlocks; //Field offset: 0x98
	public EnableFlag conflictScreen; //Field offset: 0xA0
	public LeaderboardSettings leaderboards; //Field offset: 0xA8
	public EnableFlag richPresence; //Field offset: 0xB0
	public OnlineProfile onlineProfile; //Field offset: 0xB8
	public ReplaySettings replays; //Field offset: 0xC0
	public PlayerCacheSettings playerCacheSettings; //Field offset: 0xC8
	public FriendsSettings friends; //Field offset: 0xD0
	public TeamSettings teams; //Field offset: 0xD8
	public CacheSettings cacheSettings; //Field offset: 0xE0
	public bool enableDnsCheck; //Field offset: 0xE8
	public NexusSettings nexus; //Field offset: 0xF0
	public Dictionary<String, QuestOverrideSettings> quests; //Field offset: 0xF8
	public int webviewVersion; //Field offset: 0x100
	public int mapEditorUnlockCostMM; //Field offset: 0x104
	public int mapEditorLevelRequirement; //Field offset: 0x108
	public AchievementSettings achievements; //Field offset: 0x110
	public ExternalUrls externalUrls; //Field offset: 0x118
	public Store[] giftCodeStores; //Field offset: 0x120
	public String[] mainteinableEvents; //Field offset: 0x128
	public TimeSpan maintenanceWarnPeriod; //Field offset: 0x130
	public LegendsSettings legends; //Field offset: 0x138
	public bool useOldCrossPromo; //Field offset: 0x140
	public int maxIapLoginReminders; //Field offset: 0x144
	public PowerCostOverride[] powerCostOverrides; //Field offset: 0x148
	public SkinCostOverride[] skinCostOverrides; //Field offset: 0x150
	public bool ignoreIapSales; //Field offset: 0x158

	[JsonIgnore]
	public bool useSteamDlc
	{
		 get { } //Length: 3
	}

	public ServerSettings() { }

	public bool get_useSteamDlc() { }

}

