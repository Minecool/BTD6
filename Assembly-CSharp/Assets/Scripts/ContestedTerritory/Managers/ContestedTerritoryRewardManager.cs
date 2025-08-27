namespace Assets.Scripts.ContestedTerritory.Managers;

[Extension]
public static class ContestedTerritoryRewardManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__5_0; //Field offset: 0x8
		public static Func<BaseLoot, Boolean> <>9__5_1; //Field offset: 0x10
		public static Func<TeamStoreRelic, Boolean> <>9__5_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateVictoryLootset>b__5_0(BaseLoot x) { }

		internal bool <GenerateVictoryLootset>b__5_1(BaseLoot x) { }

		internal bool <GenerateVictoryLootset>b__5_2(TeamStoreRelic x) { }

	}

	[CompilerGenerated]
	private struct <GenerateVictoryLootset>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LootSet> <>t__builder; //Field offset: 0x8
		public TileVictoryRewards tileVictoryRewards; //Field offset: 0x20
		public bool canEarnMM; //Field offset: 0x30
		public bool isScoreSubmitted; //Field offset: 0x31
		public CtTileType rewardTileType; //Field offset: 0x34
		public bool hasBonusRewards; //Field offset: 0x38
		public bool separateBonusRewards; //Field offset: 0x39
		private LootSet <lootSet>5__2; //Field offset: 0x40
		private TaskAwaiter<TeamStoreRelic[]> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	private struct TileVictoryRewards
	{
		[CompilerGenerated]
		private readonly int <MonkeyMoney>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <TeamTrophies>k__BackingField; //Field offset: 0x4
		[CompilerGenerated]
		private readonly string <Relic>k__BackingField; //Field offset: 0x8

		public int MonkeyMoney
		{
			[CompilerGenerated]
			 get { } //Length: 3
		}

		public string Relic
		{
			[CompilerGenerated]
			 get { } //Length: 291
		}

		public int TeamTrophies
		{
			[CompilerGenerated]
			 get { } //Length: 4
		}

		public TileVictoryRewards(int monkeyMoney, int teamTrophies, string relic) { }

		[CompilerGenerated]
		public int get_MonkeyMoney() { }

		[CompilerGenerated]
		public string get_Relic() { }

		[CompilerGenerated]
		public int get_TeamTrophies() { }

	}


	private static Btd6CtSettings CtSettings
	{
		private get { } //Length: 138
	}

	[AsyncStateMachine(typeof(<GenerateVictoryLootset>d__5))]
	private static Task<LootSet> GenerateVictoryLootset(TileVictoryRewards tileVictoryRewards, bool hasBonusRewards, CtTileType rewardTileType, bool separateBonusRewards, bool isScoreSubmitted, bool canEarnMM) { }

	private static Btd6CtSettings get_CtSettings() { }

	public static int GetCtPointsForScoreSubmitted(CtTileType rewardTileType) { }

	[Extension]
	public static Task<LootSet> GetPotentialVictoryRewards(ContestedTerritoryIslandTile ctTile) { }

	private static CtRewardCounts GetTileRewardCounts(ContestedTerritoryRewardSettings rewardSettings, string teamIdHoldingTile, string holdingPlayerId, bool isScoreSubmitted) { }

	private static TileVictoryRewards GetTileVictoryRewards(int tileId, string teamIdHoldingTile, string holdingPlayerId, bool isScoreSubmitted, bool playerHasWonBefore, bool canShowRelic) { }

	[Extension]
	public static Task<LootSet> GetVictoryRewards(ContestedTerritoryIslandTile ctTile, bool isScoreSubmitted, string teamIdHoldingTile, bool wasGuildTicket, bool canEarnMM) { }

}

