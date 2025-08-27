namespace Assets.Scripts.Simulation;

public class Simulation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Int32> <>9__117_0; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__118_0; //Field offset: 0x10
		public static Func<Tower, Single> <>9__118_2; //Field offset: 0x18
		public static Func<TowerDetailsModel, Int32> <>9__179_0; //Field offset: 0x20
		public static Predicate<RootObject> <>9__192_0; //Field offset: 0x28
		public static Func<KeyValuePair`2<String, Single>, String> <>9__288_0; //Field offset: 0x30
		public static Func<String, String[]> <>9__289_0; //Field offset: 0x38
		public static Func<String[], String> <>9__289_1; //Field offset: 0x40
		public static Func<String[], Single> <>9__289_2; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <FlushProcessList>b__192_0(RootObject o) { }

		internal string <GetSaveMetaData>b__288_0(KeyValuePair<String, Single> kvp) { }

		internal int <RedistributeTowers>b__118_0(int x) { }

		internal float <RedistributeTowers>b__118_2(Tower t) { }

		internal int <RemovePlayer>b__117_0(int x) { }

		internal String[] <SetSaveMetaData>b__289_0(string part) { }

		internal string <SetSaveMetaData>b__289_1(String[] split) { }

		internal float <SetSaveMetaData>b__289_2(String[] split) { }

		internal int <StockStandardTowerInventory>b__179_0(TowerDetailsModel t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public List<Tower> subTowers; //Field offset: 0x10
		public List<Tower> orphanedSubTowers; //Field offset: 0x18
		public Func<Tower, Boolean> <>9__3; //Field offset: 0x20

		public <>c__DisplayClass118_0() { }

		internal bool <RedistributeTowers>b__1(Tower t) { }

		internal bool <RedistributeTowers>b__3(Tower t) { }

	}

	internal class CashManager
	{
		public readonly KonFuze cash; //Field offset: 0x10
		public readonly bool doubleCash; //Field offset: 0x18
		public readonly bool isActivePlayer; //Field offset: 0x19

		public CashManager(double cash, bool doubleCash, bool isActivePlayer) { }

	}

	internal enum CashSource
	{
		Normal = 0,
		EcoEarned = 1,
		CoopTransferedCash = 2,
		TowerSold = 3,
		TowerBrought = 4,
		TowerUpgraded = 5,
		BankDeposit = 6,
		GeraldoPurchase = 7,
		MapInteractableUsed = 8,
		PropSold = 9,
		QuestAwarded = 10,
		CorvusNourishment = 11,
	}

	internal enum CashType
	{
		Normal = 0,
		Powers = 1,
		Ability = 2,
		EndOfRound = 3,
		NonTransformed = 4,
		CoopCash = 5,
		QuestAwarded = 6,
	}

	internal sealed class ProcessDelegate : MulticastDelegate
	{

		public ProcessDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int elapsed, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int elapsed) { }

	}

	private class SpawnEffectModel
	{
		public TransformModel transformModel; //Field offset: 0x10

		public SpawnEffectModel() { }

	}

	internal struct ThrowawayEffect
	{
		public PrefabReference display; //Field offset: 0x0
		public Vector3 position; //Field offset: 0x8
		public float rotation; //Field offset: 0x14
		public float scale; //Field offset: 0x18

	}

	public static readonly Single[] trackDifficultyXpScale; //Field offset: 0x0
	public static readonly float bossRushXpScale; //Field offset: 0x8
	public static readonly float rogueHeroXpScale; //Field offset: 0xC
	public static readonly float rogueTowerXpScale; //Field offset: 0x10
	public Entity entity; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsHeadless>k__BackingField; //Field offset: 0x18
	public GameModel model; //Field offset: 0x20
	private ObjectId syncedObjectId; //Field offset: 0x28
	private ushort localObjectId; //Field offset: 0x2C
	public SimulationTime time; //Field offset: 0x30
	public SimulationTime roundTime; //Field offset: 0x38
	public bool canEarnXP; //Field offset: 0x40
	public bool debugOptions; //Field offset: 0x41
	public bool instantCooldowns; //Field offset: 0x42
	public bool pauseWeapons; //Field offset: 0x43
	public List<WeaponModel> debugDisabledWeapons; //Field offset: 0x48
	public List<ProjectileModel> debugDisabledProjectiles; //Field offset: 0x50
	public FactoryFactory factory; //Field offset: 0x58
	public BloonManager bloonManager; //Field offset: 0x60
	public TowerManager towerManager; //Field offset: 0x68
	public PowerManager powerManager; //Field offset: 0x70
	public ArtifactManager artifactManager; //Field offset: 0x78
	public GeraldoPurchaseManager geraldoPurchaseManager; //Field offset: 0x80
	public PropManager propManager; //Field offset: 0x88
	public DialogueTriggerManager dialogueTriggerManager; //Field offset: 0x90
	private RushChallengeManager rushChallengeManager; //Field offset: 0x98
	private RogueGameManager rogueGameManager; //Field offset: 0xA0
	public readonly Dictionary<Int32, InputManager> _inputManager; //Field offset: 0xA8
	private Dictionary<Int32, TowerInventory> towerInventories; //Field offset: 0xB0
	private Dictionary<Int32, PowerInventory> powerInventories; //Field offset: 0xB8
	private Dictionary<Int32, GeraldoShopInventory> geraldoShopInventories; //Field offset: 0xC0
	private Dictionary<Int32, Int32> placementAreas; //Field offset: 0xC8
	private Dictionary<Int32, Int32> cashInventories; //Field offset: 0xD0
	public RogueInstaInventory rogueInstaInventory; //Field offset: 0xD8
	private readonly Dictionary<Int32, CorvusManager> corvusManagers; //Field offset: 0xE0
	private readonly Dictionary<String, TSMInfoModel> tsmThemeInfo; //Field offset: 0xE8
	public AudioManagerSim audioManager; //Field offset: 0xF0
	public TrackArrowManager trackArrowManager; //Field offset: 0xF8
	public ProgressiveDifficultyManager progressiveDifficultyManager; //Field offset: 0x100
	public AudioLimiterManager audioLimiterManager; //Field offset: 0x108
	public CollisionChecker collisionChecker; //Field offset: 0x110
	public EffectLimitManager effectLimitManager; //Field offset: 0x118
	public AnalyticsTrackerSimManager analyticsTrackerSimManager; //Field offset: 0x120
	public LockList<RootObject> process; //Field offset: 0x128
	public HashSet<Int32> playersWhoPlacedAHero; //Field offset: 0x130
	public float endOnRoundAdditionalTime; //Field offset: 0x138
	public float endOfRoundHeroXpScale; //Field offset: 0x13C
	public List<ThrowawayEffect> throwawayEffects; //Field offset: 0x140
	public bool hasCashChanged; //Field offset: 0x148
	public bool hasHealthChanged; //Field offset: 0x149
	public bool alternateHeliControls; //Field offset: 0x14A
	public int showCancel; //Field offset: 0x14C
	public List<String> immunityFromBloonTypes; //Field offset: 0x150
	public KonFuze maxHealthIncrease; //Field offset: 0x158
	public KonFuze startingHealth; //Field offset: 0x160
	public KonFuze softcapHealthPercentModifier; //Field offset: 0x168
	public KonFuze maxSoftcapHealth; //Field offset: 0x170
	public KonFuze maxHealth; //Field offset: 0x178
	public KonFuze maxShield; //Field offset: 0x180
	public KonFuze startingRevives; //Field offset: 0x188
	private KonFuze gameStartTimeStamp; //Field offset: 0x190
	private KonFuze gameFinishTimeStamp; //Field offset: 0x198
	public Dictionary<Int32, Single> currentRaceEventTimeRounds; //Field offset: 0x1A0
	public string helperMessage; //Field offset: 0x1A8
	public string unlocalizedhelperMessage; //Field offset: 0x1B0
	public bool gameStarted; //Field offset: 0x1B8
	[CompilerGenerated]
	private bool <gameWon>k__BackingField; //Field offset: 0x1B9
	public bool matchJustWon; //Field offset: 0x1BA
	public bool gameLost; //Field offset: 0x1BB
	public bool noLivesLost; //Field offset: 0x1BC
	public bool autoPlay; //Field offset: 0x1BD
	public bool blockAutoPlay; //Field offset: 0x1BE
	public bool pauseAutoPlay; //Field offset: 0x1BF
	private bool lockHeroPurchases; //Field offset: 0x1C0
	private bool lockTowerPurchases; //Field offset: 0x1C1
	public Int32[] bossSpawnRounds; //Field offset: 0x1C8
	private List<SimulationBehavior> behaviorCache; //Field offset: 0x1D0
	private Dictionary<String, Single> sharedAbilityCooldowns; //Field offset: 0x1D8
	public SharedTowerGrid sharedTowerGrid; //Field offset: 0x1E0
	public KonFuze cashSpent; //Field offset: 0x1E8
	private int elapsedSinceFlush; //Field offset: 0x1F0
	private int inputInterest; //Field offset: 0x1F4
	public int bloonLivesLostOverride; //Field offset: 0x1F8
	public List<String> rogueBoostsAcquired; //Field offset: 0x200
	public int lastRoundRogueBoostLootShownOn; //Field offset: 0x208
	private readonly Dictionary<Int32, CashManager> cashManagers; //Field offset: 0x210
	public bool hasTakenLeakDamage; //Field offset: 0x218
	private KonFuze shield; //Field offset: 0x220
	private KonFuze revives; //Field offset: 0x228
	private KonFuze health; //Field offset: 0x230
	private Map map; //Field offset: 0x238
	public BufferedRandom syncedRandom; //Field offset: 0x240
	public BufferedRandom unsyncedRandom; //Field offset: 0x248
	[CompilerGenerated]
	private bool <WasDoubleCashUsed>k__BackingField; //Field offset: 0x250
	private readonly Dictionary<PrefabReference, SpawnEffectModel> spawnEffectModels; //Field offset: 0x258
	[CompilerGenerated]
	private ISelectable <SelectedObj>k__BackingField; //Field offset: 0x260
	public bool sandbox; //Field offset: 0x268
	public float lastSetHealth; //Field offset: 0x26C
	private int sandBoxResetHealthTimer; //Field offset: 0x270
	private Nullable<Boolean> _isInfinitHealthMode; //Field offset: 0x274
	private Nullable<Boolean> _isBossRushMode; //Field offset: 0x276
	private Nullable<Boolean> _isEndlessRoundsMode; //Field offset: 0x278
	private Nullable<Boolean> _isRogueBossMode; //Field offset: 0x27A
	private int raceSendRoundCount; //Field offset: 0x27C
	private int raceSendRoundTimer; //Field offset: 0x280
	private int roundStartTime; //Field offset: 0x284
	private TimeSpan timePenalty; //Field offset: 0x288
	private float cachedSimBehaviorCashModifier; //Field offset: 0x290
	public int cachedTierCount; //Field offset: 0x294

	public Dictionary<Int32, CashManager> CashManagers
	{
		 get { } //Length: 8
	}

	public InputManager FirstInputManager
	{
		 get { } //Length: 98
	}

	public private bool gameWon
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool HasInputInterest
	{
		 get { } //Length: 11
	}

	public float Health
	{
		 get { } //Length: 32
		 set { } //Length: 890
	}

	public IReadOnlyCollection<InputManager> inputManagers
	{
		 get { } //Length: 71
	}

	public bool IsBossRushMode
	{
		 get { } //Length: 182
	}

	public bool IsDestroyed
	{
		 get { } //Length: 19
	}

	public bool IsEndlessRoundsMode
	{
		 get { } //Length: 206
	}

	public private bool IsHeadless
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsInfinitHealthMode
	{
		 get { } //Length: 206
	}

	public bool IsRogueBossMode
	{
		 get { } //Length: 206
	}

	public Map Map
	{
		 get { } //Length: 8
	}

	public float MaxHealth
	{
		 get { } //Length: 32
		 set { } //Length: 37
	}

	public float MaxSoftcapHealth
	{
		 get { } //Length: 75
		 set { } //Length: 37
	}

	public int Revives
	{
		 get { } //Length: 32
		 set { } //Length: 139
	}

	public int RoundStartTime
	{
		 get { } //Length: 7
	}

	public float SandboxModifyHealth
	{
		 get { } //Length: 32
		 set { } //Length: 37
	}

	public private ISelectable SelectedObj
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public float Shield
	{
		 get { } //Length: 32
		 set { } //Length: 219
	}

	public float SoftcapHealthPercentModifier
	{
		 get { } //Length: 32
		 set { } //Length: 37
	}

	public private bool WasDoubleCashUsed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private static Simulation() { }

	public Simulation() { }

	public void AbilitiesChanged() { }

	public T AddBehavior(SimulationBehaviorModel behaviorDef) { }

	public double AddCash(double c, CashType from, int cashIndex, CashSource source, Tower tower = null, bool cashDoubleable = false) { }

	public void AddGameCompletionTimePenalty(TimeSpan time) { }

	public void AddSharedAbilityCooldown(string id, float cooldownRemaining) { }

	public void AddSharedCash(double c, CashType from, CashSource source, Tower tower = null, bool cashDoubleable = true) { }

	public void AdoraDarkModeActivated() { }

	public bool AnyTiersRemaining() { }

	public bool AreRoundsActive() { }

	public void BloonSpawned(Bloon bloon) { }

	public float CalcDamageFromBloon(Bloon bloon, float damage) { }

	private void CallCallbacks() { }

	public bool CanSendNextRound() { }

	public void CheckRoundDifficulty(int round) { }

	public void CreateCashManager(int index, bool doubleCash, bool isActivePlayer) { }

	public void CreateEntity() { }

	public InputManager CreateInput(int index) { }

	public void CreateTextEffect(Vector3 position, PrefabReference asset, float lifespan, string text, bool notLocalized, DisplayCategory displayCategory = 1) { }

	public void CursorDown(float x, float y, int inputIndex) { }

	public void CursorUp(float x, float y, int inputIndex) { }

	public void CustomUIChanged(Tower tower) { }

	public void DeductSharedCash(double c, CashType from, CashSource source, Tower tower = null, bool cashDoubleable = true) { }

	public void Delete() { }

	public void DestroyAllBloons() { }

	public void DestroyTower(Tower tower, int inputIndex) { }

	public void DistributeCash(Dictionary<Int32, PlayerInfo> playerInfos) { }

	public void DistributeInventory(Dictionary<Int32, PlayerInfo> playerInfos) { }

	public void DistributePlacementAreaInventory(Dictionary<Int32, PlayerInfo> playerInfos) { }

	public void DistributeRogueInventory(List<RogueInstaMonkey> rogueInstas, bool isLoadedSave) { }

	private void DistributeXp(int roundCompleted) { }

	public void DistributeXpToHeroes(float xp, bool isFromEndOfRound) { }

	public Xp DrainXp(int inputIndex) { }

	public void EmitLine(Vector3 ejectPoint, float rotation, float distance, float lineDisplayLength, bool ignoreBlockers, out Vector3 linePosition, out float lineScale, out Vector3 lineEnd, out float distanceToBlocker) { }

	public void FlushProcessList() { }

	public void ForceUpdateBehaviorCache() { }

	public Dictionary<Int32, CashManager> get_CashManagers() { }

	public InputManager get_FirstInputManager() { }

	[CompilerGenerated]
	public bool get_gameWon() { }

	public bool get_HasInputInterest() { }

	public float get_Health() { }

	public IReadOnlyCollection<InputManager> get_inputManagers() { }

	public bool get_IsBossRushMode() { }

	public bool get_IsDestroyed() { }

	public bool get_IsEndlessRoundsMode() { }

	[CompilerGenerated]
	public bool get_IsHeadless() { }

	public bool get_IsInfinitHealthMode() { }

	public bool get_IsRogueBossMode() { }

	public Map get_Map() { }

	public float get_MaxHealth() { }

	public float get_MaxSoftcapHealth() { }

	public int get_Revives() { }

	public int get_RoundStartTime() { }

	public float get_SandboxModifyHealth() { }

	[CompilerGenerated]
	public ISelectable get_SelectedObj() { }

	public float get_Shield() { }

	public float get_SoftcapHealthPercentModifier() { }

	[CompilerGenerated]
	public bool get_WasDoubleCashUsed() { }

	public Dictionary<Int32, Int32> GetAllPlacementAreas() { }

	public T GetBehavior() { }

	public List<SimulationBehavior> GetBehaviors() { }

	public double GetCash(int cashIndex) { }

	public CashManager GetCashManager(int index) { }

	public float GetCashModifierFromSimBehaviors() { }

	public float GetCorvusBarriers() { }

	public CorvusManager GetCorvusManager(int index) { }

	public bool GetCorvusManagerExists(int index) { }

	public int GetCurrentRound() { }

	public int GetEndRound() { }

	public TimeSpan GetGameCompletionTime() { }

	public TimeSpan GetGamePenaltyTime() { }

	public GeraldoShopInventory GetGeraldoShopInventory(int index) { }

	public float GetIncomeMultiplierForRound(int round) { }

	public InputManager GetInputManager(int index) { }

	public int GetInstaCooldownAddition(string towerType) { }

	public T GetOrAddBehavior(SimulationBehaviorModel behaviorDef) { }

	public PowerInventory GetPowerInventory(int index) { }

	public bool GetPowerInventoryExists(int index) { }

	public int GetRaceSendRoundCount() { }

	public List<Mesh> GetRangeMeshes(Tower tower, bool isFromHover) { }

	public void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public ISelectable GetSelection(Vector2 at, float selectionRadius) { }

	public float GetSharedAbilityCooldown(string id) { }

	public float GetSimulationBehaviorDiscount(Tower tower, int path, int tier, float currentDiscount) { }

	public int GetSpawnedRound() { }

	public ObjectId GetSyncedObjectId() { }

	public int GetTiersUsed() { }

	public TowerInventory GetTowerInventory(int index) { }

	public bool GetTowerInventoryExists(int index) { }

	public List<Int32> GetValidPlacementAreasForPlayer(int playerIndex) { }

	public static float GetXpForRound(int roundCompleted, GameModel model) { }

	public ObjectId IncrementSyncedObjectIdVersion() { }

	public void Initialise(GameModel model, bool isHeadless) { }

	public void InitialiseGuideArrows() { }

	public void InitialiseMap(MapModel newMap) { }

	public bool InputManagerExists(int index) { }

	public bool IsCashManagerSetupForPlayer(int index) { }

	public void LockHeroPurchases(bool value) { }

	public void LockTowerPurchases(bool value) { }

	public void MatchReady(bool loadedSave) { }

	public ObjectId NextLocalObjectId() { }

	public ObjectId NextSyncedObjectId() { }

	public void NowEmagTes(bool v) { }

	public void OnRoundEmissionEnd(int roundEmissionFinished) { }

	private void OnRoundEndProjectiles() { }

	public void OnSandboxHealthChanged() { }

	public void PrimeCustomAbilityInput(Ability ability, string className) { }

	public void RedistributePlacementAreaInventory(int removedPlayer) { }

	private void RedistributePlayerInventory(int removedPlayer, Dictionary<Int32, List`1<Tower>> towersGifted = null) { }

	private Dictionary<Int32, List`1<Tower>> RedistributeTowers(int removedPlayer) { }

	public void RegisterInterestInInput() { }

	public void ReleaseTower(string towerName) { }

	public void RemoveCash(double c, CashType from, int cashIndex, CashSource source) { }

	public void RemoveCashManager(int index) { }

	private InputManager RemoveInputManager(int removedPlayer) { }

	public void RemovePlayer(int index, CashManager cashManager) { }

	public float ResetCashModifierFromSimBehaviors() { }

	public void ResetHealth() { }

	public void ResetToInfinitHealth() { }

	public void RoundEnd(int round, int highestCompletedRound) { }

	public void RoundStart(int spawnedRound) { }

	public void SandboxBloonsCleared() { }

	public void SelectionChanged(ISelectable selected) { }

	public void SellProp(Prop prop, int inputId, bool playSellEffect) { }

	public void SellTower(Tower tower, int inputId) { }

	public bool SendCash(int from, int to, double amount) { }

	[CompilerGenerated]
	private void set_gameWon(bool value) { }

	public void set_Health(float value) { }

	[CompilerGenerated]
	private void set_IsHeadless(bool value) { }

	public void set_MaxHealth(float value) { }

	public void set_MaxSoftcapHealth(float value) { }

	public void set_Revives(int value) { }

	public void set_SandboxModifyHealth(float value) { }

	[CompilerGenerated]
	private void set_SelectedObj(ISelectable value) { }

	public void set_Shield(float value) { }

	public void set_SoftcapHealthPercentModifier(float value) { }

	[CompilerGenerated]
	private void set_WasDoubleCashUsed(bool value) { }

	public void SetCash(double c, int cashIndex = -1) { }

	public void SetCursor(float x, float y, bool cursorActive, bool ignoreCursor, int inputIndex) { }

	public void SetHealth(float value, bool ignoreSoftCaps = false) { }

	public void SetHelperMessage(string message, float timeUntilCleared = 3) { }

	public void SetRoundMutators(int rounds) { }

	public void SetSandbox(bool value) { }

	public void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public void SetSyncedObjectId(ObjectId id) { }

	public bool SetVictory() { }

	public void Simulate() { }

	public Entity SpawnEffect(PrefabReference assetRef, Vector3 position, float rotation = 0, float scale = 1, float lifespan = -1, Fullscreen isFullscreen = 0, IRootBehavior transform = null, bool followTransformPosition = false, bool followTransformRotation = false, bool destroyOnTransformDestroy = false, bool alwaysUseAge = false, int limit = 999999999, bool useRoundTime = false, bool throwawayEffect = false, int animationState = -1, DisplayCategory displayCategory = 32) { }

	public ValueTuple<Boolean, Boolean> StartRaceRound(bool viaPlayBtn = false) { }

	public void StartRound() { }

	private void StockStandardPowerInventory(PowerInventory pi) { }

	private void StockStandardTowerInventory(TowerInventory ti, string playerHero) { }

	public void TakeDamage(float damage) { }

	public void TargetTypeChanged(Tower tower, TargetType type) { }

	public void ThriveStatusChanged(bool enabled) { }

	public int TiersRemaining() { }

	public double TotalCash() { }

	public void TowerRangeTransformed() { }

	public void TowerTransformed(Tower tower) { }

	public bool TryGetCashManager(int index, out CashManager cashManager) { }

	public void UnregisterInterestInInput() { }

	public void UpdateStagedCash() { }

	public Dictionary<String, TSMInfoModel> UpdateTsmThemeInfo(PropBase prop) { }

	public Dictionary<String, TSMInfoModel> UpdateTsmThemeInfo(Tower tower) { }

	public void UpgradePricesChanged(Tower tower) { }

}

