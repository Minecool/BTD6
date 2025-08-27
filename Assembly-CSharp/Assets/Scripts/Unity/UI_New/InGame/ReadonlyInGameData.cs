namespace Assets.Scripts.Unity.UI_New.InGame;

public class ReadonlyInGameData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PowerData, Boolean> <>9__41_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ArePowersAllowed>b__41_0(PowerData x) { }

	}

	public readonly bool includeTutorialOld; //Field offset: 0x10
	public readonly bool includeTutorialNew; //Field offset: 0x11
	public readonly GameType gameType; //Field offset: 0x14
	public readonly SubGameType subGameType; //Field offset: 0x18
	public readonly string selectedMode; //Field offset: 0x20
	public readonly string selectedMap; //Field offset: 0x28
	public readonly string selectedDifficulty; //Field offset: 0x30
	public readonly MapDifficulty selectedMapDifficulty; //Field offset: 0x38
	public readonly bool selectedCoopMode; //Field offset: 0x3C
	public readonly CoopDivision coopDivisionType; //Field offset: 0x40
	public readonly string gameEventId; //Field offset: 0x48
	public readonly int odysseyIslandIndex; //Field offset: 0x50
	public readonly DailyChallengeModel dcModel; //Field offset: 0x58
	public readonly OdysseyData odysseyData; //Field offset: 0x60
	public readonly BossGameData bossData; //Field offset: 0x68
	public readonly BossRushGameData bossRushData; //Field offset: 0x70
	public readonly QuestGameData questData; //Field offset: 0x78
	public readonly PlayerContentInfo playerContentInfo; //Field offset: 0x80
	public readonly bool isHost; //Field offset: 0x88
	public readonly bool goldenBloonActive; //Field offset: 0x89
	public readonly bool monkeyTeamsActive; //Field offset: 0x8A
	public readonly String[] monkeyTeams; //Field offset: 0x90
	public readonly bool collectionEventBonusActive; //Field offset: 0x98
	public readonly Int32[] checkpointRounds; //Field offset: 0xA0
	public readonly String[] temporaryUnlockedTowers; //Field offset: 0xA8
	public ActiveRelicKnowledge activeRelicKnowledge; //Field offset: 0xB0
	public readonly bool hasDefaultCheckpointCost; //Field offset: 0xB8
	public LeaderboardScoringType scoringType; //Field offset: 0xBC
	public bool isApopalypse; //Field offset: 0xC0
	public RogueGameData rogueData; //Field offset: 0xC8
	public bool loadedSave; //Field offset: 0xD0
	[CompilerGenerated]
	private bool <collectionEventRewardGiven>k__BackingField; //Field offset: 0xD1

	public private bool collectionEventRewardGiven
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool DisableMapSeasonalProps
	{
		 get { } //Length: 9
	}

	public bool HasCosmeticsOverrides
	{
		 get { } //Length: 30
	}

	public bool IsCreationMode
	{
		 get { } //Length: 157
	}

	public bool IsEditingMapMode
	{
		 get { } //Length: 77
	}

	public bool IsQuest
	{
		 get { } //Length: 9
	}

	public bool IsSandbox
	{
		 get { } //Length: 120
	}

	public bool IsUserPlayMode
	{
		 get { } //Length: 157
	}

	public bool RequiresHudManager
	{
		 get { } //Length: 123
	}

	public ReadonlyInGameData(InGameData data) { }

	public bool ArePowersAllowed() { }

	public bool AwardCollectionEventReward() { }

	public bool CanEarnPlayerAndTowerXp() { }

	public Dictionary<String, String> GatherMetadata() { }

	[CompilerGenerated]
	public bool get_collectionEventRewardGiven() { }

	public bool get_DisableMapSeasonalProps() { }

	public bool get_HasCosmeticsOverrides() { }

	public bool get_IsCreationMode() { }

	public bool get_IsEditingMapMode() { }

	public bool get_IsQuest() { }

	public bool get_IsSandbox() { }

	public bool get_IsUserPlayMode() { }

	public bool get_RequiresHudManager() { }

	public bool IsDoubleCashAllowed() { }

	public bool IsTowerTemporarilyUnlocked(string towerId) { }

	[CompilerGenerated]
	private void set_collectionEventRewardGiven(bool value) { }

}

