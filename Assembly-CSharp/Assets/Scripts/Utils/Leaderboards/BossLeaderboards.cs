namespace Assets.Scripts.Utils.Leaderboards;

public static class BossLeaderboards
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string leaderboardId; //Field offset: 0x10
		public string miniLeaderboardId; //Field offset: 0x18
		public LeaderboardScoreData score; //Field offset: 0x20
		public Metadatas metadatas; //Field offset: 0x30
		public BossEvent bossEvent; //Field offset: 0x40
		public bool isElite; //Field offset: 0x48
		public LeaderboardType leaderboardType; //Field offset: 0x4C
		public BossLeaderboardType bossLeaderboardType; //Field offset: 0x50
		public int playerCount; //Field offset: 0x54
		public string teamId; //Field offset: 0x58
		public Action onSubmissionCancelled; //Field offset: 0x60

		public <>c__DisplayClass3_0() { }

		internal void <TrySubmitScores>b__0() { }

		internal void <TrySubmitScores>b__1() { }

	}

	[CompilerGenerated]
	private struct <SubmitCurrentScore>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Double[]> <>t__builder; //Field offset: 0x8
		public int bossTier; //Field offset: 0x20
		public BossEvent bossEvent; //Field offset: 0x28
		public bool isElite; //Field offset: 0x30
		public Action onSubmissionCancelled; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySubmitScores>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string leaderboardId; //Field offset: 0x20
		public string miniLeaderboardId; //Field offset: 0x28
		public LeaderboardScoreData score; //Field offset: 0x30
		public Metadatas metadatas; //Field offset: 0x40
		public BossEvent bossEvent; //Field offset: 0x50
		public bool isElite; //Field offset: 0x58
		public LeaderboardType leaderboardType; //Field offset: 0x5C
		public BossLeaderboardType bossLeaderboardType; //Field offset: 0x60
		public int playerCount; //Field offset: 0x64
		public string teamId; //Field offset: 0x68
		public Action onSubmissionCancelled; //Field offset: 0x70
		private <>c__DisplayClass3_0 <>8__1; //Field offset: 0x78
		private string <submittingId>5__2; //Field offset: 0x80
		private bool <submittingMini>5__3; //Field offset: 0x88
		private Byte[] <submissionData>5__4; //Field offset: 0x90
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x98
		private TaskAwaiter<ScoreModel> <>u__2; //Field offset: 0xA0
		private TaskAwaiter <>u__3; //Field offset: 0xA8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct Metadatas
	{
		public string normal; //Field offset: 0x0
		public string mini; //Field offset: 0x8

	}


	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	private static Btd6Player get_Player() { }

	private static string GetLeaderboardId(string eventId, LeaderboardType leaderboardType, int playerCount, bool isElite) { }

	private static Metadatas GetMetadatas(bool isCoop, string teamId, bool isElite) { }

	private static string GetMiniLeaderboardId(string eventId, LeaderboardType leaderboardType, bool isElite) { }

	private static Byte[] GetSubmissionData(string leaderboardId, LeaderboardScoreData score, string metadata, bool isMini, bool isElite, LeaderboardType leaderboardType, int playerCount, string teamId) { }

	[AsyncStateMachine(typeof(<SubmitCurrentScore>d__2))]
	public static Task<Double[]> SubmitCurrentScore(BossEvent bossEvent, bool isElite, int bossTier, Action onSubmissionCancelled = null) { }

	[AsyncStateMachine(typeof(<TrySubmitScores>d__3))]
	private static Task TrySubmitScores(string leaderboardId, string miniLeaderboardId, LeaderboardScoreData score, Metadatas metadatas, BossEvent bossEvent, bool isElite, LeaderboardType leaderboardType, BossLeaderboardType bossLeaderboardType, int playerCount, string teamId, Action onSubmissionCancelled) { }

	private static void ValidateScore(LeaderboardScoreData leaderboardScore, LeaderboardScoringType leaderboardScoringType) { }

}

