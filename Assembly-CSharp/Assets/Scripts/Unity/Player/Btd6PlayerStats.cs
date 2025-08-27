namespace Assets.Scripts.Unity.Player;

public class Btd6PlayerStats
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ActiveAchievement, Boolean> <>9__88_0; //Field offset: 0x8
		public static Func<ActiveAchievement, Int32> <>9__88_1; //Field offset: 0x10
		public static Func<ActiveAchievement, Boolean> <>9__88_2; //Field offset: 0x18
		public static Func<ActiveAchievement, Int32> <>9__88_3; //Field offset: 0x20
		public static Func<KeyValuePair`2<Int32, KonFuze>, Int32> <>9__88_6; //Field offset: 0x28
		public static Func<KeyValuePair`2<Int32, KonFuze>, Int32> <>9__88_8; //Field offset: 0x30
		public static Func<KeyValuePair`2<Int32, KonFuze>, Int32> <>9__88_10; //Field offset: 0x38
		public static Func<KeyValuePair`2<Int32, BossMedalSaveData>, Int32> <>9__88_11; //Field offset: 0x40
		public static Func<KeyValuePair`2<Int32, BossMedalSaveData>, BossMedalSaveData> <>9__88_12; //Field offset: 0x48
		public static Func<KeyValuePair`2<Int32, KonFuze>, Int32> <>9__88_14; //Field offset: 0x50
		public static Func<KeyValuePair`2<Int32, KonFuze>, Int32> <>9__88_16; //Field offset: 0x58
		public static Func<KeyValuePair`2<String, LegendMedalSaveData>, String> <>9__88_17; //Field offset: 0x60
		public static Func<KeyValuePair`2<String, LegendMedalSaveData>, LegendMedalSaveData> <>9__88_18; //Field offset: 0x68
		public static Func<KeyValuePair`2<String, NamedMonkeyStats>, String> <>9__90_0; //Field offset: 0x70
		public static Func<KeyValuePair`2<String, NamedMonkeyStats>, PublicNamedMonkeyStats> <>9__90_1; //Field offset: 0x78
		public static Func<KeyValuePair`2<String, LegendsStats>, String> <>9__91_0; //Field offset: 0x80
		public static Func<KeyValuePair`2<String, LegendsStats>, PublicLegendsStats> <>9__91_1; //Field offset: 0x88

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__88_0(ActiveAchievement a) { }

		internal int <.ctor>b__88_1(ActiveAchievement a) { }

		internal int <.ctor>b__88_10(KeyValuePair<Int32, KonFuze> kvp) { }

		internal int <.ctor>b__88_11(KeyValuePair<Int32, BossMedalSaveData> kvp) { }

		internal BossMedalSaveData <.ctor>b__88_12(KeyValuePair<Int32, BossMedalSaveData> kvp) { }

		internal int <.ctor>b__88_14(KeyValuePair<Int32, KonFuze> kvp) { }

		internal int <.ctor>b__88_16(KeyValuePair<Int32, KonFuze> kvp) { }

		internal string <.ctor>b__88_17(KeyValuePair<String, LegendMedalSaveData> kvp) { }

		internal LegendMedalSaveData <.ctor>b__88_18(KeyValuePair<String, LegendMedalSaveData> kvp) { }

		internal bool <.ctor>b__88_2(ActiveAchievement a) { }

		internal int <.ctor>b__88_3(ActiveAchievement a) { }

		internal int <.ctor>b__88_6(KeyValuePair<Int32, KonFuze> kvp) { }

		internal int <.ctor>b__88_8(KeyValuePair<Int32, KonFuze> kvp) { }

		internal string <PopulateLegendsStats>b__91_0(KeyValuePair<String, LegendsStats> keyValuePair) { }

		internal PublicLegendsStats <PopulateLegendsStats>b__91_1(KeyValuePair<String, LegendsStats> keyValuePair) { }

		internal string <PopulateNamedMonkeyStats>b__90_0(KeyValuePair<String, NamedMonkeyStats> kvp) { }

		internal PublicNamedMonkeyStats <PopulateNamedMonkeyStats>b__90_1(KeyValuePair<String, NamedMonkeyStats> kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public string legendName; //Field offset: 0x10
		public Btd6PlayerStats <>4__this; //Field offset: 0x18

		public <>c__DisplayClass88_0() { }

		internal bool <.ctor>b__19(KeyValuePair<String, Boolean> x) { }

	}

	[JsonIgnore]
	public const int kCurrentStatsVersion = 1; //Field offset: 0x0
	public string playerId; //Field offset: 0x10
	public int playerRank; //Field offset: 0x18
	public float playerXp; //Field offset: 0x1C
	public int veteranRank; //Field offset: 0x20
	public long veteranXp; //Field offset: 0x28
	public string avatar; //Field offset: 0x30
	public string frame; //Field offset: 0x38
	public string banner; //Field offset: 0x40
	public int gameCount; //Field offset: 0x48
	public int gamesWon; //Field offset: 0x4C
	public int highestRound; //Field offset: 0x50
	public int highestRoundCurrentVersion; //Field offset: 0x54
	public int monkeysPlaced; //Field offset: 0x58
	public long bloonsPopped; //Field offset: 0x60
	public long camosPopped; //Field offset: 0x68
	public long leadsPopped; //Field offset: 0x70
	public long purplesPopped; //Field offset: 0x78
	public long regrowsPopped; //Field offset: 0x80
	public long ceramicsPopped; //Field offset: 0x88
	public int moabsPopped; //Field offset: 0x90
	public int bfbsPopped; //Field offset: 0x94
	public int zomgsPopped; //Field offset: 0x98
	public int ddtsPopped; //Field offset: 0x9C
	public int badsPopped; //Field offset: 0xA0
	public int bossesPopped; //Field offset: 0xA4
	public int bloonsLeaked; //Field offset: 0xA8
	public long cashEarned; //Field offset: 0xB0
	public int instaMonkeysUsed; //Field offset: 0xB8
	public int powersUsed; //Field offset: 0xBC
	public int abilitiesUsed; //Field offset: 0xC0
	public long coopBloonsPopped; //Field offset: 0xC8
	public long coopCashGiven; //Field offset: 0xD0
	public int rogueGameTilesWon; //Field offset: 0xD8
	public int rogueBossesDefeated; //Field offset: 0xDC
	public int rogueStandardTileWins; //Field offset: 0xE0
	public int rogueMiniBossTilesWins; //Field offset: 0xE4
	public int rogueMiniGameTilesWins; //Field offset: 0xE8
	public int rogueChallengeGameTilesWins; //Field offset: 0xEC
	public int rogueCampaignsBeaten; //Field offset: 0xF0
	public int rogueTotalLoopsDone; //Field offset: 0xF4
	public int rogueTotalExtractedArtifacts; //Field offset: 0xF8
	public int rogueTotalArtifactsGained; //Field offset: 0xFC
	public int rogueTotalTier5TypesUsed; //Field offset: 0x100
	public int rogueTotalMinigameTypesPlayed; //Field offset: 0x104
	public int rogueLegendaryBoostTypesUsed; //Field offset: 0x108
	public int rogueTowerTypesPlaced; //Field offset: 0x10C
	public List<Int32> achievementsClaimed; //Field offset: 0x110
	public List<Int32> achievements; //Field offset: 0x118
	public List<Int32> hiddenAchievements; //Field offset: 0x120
	public List<Int32> hiddenAchievementsClaimed; //Field offset: 0x128
	public Dictionary<String, Int32> heroesPlacedData; //Field offset: 0x130
	public Dictionary<String, Int32> towersPlacedData; //Field offset: 0x138
	private MapInfoManager mapInfo; //Field offset: 0x140
	public Dictionary<String, Int32> spMedals; //Field offset: 0x148
	public Dictionary<String, Int32> coopMedals; //Field offset: 0x150
	public Dictionary<String, Int32> raceMedals; //Field offset: 0x158
	public Dictionary<String, Int32> bossMedals; //Field offset: 0x160
	public Dictionary<String, Int32> bossEliteMedals; //Field offset: 0x168
	public Dictionary<String, Int32> ctLocalMedals; //Field offset: 0x170
	public Dictionary<String, Int32> ctGlobalMedals; //Field offset: 0x178
	public Dictionary<Int32, BossMedalSaveData> bossBadges; //Field offset: 0x180
	public int dailyRewards; //Field offset: 0x188
	public int challengesCompleted; //Field offset: 0x18C
	public Dictionary<String, Boolean> savedStats; //Field offset: 0x190
	public Dictionary<String, PublicNamedMonkeyStats> namedMonkeyStats; //Field offset: 0x198
	public Dictionary<String, Dictionary`2<String, Boolean>> savedNamedMonkeyStats; //Field offset: 0x1A0
	public Dictionary<String, PublicLegendsStats> legendsStatsByName; //Field offset: 0x1A8
	public Dictionary<String, Dictionary`2<String, Boolean>> savedLegendsStats; //Field offset: 0x1B0
	public Dictionary<String, LegendMedalSaveData> legendBadges; //Field offset: 0x1B8
	public int totalOdysseysCompleted; //Field offset: 0x1C0
	public int totalOdysseyStars; //Field offset: 0x1C4
	public int totalTrophiesEarned; //Field offset: 0x1C8
	public int statsVersion; //Field offset: 0x1CC
	public long necroBloonsReanimated; //Field offset: 0x1D0
	public int transformingTonicsUsed; //Field offset: 0x1D8
	public string mostExperiencedMonkey; //Field offset: 0x1E0
	public float mostExperiencedMonkeyXp; //Field offset: 0x1E8
	public int instaMonkeyCollection; //Field offset: 0x1EC
	public int collectionChestsOpened; //Field offset: 0x1F0
	public int goldenBloonsPopped; //Field offset: 0x1F4
	public int monkeyTeamsWins; //Field offset: 0x1F8
	public Dictionary<String, Int32> paragonsPurchasedData; //Field offset: 0x200
	public int highestRoundCHIMPS; //Field offset: 0x208
	public int highestRoundDeflation; //Field offset: 0x20C
	public long damageDoneToBosses; //Field offset: 0x210
	public bool hasPublicAccolades; //Field offset: 0x218

	[JsonConstructor]
	public Btd6PlayerStats() { }

	public Btd6PlayerStats(Btd6Player player) { }

	[CompilerGenerated]
	private string <.ctor>b__88_13(KeyValuePair<Int32, KonFuze> kvp) { }

	[CompilerGenerated]
	private string <.ctor>b__88_15(KeyValuePair<Int32, KonFuze> kvp) { }

	[CompilerGenerated]
	private bool <.ctor>b__88_4(int a) { }

	[CompilerGenerated]
	private string <.ctor>b__88_5(KeyValuePair<Int32, KonFuze> kvp) { }

	[CompilerGenerated]
	private string <.ctor>b__88_7(KeyValuePair<Int32, KonFuze> kvp) { }

	[CompilerGenerated]
	private string <.ctor>b__88_9(KeyValuePair<Int32, KonFuze> kvp) { }

	private string GetLeaderboardBadgeName(int badgeId) { }

	private int GetOdysseyStars(Dictionary<String, KonFuze> completedOdysseys) { }

	private Dictionary<String, PublicLegendsStats> PopulateLegendsStats(Dictionary<String, LegendsStats> legendsStats) { }

	private Dictionary<String, PublicNamedMonkeyStats> PopulateNamedMonkeyStats(Dictionary<String, NamedMonkeyStats> nms) { }

	private static void RepairIfOverflowed(ref long val) { }

	public Dictionary<String, Int32> SetMedalCount(bool coop) { }

	[OnDeserialized]
	internal void ValidateAfterDeserialising(StreamingContext context) { }

}

