namespace Assets.Scripts.Unity.Network;

public static class ReplayUtility
{
	[CompilerGenerated]
	private struct <TrySubmitLeadeboardReplay>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Replay replay; //Field offset: 0x20
		public BaseServerEvent _event; //Field offset: 0x28
		public string leaderboardId; //Field offset: 0x30
		public int gameId; //Field offset: 0x38
		private ReplaySettings <replaySettings>5__2; //Field offset: 0x40
		private TaskAwaiter<RankModel> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kReplayIdPrefix = "replay"; //Field offset: 0x0
	private const string kReplayTag_CT = "CT"; //Field offset: 0x0
	private const string kReplayTag_Coop = "coop"; //Field offset: 0x0

	private static string ReplayVersion
	{
		private get { } //Length: 64
	}

	private static string get_ReplayVersion() { }

	public static string GetContestedTerritoryReplayId(string eventId, string tileShortcode) { }

	public static string GetCoopReplayId(string lobbyId) { }

	public static string GetLeaderboardReplayId(string leaderboardId, int gameId) { }

	[AsyncStateMachine(typeof(<TrySubmitLeadeboardReplay>d__8))]
	public static Task<Boolean> TrySubmitLeadeboardReplay(Replay replay, BaseServerEvent _event, string leaderboardId, int gameId) { }

}

