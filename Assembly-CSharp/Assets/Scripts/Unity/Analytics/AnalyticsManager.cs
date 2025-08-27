namespace Assets.Scripts.Unity.Analytics;

public class AnalyticsManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public Btd6Player player; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal void <PlayerLoaded>g___onPlayerLoaded|0(LiNKAccount linkAct) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public string bloon; //Field offset: 0x10
		public int round; //Field offset: 0x18

		public <>c__DisplayClass34_0() { }

		internal bool <GetLeakedBloon>b__0(LeakedBloon x) { }

	}

	[CompilerGenerated]
	private struct <GetHackerStatus>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Nullable`1<Boolean>> <>t__builder; //Field offset: 0x8
		private string <playerId>5__2; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetValidServerUrl>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		private List<String> <serverUrls>5__2; //Field offset: 0x20
		private Dictionary<String, Task`1<Boolean>> <hostnameCheckTasks>5__3; //Field offset: 0x28
		private TimeSpan <timeout>5__4; //Field offset: 0x30
		private float <startSeconds>5__5; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x3C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSettings>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AnalyticsManager <>4__this; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCrossPromoLiNKAttributionEvent>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string action; //Field offset: 0x28
		public string type; //Field offset: 0x30
		public int appId; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendLiNKAttributionEvent>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private string <nkAttributionId>5__2; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartSession>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public AnalyticsManager <>4__this; //Field offset: 0x28
		public bool isOfflineMode; //Field offset: 0x30
		private TaskAwaiter<Nullable`1<Boolean>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class LeakedBloon
	{
		public readonly string bloon; //Field offset: 0x10
		public readonly int roundId; //Field offset: 0x18
		public int count; //Field offset: 0x1C
		public int totalDamage; //Field offset: 0x20

		public LeakedBloon(string bloon, int round) { }

	}

	[CompilerGenerated]
	private static AnalyticsManager <Instance>k__BackingField; //Field offset: 0x0
	public readonly ContentBrowserAnalytics ContentBrowser; //Field offset: 0x10
	public readonly AssetBundleAnalytics AssetBundles; //Field offset: 0x18
	public readonly TwitchAnalytics TwitchAnalytics; //Field offset: 0x20
	private bool isReportedHacker; //Field offset: 0x28

	private int AttemptId
	{
		private get { } //Length: 70
	}

	public static bool EventsEnabled
	{
		 get { } //Length: 7
		 set { } //Length: 103
	}

	private int GameId
	{
		private get { } //Length: 70
	}

	public string HostName
	{
		 get { } //Length: 66
		 set { } //Length: 114
	}

	public private static AnalyticsManager Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	private string Platform
	{
		private get { } //Length: 128
	}

	private Btd6Player Player
	{
		private get { } //Length: 7
	}

	public AnalyticsManager() { }

	[CompilerGenerated]
	internal static string <EndBoss>g__padMilliSeconds|83_0(int ms) { }

	public void AccessBossMenu(string from) { }

	public void AccessCTMenu(string from) { }

	public void AccessOdysseyMenu(string from) { }

	public void AccessPlayerStatsMenu(bool ownStats, string from) { }

	public void AccessRaceMenu(string from) { }

	public void AccountMerged(string oldUserId, string newUserId) { }

	public void ActivateCorvusSpell(string spellId, bool turnOn) { }

	private void AddBaseTowerUpgradeInfo(AnalyticsData analyticData, int gameId, int attemptId, BaseTowerUpgradeInfo upgradeInfo, AnalyticsGameSessionInfo sessionInfo, string mode) { }

	public void BlockedHostnames(IList<String> hostnames) { }

	public void BloonMovement(bool autoSend, bool fastForward) { }

	public void BossBeaten(int bossTier, int round, bool isElite, BossType bossType, bool isRanked) { }

	public void BossRushDeath(int round_id, string bossName, string mapName, int islandNo, int deathCount, string eventId) { }

	public void BossRushIslandClicked(int tileIndex, string islandStatus) { }

	public void BossRushIslandOpened(int islandIndex, string islandStatus) { }

	public void BossRushRewardsClaimed(int islandIndex, string rewards, string guildId) { }

	public void BossRushStartTrack(string eventId, string relics, string towers, int maxTowers, int islandIndex, string mapName, int ticketsRemaining, int mmSpent) { }

	public void BuyItem(string itemName, float amountSpent, string currency) { }

	public void ChangeAvatar(string avatarname) { }

	public void ChangeBanner(string bannername) { }

	public void ChangeEventBanner(string bannerName, string clickOrAutomatic, int bannerPosition) { }

	public void ChangeLanguage(string previousLanguage, string previousLanguageCode, string newLanguage, string newLanguageCode) { }

	public void ChangeMenu(string from, string menu) { }

	public void changeTargetingPrio(string towerName, string prev_or_next) { }

	public void CheckCTNode(string guildID, string eventId, int instance, int nodeID, string owner, bool playable, int score, string type, string bossName, string relicName, string tileType, int x, int y) { }

	public void ChoseLocalSave(ProfileModel localData, ProfileModel remoteData) { }

	public void ChoseRemoteSave(ProfileModel localData, ProfileModel remoteData) { }

	private void ChoseSaveFromConflict(ProfileModel localData, ProfileModel remoteData, bool usedLocal) { }

	public void ClaimQuestReward(int currentQuestIndex, string questName, int unlockLevel, string reward_name) { }

	public void ClickInfoPanel(string accessedFrom) { }

	public void CollectionCrateOpened(string eventId, int crateIndex) { }

	public void CoopCreatedMatch(int numPlayers, string mapName, string difficulty, string mode, string matchId) { }

	public void CoopEndTrack(string CoopLobbyId, string RelayIP, Nullable<TimeSpan> CoopAvgLatency, Nullable<TimeSpan> maxLatency, int gameTime, string endResult) { }

	public void CoopJoinedMatchWithCode(string matchId) { }

	public void CoopJoinedQuickMatch(string matchType, string matchId) { }

	public void CoopLeftLobby(string matchId) { }

	public void CoopPlayerRemoved(string lobbyId, int round) { }

	public void CoopRejoin(string openedFrom, bool triedRejoin, string lobbyId) { }

	public void CoopRejoinComplete(string lobbyId, int round, TimeSpan waitTime) { }

	public void CoopRejoinSucceeded(string lobbyId, int round) { }

	public void CoopSentCash(float sumOfCashSent, int totalTimesCashSent, int totalTimesCashReceived, float sumOfCashReceieved, float cashRemaining, int round, string gameMode) { }

	public void CoopStartQuickMatch(string matchType) { }

	public void CoopStartTrack(string matchId, string division, bool isRestart) { }

	public void CoopUpdateLobby(string previousId, string newId, bool isPublic) { }

	private void CreateParagon(int gameId, int attemptId, ParagonUpgradeInfo upgradeInfo, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void CTEnableCosmetic(string guildID, string itemName, string selectionType) { }

	public void CTLeaderboardOpen(string eventId, string guildID, int instance, string accessedFrom) { }

	public void CTStartTrack(string eventId, int instance, int node, string guildID, bool resumedGame, string activeRKnowledge, string owner, bool isRestart) { }

	private void DamageIgnored(int gameId, int attemptId, LeakedBloon leakedBloon, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	private void DamageReceived(int gameId, int attemptId, LeakedBloon leakedBloon, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void DesyncDetected(string map, string difficulty, int numOfPlayers, int roundReached) { }

	public void DeviceModel(string modelName) { }

	public void DeviceSpecs(string deviceModel, int systemMemorySize, int processorCount, int processorFrequency, string graphicsDeviceName, int graphicsMemorySize, int graphicsShaderLevel, string currentAssetScale) { }

	public void EarntLeaderboardBadge(string eventId, LeaderboardType leaderboardType, bool isMini, bool isElite, LeaderboardBadgeType badgeType, bool isLocal, bool isTeam) { }

	public void EarntLeaderboardTrophies(string eventId, LeaderboardType leaderboardType, bool isMini, bool isElite, int quantity) { }

	public void EditOrClearClicked(string buttonClicked, string creationId) { }

	public void EndBoss(string eventID, int roundReached, bool wasBestTime, EndMapState state, int currCash, int currLives, int towersPlaced, int abilitiesUsed, int cashSpent, int rawCashSpent, int startingCash, float averageTowerAttackSpeed, float averageTowerDamage, float averageTowerPierce, bool isRanked, bool isElite, bool isCoop, int playerCount, BossType bossType, bool usedDc, int activatedPowerCount, string teamId, SubGameType subGameType, BossScoreComponents bossScore) { }

	public void EndCTNode(EndMapState state, string statusChange, int prevScore, int newScore, string guildId, int instance, int TileId, Nullable<Int32> rcs, bool loadedSave) { }

	public void EndDailyChallenge(EndMapState state, string challengeId, string challengeType, int roundReached, int livesLeft, bool noLivesLost) { }

	public void EndGameNecroBloons(int gameId, int attemptId, ObjectId towerId, int bloons_spawned) { }

	public void EndQuestStep(string questName, string taskName, int taskId, long score, bool victory) { }

	public void EndRace(string eventID, int roundReached, float timeRecorded, bool wasBestTime, EndMapState state, int currCash, int currLives, int towersPlaced, int abilitiesUsed, int cashSpent, int rawCashSpent, int startingCash, float averageTowerAttackSpeed, float averageTowerDamage, float averageTowerPierce, bool usedDc, int activatedPowerCount) { }

	public void EndTrack(EndMapState state, int wasFreeplay, int roundsReached, int livesLeft, bool noLivesLost) { }

	public void EquipTrophyStoreItem(string itemId) { }

	public void EventPanelNavigation(string navigatedTo, int bannerPriority = -2147483648, string buttonOrBanner = "", int buttonPosition = 0, string activeOrInactive = "") { }

	public void FailedLeaderboardSubmission(LeaderboardType leaderboardType, string leaderboardId, ulong score, bool isMini, string exception, bool isElite = false, int teamSize = 1) { }

	private void FirstPurchase(string itemName, float amountSpent, string currency) { }

	private void FirstSession() { }

	public void FirstTimeWin(string game_mode, string difficulty, string mapName) { }

	public void ForceDefeat(GameType gameType, string eventId, bool isCoop) { }

	public void GainKnowledgePoints(int pointsEarnt, string howEarnt) { }

	public void GainMonkeyMoney(int amountGained, string gainedBy) { }

	public void GainTrophies(int amountGained, string gainedBy) { }

	public void GeraldoShopRoundData(Dictionary<String, Int32> data, int round) { }

	private int get_AttemptId() { }

	public static bool get_EventsEnabled() { }

	private int get_GameId() { }

	public string get_HostName() { }

	[CompilerGenerated]
	public static AnalyticsManager get_Instance() { }

	private string get_Platform() { }

	private Btd6Player get_Player() { }

	public void getCollectionPoints(string eventId, int amount) { }

	private string GetEventName(string baseName, bool isCheated) { }

	[AsyncStateMachine(typeof(<GetHackerStatus>d__54))]
	private static Task<Nullable`1<Boolean>> GetHackerStatus() { }

	public void GetInstaMonkey(string monkey_name, Int32[] rawTier, LootFrom source) { }

	private LeakedBloon GetLeakedBloon(List<LeakedBloon> bloonsList, string bloon, int round) { }

	public void GetPower(string powerName, int quantity, int mmSpent, LootFrom gainedBy) { }

	private string GetRankedLeaderboardId() { }

	private string GetTierName(Int32[] rawTiers) { }

	private long GetTimeDelta(float start, float end) { }

	[AsyncStateMachine(typeof(<GetValidServerUrl>d__25))]
	public Task<String> GetValidServerUrl() { }

	public void GoldenBloonAppeared(string goldenBloonType, int spawnRound) { }

	public void GoldenBloonEscaped(string goldenBloonType, int spawnRound) { }

	public void GoldenBloonPopped(string goldenBloonType, int spawnRound, int mmReward) { }

	public void GuildManagement(GuildModel model, string action) { }

	public void GuildMemberManagement(GuildModel model, string member, string action) { }

	public void GuildQuickJoin(GuildModel model, bool successful, int searchItterations, int failedJoinAttempts, bool searchTimedOut, bool seachCancelled, string action) { }

	public void HackerDetected(string triggered_by, string hack_type, string hacked_value, bool triggerEverytime = false) { }

	private bool HasIgnoredDamage(LifeLeakInfo lifeLeakInfo) { }

	public static Task Initialize() { }

	public static bool IsDamageEnabled() { }

	public void JukeboxAddAllTracks() { }

	public void JukeboxAddTrack(string trackname, int playlistsize) { }

	public void JukeboxOpened() { }

	public void JukeboxRemoveAllTracks() { }

	public void JukeboxRemoveTrack(string trackname, int playlistsize) { }

	public void JukeboxSwitched(bool turnedOn) { }

	public void LegendsAddArtifact(string seed, int rogueGameId, int progress, int stage, string artifact, int artifactTier) { }

	public void LegendsAddInsta(string seed, int rogueGameId, int progress, int stage, string insta, string tier) { }

	public void LegendsArtifactEnhanced(string seed, int rogueGameId, int progress, int stage, string artifact, int artifactTier) { }

	public void LegendsArtifactExtracted(string seed, int rogueGameId, int stage, string artifact, int artifactTier) { }

	public void LegendsBloonsPopped(string seed, int rogueGameId, int progress, int stage, int bloonsPopped, int moabsPopped, int bfbsPopped, int badsPopped, int ddtsPopped, int bossesPopped) { }

	public void LegendsBuyMarshmallow(string seed, int rogueGameId, int progress, int stage, string mallowName, int mallowTier, int maxTier, int mallowCost, int mallowsBefore, int mallowsAfter) { }

	public void LegendsCampfireClicked(string seed, int rogueGameId, int progress, int stage, string choice) { }

	public void LegendsEarnXP(string seed, int rogueGameId, int progress, int stage, int xpEarnt, int xpPrior, int xpNow, string earntFrom, bool addedToTotal) { }

	public void LegendsLootChoices(string seed, int rogueGameId, int progress, int stage, int slot, string option, string tier) { }

	public void LegendsLootChosen(string seed, int rogueGameId, int progress, int stage, string choice, string tier) { }

	public void LegendsLoseHearts(string seed, int rogueGameId, int progress, int stage, string tileLost, int livesRemaining, string loseSkip) { }

	public void LegendsMerchantTrade(string seed, int rogueGameId, int progress, int stage, string selectedArtifacts, string merchantArtifacts) { }

	public void LegendsMiniGameScore(string seed, int rogueGameId, int progress, int stage, int tierAchieved, string gameMode) { }

	public void LegendsQueueBoosts(string seed, int rogueGameId, int progress, int stage, bool isOn) { }

	public void LegendsRemoveArtifact(string seed, int rogueGameId, int progress, int stage, string insta, string tier) { }

	public void LegendsRemoveInsta(string seed, int rogueGameId, int progress, int stage, string insta, string tier) { }

	public void LegendsRerollLoot(string seed, int rogueGameId, int progress, int stage, int rerollCost) { }

	public void LegendsStageComplete(string seed, int rogueGameId, int progress, int stage) { }

	public void LegendsStageFailed(string seed, int rogueGameId, int progress, int stage) { }

	public void LegendsTileClicked(string seed, int rogueGameId, int progress, int stage, string tileType, bool isLegendary) { }

	public void LegendsUseBoost(string seed, int rogueGameId, int progress, int stage, string insta, string tier) { }

	public void LevelUpHero(string heroName, int newLevel, int cashSpent, int roundId, string map, string difficulty, string mode) { }

	public void LiNKFriendMenuAccessed(string accessedFrom, int totalFriends, int totalAwaitingTheirRequests, int totalAwaitingYourRequests, int totalBlocked) { }

	public void LiNKFriendRequestAction(string friend_userid, FriendsCall callType) { }

	public void LiNKFriendRequestsToggled(bool allowFriendRequests) { }

	public void LiNKGuildAction(string guildID, GuildsCall callType) { }

	public void LiNKGuildMenuAccessed(string eventId, string guildID, int instance, string accessedFrom, string whichPage) { }

	public void LoadCTWorld(string eventId, string guildID, int instance) { }

	[AsyncStateMachine(typeof(<LoadSettings>d__17))]
	private Task LoadSettings() { }

	public void LoginError(string error) { }

	public void MapDifficultyUnlocked(string difficulty) { }

	public void MapInteractableConfirmed(string modelName, string mapName) { }

	public void MapSaves(string mapname, int totalsaves, int uniquemaps) { }

	public void MedalGained(string map, string difficulty, string mode, bool isCoop, int totalAfter, int totalMap) { }

	public void MergeBeast(string beast, int power, int x, int y, string beastId) { }

	public void MigrateNoLinkID(string oldNoLinkID, string newNoLinkID) { }

	public void ModsDetected(string appsValue, string librariesValue) { }

	public void MonkeyTeamsVictory() { }

	public void NavigateMessagetoBoard() { }

	public void NKNetworkingError(string type, string info, string url) { }

	public void OdysseyComplete(string eventid, int difficulty, int lives_remaining) { }

	public void OdysseyEndTrack(OdysseySaveData savedata, int currentround, int currenthealth, string winlossquit, int islandNumber) { }

	public void OdysseyLoadout(int chosenDifficulty, string odysseyId, Dictionary<String, Int32> monkeys, Dictionary<String, Int32> powers) { }

	public void OdysseyReplayComplete(string eventid, int difficulty, int lives_remaining) { }

	public void OdysseyStartTrack(OdysseySaveData savedata, string mapname, bool resumedgame, string difficulty, int islandNumber, bool isRestart) { }

	public void OpenAccoladesStore(PlayerContentInfo playerContentInfo, string openFrom) { }

	public void OpenBossChallengeScreen(string accessedfrom) { }

	public void OpenBossRushScreen(string openFrom) { }

	public void OpenChallengeEditorPlayScreen(string accessedFrom, string challengeId) { }

	public void OpenChallengeEditorScreen(string accessedFrom) { }

	public void OpenedEventsPanel() { }

	public void OpenedMapEditorIAPTab(string accessed_from) { }

	public void OpenMapEditorPlayScreen(string accessedFrom, string mapId) { }

	public void OpenMapEditorScreen(string accessedFrom) { }

	public void OpenOdysseyEditorPlayScreen(string accessedFrom, string odysseyId) { }

	public void OpenOdysseyEditorScreen(string accessedFrom) { }

	public void OpenPowerScreen(string previousMenu) { }

	public void OpenQuestMenu(string accessedFrom) { }

	public void OpenStore(string previousMenu) { }

	public void OpenTeamsStore(string eventId, string guildID, int instance, string accessedFrom) { }

	public void OpenTrophyStore(int trophyBalance) { }

	public void OwnerIdMismatch(string ownerId, bool isStaging) { }

	private void PlaceHero(int gameId, int attemptId, TowerPlaceInfo towerPlaceInfo, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	private void PlaceTower(int gameId, int attemptId, TowerPlaceInfo towerPlaceInfo, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void PlayerDisconnected(string map, string difficulty, int numOfPlayers, int roundReached, string reason) { }

	public void PlayerFollowed(string playerId, int increment, int countBefore) { }

	public void PlayerLoaded(Btd6Player player) { }

	public void PresentAvailable(int playerRank, string towerName) { }

	public void PresentOpened(int playerRank, string towerName) { }

	public void PresentTapped(int popCount, int popsRemaining, int playerRank, string towerName) { }

	public void PrimeDropClaimed(string dropId, string Rewards) { }

	public void RacePassClaim(int quantity, int total, string source) { }

	public void RacePassClaimFailed(int quantity, string source) { }

	public void RacePassConsumed(string raceId, int total) { }

	public void RaceRemoved(RaceEventData raceEventData) { }

	private void RankedGame(string leaderboardId, string actionName, int gameId, int attemptId, int roundId, string unit, string details, string upgradePath, string unitCoordinates, double cash, string teamId, long time, long deltaTime) { }

	public void RankUp(int rankReached, bool isVeteran) { }

	public void ReceivedMapKey(string keyType, int keysRemaining, bool fromGift) { }

	public void RelayDisconnect(string exception, string lobbyOrGame) { }

	public void ReleaseCaveMonkey(string towerName, int roundId) { }

	public void ReplayTaskDialogue(string questName, int taskId) { }

	public void Report(AnalyticsData data, AnalyticsEventGroup eventGroup = 0, bool forceSendHackerAnalytics = false) { }

	public void ReportIncompatibleDataVersion(string dataVersion, string clientVersion, string playOrConflict) { }

	public void ReportRoundEvents(AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void RestartCoopGame(string map, string difficulty, int roundReached) { }

	public void RestartGame(string map, string difficulty, int roundReached) { }

	public void RestartGame(string map, string difficulty, int roundReached, bool isCoop) { }

	public void RestartLegendsCampaign(string seed, int rogueGameId, int previousProgress, int stage, string hero, int lives) { }

	public void RestartOdyssey(string odysseyId) { }

	public void RestartRace(string eventID, int mmSpent, int mmLeft, bool hasRacePass) { }

	private void RoundBalance(int gameId, int attemptId, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void SavedGame(GameEditorModel gameEditorModel, string creationId) { }

	public void SavedMap(MapEditorModel mapEditorModel, string creationId) { }

	public void ScreenResolution(int horizontal, int vertical, bool isFullScreen) { }

	public void SearchBarUseage(string searchType, string searchString) { }

	public void SelectHero(string heroName) { }

	public void SelectRelic(string eventId, string guildID, int instance, string relicName, string location, string selectionType) { }

	public void SelectTowerToUnlock(string towerName, string conditions) { }

	private void SellMonkey(int gameId, int attemptId, TowerSellInfo towerSoldInfo, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup, string mode) { }

	private void SendAppleAdsAttributionEvent() { }

	[AsyncStateMachine(typeof(<SendCrossPromoLiNKAttributionEvent>d__24))]
	public void SendCrossPromoLiNKAttributionEvent(string type, string action, int appId) { }

	public void SendEmote(string emoteId) { }

	public void SendExcessTowerXPValues() { }

	[AsyncStateMachine(typeof(<SendLiNKAttributionEvent>d__23))]
	private void SendLiNKAttributionEvent() { }

	public void SendMute(bool muted) { }

	public static void set_EventsEnabled(bool value) { }

	public void set_HostName(string value) { }

	[CompilerGenerated]
	private static void set_Instance(AnalyticsManager value) { }

	public void SetPUS(string playerID, string status) { }

	public void ShowColourOfPlayerPause(string colour) { }

	public void ShowCrewDetails() { }

	public void ShowIslandRules() { }

	public void ShowPlayerPause(string map, string difficulty, int numOfPlayers, int roundReached, bool wasMe) { }

	public void SpendMonkeyMoney(int amountSpent, string spentOn, int amountLeft) { }

	public void SpendTrophies(int amountSpent, string itemId, string itemName, int amountLeft) { }

	public void StartDailyChallenge(string mapName, string difficulty, string challengeId, string challengeType, int monkeyMoney, int knowledgePoints, string heroSelected, bool isRestart) { }

	public void StartLegendsCampaign(string seed, int rogueGameId, int stage, string hero, string artifacts, string instas, bool chimps, string curses, int curseCounter, float xpMod) { }

	public void StartMonkeyTeams(String[] monkeyTeams) { }

	public void StartOdyssey(string eventID, ChallengeType odysseyType) { }

	public void StartQuestStep(int currentQuestIndex, string questName, int unlockLevel, string title, string subtitle, int taskId, double gameId, int attemptId, bool isContinue) { }

	public void StartRace(string eventID, string startMethod, int mmSpent, int mmLeft) { }

	[AsyncStateMachine(typeof(<StartSession>d__53))]
	public void StartSession(bool isOfflineMode) { }

	public void StartTrack(string gameMode, bool resumedGame, bool coopMode, string mapName, string difficulty, bool overwroteSave, float monkeyMoney, int knowledgePoints, string heroSelected, string heroSkin, string eventId, int rank, bool isRestart, bool doubleCash, bool fastTrack) { }

	public void SubmittedLeaderboardScore(LeaderboardType leaderboardType, string leaderboardId, string eventID, ulong score, bool isMini, bool isElite, int teamSize, string teamId, float sha) { }

	public void sweepstakesCheckInfo() { }

	public void sweepstakesCheckTC() { }

	public void SweepstakesCompleteTasks(string sweepstakesId, string taskName, int taskTier, string taskTarget, int tickets) { }

	public void SweepstakesReferall(string sweepstakesId, int tickets, string shareCode, bool isSuccess) { }

	public void SweepstakesShare(string sweepstakesId, int tickets, string shareCode) { }

	public void SweepstakesTCAgree() { }

	public void SweepstakesUnlockTask(string sweepstakesId, string taskName) { }

	public void SwitchTrophyStoreTab(string from, string to) { }

	public void TargetTypeButton(string towerName, string targetType) { }

	public void ToggleColourBlindMode(bool colourblindOn) { }

	public void ToggleFF(bool fastForward) { }

	private void TotalDamage(int gameId, int attemptId, int totalDamage, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void TowerGoalUnlock(string towerName) { }

	public void TutorialStepComplete(int tutorialStep) { }

	public void UnequipTrophyStoreItem(string itemId) { }

	public void UnlockAchievement(string achievementName) { }

	public void UnlockHero(string heroName, int playerLevel, string prevMenu) { }

	public void UnlockHeroSkin(string heroName, string skinName, int playerLevel, string prevMenu) { }

	public void UnlockKnowledge(int pointsSpent, string knowledgeName, string knowledgeTree, int pointsLeft) { }

	public void UnlockMapEditor(string unlockedWith, bool unlocked) { }

	public void UnlockPropPack(string proppack, string unlockedWith, bool unlocked) { }

	public void UnlockTowerTier(Int32[] rawTiers, string towerName, string upgradeName, int xpSpent, int xpLeftover) { }

	private void UpgradeUnit(int gameId, int attemptId, TowerUpgradeInfo upgradeInfo, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	private void UseActivatedAbility(int gameId, int attemptId, AbilityActivateInfo abilityActivatedInfo, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup) { }

	public void UseCheckpoint(int roundReachedReal, int roundReached, int mmSpent, string eventId, bool isRanked, bool isElite, bool isCoop, int players) { }

	private void UseContinue(string map, string difficulty, int mmSpent, int roundReached) { }

	public void UseContinue(string map, string difficulty, int mmSpent, int roundReached, bool isCoop) { }

	private void UseCoopContinue(string map, string difficulty, int mmSpent, int roundReached) { }

	public void UseCTCheckpoint(int roundReached, int roundReset, int mmSpent, string eventId, int instance, string guildId, int node, string owner) { }

	public void UsedMapKey(string mapName, string keyType, int keysRemaining) { }

	public void UseFreeContinue(bool isCoop) { }

	public void UseInstaMonkey(string monkeyType, Int32[] rawTier) { }

	private void UsePower(int gameId, int attemptId, string powerName, int roundId, int x, int y, int powersRemaining, AnalyticsGameSessionInfo sessionInfo, AnalyticsEventGroup analyticsGroup, string mode) { }

	public void ViewTrophyStoreItem(string itemId) { }

	public void VoteForRelic(string eventId, string guildID, int instance, string relicName, bool unvote) { }

	public void WebBrowserOpen(string url) { }

	public void WPToggleBeam(string toggled) { }

}

