namespace Assets.Scripts.Models;

public class GameModel : Model
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PowerModel, Int32> <>9__74_0; //Field offset: 0x8
		public static Func<PowerProModel, Int32> <>9__74_1; //Field offset: 0x10
		public static Func<KnowledgeCategory, KnowledgeCategory> <>9__79_0; //Field offset: 0x18
		public static Func<KnowledgeModel, ModModel> <>9__87_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__74_0(PowerModel p) { }

		internal int <.ctor>b__74_1(PowerProModel p) { }

		internal ModModel <get_AllMods>b__87_0(KnowledgeModel k) { }

		internal KnowledgeCategory <GetCategorisedKnowlege>b__79_0(KnowledgeCategory cat) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass106_0
	{
		public string towerId; //Field offset: 0x10

		public <>c__DisplayClass106_0() { }

		internal bool <GetCreatedTowerModel>b__0(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public KnowledgeCategory cat; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <GetCategorisedKnowlege>b__2(KnowledgeModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public string mname; //Field offset: 0x10

		public <>c__DisplayClass88_0() { }

		internal bool <GetModModel>b__0(ModModel m) { }

	}

	[CompilerGenerated]
	private sealed class <GetTowersWithBaseId>d__95 : IEnumerable<TowerModel>, IEnumerable, IEnumerator<TowerModel>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private TowerModel <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public GameModel <>4__this; //Field offset: 0x28
		private string baseId; //Field offset: 0x30
		public string <>3__baseId; //Field offset: 0x38
		private TowerModel[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48
		private PowerModel[] <>7__wrap3; //Field offset: 0x50

		private override TowerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Towers.TowerModel>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetTowersWithBaseId>d__95(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TowerModel> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.Towers.TowerModel>.GetEnumerator() { }

		[DebuggerHidden]
		private override TowerModel System.Collections.Generic.IEnumerator<Assets.Scripts.Models.Towers.TowerModel>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public float cash; //Field offset: 0x30
	public float startingHealth; //Field offset: 0x34
	public float maxHealth; //Field offset: 0x38
	public float startingShield; //Field offset: 0x3C
	public float maxShield; //Field offset: 0x40
	public float sellMultiplier; //Field offset: 0x44
	public float selectedDifficultyRating; //Field offset: 0x48
	public float maxSoftcapHealth; //Field offset: 0x4C
	public float softcapHealthPercentModifier; //Field offset: 0x50
	public string difficultyId; //Field offset: 0x58
	public int startRound; //Field offset: 0x60
	public int endRound; //Field offset: 0x64
	public bool towerSellEnabled; //Field offset: 0x68
	public int maxTowerCount; //Field offset: 0x6C
	public int maxPowerCount; //Field offset: 0x70
	public int leastCashUsed; //Field offset: 0x74
	public int leastTiersUsed; //Field offset: 0x78
	public bool ignoreLeastMode; //Field offset: 0x7C
	public bool continueEnabled; //Field offset: 0x7D
	public bool doubleCashAllowed; //Field offset: 0x7E
	public string gameMode; //Field offset: 0x80
	public GameType gameType; //Field offset: 0x88
	public SubGameType subGameType; //Field offset: 0x8C
	public int randomSeed; //Field offset: 0x90
	public bool reverseMode; //Field offset: 0x94
	public int raceSendRoundDelay; //Field offset: 0x98
	public bool goldenBloonActive; //Field offset: 0x9C
	public string bossBloonType; //Field offset: 0xA0
	public bool bossEliteMode; //Field offset: 0xA8
	public bool bossRankedMode; //Field offset: 0xA9
	public Int32[] bossSpawnRounds; //Field offset: 0xB0
	public int penaltyGraceTimeFrames; //Field offset: 0xB8
	public float penaltyGraceTimeSecondsPerRound; //Field offset: 0xBC
	public int spawnHeroesAtLevel; //Field offset: 0xC0
	public float monkeyMoneyReward; //Field offset: 0xC4
	public bool bossForcePreSpawnBoss; //Field offset: 0xC8
	public float bossSpawnDistanceOverride; //Field offset: 0xCC
	public bool isApopalypse; //Field offset: 0xD0
	public int startingRevives; //Field offset: 0xD4
	public bool wasFastTrackApplied; //Field offset: 0xD8
	public float heroXpMultiplier; //Field offset: 0xDC
	public MapModel map; //Field offset: 0xE0
	[CompilerGenerated]
	private RoundSetModel <roundSet>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private IncomeSetModel <incomeSet>k__BackingField; //Field offset: 0xF0
	public SimulationBehaviorModel[] behaviors; //Field offset: 0xF8
	public TowerModel[] towers; //Field offset: 0x100
	public UpgradeModel[] upgrades; //Field offset: 0x108
	public BloonModel[] bloons; //Field offset: 0x110
	public FreeplayBloonGroupModel[] freeplayGroups; //Field offset: 0x118
	public KnowledgeModel[] allKnowledge; //Field offset: 0x120
	public PowerModel[] powers; //Field offset: 0x128
	public PowerProModel[] powersPro; //Field offset: 0x130
	public TowerDetailsModel[] towerSet; //Field offset: 0x138
	public TowerDetailsModel[] heroSet; //Field offset: 0x140
	public PowerDetailsModel[] powerSet; //Field offset: 0x148
	public TowerTierRestrictionModel[] towerTierRestrictions; //Field offset: 0x150
	public BuffIndicatorModel[] buffIndicatorModels; //Field offset: 0x158
	public ParagonDegreeDataModel paragonDegreeDataModel; //Field offset: 0x160
	public GeraldoItemModel[] geraldoItemModels; //Field offset: 0x168
	public CustomMapDataModel customMapDataModel; //Field offset: 0x170
	public MapEditorBehaviorModel mapEditorBehaviorModel; //Field offset: 0x178
	public float globalBloonScale; //Field offset: 0x180
	public float globalBossBloonScale; //Field offset: 0x184
	public float globalTowerScale; //Field offset: 0x188
	private Dictionary<String, BloonModel> bloonsByName; //Field offset: 0x190
	private Dictionary<String, UpgradeModel> upgradesByName; //Field offset: 0x198
	private Dictionary<String, PowerProUpgradeModel> powerProUpgradesByName; //Field offset: 0x1A0
	private Dictionary<KnowledgeCategory, KnowledgeModel[]> _categorisedKnowledge; //Field offset: 0x1A8
	private Dictionary<Type, Dictionary`2<String, Model>> searchCache; //Field offset: 0x1B0

	public IEnumerable<ModModel> AllMods
	{
		 get { } //Length: 357
	}

	public private IncomeSetModel incomeSet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private RoundSetModel roundSet
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public GameModel(TowerModel[] towers, UpgradeModel[] upgrades, BloonModel[] bloons, KnowledgeModel[] allKnowledge, PowerModel[] powers, PowerProModel[] powersPro, FreeplayBloonGroupModel[] freeplayGroups, TowerDetailsModel[] towerSet, TowerDetailsModel[] heroSet, PowerDetailsModel[] powerSet, TowerTierRestrictionModel[] towerTierRestrictions, BuffIndicatorModel[] buffIndicatorModels, ParagonDegreeDataModel paragonDegreeDataModel, GeraldoItemModel[] geraldoItemModels, CustomMapDataModel customMapDataModel) { }

	[CompilerGenerated]
	private KnowledgeModel[] <GetCategorisedKnowlege>b__79_1(KnowledgeCategory cat) { }

	public void CalcStartingCash(GameModel result, List<ModModel> mods) { }

	public virtual Model Clone() { }

	private void CreateModded(GameModel result, List<ModModel> mods, List<RelicKnowledgeItemBase> relicKnowledge) { }

	public GameModel CreateModded(List<String> activeMods, ModModel dcmModModel, ActiveRelicKnowledge activeRelicKnowledge = null, MapModel map = null, RoundSetModel roundSet = null, List<ArtifactLoot> artifactsInventory = null) { }

	public bool DoesBloonExist(string id) { }

	public T Find(string search) { }

	public IEnumerable<ModModel> get_AllMods() { }

	[CompilerGenerated]
	public IncomeSetModel get_incomeSet() { }

	[CompilerGenerated]
	public RoundSetModel get_roundSet() { }

	public TowerModel GetBeastHandlerPetTowerModel(string towerBaseId, int tier) { }

	public BloonModel GetBloon(string id) { }

	public Dictionary<KnowledgeCategory, KnowledgeModel[]> GetCategorisedKnowlege() { }

	public TowerModel GetCreatedTowerModel(string towerId) { }

	public GeraldoItemModel GetGeraldoItemWithName(string name) { }

	public TowerModel GetHeroWithNameAndLevel(string name, int tier) { }

	public List<PowerModel> GetModdedPowers(List<String> activeMods) { }

	public ModModel GetModModel(string mname) { }

	public TowerModel GetParagonTower(string id) { }

	public UpgradeModel GetParagonUpgrade(string id) { }

	public UpgradeModel GetParagonUpgradeForTowerId(string baseId) { }

	public PowerProModel GetPowerProModel(string powerBaseId) { }

	public PowerProUpgradeModel GetPowerProUpgrade(string id) { }

	public PowerModel GetPowerWithId(string id) { }

	public ProjectileModel GetProjectileBySaveId(string saveId) { }

	public PowerProUpgradeModel GetProUpgradeForPower(string powerBaseId, int tier, int path) { }

	public PowerProUpgradeModel GetProUpgradeForTower(TowerModel towerModel, int tier, int path) { }

	public TowerModel GetTower(string baseId, int pathOneTier = 0, int pathTwoTier = 0, int pathThreeTier = 0) { }

	public TowerModel GetTowerFromId(string id) { }

	[IteratorStateMachine(typeof(<GetTowersWithBaseId>d__95))]
	public IEnumerable<TowerModel> GetTowersWithBaseId(string baseId) { }

	public TowerModel GetTowerWithName(string name) { }

	public UpgradeModel GetUpgrade(string id) { }

	public int GetXpCostForProUpgrade(string powerBaseId, int tier) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public static float ScaleRewardForTrackDifficulty(float reward, string trackDifficulty) { }

	[CompilerGenerated]
	private void set_incomeSet(IncomeSetModel value) { }

	[CompilerGenerated]
	private void set_roundSet(RoundSetModel value) { }

	public void SetIncomeSet(IncomeSetModel incomeSetModel) { }

	public void SetRoundSet(RoundSetModel roundSetModel) { }

	public bool TryGetProp(string name, out PropModel propModel) { }

	public void UpdateBloonNames() { }

	public void UpdateUpgradeNames() { }

}

