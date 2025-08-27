namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public static class DailyChallengeManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<String> <>9__8_0; //Field offset: 0x8
		public static Predicate<String> <>9__8_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CleanupChallengeListData>b__8_0(string x) { }

		internal bool <CleanupChallengeListData>b__8_1(string x) { }

	}

	[CompilerGenerated]
	private struct <CompletedDailyChallenge>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string uniqueDCId; //Field offset: 0x20
		public bool isVictory; //Field offset: 0x28
		public bool hasDoubleCash; //Field offset: 0x29
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private TaskAwaiter<PlayerContentStats> <>u__3; //Field offset: 0x40
		private TaskAwaiter<ElasticSearchUpdateStatus> <>u__4; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateStatsIfMissing>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string uniqueDCId; //Field offset: 0x20
		private TaskAwaiter<PlayerContentStats> <>u__1; //Field offset: 0x28
		private TaskAwaiter<ESDocument> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStats>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<PlayerContentStats> <>t__builder; //Field offset: 0x8
		public string uniqueDCId; //Field offset: 0x20
		private TaskAwaiter<PagedCollection`1<ESDocument>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReStartedDailyChallenge>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string uniqueDCId; //Field offset: 0x20
		private TaskAwaiter<ElasticSearchUpdateStatus> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartedDailyChallenge>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string uniqueDCId; //Field offset: 0x20
		private bool <isFirstPlay>5__2; //Field offset: 0x28
		private bool <updateSuccesful>5__3; //Field offset: 0x29
		private bool <isNewStats>5__4; //Field offset: 0x2A
		private bool <hasLinkAccount>5__5; //Field offset: 0x2B
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<ElasticSearchUpdateStatus> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class DailyChallengeInfo
	{
		public string id; //Field offset: 0x10
		public PlayerContentStats stats; //Field offset: 0x18

		public DailyChallengeInfo(string id, PlayerContentStats stats = null) { }

	}

	private const string kDailyChallengeIndex = "dailychallenges"; //Field offset: 0x0

	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	private static void CleanupChallengeListData() { }

	[AsyncStateMachine(typeof(<CompletedDailyChallenge>d__9))]
	public static Task CompletedDailyChallenge(string uniqueDCId, bool isVictory, bool hasDoubleCash) { }

	[AsyncStateMachine(typeof(<CreateStatsIfMissing>d__7))]
	private static Task<Boolean> CreateStatsIfMissing(string uniqueDCId) { }

	private static Btd6Player get_Player() { }

	private static string GetEsDocId(string uniqueDCId) { }

	[AsyncStateMachine(typeof(<GetStats>d__4))]
	public static Task<PlayerContentStats> GetStats(string uniqueDCId) { }

	[AsyncStateMachine(typeof(<ReStartedDailyChallenge>d__10))]
	public static Task ReStartedDailyChallenge(string uniqueDCId) { }

	[AsyncStateMachine(typeof(<StartedDailyChallenge>d__6))]
	public static Task StartedDailyChallenge(string uniqueDCId) { }

}

