namespace Assets.Scripts.Models.ServerEvents;

public class DailyChallengeModel : IContentBrowserData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PowerData, String> <>9__60_0; //Field offset: 0x8
		public static Func<IGrouping`2<String, PowerData>, PowerData> <>9__60_1; //Field offset: 0x10
		public static Func<String, String> <>9__60_2; //Field offset: 0x18
		public static Func<PowerData, String> <>9__60_3; //Field offset: 0x20
		public static Func<String, PowerData, PowerData> <>9__60_4; //Field offset: 0x28
		public static Predicate<TowerData> <>9__61_0; //Field offset: 0x30
		public static Predicate<TowerData> <>9__61_1; //Field offset: 0x38
		public static Func<TowerData, String> <>9__61_2; //Field offset: 0x40
		public static Func<IGrouping`2<String, TowerData>, TowerData> <>9__61_3; //Field offset: 0x48
		public static Func<String, String> <>9__61_4; //Field offset: 0x50
		public static Func<TowerData, String> <>9__61_5; //Field offset: 0x58
		public static Func<String, TowerData, TowerData> <>9__61_6; //Field offset: 0x60
		public static Predicate<TowerData> <>9__61_7; //Field offset: 0x68
		public static Func<String, RoundSetModModel> <>9__64_0; //Field offset: 0x70
		public static Func<TowerData, Boolean> <>9__66_0; //Field offset: 0x78
		public static Func<TowerData, Boolean> <>9__82_0; //Field offset: 0x80
		public static Func<TowerData, Boolean> <>9__82_1; //Field offset: 0x88
		public static Func<TowerData, String> <>9__82_4; //Field offset: 0x90

		private static <>c() { }

		public <>c() { }

		internal bool <GetLimitedHeroSelection>b__82_0(TowerData tower) { }

		internal bool <GetLimitedHeroSelection>b__82_1(TowerData tower) { }

		internal string <GetLimitedHeroSelection>b__82_4(TowerData heroTower) { }

		internal bool <GetValidHeroForChallenge>b__66_0(TowerData x) { }

		internal RoundSetModModel <PreApplyDC>b__64_0(string rs) { }

		internal string <ValidatePowerSet>b__60_0(PowerData x) { }

		internal PowerData <ValidatePowerSet>b__60_1(IGrouping<String, PowerData> y) { }

		internal string <ValidatePowerSet>b__60_2(string x) { }

		internal string <ValidatePowerSet>b__60_3(PowerData y) { }

		internal PowerData <ValidatePowerSet>b__60_4(string x, PowerData y) { }

		internal bool <ValidateTowerSet>b__61_0(TowerData t) { }

		internal bool <ValidateTowerSet>b__61_1(TowerData t) { }

		internal string <ValidateTowerSet>b__61_2(TowerData x) { }

		internal TowerData <ValidateTowerSet>b__61_3(IGrouping<String, TowerData> y) { }

		internal string <ValidateTowerSet>b__61_4(string x) { }

		internal string <ValidateTowerSet>b__61_5(TowerData y) { }

		internal TowerData <ValidateTowerSet>b__61_6(string x, TowerData y) { }

		internal bool <ValidateTowerSet>b__61_7(TowerData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public PowerModel powerModel; //Field offset: 0x10

		public <>c__DisplayClass60_0() { }

		internal bool <ValidatePowerSet>b__5(PowerData p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public TowerDetailsModel towerDets; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal bool <ValidateTowerSet>b__8(TowerData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_1
	{
		public TowerDetailsModel towerDets; //Field offset: 0x10

		public <>c__DisplayClass61_1() { }

		internal bool <ValidateTowerSet>b__9(TowerData t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public DailyChallengeModel dcm; //Field offset: 0x10
		public float bossSpeedMultiplier; //Field offset: 0x18
		public float ceramicHealthMultiplier; //Field offset: 0x1C
		public float moabHealthMultiplier; //Field offset: 0x20
		public float bossHealthMultiplier; //Field offset: 0x24

		public <>c__DisplayClass65_0() { }

		internal bool <ApplyDCToGameModel>b__0(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__1(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__2(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__3(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__4(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__5(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__6(BloonModel bloon) { }

		internal bool <ApplyDCToGameModel>b__7(BloonModel bloon) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public bool hasBannedHeroes; //Field offset: 0x10
		public String[] bannedHeros; //Field offset: 0x18
		public bool canUseAnyHero; //Field offset: 0x20

		public <>c__DisplayClass82_0() { }

		internal bool <GetLimitedHeroSelection>b__2(TowerData heroTower) { }

		internal bool <GetLimitedHeroSelection>b__3(TowerData heroTower) { }

	}

	internal struct ChallengeModifierData
	{
		public readonly ChallengeModifiers challengeModifiers; //Field offset: 0x0
		public readonly ChallengeModifierCategory modifierCategory; //Field offset: 0x4
		public readonly string localizedDescription; //Field offset: 0x8
		public readonly float modifierValue; //Field offset: 0x10
		public readonly string localizedTitle; //Field offset: 0x18
		public readonly string minTxtOverride; //Field offset: 0x20
		public readonly string maxTxtOverride; //Field offset: 0x28

		public ChallengeModifierData(ChallengeModifiers challengeModifiers, ChallengeModifierCategory modifierCategory, string localizedDescription, float modifierValue, string localizedTitle, string minTxtOverride, string maxTxtOverride) { }

	}

	public const string CHOSENPRIMARYHERO = "ChosenPrimaryHero"; //Field offset: 0x0
	public const string CHOSENSECONDARYHERO = "ChosenSecondaryHero"; //Field offset: 0x0
	public const int LeastCashOrTiersNotSetValue = 99999999; //Field offset: 0x0
	private static readonly List<String> validCamoRegenBloons; //Field offset: 0x0
	private static readonly List<String> validFortifiedBloons; //Field offset: 0x8
	public List<TowerData> towers; //Field offset: 0x10
	public List<PowerData> powers; //Field offset: 0x18
	[MapName]
	public string map; //Field offset: 0x20
	[Difficulty]
	public string difficulty; //Field offset: 0x28
	public string rewards; //Field offset: 0x30
	[Mode]
	public string mode; //Field offset: 0x38
	public int id; //Field offset: 0x40
	public int maxTowers; //Field offset: 0x44
	public int maxPowers; //Field offset: 0x48
	public int leastCashUsed; //Field offset: 0x4C
	public int leastTiersUsed; //Field offset: 0x50
	public bool ignoreLeastMode; //Field offset: 0x54
	public BloonModifiers bloonModifiers; //Field offset: 0x58
	[Range(0, 5)]
	public float removeableCostMultiplier; //Field offset: 0x60
	[Range(0, 5)]
	public float abilityCooldownReductionMultiplier; //Field offset: 0x64
	public List<String> roundSets; //Field offset: 0x68
	public bool disableMK; //Field offset: 0x70
	public bool disableSelling; //Field offset: 0x71
	public bool disablePowers; //Field offset: 0x72
	public bool disableInstas; //Field offset: 0x73
	public bool disableDoubleCash; //Field offset: 0x74
	public bool disableFastTrack; //Field offset: 0x75
	public bool noContinues; //Field offset: 0x76
	public bool noInstaReward; //Field offset: 0x77
	public StartRules startRules; //Field offset: 0x78
	public string name; //Field offset: 0x80
	public bool displayIncludedTowers; //Field offset: 0x88
	public bool displayIncludedPowers; //Field offset: 0x89
	public int seed; //Field offset: 0x8C
	[Range(1, 4)]
	public int numberOfPlayers; //Field offset: 0x90
	public CoopDivision coopDivisionType; //Field offset: 0x94
	[TowerType]
	public String[] temporaryUnlockedTowers; //Field offset: 0x98
	public int maxParagons; //Field offset: 0xA0
	[JsonProperty("prePlacedAssets")]
	public CustomMapModel customMapModel; //Field offset: 0xA8
	[ExtendedDrawer]
	public SimulationBehaviorsMod simulationBehaviorsMod; //Field offset: 0xB0
	public bool disableHeroBoosting; //Field offset: 0xB8
	public bool disableTowerXp; //Field offset: 0xB9
	public List<String> overriddenPlayerCosmetics; //Field offset: 0xC0
	public bool disablePlayerCosmetics; //Field offset: 0xC8
	public CashModifiers cashModifiers; //Field offset: 0xD0
	public bool hasDailyChallengeStats; //Field offset: 0xD8
	public string eventID; //Field offset: 0xE0
	public ChallengeType chalType; //Field offset: 0xE8
	public DateTime endTimeUTC; //Field offset: 0xF0
	public DateTime startTimeUTC; //Field offset: 0xF8
	public bool validatedTowerSet; //Field offset: 0x100
	public bool validatedPowerSet; //Field offset: 0x101
	private string _uniqueDCId; //Field offset: 0x108

	public ChallengeCreationType ChallengeCreationType
	{
		 get { } //Length: 216
	}

	[JsonIgnore]
	public bool HasCustomRounds
	{
		 get { } //Length: 69
	}

	[JsonIgnore]
	public bool IsDefaultDcm
	{
		 get { } //Length: 179
	}

	[JsonIgnore]
	public bool IsUnlosable
	{
		 get { } //Length: 276
	}

	[JsonIgnore]
	public string uniqueDCId
	{
		 get { } //Length: 223
	}

	private static DailyChallengeModel() { }

	public DailyChallengeModel() { }

	[CompilerGenerated]
	internal static string <ValidateDailyChallenge>g__GetIdPrefix|83_0(ChallengeType challengeType) { }

	private static string AddCamoRegenToBloonString(string bloon, bool camo, bool regen, bool fortified) { }

	public static void ApplyDCToGameModel(DailyChallengeModel dcm, GameModel gameModel) { }

	public DailyChallengeModel Clone() { }

	public bool CompareKeyValues(DailyChallengeModel com) { }

	public void CopyValues(DailyChallengeModel from) { }

	public static DailyChallengeModel CreateDefaultEditorModel() { }

	public ChallengeCreationType get_ChallengeCreationType() { }

	public bool get_HasCustomRounds() { }

	public bool get_IsDefaultDcm() { }

	public bool get_IsUnlosable() { }

	public string get_uniqueDCId() { }

	public List<TowerData> GetAvailableTowers() { }

	public int GetDefaultEndRound() { }

	private int GetDefaultStartRound() { }

	public List<TowerData> GetExcludedTowers(bool ignoreHeroes) { }

	public List<String> GetLimitedHeroSelection(String[] bannedHeros = null) { }

	public LootSet GetLootSet() { }

	public List<ChallengeModifierData> GetModList(bool includeExtras = false, bool includeSpecialConditions = false) { }

	public int GetTotalLeakDamage() { }

	public string GetValidHeroForChallenge(string playersPrimaryHeroSelection, String[] bannedHeros = null) { }

	public static ModModel PreApplyDC(DailyChallengeModel dcm, out bool disableMK) { }

	public void SetDefaults() { }

	public void ValidateDailyChallenge(ChallengeType challengeType, string specificId = null, DateTime startDate = null, DateTime endDate = null) { }

	public void ValidatePowerSet() { }

	public void ValidateTowerSet() { }

}

