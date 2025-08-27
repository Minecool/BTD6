namespace Assets.Scripts.Utils.Leaderboards;

[Extension]
public static class LeaderboardPoolHelper
{
	[CompilerGenerated]
	private struct <GetGroup>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String[]> <>t__builder; //Field offset: 0x8
		public string leaderboardEventId; //Field offset: 0x20
		public bool isElite; //Field offset: 0x28
		public Btd6Player player; //Field offset: 0x30
		private TaskAwaiter<Dictionary`2<String, String[]>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <JoinLeaderboardGroup>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public string leaderboardEventId; //Field offset: 0x28
		public bool isElite; //Field offset: 0x30
		public int maxPlayers; //Field offset: 0x34
		private string <leaderboardEventIdFull>5__2; //Field offset: 0x38
		private TaskAwaiter<String[]> <>u__1; //Field offset: 0x40
		private TaskAwaiter<LiNKLobby> <>u__2; //Field offset: 0x48
		private TaskAwaiter<String> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kMiniLeaderboardBucketName = "LeaderboardPoolBucket"; //Field offset: 0x0
	private static readonly TimeSpan lobbyExpireTime; //Field offset: 0x0

	private static LeaderboardPoolHelper() { }

	[AsyncStateMachine(typeof(<GetGroup>d__3))]
	public static Task<String[]> GetGroup(Btd6Player player, string leaderboardEventId, bool isElite) { }

	private static string GetLeaderboardEventId(string eventId, bool isElite) { }

	[AsyncStateMachine(typeof(<JoinLeaderboardGroup>d__2))]
	[Extension]
	public static Task JoinLeaderboardGroup(Btd6Player player, string leaderboardEventId, int maxPlayers, bool isElite) { }

}

