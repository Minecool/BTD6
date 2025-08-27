namespace Assets.Scripts.Utils.Leaderboards;

[Extension]
public static class LeaderboardDownloader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ScoreModel, Boolean> <>9__22_0; //Field offset: 0x8
		public static Func<String, Boolean> <>9__27_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetMiniScores>b__22_0(ScoreModel x) { }

		internal bool <GetRanks>b__27_0(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <GetRank>b__0(ScoreModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <GetAnonymousRank>b__0(RankModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public string playerId; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <GetGroupRank>b__0(GroupScoreModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public string groupId; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <GetGroupScores>b__0(GroupScoreModel x) { }

	}

	[CompilerGenerated]
	private struct <DownloadAndParse>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ScoreModel[]> <>t__builder; //Field offset: 0x8
		public Environments environment; //Field offset: 0x20
		public int appId; //Field offset: 0x24
		public string leaderboardId; //Field offset: 0x28
		public int maxScores; //Field offset: 0x30
		private TaskAwaiter<Byte[]> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAnonymousRank>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RankModel> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		public string leaderboardId; //Field offset: 0x28
		public bool useCache; //Field offset: 0x30
		public Btd6Player player; //Field offset: 0x38
		private <>c__DisplayClass13_0 <>8__1; //Field offset: 0x40
		private string <cacheId>5__2; //Field offset: 0x48
		private TaskAwaiter<RankModel[]> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGroupRank>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RankModel> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public LeaderboardData leaderboardData; //Field offset: 0x28
		public bool useCache; //Field offset: 0x30
		public int groupSize; //Field offset: 0x34
		private <>c__DisplayClass20_0 <>8__1; //Field offset: 0x38
		private string <groupId>5__2; //Field offset: 0x40
		private string <groupLeaderboardId>5__3; //Field offset: 0x48
		private string <cacheId>5__4; //Field offset: 0x50
		private RankModel <groupRank>5__5; //Field offset: 0x58
		private TaskAwaiter<ScoreModel[]> <>u__1; //Field offset: 0x60
		private TaskAwaiter<RankModel[]> <>u__2; //Field offset: 0x68
		private TaskAwaiter<IEnumerable`1<GroupScoreModel>> <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGroupScores>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<GroupScoreModel>> <>t__builder; //Field offset: 0x8
		public int groupSize; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x28
		public LeaderboardData leaderboardData; //Field offset: 0x30
		public bool isHighPriority; //Field offset: 0x38
		public bool useCache; //Field offset: 0x39
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetMiniScores>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<ScoreModel>> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string eventId; //Field offset: 0x28
		public bool isElite; //Field offset: 0x30
		public string leaderboardId; //Field offset: 0x38
		private String[] <playerIds>5__2; //Field offset: 0x40
		private string <cacheId>5__3; //Field offset: 0x48
		private IEnumerable<ScoreModel> <scores>5__4; //Field offset: 0x50
		private TaskAwaiter<String[]> <>u__1; //Field offset: 0x58
		private TaskAwaiter<LeaderboardScoreCache> <>u__2; //Field offset: 0x60
		private TaskAwaiter<ScoreModel[]> <>u__3; //Field offset: 0x68
		private TaskAwaiter <>u__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetRank>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RankModel> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string playerIdOverride; //Field offset: 0x28
		public string leaderboardId; //Field offset: 0x30
		public bool useCache; //Field offset: 0x38
		public bool checkTimeStamps; //Field offset: 0x39
		private <>c__DisplayClass12_0 <>8__1; //Field offset: 0x40
		private string <cacheId>5__2; //Field offset: 0x48
		private RankModel <playerRank>5__3; //Field offset: 0x50
		private TaskAwaiter<RankModel> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetRanks>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<RankModel[]> <>t__builder; //Field offset: 0x8
		public String[] playerIds; //Field offset: 0x20
		public bool useCache; //Field offset: 0x28
		public Btd6Player player; //Field offset: 0x30
		public string leaderboardId; //Field offset: 0x38
		private string <cacheId>5__2; //Field offset: 0x40
		private RankModel[] <ranks>5__3; //Field offset: 0x48
		private TaskAwaiter<LeaderboardRanksCache> <>u__1; //Field offset: 0x50
		private TaskAwaiter<RankModel[]> <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetScores>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<ScoreModel>> <>t__builder; //Field offset: 0x8
		public string leaderboardId; //Field offset: 0x20
		public bool isHighPriority; //Field offset: 0x28
		public int maxScores; //Field offset: 0x2C
		public bool useCache; //Field offset: 0x30
		public Btd6Player player; //Field offset: 0x38
		private ScoreModel[] <scores>5__2; //Field offset: 0x40
		private TaskAwaiter<ScoreModel[]> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static readonly StorageManager <LeaderboardStorage>k__BackingField; //Field offset: 0x0
	private const string kRankCachePostfix = "_spr"; //Field offset: 0x0
	private const string kGroupRankCachePostfix = "_mpr"; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly LeaderboardRankCache <RankCache>k__BackingField; //Field offset: 0x8
	private static readonly string kTimestampMetadataFinder; //Field offset: 0x10

	private static TimeSpan CacheLife
	{
		private get { } //Length: 159
	}

	private static StorageManager LeaderboardStorage
	{
		[CompilerGenerated]
		private get { } //Length: 78
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	private static LeaderboardRankCache RankCache
	{
		[CompilerGenerated]
		private get { } //Length: 79
	}

	private static LeaderboardDownloader() { }

	public static void ClearCache(string leaderboardId) { }

	[AsyncStateMachine(typeof(<DownloadAndParse>d__26))]
	private static Task<ScoreModel[]> DownloadAndParse(Environments environment, int appId, string leaderboardId, int maxScores) { }

	private static TimeSpan get_CacheLife() { }

	[CompilerGenerated]
	private static StorageManager get_LeaderboardStorage() { }

	private static TimeSpan get_Now() { }

	[CompilerGenerated]
	private static LeaderboardRankCache get_RankCache() { }

	[AsyncStateMachine(typeof(<GetAnonymousRank>d__13))]
	[Extension]
	private static Task<RankModel> GetAnonymousRank(Btd6Player player, string leaderboardId, string playerId, bool useCache = true) { }

	private static RankModel GetDefaultRank(string leaderboardId, string userId) { }

	[Extension]
	public static string GetGroupId(string metadataString) { }

	private static string GetGroupLeaderboardCacheId(string leaderboardId) { }

	[AsyncStateMachine(typeof(<GetGroupRank>d__20))]
	[Extension]
	public static Task<RankModel> GetGroupRank(Btd6Player player, LeaderboardData leaderboardData, int groupSize, bool useCache = true) { }

	[AsyncStateMachine(typeof(<GetGroupScores>d__21))]
	[Extension]
	public static Task<IEnumerable`1<GroupScoreModel>> GetGroupScores(Btd6Player player, LeaderboardData leaderboardData, int groupSize, bool isHighPriority = false, bool useCache = true) { }

	[AsyncStateMachine(typeof(<GetMiniScores>d__22))]
	[Extension]
	public static Task<IEnumerable`1<ScoreModel>> GetMiniScores(Btd6Player player, string leaderboardId, string eventId, bool isElite) { }

	[AsyncStateMachine(typeof(<GetRank>d__12))]
	[Extension]
	public static Task<RankModel> GetRank(Btd6Player player, string leaderboardId, bool useCache = true, bool checkTimeStamps = true, string playerIdOverride = null) { }

	[AsyncStateMachine(typeof(<GetRanks>d__27))]
	[Extension]
	public static Task<RankModel[]> GetRanks(Btd6Player player, string leaderboardId, String[] playerIds, bool useCache = true) { }

	private static long GetScore(ScoreModel scoreModel) { }

	[AsyncStateMachine(typeof(<GetScores>d__14))]
	[Extension]
	public static Task<IEnumerable`1<ScoreModel>> GetScores(Btd6Player player, string leaderboardId, bool isHighPriority = false, int maxScores = 130, bool useCache = true) { }

	private static long GetTimeStamp(ScoreModel scoreModel) { }

	private static bool HasTimestamp(ScoreModel score) { }

}

