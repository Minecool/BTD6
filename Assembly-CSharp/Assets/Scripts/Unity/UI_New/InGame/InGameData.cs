namespace Assets.Scripts.Unity.UI_New.InGame;

public class InGameData
{
	private static InGameData _editableInstance; //Field offset: 0x0
	private static ReadonlyInGameData _readonlyGameInstance; //Field offset: 0x8
	public bool includeTutorial; //Field offset: 0x10
	public GameType gameType; //Field offset: 0x14
	public SubGameType subGameType; //Field offset: 0x18
	public string selectedMode; //Field offset: 0x20
	public string selectedMap; //Field offset: 0x28
	public string selectedDifficulty; //Field offset: 0x30
	public MapDifficulty selectedMapDifficulty; //Field offset: 0x38
	public bool selectedCoopMode; //Field offset: 0x3C
	public CoopDivision coopDivisionType; //Field offset: 0x40
	public string gameEventId; //Field offset: 0x48
	public int odysseyIslandIndex; //Field offset: 0x50
	public DailyChallengeModel dcModel; //Field offset: 0x58
	public OdysseyData odysseyData; //Field offset: 0x60
	public BossGameData bossData; //Field offset: 0x68
	public BossRushGameData bossRushData; //Field offset: 0x70
	public RogueGameData rogueData; //Field offset: 0x78
	public PlayerContentInfo playerContentInfo; //Field offset: 0x80
	public bool isHost; //Field offset: 0x88
	public bool goldenBloonActive; //Field offset: 0x89
	public bool monkeyTeamsActive; //Field offset: 0x8A
	public String[] monkeyTeams; //Field offset: 0x90
	public bool collectionEventBonusActive; //Field offset: 0x98
	public Int32[] checkpointRounds; //Field offset: 0xA0
	public String[] temporaryUnlockedTowers; //Field offset: 0xA8
	public ActiveRelicKnowledge activeRelicKnowledge; //Field offset: 0xB0
	public QuestGameData questData; //Field offset: 0xB8
	public bool hasDefaultCheckpointCost; //Field offset: 0xC0
	public LeaderboardScoringType scoringType; //Field offset: 0xC4

	public static ReadonlyInGameData CurrentGame
	{
		 get { } //Length: 55
	}

	public static InGameData Editable
	{
		 get { } //Length: 119
	}

	public bool IsApopalypse
	{
		 get { } //Length: 61
	}

	public bool IsCollectionEventBonusAllowed
	{
		 get { } //Length: 75
	}

	public bool IsEventTrainingMode
	{
		 get { } //Length: 12
	}

	public bool IsMonkeyTeamsAllowed
	{
		 get { } //Length: 75
	}

	private InGameData() { }

	public static void CreateNewInstance() { }

	public void CreateReadonlyCopyForGame() { }

	private bool GameIsStandardAndNonSandbox() { }

	public static ReadonlyInGameData get_CurrentGame() { }

	public static InGameData get_Editable() { }

	public bool get_IsApopalypse() { }

	public bool get_IsCollectionEventBonusAllowed() { }

	public bool get_IsEventTrainingMode() { }

	public bool get_IsMonkeyTeamsAllowed() { }

	public static string GetAnalyticMode() { }

	public static SubGameType GetBossSubGameType(LeaderboardScoringType scoringType) { }

	public static bool IsFastTrackAllowed(string selectedMode, GameType gameType) { }

	public bool IsGoldenBloonAllowed() { }

	public static void OnDestroyGame() { }

	public void ResetSubGameType() { }

	public void SetupBoss(string eventId, BossType bossType, bool isElite, bool isRanked, Int32[] spawnRounds, DailyChallengeModel dcm, LeaderboardScoringType scoringType) { }

	public void SetupBossChallenge(string eventId, BossType bossType, bool isElite, bool isRanked, DailyChallengeModel dcm, LeaderboardScoringType scoreType) { }

	public void SetupBossRush(BossRushEvent bossRushEvent, BossRushSettings bossRushSettings, DailyChallengeModel dcm, BossType bossType, int tileIndex, bool isReplay, Nullable<UInt64> latestTeamScoreId, int hpLeft, String[] bannedHeros) { }

	public void SetupContestedTerritory(ContestedTerritoryGameData gameData) { }

	public void SetupDailyChallenge() { }

	public void SetupGameEditorEditMode(GameEditorModel gameEditorModel = null) { }

	public void SetupGameEditorPlayMode(GameEditorModel gameEditorModel, string mode, string difficulty, ChallengeType challengeType, PlayerContentInfo playerContentInfo) { }

	public void SetupMapEditorEditMode(CustomMapModel customMapModel = null) { }

	public void SetupMapEditorPlayMode(CustomMapModel customMapModel, string mode, string difficulty, ChallengeType challengeType, PlayerContentInfo playerContentInfo) { }

	public void SetupNormalGame(string mapId, String[] monkeyTeam = null) { }

	public void SetupOdyssey() { }

	public void SetupQuest(int questIndex, int partIndex, QuestDetails questDetails, TaskData taskData, bool disableQuestDialogue) { }

	public void SetupRace(string raceEventId) { }

	public void SetupRogueGame(DailyChallengeModel dcm, List<RogueInstaMonkey> instasInventory, List<ArtifactLoot> artifactsInventory, Vector2Int tileCoords, RogueTileType tileType, BossRushGameData _bossRushData, BossType boss, int stage, RogueMiniGameData miniGameData, bool isLegendaryTile, int tileSeed, bool isChimps, RogueBloonModifier modifierType, bool isReverse) { }

	public void SetupTutorial() { }

	public static void UseExistingInstance(InGameData data) { }

	public static string ValidateMapId(string mapId = null) { }

}

