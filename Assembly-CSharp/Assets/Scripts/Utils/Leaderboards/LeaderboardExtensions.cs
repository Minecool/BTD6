namespace Assets.Scripts.Utils.Leaderboards;

[Extension]
public static class LeaderboardExtensions
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Dictionary<Int32, KonFuze> medalData; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal int <GetMedalMetadata>b__0(LeaderboardBadgeType badge) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public int i; //Field offset: 0x0

		public <>c__DisplayClass23_0`1() { }

		internal bool <GetPlayerPlacings>b__0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public string userOrGuildId; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <LoadPlayersLeaderboardData>b__0(GroupScoreModel t) { }

	}

	[CompilerGenerated]
	private struct <GetLeaderboardScores>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<GroupScoreModel>> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public IEnumerable<ScoreModel> preLoadedScores; //Field offset: 0x28
		public LeaderboardData leaderboard; //Field offset: 0x30
		public string guildIdOverride; //Field offset: 0x38
		private TaskAwaiter<RankModel> <>u__1; //Field offset: 0x40
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__2; //Field offset: 0x48
		private TaskAwaiter<IEnumerable`1<GroupScoreModel>> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadGroupScores>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<GroupScoreModel>> <>t__builder; //Field offset: 0x8
		public bool isGuildLeaderboard; //Field offset: 0x20
		public string guildIdOverride; //Field offset: 0x28
		public LeaderboardData leaderboard; //Field offset: 0x30
		public IEnumerable<ScoreModel> preLoadedScores; //Field offset: 0x38
		public RankModel preloadedPlayerRank; //Field offset: 0x40
		private string <guildId>5__2; //Field offset: 0x48
		private List<GroupScoreModel> <scores>5__3; //Field offset: 0x50
		private TaskAwaiter<List`1<GroupScoreModel>> <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPlayersLeaderboardData>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isGuildLeaderboard; //Field offset: 0x20
		public string guildIdOverride; //Field offset: 0x28
		public RankModel preloadedPlayerRank; //Field offset: 0x30
		public LeaderboardData leaderboard; //Field offset: 0x38
		public List<GroupScoreModel> groupScores; //Field offset: 0x40
		private <>c__DisplayClass35_0 <>8__1; //Field offset: 0x48
		private TaskAwaiter<RankModel> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string kBossPrefix = "Asc:Boss_"; //Field offset: 0x0
	public const string kRacePrefix = "Asc:Race_"; //Field offset: 0x0

	private static LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	[Extension]
	public static void AddMedalData(MetadataBuilder metadata, Dictionary<Int32, KonFuze> medalData) { }

	private static LocalizationManager get_Locs() { }

	private static Btd6Player get_Player() { }

	[Extension]
	public static LeaderboardReward[][] GetAllCtRewards(LeaderboardRewards ctLeaderboardRewards) { }

	public static int GetBadgeImgIndex(BadgePlacingType badgePlacingType, int position, int totalPositions) { }

	public static int GetBadgeImgIndex(BadgePlacingType badgePlacingType, float position, bool isPerc) { }

	public static int GetBadgeImgIndex(BadgePlacingType badgePlacingType, LeaderboardBadgeType leaderboardBadgeType) { }

	[Extension]
	public static BadgePlacingType GetBadgePlacingType(LeaderboardType leaderboardType, int index) { }

	[Extension]
	public static BadgePlacingType GetBadgePlacingType(LeaderboardType leaderboardType, bool isLocal, bool isPlayer) { }

	[Extension]
	public static BossLeaderboardType GetBossLeaderboardType(int playerCount, bool isElite) { }

	[Extension]
	public static ScoreComponent GetBossScoreComponentMask(LeaderboardScoringType leaderboardScoringType) { }

	private static Nullable<ScoreComponent> GetComponentMask(LeaderboardType leaderboardType) { }

	[Extension]
	public static string GetCtLeaderboardId(string eventId, int instanceId, CtLeaderboardType ctLeaderboardType) { }

	[Extension]
	public static int GetGroupSize(BossLeaderboardType bossLeaderboardType) { }

	[Extension]
	public static int GetGroupSize(LeaderboardType leaderboardType, int index) { }

	[Extension]
	private static int GetIntOrDefault(Dictionary<Int32, KonFuze> medalData, LeaderboardBadgeType badgeType) { }

	private static int GetLeaderboardGroupCount(LeaderboardType leaderboardType) { }

	[Extension]
	public static string GetLeaderboardId(BossLeaderboardType bossLeaderboardType, string eventId, LeaderboardType leaderboardType) { }

	[Extension]
	public static string GetLeaderboardIdPostfix(LeaderboardType leaderboardType) { }

	[Extension]
	public static string GetLeaderboardLinkId(LeaderboardType leaderboardType, int index, string eventId, Nullable<Int32> instanceId = null) { }

	[AsyncStateMachine(typeof(<GetLeaderboardScores>d__34))]
	[Extension]
	public static Task<List`1<GroupScoreModel>> GetLeaderboardScores(Btd6Player player, LeaderboardData leaderboard, IEnumerable<ScoreModel> preLoadedScores, string guildIdOverride) { }

	private static int GetLeaderboardStartIndex(LeaderboardType leaderboardType, bool isElite, bool isCtLocal = false) { }

	[Extension]
	public static LootFrom GetLootFrom(LeaderboardType leaderboardType) { }

	private static Dictionary<Int32, KonFuze> GetMedalData(LeaderboardType leaderboardType, bool isElite, bool isGlobal) { }

	[Extension]
	public static string GetMedalMetadata(Dictionary<Int32, KonFuze> medalData) { }

	[Extension]
	public static SpriteReference[] GetMedalSprites(GameData data, LeaderboardType leaderboardType, bool isElite, BadgePlacingType badgePlacingType = 0) { }

	[Extension]
	public static int GetNumberOfRequiredLeaderboards(LeaderboardType leaderboardType) { }

	public static int GetPlacingsPercThreshold(LeaderboardReward[] rewards) { }

	[Extension]
	public static PlayerLeaderboardPlacing GetPlayerPlacings(List<T> leaderboards, LeaderboardType leaderboardType, int placingPercThreshold, bool isElite = false, bool isCtLocal = false) { }

	[Extension]
	public static string GetRaceLeaderboardId(string eventId) { }

	[Extension]
	public static LeaderboardReward GetReward(LeaderboardReward[] leaderboardReward, int placing, float percentage) { }

	[Extension]
	private static LeaderboardBadgeType GetRewardBadge(int value, int totalLeadboardCount, bool isZeroBased) { }

	[Extension]
	private static bool HasBetterPlacing(LeaderboardData leaderboard, int otherPlacing, int otherTotalScores, int placingPercThreshold) { }

	[Extension]
	public static bool HasSubmissionTimeComponent(LeaderboardType leaderboardType) { }

	[Extension]
	public static bool IsCasualCtLeaderboard(CtLeaderboardType ctLeaderboardType) { }

	[Extension]
	public static bool IsEliteIndex(LeaderboardType leaderboardType, int index) { }

	[Extension]
	public static bool IsGuildLeaderboard(LeaderboardType leaderboardType, int index) { }

	[Extension]
	public static bool IsMiniIndex(LeaderboardType leaderboardType, int index) { }

	[AsyncStateMachine(typeof(<LoadGroupScores>d__40))]
	[Extension]
	public static Task<List`1<GroupScoreModel>> LoadGroupScores(LeaderboardData leaderboard, bool isGuildLeaderboard, IEnumerable<ScoreModel> preLoadedScores = null, RankModel preloadedPlayerRank = null, string guildIdOverride = null) { }

	[AsyncStateMachine(typeof(<LoadPlayersLeaderboardData>d__35))]
	[Extension]
	public static Task LoadPlayersLeaderboardData(LeaderboardData leaderboard, bool isGuildLeaderboard, List<GroupScoreModel> groupScores, RankModel preloadedPlayerRank = null, string guildIdOverride = null) { }

	[Extension]
	public static string PositionToPositionName(int position) { }

	[Extension]
	public static LeaderboardBadgeType PositionToRewardBadge(int position, int totalLeadboardCount) { }

	[Extension]
	public static LeaderboardType ToBossLeaderboardType(LeaderboardScoringType leaderboardScoringType) { }

	[Extension]
	public static string ToPlacingLocalized(int position, bool isPerc) { }

	[Extension]
	public static string ToPlacingLocalized(float position, bool isPerc) { }

	[Extension]
	public static TimeSpan ToTimeSpan(int leaderboardTimeScore) { }

}

