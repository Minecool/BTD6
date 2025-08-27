namespace Assets.Scripts.Models.Profile;

public class ProfileModel : ILegendsDataProvider
{
	[CompilerGenerated]
	private struct <<Validate>g__validateCreatorCodeAsync|236_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NexusSettings nexusSettings; //Field offset: 0x20
		private NexusSettings <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<QuestTaskSaveData, Boolean> <>9__236_2; //Field offset: 0x8
		public static Func<SweepstakesStatsForTask, Boolean> <>9__249_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CompletedDailyChallenge>b__249_0(SweepstakesStatsForTask x) { }

		internal bool <Validate>b__236_2(QuestTaskSaveData t) { }

	}

	internal enum PUS
	{
		NotSet = 0,
		FreeUser = 1,
		PaidForGame = 2,
		BoughtGold = 3,
	}

	public const string transformingTonic = "Transforming Tonic"; //Field offset: 0x0
	public const string totalTransformingTonic = "Total Transforming Tonic"; //Field offset: 0x0
	[JsonConverter(typeof(VersionConverter))]
	public Version savedByGameVersion; //Field offset: 0x10
	public int savedBySkuId; //Field offset: 0x18
	public Dictionary<String, KonFuze_NoShuffle> towerXp; //Field offset: 0x20
	public HashSet<String> acquiredUpgrades; //Field offset: 0x28
	public HashSet<String> viewedUpgrades; //Field offset: 0x30
	public HashSet<String> paragonUpgradesPurchased; //Field offset: 0x38
	public HashSet<String> acquiredKnowledge; //Field offset: 0x40
	public HashSet<String> paidForKnowledge; //Field offset: 0x48
	public bool knowledgeDisabled; //Field offset: 0x50
	public bool newKnowledgePoints; //Field offset: 0x51
	public HashSet<String> unlockedTowers; //Field offset: 0x58
	public HashSet<String> unlockedHeroes; //Field offset: 0x60
	public HashSet<String> unlockedTowerSkins; //Field offset: 0x68
	public HashSet<String> seenUnlockedNotification; //Field offset: 0x70
	public HashSet<String> seenUnlockedHeroes; //Field offset: 0x78
	public HashSet<String> seenNewTowerNotifications; //Field offset: 0x80
	public HashSet<String> seenNewHeroNotification; //Field offset: 0x88
	public HashSet<String> seenNewTowerSkinNotification; //Field offset: 0x90
	public MapInfoManager mapInfo; //Field offset: 0x98
	public KonFuze UnlockAllModes; //Field offset: 0xA0
	public HashSet<String> seenEvents; //Field offset: 0xA8
	public KonFuze paidUserStatus; //Field offset: 0xB0
	public string rateMeSkuVersionNumber; //Field offset: 0xB8
	public bool countGamesSinceSkuRateMeChange; //Field offset: 0xC0
	public int completedGamesSinceSkuRateMeChange; //Field offset: 0xC4
	public int completedGame; //Field offset: 0xC8
	public Dictionary<String, String> selectedTowerSkinData; //Field offset: 0xD0
	public Dictionary<String, KonFuze> powers; //Field offset: 0xD8
	public Dictionary<String, PowerData> powersData; //Field offset: 0xE0
	[JsonProperty(ItemConverterType = typeof(ListItemConverterDecorator), ItemConverterParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomJsonConverter)}])]
	public Dictionary<String, List`1<InstaTowerModel>> instaTowers; //Field offset: 0xE8
	[JsonProperty]
	private Dictionary<String, MapSaveDataModel> savedMaps; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <HasStartedTutorial>k__BackingField; //Field offset: 0xF8
	public bool isPendingNoLinkIdMigration; //Field offset: 0xF9
	public byte noLinkIdVersion; //Field offset: 0xFA
	public string ownerID; //Field offset: 0x100
	public string trophiesWalletId; //Field offset: 0x108
	public string teamTrophiesWalletId; //Field offset: 0x110
	public List<UnclaimedTrophies> unclaimedTrophies; //Field offset: 0x118
	public DateTime timeStamp; //Field offset: 0x120
	public KonFuze monkeyMoney; //Field offset: 0x128
	public KonFuze xp; //Field offset: 0x130
	public KonFuze rank; //Field offset: 0x138
	public KonFuze veteranXp; //Field offset: 0x140
	public KonFuze veteranRank; //Field offset: 0x148
	public bool seenVeteranRankInfo; //Field offset: 0x150
	public int levelCapWas; //Field offset: 0x154
	public KonFuze trophies; //Field offset: 0x158
	public KonFuze lifetimeTrophies; //Field offset: 0x160
	public KonFuze lifetimeTeamTrophies; //Field offset: 0x168
	public KonFuze knowledgePoints; //Field offset: 0x170
	public string primaryHero; //Field offset: 0x178
	public string secondaryHero; //Field offset: 0x180
	public Dictionary<Int32, Single> achievementsProgress; //Field offset: 0x188
	public HashSet<Int32> achievementsClaimed; //Field offset: 0x190
	public HashSet<Int32> achievementsSeen; //Field offset: 0x198
	public HashSet<Int32> achievementsPostedToXBoxLive; //Field offset: 0x1A0
	public HashSet<Int32> achievementsPostedToGooglePlay; //Field offset: 0x1A8
	public AnalyticsKonFuze analyticsKonFuze; //Field offset: 0x1B0
	public int highestSeenRound; //Field offset: 0x1B8
	public int highestSeenRoundCurrentVersion; //Field offset: 0x1BC
	public PurchaseModel purchase; //Field offset: 0x1C0
	public Nullable<DateTime> lastReceivedInboxMessage; //Field offset: 0x1C8
	public int dailyRewardIndex; //Field offset: 0x1D8
	public DateTime lastSavedUTCTime; //Field offset: 0x1E0
	public DateTime nextDailyRewardDateTime; //Field offset: 0x1E8
	public int totalDailyChallengesCompleted; //Field offset: 0x1F0
	public int consecutiveDailyChallengesCompleted; //Field offset: 0x1F4
	public List<String> uniqueCompletedDailyChallengeIds; //Field offset: 0x1F8
	public Dictionary<Int32, KonFuze> raceMedalData; //Field offset: 0x200
	[Obsolete("This is a legacy field. bossMedals should be used instead", False)]
	public Dictionary<Int32, KonFuze> bossBadgeData; //Field offset: 0x208
	public Dictionary<Int32, BossMedalSaveData> bossMedals; //Field offset: 0x210
	public Dictionary<Int32, KonFuze> bossLeaderboardMedals; //Field offset: 0x218
	public Dictionary<Int32, KonFuze> bossLeaderboardEliteMedals; //Field offset: 0x220
	[Obsolete("Use OnlineProfileModel.ctLeaderboardBadges instead. This is still here for parsing and migration purposes only.", False)]
	public Dictionary<Int32, KonFuze> ctLeaderboardBadges; //Field offset: 0x228
	[Obsolete("Use OnlineProfileModel.ctGlobalLeaderboardBadges instead. This is still here for parsing and migration purposes only.", False)]
	public Dictionary<Int32, KonFuze> ctGlobalLeaderboardBadges; //Field offset: 0x230
	public bool seenMiniRace; //Field offset: 0x238
	public KonFuze totalRacesEntered; //Field offset: 0x240
	public KonFuze raceBestTimeForAchievements; //Field offset: 0x248
	public DailyChallengeModel challengeEditorModel; //Field offset: 0x250
	[JsonProperty(PropertyName = "mapEditorData")]
	private MapEditorCreatorModel mapEditorCreatorModel; //Field offset: 0x258
	public bool hasUnlockedMapEditor; //Field offset: 0x260
	public List<String> unlockedPropPacks; //Field offset: 0x268
	public bool seenMapEditorInfoPopup; //Field offset: 0x270
	public bool seenMapBrowser; //Field offset: 0x271
	public bool seenGameBrowser; //Field offset: 0x272
	public bool autosetSpecialConditions; //Field offset: 0x273
	public string submittedChallengeEditorID; //Field offset: 0x278
	public string submittedOdysseyEditorID; //Field offset: 0x280
	public bool seenChallengeModifiedPopup; //Field offset: 0x288
	public InGameSettings inGameSettings; //Field offset: 0x290
	public string languageCode; //Field offset: 0x298
	public KonFuze challengesPlayed; //Field offset: 0x2A0
	public KonFuze challengesShared; //Field offset: 0x2A8
	public KonFuze winsWithCustomHeroSkin; //Field offset: 0x2B0
	public KonFuze billGreates; //Field offset: 0x2B8
	public KonFuze aCrateTime; //Field offset: 0x2C0
	public CollectionEventMapBonusSaveData collectionEventMapBonusData; //Field offset: 0x2C8
	public OdysseySaveData odysseySaveData; //Field offset: 0x2D0
	public OdysseySaveData odysseyEditorSaveData; //Field offset: 0x2D8
	public OdysseyData odysseysEditorData; //Field offset: 0x2E0
	public OdysseyData embarkedOdysseyEditorDcm; //Field offset: 0x2E8
	public Dictionary<String, KonFuze> completedOdysseys; //Field offset: 0x2F0
	public KonFuze totalCompletedOdysseys; //Field offset: 0x2F8
	public bool cancelledFacebookFriendsPopup; //Field offset: 0x300
	public int coopQuickMatchSetting; //Field offset: 0x304
	public bool coopMatchSetToPrivate; //Field offset: 0x308
	public CoopGameDetails currentCoopGameDetails; //Field offset: 0x310
	public HotkeysData hotkeysData; //Field offset: 0x318
	public HotkeysData2 hotkeysData2; //Field offset: 0x320
	public bool hasSeenNewDoubleCash; //Field offset: 0x328
	public bool seenBigBloons; //Field offset: 0x329
	public bool unlockedBigBloons; //Field offset: 0x32A
	public bool bigBloonsActive; //Field offset: 0x32B
	public bool seenSmallBloons; //Field offset: 0x32C
	public bool unlockedSmallBloons; //Field offset: 0x32D
	public bool smallBloonsActive; //Field offset: 0x32E
	public bool seenBigTowers; //Field offset: 0x32F
	public bool unlockedBigTowers; //Field offset: 0x330
	public bool bigTowersActive; //Field offset: 0x331
	public bool seenSmallTowers; //Field offset: 0x332
	public bool unlockedSmallTowers; //Field offset: 0x333
	public bool smallTowersActive; //Field offset: 0x334
	public bool smallBossesActive; //Field offset: 0x335
	public bool seenSmallBosses; //Field offset: 0x336
	public bool unlockedSmallBosses; //Field offset: 0x337
	public bool seenFastTrack; //Field offset: 0x338
	public bool unlockedFastTrack; //Field offset: 0x339
	public bool fastTrackActive; //Field offset: 0x33A
	public int patWinsOn10Release; //Field offset: 0x33C
	public bool oompaLoompad; //Field offset: 0x340
	public Dictionary<String, CollectionEventDataModel> collectionEventData; //Field offset: 0x348
	public List<TrackItemData> savedPlayList; //Field offset: 0x350
	public bool useJukeBox; //Field offset: 0x358
	public Dictionary<String, TrophyStoreSD> trophyStorePurchasedItems; //Field offset: 0x360
	public Dictionary<String, String> namedMonkeyNames; //Field offset: 0x368
	public Dictionary<String, Boolean> savedStats; //Field offset: 0x370
	public string profileAvatar; //Field offset: 0x378
	public string profileAvatarFrame; //Field offset: 0x380
	public string profileBanner; //Field offset: 0x388
	public bool seenProfileStats; //Field offset: 0x390
	public Dictionary<String, Dictionary`2<String, Boolean>> savedNamedMonkeyStats; //Field offset: 0x398
	public bool trophyStoreSeen; //Field offset: 0x3A0
	public KonFuze noStoneUnturned; //Field offset: 0x3A8
	public KonFuze moProblems; //Field offset: 0x3B0
	public KonFuze fullSpeed; //Field offset: 0x3B8
	public int transformicTonicUsesOn20Release; //Field offset: 0x3C0
	public KonFuze currentTowerGiftProgress; //Field offset: 0x3C8
	public int trophiesSpent; //Field offset: 0x3D0
	public int hostedCoopGames; //Field offset: 0x3D4
	public int collectionEventCratesOpened; //Field offset: 0x3D8
	public Dictionary<Int32, Int32> collectionEventCratesTypesOpened; //Field offset: 0x3E0
	public KonFuze continuesUsed; //Field offset: 0x3E8
	public List<String> blockedHostnames; //Field offset: 0x3F0
	public ContentType selectedContentTab; //Field offset: 0x3F8
	public Dictionary<MapDifficulty, GoldenBloonMapData> goldenBloonData; //Field offset: 0x400
	public int goldenBloonsPopped; //Field offset: 0x408
	public int monkeyTeamsWins; //Field offset: 0x40C
	public Dictionary<MapDifficulty, MonkeyTeamMapData> monkeyTeamsData; //Field offset: 0x410
	public HashSet<Int32> giftedAchievements; //Field offset: 0x418
	public List<RacePassClaim> unverifiedRacePassClaims; //Field offset: 0x420
	public bool isBossRankedSelected; //Field offset: 0x428
	public bool isBossEliteSelected; //Field offset: 0x429
	public List<BossEventData> bossesEventData; //Field offset: 0x430
	public List<QuestEventData> questsEventData; //Field offset: 0x438
	public List<String> playedDailyChallengeIds; //Field offset: 0x440
	public List<String> lostDailyChallengeIds; //Field offset: 0x448
	public List<String> wonDailyChallengeIds; //Field offset: 0x450
	public int numWonUniqueDailyChallenges; //Field offset: 0x458
	public bool friendScreenShowCode; //Field offset: 0x45C
	public bool toggleFriendRequests; //Field offset: 0x45D
	public int numAwaitingFriendRequests; //Field offset: 0x460
	public DateTime guildLastCheckedMessage; //Field offset: 0x468
	public DateTime guildInviteChecked; //Field offset: 0x470
	public Dictionary<String, DateTime> teamInvitationsSent; //Field offset: 0x478
	public bool isInTeam; //Field offset: 0x480
	public bool colorBlindModeOn; //Field offset: 0x481
	public bool ctScorePanelCollapsed; //Field offset: 0x482
	public bool dataConsent; //Field offset: 0x483
	public Dictionary<SubGameType, Boolean> ctSeenFirstTimePopup; //Field offset: 0x488
	public Dictionary<SubGameType, Int32> ctCapturedTileType; //Field offset: 0x490
	public bool toggleTeamRequests; //Field offset: 0x498
	public string previousGuildId; //Field offset: 0x4A0
	[Obsolete]
	public string nexusCreatorId; //Field offset: 0x4A8
	public NexusSettings nexus; //Field offset: 0x4B0
	public bool isOnlineStatusEnabled; //Field offset: 0x4B8
	public List<QuestSaveData> questsSaveData; //Field offset: 0x4C0
	public bool isPendingNamedMonkeyValidation; //Field offset: 0x4C8
	public AccessibilitySettings accessibilitySettings; //Field offset: 0x4D0
	public Dictionary<String, KonFuze> geraldoShopItemsUsed; //Field offset: 0x4D8
	public AudioSettings audioSettings; //Field offset: 0x4E0
	public string seenUpcomingCtEventId; //Field offset: 0x4E8
	public Dictionary<String, Dictionary`2<String, BossScoreComponents>> bossChallengeScores; //Field offset: 0x4F0
	public Dictionary<String, Dictionary`2<String, BossScoreComponents>> bossChallengeScores2p; //Field offset: 0x4F8
	public Dictionary<String, Dictionary`2<String, BossScoreComponents>> bossChallengeScores3p; //Field offset: 0x500
	public Dictionary<String, Dictionary`2<String, BossScoreComponents>> bossChallengeScores4p; //Field offset: 0x508
	public BossType selectedChallengeBoss; //Field offset: 0x510
	public string selectedChallengeBossMap; //Field offset: 0x518
	public bool selectedChallengeBossRanked; //Field offset: 0x520
	public LeaderboardScoringType selectedChallengeBossScoring; //Field offset: 0x524
	public bool seenBossChallenge; //Field offset: 0x528
	public HashSet<BossType> uniqueBossesDefeated; //Field offset: 0x530
	public KonFuze heavyInvestment; //Field offset: 0x538
	public bool hideAccoladeNotifs; //Field offset: 0x540
	public bool hasPublicAccolades; //Field offset: 0x541
	public Dictionary<String, KonFuze> towerUnlockProgresses; //Field offset: 0x548
	public string selectedTowerForUnlockProgression; //Field offset: 0x550
	public GameEditorJsonData gameEditorData; //Field offset: 0x558
	public LegendsDataModel legendsData; //Field offset: 0x560
	public HashSet<LegendsType> seenLegends; //Field offset: 0x568
	public HashSet<String> seenStorePipIds; //Field offset: 0x570
	public int iapLoginReminderCount; //Field offset: 0x578
	public Dictionary<String, SweepstakesStats> sweepstakesStatsByEvent; //Field offset: 0x580
	public Dictionary<String, Boolean> seenDialogues; //Field offset: 0x588
	[JsonProperty("giftsReceived")]
	public HashSet<String> openedAndDeletedGiftIds; //Field offset: 0x590
	[JsonProperty("receivedGiftEventIds")]
	public HashSet<String> openedGiftEventIds; //Field offset: 0x598
	public Dictionary<String, ServerGift> pendingGifts; //Field offset: 0x5A0
	public Dictionary<String, ClaimedGiftModel> claimedGifts; //Field offset: 0x5A8
	public HashSet<String> seenMessageEventIds; //Field offset: 0x5B0
	public HashSet<String> deletedMessageEventIds; //Field offset: 0x5B8
	public TutorialType tutorialTypeSelected; //Field offset: 0x5C0
	public PowersProSaveData powersProSaveData; //Field offset: 0x5C8
	[CompilerGenerated]
	private BossEventData <CurrentBossEventData>k__BackingField; //Field offset: 0x5D0
	[CompilerGenerated]
	private QuestEventData <CurrentQuestEventData>k__BackingField; //Field offset: 0x5D8

	[JsonIgnore]
	public ActiveKnowledge ActiveKnowledge
	{
		 get { } //Length: 27
	}

	[JsonIgnore]
	public Dictionary<String, MapSaveDataModel> AllSavedMaps
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public BossEventData CurrentBossEventData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[JsonIgnore]
	public QuestEventData CurrentQuestEventData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[JsonProperty("HasCompletedTutorial")]
	public bool HasStartedTutorial
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	[JsonIgnore]
	public int KnowledgePoints
	{
		 get { } //Length: 37
		 set { } //Length: 89
	}

	[JsonIgnore]
	public override LegendsDataModel LegendsData
	{
		 get { } //Length: 8
	}

	[JsonIgnore]
	public MapEditorCreatorModel MapEditorCreatorModel
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	[JsonIgnore]
	private GameModel Model
	{
		private get { } //Length: 68
	}

	public ProfileModel(string startingTower, string startingHero) { }

	public ProfileModel() { }

	[CompilerGenerated]
	private bool <Validate>b__236_0(string ak) { }

	[AsyncStateMachine(typeof(<<Validate>g__validateCreatorCodeAsync|236_1>d))]
	[CompilerGenerated]
	internal static Task <Validate>g__validateCreatorCodeAsync|236_1(NexusSettings nexusSettings) { }

	public void AddCTCapturedTileType(SubGameType subGameType) { }

	private void CheckForForcedUnlockTowers() { }

	public void CompletedDailyChallenge(DailyChallengeModel dcm) { }

	public ActiveKnowledge get_ActiveKnowledge() { }

	public Dictionary<String, MapSaveDataModel> get_AllSavedMaps() { }

	[CompilerGenerated]
	public BossEventData get_CurrentBossEventData() { }

	[CompilerGenerated]
	public QuestEventData get_CurrentQuestEventData() { }

	[CompilerGenerated]
	public bool get_HasStartedTutorial() { }

	public int get_KnowledgePoints() { }

	public override LegendsDataModel get_LegendsData() { }

	public MapEditorCreatorModel get_MapEditorCreatorModel() { }

	private GameModel get_Model() { }

	public int GetCTCapturedTileType(SubGameType subGameType) { }

	public ValueTuple<Int32, Boolean, Int64, Int64> GetRankDisplay() { }

	public bool GetSavedMap(string key, out MapSaveDataModel savedMap) { }

	public int GetTotalDailyChallengeCompletedCount() { }

	public bool HasCompletedDailyChallenge(string dcUniqueDailyID) { }

	public bool HasPurchasedNamedMonkeys() { }

	public bool HasSavedMap(string key) { }

	private void InitialiseFreshProfile(string startingTower, string startingHero) { }

	public bool IsNewer(ProfileModel other) { }

	public void RemoveCtSavedMaps() { }

	public void RemoveNamedMonkeys() { }

	public bool RemoveSavedMap(string key) { }

	public void ResetMonkeyNames() { }

	public void ResetTutorialFlags() { }

	[CompilerGenerated]
	public void set_CurrentBossEventData(BossEventData value) { }

	[CompilerGenerated]
	public void set_CurrentQuestEventData(QuestEventData value) { }

	[CompilerGenerated]
	public void set_HasStartedTutorial(bool value) { }

	public void set_KnowledgePoints(int value) { }

	public void set_MapEditorCreatorModel(MapEditorCreatorModel value) { }

	public void SetMonkeyName(string monkeyKey, string name) { }

	public void SetSavedMap(string key, MapSaveDataModel savedMap) { }

	public bool TryGetSweepstakesStats(string eventId, out SweepstakesStats sweepstakesStats) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

	public void ValidateNamedMonkeys() { }

	public void ValidateSelectedTowerSkinData() { }

}

