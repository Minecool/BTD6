namespace Assets.Scripts.Utils.Leaderboards;

[Extension]
public static class CtLeaderboardExtensions
{
	[CompilerGenerated]
	private struct <_GetCtLeaderboards>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtLeaderboards> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string eventId; //Field offset: 0x28
		public Nullable<Int32> instanceId; //Field offset: 0x30
		public string guildId; //Field offset: 0x38
		public bool useCache; //Field offset: 0x40
		private Task<LeaderboardRankScores> <localPlayerLb>5__2; //Field offset: 0x48
		private Task<LeaderboardRankScores> <globalTeamLb>5__3; //Field offset: 0x50
		private Task<LeaderboardRankScores> <globalPlayerLb>5__4; //Field offset: 0x58
		private LeaderboardRankScores <>7__wrap4; //Field offset: 0x60
		private LeaderboardRankScores <>7__wrap5; //Field offset: 0x70
		private LeaderboardRankScores <>7__wrap6; //Field offset: 0x80
		private TaskAwaiter<LeaderboardRankScores> <>u__1; //Field offset: 0x90

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCtLeaderboards>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtLeaderboards> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string eventId; //Field offset: 0x28
		public Nullable<Int32> instanceId; //Field offset: 0x30
		public string guildId; //Field offset: 0x38
		public bool useCache; //Field offset: 0x40
		private TaskAwaiter<CtLeaderboards> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGlobalPlayerLeaderboard>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LeaderboardRankScores> <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x28
		public bool useCache; //Field offset: 0x30
		private string <leaderboardId>5__2; //Field offset: 0x38
		private RankModel <rank>5__3; //Field offset: 0x40
		private bool <isTop100Rank>5__4; //Field offset: 0x48
		private TaskAwaiter<RankModel> <>u__1; //Field offset: 0x50
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetGlobalTeamLeaderboard>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LeaderboardRankScores> <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public string guildId; //Field offset: 0x28
		public Btd6Player player; //Field offset: 0x30
		public bool useCache; //Field offset: 0x38
		private string <leaderboardId>5__2; //Field offset: 0x40
		private RankModel <rank>5__3; //Field offset: 0x48
		private bool <isTop100Rank>5__4; //Field offset: 0x50
		private TaskAwaiter<RankModel> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLocalPlayerLeaderboard>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LeaderboardRankScores> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> instanceId; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x28
		public string eventId; //Field offset: 0x30
		public bool useCache; //Field offset: 0x38
		private string <leaderboardId>5__2; //Field offset: 0x40
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLocalTeamLeaderboard>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LeaderboardRankScores> <>t__builder; //Field offset: 0x8
		public Nullable<Int32> instanceId; //Field offset: 0x20
		public string guildId; //Field offset: 0x28
		public string eventId; //Field offset: 0x30
		public Btd6Player player; //Field offset: 0x38
		public bool useCache; //Field offset: 0x40
		private string <leaderboardId>5__2; //Field offset: 0x48
		private TaskAwaiter<IEnumerable`1<ScoreModel>> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static Action<CtLeaderboards> OnLeaderboardsRefreshed; //Field offset: 0x0
	private static Task<CtLeaderboards> ctLeaderboardTask; //Field offset: 0x8

	[AsyncStateMachine(typeof(<_GetCtLeaderboards>d__3))]
	[Extension]
	private static Task<CtLeaderboards> _GetCtLeaderboards(Btd6Player player, string eventId, Nullable<Int32> instanceId, string guildId, bool useCache) { }

	[Extension]
	public static void ClearCtLeaderboardsCache(Btd6Player player, string eventId, int instanceId) { }

	[AsyncStateMachine(typeof(<GetCtLeaderboards>d__2))]
	[Extension]
	public static Task<CtLeaderboards> GetCtLeaderboards(Btd6Player player, string eventId, Nullable<Int32> instanceId, string guildId, bool useCache = true) { }

	private static LeaderboardRankScores GetEmptyLeaderboardRankScores(string leaderboardId, string id) { }

	private static RankModel GetEmptyRank(string leaderboardId, string id) { }

	[AsyncStateMachine(typeof(<GetGlobalPlayerLeaderboard>d__7))]
	[Extension]
	private static Task<LeaderboardRankScores> GetGlobalPlayerLeaderboard(Btd6Player player, string eventId, bool useCache = true) { }

	[AsyncStateMachine(typeof(<GetGlobalTeamLeaderboard>d__8))]
	[Extension]
	private static Task<LeaderboardRankScores> GetGlobalTeamLeaderboard(Btd6Player player, string eventId, string guildId, bool useCache = true) { }

	[AsyncStateMachine(typeof(<GetLocalPlayerLeaderboard>d__6))]
	[Extension]
	private static Task<LeaderboardRankScores> GetLocalPlayerLeaderboard(Btd6Player player, string eventId, Nullable<Int32> instanceId, bool useCache = true) { }

	[AsyncStateMachine(typeof(<GetLocalTeamLeaderboard>d__5))]
	[Extension]
	private static Task<LeaderboardRankScores> GetLocalTeamLeaderboard(Btd6Player player, string eventId, Nullable<Int32> instanceId, string guildId, bool useCache = true) { }

	private static RankModel GetRankFromScores(ScoreModel[] scores, string leaderboardId, string id, RankModel originalRank = null) { }

	[Extension]
	private static bool IsTop100Rank(RankModel rankModel) { }

}

