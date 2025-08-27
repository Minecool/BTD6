namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueLegendsManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RogueTileData, Boolean> <>9__41_0; //Field offset: 0x8
		public static Func<RogueInstaMonkey, Boolean> <>9__45_0; //Field offset: 0x10
		public static Func<ArtifactLoot, Boolean> <>9__45_1; //Field offset: 0x18
		public static Func<ArtifactLoot, Boolean> <>9__50_0; //Field offset: 0x20
		public static Func<ArtifactLoot, Boolean> <>9__51_0; //Field offset: 0x28
		public static Func<ArtifactLoot, Boolean> <>9__52_0; //Field offset: 0x30
		public static Func<ArtifactLoot, Boolean> <>9__53_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <AssignMapsToTileDatas>b__41_0(RogueTileData x) { }

		internal bool <ClaimMMTokens>b__52_0(ArtifactLoot x) { }

		internal bool <ClaimQueuedRogueXp>b__53_0(ArtifactLoot x) { }

		internal bool <GetTokenCount>b__50_0(ArtifactLoot x) { }

		internal bool <RemoveBoosts>b__45_0(RogueInstaMonkey x) { }

		internal bool <RemoveBoosts>b__45_1(ArtifactLoot x) { }

		internal bool <RemoveTokens>b__51_0(ArtifactLoot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public string heroSkinId; //Field offset: 0x10
		public string heroBaseId; //Field offset: 0x18

		public <>c__DisplayClass30_0() { }

		internal bool <GetHeroStarterKit>b__0(RogueHeroStarterKit x) { }

		internal bool <GetHeroStarterKit>b__1(RogueHeroStarterKit x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public List<String> excludedMaps; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal bool <GetMap>b__0(MapDetails x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public RogueLegendsManager <>4__this; //Field offset: 0x10
		public List<ArtifactLoot> artifactLoots; //Field offset: 0x18
		public Func<ArtifactModelBase, Boolean> <>9__2; //Field offset: 0x20

		public <>c__DisplayClass57_0() { }

		internal bool <GetRandomArtifacts>b__2(ArtifactModelBase x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_1
	{
		public int tier; //Field offset: 0x10
		public <>c__DisplayClass57_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass57_1() { }

		internal bool <GetRandomArtifacts>b__0(ArtifactModelBase x) { }

		internal bool <GetRandomArtifacts>b__1(MapArtifactModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public RogueLootData boostLootData; //Field offset: 0x10
		public RogueLegendsManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass80_0() { }

		internal void <UseQueuedBoost>b__0() { }

	}

	internal sealed class OnRogueGameEnd : MulticastDelegate
	{

		public OnRogueGameEnd(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static RogueLegendsManager instance; //Field offset: 0x0
	private QuestDetails fromQuest; //Field offset: 0x10
	[CompilerGenerated]
	private QuestGameData <QuestInGameData>k__BackingField; //Field offset: 0x18
	private bool isBoostPopupActive; //Field offset: 0x20

	public QuestDetails FromQuest
	{
		 get { } //Length: 5
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private MapSet MapSet
	{
		private get { } //Length: 71
	}

	public private QuestGameData QuestInGameData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueLegendsManager() { }

	[CompilerGenerated]
	private void <BoostPopup>b__78_0() { }

	[CompilerGenerated]
	private bool <GetRandomInstas>b__38_0(string x) { }

	[CompilerGenerated]
	private bool <GetRandomInstas>b__38_1(string x) { }

	public void AddInstaToInventory(RogueInstaMonkey insta) { }

	public void AddLives(int amount) { }

	public void AddRogueShopXp(int amount) { }

	public void ApplyXpShopDCMEffects(DailyChallengeModel dcm) { }

	public void ApplyXpShopStartGameEffects(GameModel moddedGameModel) { }

	public void ApplyXpShopStartMapEffects() { }

	public void AssignMapsToTileDatas(Dictionary<Vector2Int, RogueTileData> tileDatas) { }

	public void BeatTile(Vector2Int coords, bool progress, bool moveToTile, RogueLootData reward) { }

	private void BoostPopup(int round) { }

	public void CheckFeats() { }

	public void CheckForTrophyStoreUnlocks() { }

	public bool CheckIfArtifactOwned(ArtifactModelBase model, int tier) { }

	public void CheckRoundForLootPopup(int round) { }

	public void ChooseLoot(ReturnCallback confirmCallback, RogueLootData rogueLootData, ReturnCallback onRewardScreenClosedCallback = null, ReturnCallback onCancelCallback = null) { }

	public void ClaimFeat(int featId) { }

	public void ClaimMMTokens() { }

	public void ClaimQueuedRogueXp() { }

	public void ClearFromQuest() { }

	public void DeleteRogueRun() { }

	public void Destroy() { }

	public void FailTile(Vector2Int coords, bool reduceLives) { }

	public QuestDetails get_FromQuest() { }

	private LegendsDataModel get_LegendsData() { }

	private MapSet get_MapSet() { }

	[CompilerGenerated]
	public QuestGameData get_QuestInGameData() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private RogueHeroStarterKit GetHeroStarterKit(string heroSkinId, string heroBaseId) { }

	public float GetInstaIngameCost(string baseId, Int32[] tiers, RogueLootType lootType) { }

	public float GetInstaIngameCost(RogueInstaMonkey insta) { }

	private int GetInstaTowerMaxTier(int progress) { }

	private MapDetails GetMap(Random rand, MapDifficulty difficulty, List<String> usedMaps, RogueTileType tileType) { }

	public int GetNextInstaUniqueId() { }

	public List<ArtifactLoot> GetRandomArtifacts(int amount, RogueLootType type, int round, int tileSeed, int tierOverride = -1, int rerollCount = 0, int guaranteedLegendary = 0, bool filterNonExtracted = false, float rareChanceMultiplier = 1, float legendaryChanceMultiplier = 1) { }

	private int GetRandomArtifactTier(Random rand, float rareChanceMultiplier = 1, float legendaryChanceMultiplier = 1) { }

	public List<RogueInstaMonkey> GetRandomInstas(int amount, RogueLootType rogueLootType, int tierOverride, int tileSeed, int round, int rerollCount) { }

	public List<RogueLoot> GetRandomLoot(int amount, RogueLootData rogueLootData, int rerollCount) { }

	private MapDifficulty GetRandomMapDifficulty(Random rand, RogueTileData rogueTileData) { }

	public string GetRogueSaveDataJson() { }

	public List<RogueInstaMonkey> GetStarterInstasForHero(string heroId, string heroBaseId) { }

	public ArtifactLoot GetStartingArtifactForHero(string heroSkinId, string heroBaseId) { }

	public ArtifactModelBase GetStartingArtifactModelForHero(string heroSkinId, string heroBaseId) { }

	public int GetTokenCount() { }

	public bool HasArtifactInLootPoolAlready(ArtifactModelBase artifactModel, List<ArtifactLoot> lootPool) { }

	public void IncreaseRogueStage() { }

	public void InitRogueRun(bool isChimps, bool isTraining) { }

	public void MaxFeatProgress(int featId) { }

	private void OnArtifactAdded(ArtifactLoot artifact, bool ignoreItemArtifact) { }

	private void OnArtifactRemoved(ArtifactLoot artifact) { }

	private void OnBoostPopupClosed() { }

	private void OnBossRushKill(int killCount) { }

	private void OnBossSkull() { }

	public void OnGameStarted() { }

	public void OnGameWin() { }

	public void OnRestart() { }

	private void OnRoundEnd(int round) { }

	private void RemoveBoosts() { }

	public void RemoveInstaFromInventory(RogueInstaMonkey insta) { }

	public void RemoveLives(int amount) { }

	public void RemoveTokens(int amount) { }

	public void ReportFeatProgress(LegendsFeatActive feat) { }

	public void ResetRogueRun(bool isChimps = false) { }

	[CompilerGenerated]
	private void set_QuestInGameData(QuestGameData value) { }

	public void SetRogueInfoFromQuest(QuestDetails quest, QuestGameData questInGameData) { }

	public void StartListeners() { }

	public void StopAndStartListeners() { }

	public void StopListeners() { }

	public bool TryGetQuestRogueData(out RogueQuestInfo data) { }

	public void UseQueuedBoost() { }

}

