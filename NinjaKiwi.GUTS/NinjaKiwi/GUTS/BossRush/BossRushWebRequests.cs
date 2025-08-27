namespace NinjaKiwi.GUTS.BossRush;

[Extension]
public static class BossRushWebRequests
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public int daysSinceEventStart; //Field offset: 0x0
		public byte stage; //Field offset: 0x0

		public <>c__DisplayClass11_0`1() { }

		internal bool <BR_GetScores>b__0(SubmittedScore x) { }

	}

	[CompilerGenerated]
	private struct <BR_ClaimTeamTrophies>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushTeamTrophyClaimResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<BossRushTeamTrophyClaimResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BR_GetCompletedTier>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushCompletedTierResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<BossRushCompletedTierResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BR_GetScores>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushPlayerScoresResponse> <>t__builder; //Field offset: 0x0
		public int daysSinceEventStart; //Field offset: 0x0
		public byte stage; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<BossRushPlayerScoresResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BR_GetStatus>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushStatusResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public bool forceUpdate; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<BossRushStatusResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BR_SubmitScore>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushScoreResponse> <>t__builder; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		public uint score; //Field offset: 0x0
		public byte stage; //Field offset: 0x0
		public bool isDebug; //Field offset: 0x0
		public int gameId; //Field offset: 0x0
		public float ce; //Field offset: 0x0
		public float cs; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<BossRushScoreResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static List<SubmittedScore> <CachedSubmittedScores>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"status", "hasBeenUsed"}])]
	private static ValueTuple<BossRushGuildStatus, Boolean> <BossRushGuildStatusCache>k__BackingField; //Field offset: 0x8

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"status", "hasBeenUsed"}])]
	internal static ValueTuple<BossRushGuildStatus, Boolean> BossRushGuildStatusCache
	{
		[CompilerGenerated]
		internal get { } //Length: 67
		[CompilerGenerated]
		internal set { } //Length: 64
	}

	public internal static List<SubmittedScore> CachedSubmittedScores
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		internal set { } //Length: 60
	}

	[AsyncStateMachine(typeof(<BR_ClaimTeamTrophies>d__12`1))]
	[Extension]
	public static Task<BossRushTeamTrophyClaimResponse> BR_ClaimTeamTrophies(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<BR_GetCompletedTier>d__9`1))]
	[Extension]
	public static Task<BossRushCompletedTierResponse> BR_GetCompletedTier(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<BR_GetScores>d__11`1))]
	[Extension]
	public static Task<BossRushPlayerScoresResponse> BR_GetScores(Player<T> player, string eventId, int daysSinceEventStart, byte stage) { }

	[AsyncStateMachine(typeof(<BR_GetStatus>d__10`1))]
	[Extension]
	public static Task<BossRushStatusResponse> BR_GetStatus(Player<T> player, string eventId, bool forceUpdate = true) { }

	[AsyncStateMachine(typeof(<BR_SubmitScore>d__4`1))]
	[Extension]
	public static Task<BossRushScoreResponse> BR_SubmitScore(Player<T> player, string eventId, uint score, byte stage, int gameId, float ce, float cs, bool isDebug = false) { }

	[CompilerGenerated]
	internal static ValueTuple<BossRushGuildStatus, Boolean> get_BossRushGuildStatusCache() { }

	[CompilerGenerated]
	public static List<SubmittedScore> get_CachedSubmittedScores() { }

	[CompilerGenerated]
	internal static void set_BossRushGuildStatusCache(ValueTuple<BossRushGuildStatus, Boolean> value) { }

	[CompilerGenerated]
	internal static void set_CachedSubmittedScores(List<SubmittedScore> value) { }

}

