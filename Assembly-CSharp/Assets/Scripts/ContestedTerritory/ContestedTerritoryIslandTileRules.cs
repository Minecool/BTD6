namespace Assets.Scripts.ContestedTerritory;

public class ContestedTerritoryIslandTileRules
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BossType, BossType> <>9__27_0; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__27_2; //Field offset: 0x10
		public static Func<TowerData, Boolean> <>9__53_0; //Field offset: 0x18
		public static Func<TowerData, Boolean> <>9__67_0; //Field offset: 0x20
		public static Func<TowerData, Boolean> <>9__67_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal BossType <SetBoss>b__27_0(BossType bossType) { }

		internal int <SetBoss>b__27_2(int roundNumber) { }

		internal bool <SetHero>b__53_0(TowerData x) { }

		internal bool <ValidateHardCodedRules>b__67_0(TowerData x) { }

		internal bool <ValidateHardCodedRules>b__67_1(TowerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public String[] blacklistedMapIds; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <SetMap>b__0(MapDetails map) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Dictionary<String, Single> bossChanceSettings; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal float <SetBoss>b__1(BossType bossType) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass52_0() { }

		internal bool <IsWaterOnlyTower>b__0(TowerModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public String[] forbiddenHeroes; //Field offset: 0x10
		public ContestedTerritoryIslandTileRules <>4__this; //Field offset: 0x18

		public <>c__DisplayClass53_0() { }

		internal bool <SetHero>b__1(TowerData x) { }

		internal bool <SetHero>b__2(TowerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public List<TowerData> proposedTowerList; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal bool <GenerateProposedList>b__1(TowerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_1
	{
		public List<String> bossTowers; //Field offset: 0x10

		public <>c__DisplayClass61_1() { }

		internal bool <GenerateProposedList>b__0(TowerData tower) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public TowerLists currentTowerLists; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <PickBossSpecificTowerNames>b__0(string towerName) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public List<String> pickedTowers; //Field offset: 0x10
		public List<String> possibleTowers; //Field offset: 0x18

		public <>c__DisplayClass63_0() { }

		internal bool <GetTowersToPickFrom>b__0(string towerName) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public String[] forbiddenTowers; //Field offset: 0x10
		public Func<TowerData, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass73_0() { }

		internal bool <BuildCache>b__0(TowerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public string towerName; //Field offset: 0x10

		public <>c__DisplayClass74_0() { }

		internal bool <CacheTower>b__0(TowerModel x) { }

	}

	private enum TowerRestriction
	{
		None = 0,
		PerTowerCap = 1,
		MaxTowers = 2,
	}

	private const float CamoRevealTowerChanceBuff = 0.04; //Field offset: 0x0
	private const int MinimumTowerTypes = 4; //Field offset: 0x0
	private const int MinimumTowerCount = 4; //Field offset: 0x0
	private const int MaximumTowerCount = 39; //Field offset: 0x0
	private readonly ContestedTerritoryIslandTileRulesBase baseRules; //Field offset: 0x10
	private readonly ContestedTerritoryGameData gameData; //Field offset: 0x18
	private MapDetails selectedMap; //Field offset: 0x20
	[CompilerGenerated]
	private bool <HaveBeenFullyGenerated>k__BackingField; //Field offset: 0x28
	private readonly IReadOnlyList<String> MapsTreatedLikeNoWaterMaps; //Field offset: 0x30
	private Dictionary<String, Single> towerSelectionChances; //Field offset: 0x38
	private List<TowerData> allTowers; //Field offset: 0x40
	private List<TowerData> leadTowers; //Field offset: 0x48
	private List<TowerData> camoTowers; //Field offset: 0x50
	private List<TowerData> camoRevealTowers; //Field offset: 0x58
	private List<TowerData> waterTowers; //Field offset: 0x60
	private List<TowerData> requiredTowerList; //Field offset: 0x68
	private float mapWaterTowerModifier; //Field offset: 0x70
	private bool hasHero; //Field offset: 0x74
	private TowerRestriction restriction; //Field offset: 0x78
	private int towerTypeCount; //Field offset: 0x7C
	private int perMapMax; //Field offset: 0x80

	private ContestedTerritoryGameSettings gameSettings
	{
		private get { } //Length: 27
	}

	public ContestedTerritoryGameType GameType
	{
		 get { } //Length: 26
	}

	public private bool HaveBeenFullyGenerated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private ContestedTerritoryInjectedSettings injectedSettings
	{
		private get { } //Length: 27
	}

	public bool IsBoss
	{
		 get { } //Length: 31
	}

	private static MapSet MapSet
	{
		private get { } //Length: 197
	}

	private ContestedTerritoryMapSettings mapSettings
	{
		private get { } //Length: 27
	}

	private Random randomiser
	{
		private get { } //Length: 27
	}

	public ContestedTerritoryIslandTileTheme Theme
	{
		 get { } //Length: 20
	}

	public ContestedTerritoryIslandTileRules(ContestedTerritoryIslandTileRulesBase baseRules, ContestedTerritoryTileGameSettings tileGameSettings) { }

	[CompilerGenerated]
	private bool <ValidateProposedTowerList>b__66_0(TowerData x) { }

	[CompilerGenerated]
	private bool <ValidateProposedTowerList>b__66_1(TowerData x) { }

	[CompilerGenerated]
	private bool <ValidateProposedTowerList>b__66_2(TowerData x) { }

	private void ApplyTowerRestrictions(List<TowerData> selectedTowers) { }

	private void BuildCache() { }

	private void CacheTower(TowerData towerData, ContestedTerritoryTowerSetting towerSetting) { }

	private List<TowerData> GenerateProposedList() { }

	private ContestedTerritoryGameSettings get_gameSettings() { }

	public ContestedTerritoryGameType get_GameType() { }

	[CompilerGenerated]
	public bool get_HaveBeenFullyGenerated() { }

	private ContestedTerritoryInjectedSettings get_injectedSettings() { }

	public bool get_IsBoss() { }

	private static MapSet get_MapSet() { }

	private ContestedTerritoryMapSettings get_mapSettings() { }

	private Random get_randomiser() { }

	public ContestedTerritoryIslandTileTheme get_Theme() { }

	public BossType GetBossType() { }

	private String[] GetForbiddenHeroes(ContestedTerritoryGameType gameType) { }

	private String[] GetForbiddenTowers(ContestedTerritoryGameType gameType) { }

	public ContestedTerritoryGameData GetGameData(NodeStatus nodeStatus, ContestedTerritoryGameType gameType, CtTileType ctTileType) { }

	private static string GetTowerId(TowerData t) { }

	private static List<String> GetTowersToPickFrom(TowerLists towerLists, bool usePrimary, bool useMilitary, bool useMagic, bool useSupport, List<String> pickedTowers, List<String> possibleTowers) { }

	private static string GetValue(string v) { }

	private bool IsWaterOnlyTower(string id) { }

	private void ModifyCamoRevealTowerChance(float amount) { }

	public static List<String> PickBossSpecificTowerNames(Random randomiser, Dictionary<String, TowerLists[]> bossSpecialTowers, BossType bossType, IReadOnlyDictionary<String, Single> towerSelectionChances) { }

	private void RestrictTowersForMaxTowerGame(List<TowerData> selectedTowers) { }

	private void RestrictTowersForPerTowerCapGame(List<TowerData> selectedTowers) { }

	private void RestrictTowersForRegularGame(List<TowerData> selectedTowers) { }

	private bool SelectedMapHasWater() { }

	[CompilerGenerated]
	private void set_HaveBeenFullyGenerated(bool value) { }

	private void SetAdditionalModifiers() { }

	private void SetBoss() { }

	private void SetGameDifficulty() { }

	private void SetGameMode() { }

	private void SetHero(ContestedTerritoryGameType gameType) { }

	private void SetMap() { }

	private void SetModifiers() { }

	private void SetRestrictionAndAssociatedCounts() { }

	private void SetRounds() { }

	private void SetStartingCash() { }

	private void SetTowers() { }

	private void SetupMaxTowersGame() { }

	private void SetupPerTowerCapGame() { }

	private void SetupRegularGame() { }

	private void SetVictoryCondition(NodeStatus nodeStatus, CtTileType ctTileType) { }

	private bool ValidateHardCodedRules(List<TowerData> proposedTowerList) { }

	private bool ValidateProposedTowerList(List<TowerData> proposedTowerList) { }

}

