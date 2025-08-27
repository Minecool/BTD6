namespace Assets.Scripts.Unity.UI_New.BossBloons;

[Extension]
public static class BossRushTileRulesRandomizer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<String, Boolean> <>9__5_1; //Field offset: 0x8
		public static Func<String, Nullable`1<BossType>> <>9__9_0; //Field offset: 0x10
		public static Func<Nullable`1<BossType>, Boolean> <>9__9_1; //Field offset: 0x18
		public static Func<String, Boolean> <>9__9_2; //Field offset: 0x20
		public static Func<ContestedTerritoryRelicType, ContestedTerritoryRelicType> <>9__10_1; //Field offset: 0x28
		public static Func<KeyValuePair`2<ContestedTerritoryRelicType, Single>, Single> <>9__10_4; //Field offset: 0x30
		public static Func<ContestedTerritoryRelicType[], Boolean> <>9__10_3; //Field offset: 0x38
		public static Func<ContestedTerritoryRelicType, Boolean> <>9__10_5; //Field offset: 0x40
		public static Func<ContestedTerritoryRelicType, Boolean> <>9__10_6; //Field offset: 0x48
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, Boolean> <>9__12_0; //Field offset: 0x50
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, String> <>9__12_1; //Field offset: 0x58
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, Boolean> <>9__13_0; //Field offset: 0x60
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, String> <>9__13_1; //Field offset: 0x68
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, Boolean> <>9__14_0; //Field offset: 0x70
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, String> <>9__14_1; //Field offset: 0x78
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, Boolean> <>9__15_0; //Field offset: 0x80
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, String> <>9__15_1; //Field offset: 0x88
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, Boolean> <>9__16_0; //Field offset: 0x90
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, String> <>9__16_1; //Field offset: 0x98
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, String> <>9__17_0; //Field offset: 0xA0
		public static Func<KeyValuePair`2<String, BossRushTowerSettings>, Single> <>9__17_1; //Field offset: 0xA8
		public static Func<String, Boolean> <>9__18_3; //Field offset: 0xB0
		public static Func<String, Boolean> <>9__19_1; //Field offset: 0xB8
		public static Func<TowerDetailsModel, String> <>9__19_3; //Field offset: 0xC0
		public static Func<TowerDetailsModel, String> <>9__19_5; //Field offset: 0xC8
		public static Func<String, Boolean> <>9__19_6; //Field offset: 0xD0
		public static Func<TowerDetailsModel, Boolean> <>9__19_11; //Field offset: 0xD8
		public static Func<TowerDetailsModel, String> <>9__19_14; //Field offset: 0xE0
		public static Func<String, String> <>9__19_15; //Field offset: 0xE8
		public static Func<TowerDetailsModel, String> <>9__19_21; //Field offset: 0xF0

		private static <>c() { }

		public <>c() { }

		internal bool <GetCamoRevealingTowers>b__14_0(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal string <GetCamoRevealingTowers>b__14_1(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal bool <GetCamoTowers>b__13_0(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal string <GetCamoTowers>b__13_1(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal bool <GetCheapTowers>b__16_0(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal string <GetCheapTowers>b__16_1(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal bool <GetLeadTowers>b__12_0(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal string <GetLeadTowers>b__12_1(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal Nullable<BossType> <GetRandomBosses>b__9_0(string x) { }

		internal bool <GetRandomBosses>b__9_1(Nullable<BossType> x) { }

		internal bool <GetRandomBosses>b__9_2(string x) { }

		internal bool <GetRandomMaps>b__5_1(string x) { }

		internal ContestedTerritoryRelicType <GetRandomRelics>b__10_1(ContestedTerritoryRelicType relicType) { }

		internal bool <GetRandomRelics>b__10_3(ContestedTerritoryRelicType[] x) { }

		internal float <GetRandomRelics>b__10_4(KeyValuePair<ContestedTerritoryRelicType, Single> x) { }

		internal bool <GetRandomRelics>b__10_5(ContestedTerritoryRelicType x) { }

		internal bool <GetRandomRelics>b__10_6(ContestedTerritoryRelicType x) { }

		internal bool <GetRandomStageTowers>b__19_1(string x) { }

		internal bool <GetRandomStageTowers>b__19_11(TowerDetailsModel x) { }

		internal string <GetRandomStageTowers>b__19_14(TowerDetailsModel x) { }

		internal string <GetRandomStageTowers>b__19_15(string heroId) { }

		internal string <GetRandomStageTowers>b__19_21(TowerDetailsModel x) { }

		internal string <GetRandomStageTowers>b__19_3(TowerDetailsModel x) { }

		internal string <GetRandomStageTowers>b__19_5(TowerDetailsModel x) { }

		internal bool <GetRandomStageTowers>b__19_6(string x) { }

		internal string <GetTowerChances>b__17_0(KeyValuePair<String, BossRushTowerSettings> x) { }

		internal float <GetTowerChances>b__17_1(KeyValuePair<String, BossRushTowerSettings> z) { }

		internal bool <GetWaterBoostedTowers>b__15_0(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal string <GetWaterBoostedTowers>b__15_1(KeyValuePair<String, BossRushTowerSettings> kvp) { }

		internal bool <IsValidTowerSelection>b__18_3(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public BossRushSettings bossRushSettings; //Field offset: 0x10
		public Dictionary<ContestedTerritoryRelicType, Single> relicChances; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal bool <GetRandomRelics>b__0(ContestedTerritoryRelicType x) { }

		internal float <GetRandomRelics>b__2(ContestedTerritoryRelicType relcType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public KeyValuePair<String, BossRushTowerSettings> kvp; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <GetLeadTowers>b__2(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public KeyValuePair<String, BossRushTowerSettings> kvp; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetCamoTowers>b__2(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public KeyValuePair<String, BossRushTowerSettings> kvp; //Field offset: 0x10

		public <>c__DisplayClass14_0() { }

		internal bool <GetCamoRevealingTowers>b__2(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public KeyValuePair<String, BossRushTowerSettings> kvp; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <GetWaterBoostedTowers>b__2(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public KeyValuePair<String, BossRushTowerSettings> kvp; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <GetCheapTowers>b__2(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Dictionary<String, BossRushTowerSettings> towerSettings; //Field offset: 0x10

		public <>c__DisplayClass18_0() { }

		internal bool <IsValidTowerSelection>b__0(string x) { }

		internal bool <IsValidTowerSelection>b__1(string x) { }

		internal bool <IsValidTowerSelection>b__2(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public IReadOnlyDictionary<String, Single> towerChances; //Field offset: 0x10
		public List<String> bossTowers; //Field offset: 0x18
		public Dictionary<String, BossRushTowerSettings> towerSettings; //Field offset: 0x20
		public List<String> proposedTowerList; //Field offset: 0x28
		public BossRushSettings bossRushSettings; //Field offset: 0x30
		public Func<TowerDetailsModel, Boolean> <>9__12; //Field offset: 0x38
		public Func<TowerDetailsModel, Boolean> <>9__20; //Field offset: 0x40

		public <>c__DisplayClass19_0() { }

		internal bool <GetRandomStageTowers>b__0(TowerDetailsModel x) { }

		internal bool <GetRandomStageTowers>b__10(TowerDetailsModel x) { }

		internal bool <GetRandomStageTowers>b__12(TowerDetailsModel x) { }

		internal float <GetRandomStageTowers>b__16(string heroId) { }

		internal bool <GetRandomStageTowers>b__17(string x) { }

		internal bool <GetRandomStageTowers>b__20(TowerDetailsModel x) { }

		internal bool <GetRandomStageTowers>b__4(TowerDetailsModel tower) { }

		internal bool <GetRandomStageTowers>b__7(TowerDetailsModel x) { }

		internal bool <GetRandomStageTowers>b__9(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public String[] towersOverride; //Field offset: 0x10

		public <>c__DisplayClass19_1() { }

		internal bool <GetRandomStageTowers>b__2(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_2
	{
		public string x; //Field offset: 0x10

		public <>c__DisplayClass19_2() { }

		internal bool <GetRandomStageTowers>b__8(TowerDetailsModel z) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_3
	{
		public String[] bannedHeroes; //Field offset: 0x10

		public <>c__DisplayClass19_3() { }

		internal bool <GetRandomStageTowers>b__13(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_4
	{
		public IEnumerable<String> unselectedBossTowerNames; //Field offset: 0x10

		public <>c__DisplayClass19_4() { }

		internal bool <GetRandomStageTowers>b__18(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_5
	{
		public string x; //Field offset: 0x10

		public <>c__DisplayClass19_5() { }

		internal bool <GetRandomStageTowers>b__19(string z) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public BossRushRandomizerSettings bossRushRandomSettings; //Field offset: 0x10
		public List<MapDetails> randomMaps; //Field offset: 0x18
		public Func<MapDetails, Boolean> <>9__2; //Field offset: 0x20

		public <>c__DisplayClass5_0() { }

		internal bool <GetRandomMaps>b__2(MapDetails map) { }

		internal bool <GetRandomMaps>g__IsMapBlacklisted|0(MapDetails mapDetails) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass6_0
	{
		public List<MapDifficulty> invalidMapDifficulties; //Field offset: 0x0
		public Dictionary<String, Single> mapDifficultyChance; //Field offset: 0x8

	}

	[CompilerGenerated]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"bossRushTileRules", "randomSeedString", "settingsHash"}])]
	private static ValueTuple<BossRushTileRules, String, String> <Cache>k__BackingField; //Field offset: 0x0

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"bossRushTileRules", "randomSeedString", "settingsHash"}])]
	private static ValueTuple<BossRushTileRules, String, String> Cache
	{
		[CompilerGenerated]
		private get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 73
	}

	private static TowerDetailsModel[] HeroSet
	{
		private get { } //Length: 80
	}

	private static MapSet MapSet
	{
		private get { } //Length: 197
	}

	private static TowerDetailsModel[] TowerSet
	{
		private get { } //Length: 80
	}

	[CompilerGenerated]
	internal static float <RollMapDifficulty>g__GetDifficultyChance|6_0(MapDifficulty mapDifficulty, ref <>c__DisplayClass6_0 unnamed_param_1) { }

	public static BossRushTileRules GenerateRules(string randomSeedString, BossRushSettings bossRushSettings) { }

	[CompilerGenerated]
	private static ValueTuple<BossRushTileRules, String, String> get_Cache() { }

	private static TowerDetailsModel[] get_HeroSet() { }

	private static MapSet get_MapSet() { }

	private static TowerDetailsModel[] get_TowerSet() { }

	[Extension]
	private static IEnumerable<String> GetCamoRevealingTowers(Dictionary<String, BossRushTowerSettings> towerSettings) { }

	[Extension]
	private static IEnumerable<String> GetCamoTowers(Dictionary<String, BossRushTowerSettings> towerSettings) { }

	[Extension]
	private static IEnumerable<String> GetCheapTowers(Dictionary<String, BossRushTowerSettings> towerSettings) { }

	[Extension]
	private static IEnumerable<String> GetLeadTowers(Dictionary<String, BossRushTowerSettings> towerSettings) { }

	private static BossType[] GetRandomBosses(Random random, int stageCount, BossRushSettings bossRushSettings) { }

	private static MapDetails[] GetRandomMaps(Random random, int stageCount, BossRushSettings bossRushSettings) { }

	private static ContestedTerritoryRelicType[][] GetRandomRelics(Random random, int stageCount, BossRushSettings bossRushSettings) { }

	private static String[] GetRandomStageTowers(Random random, BossRushSettings bossRushSettings, BossType bossType, MapDetails mapDetails, String[] nextStageTowers) { }

	private static String[][] GetRandomTowers(Random random, int stageCount, BossRushSettings bossRushSettings, MapDetails[] maps, BossType[] bosses) { }

	[Extension]
	private static IReadOnlyDictionary<String, Single> GetTowerChances(Dictionary<String, BossRushTowerSettings> towerSettings) { }

	private static string GetTowerId(TowerDetailsModel t) { }

	[Extension]
	private static IEnumerable<String> GetWaterBoostedTowers(Dictionary<String, BossRushTowerSettings> towerSettings) { }

	private static bool IsValidTowerSelection(String[] selectedTowers, Dictionary<String, BossRushTowerSettings> towerSettings, MapDetails lastMap) { }

	private static MapDifficulty RollMapDifficulty(Random random, BossRushRandomizerSettings bossRushRandomSettings, int tileIndex, List<MapDifficulty> invalidMapDifficulties) { }

	[CompilerGenerated]
	private static void set_Cache(ValueTuple<BossRushTileRules, String, String> value) { }

}

