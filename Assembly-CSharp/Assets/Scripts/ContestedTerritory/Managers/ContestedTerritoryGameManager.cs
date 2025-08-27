namespace Assets.Scripts.ContestedTerritory.Managers;

public static class ContestedTerritoryGameManager
{
	[CompilerGenerated]
	private struct <ReleaseTileActivityAsync>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isTileCaptured; //Field offset: 0x28
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Restart>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StartTileGameResponse> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<StartTileGameResponse> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartPlayingTile>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StartTileGameResponse> <>t__builder; //Field offset: 0x8
		public int tileId; //Field offset: 0x20
		private StartTileGameResponse <response>5__2; //Field offset: 0x28
		private ContestedTerritoryIslandTile <tile>5__3; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static int lastTilePlayed; //Field offset: 0x0
	private static bool lastTilePlayedWasCaptured; //Field offset: 0x4
	[CompilerGenerated]
	private static ContestedTerritoryIslandTile <currentGameTile>k__BackingField; //Field offset: 0x8
	public static Action OnCurrTileScoreChanged; //Field offset: 0x10
	public static bool playerCanAttackAnyTile; //Field offset: 0x18
	public static bool playerCanViewAllTileDetails; //Field offset: 0x19

	public private static ContestedTerritoryIslandTile currentGameTile
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static string GameInProgressTileCode
	{
		 get { } //Length: 143
	}

	public static bool GameInProgressTileHasBannerReward
	{
		 get { } //Length: 150
	}

	public static bool GameInProgressTileHasRelicReward
	{
		 get { } //Length: 150
	}

	public static Nullable<Int32> GameInProgressTileId
	{
		 get { } //Length: 181
	}

	public static int GameInProgressTileScore
	{
		 get { } //Length: 391
	}

	public static int LastTilePlayed
	{
		 get { } //Length: 77
	}

	public static bool LastTileWasCaptured
	{
		 get { } //Length: 79
	}

	public static string teamId
	{
		 get { } //Length: 139
	}

	public static string TeamShortCode
	{
		 get { } //Length: 139
	}

	private static ContestedTerritoryGameManager() { }

	public static void AbandonCurrentTile() { }

	private static void CurrTileScoreChanged() { }

	public static void FinishCurrentTile(bool isTileCaptured) { }

	[CompilerGenerated]
	public static ContestedTerritoryIslandTile get_currentGameTile() { }

	public static string get_GameInProgressTileCode() { }

	public static bool get_GameInProgressTileHasBannerReward() { }

	public static bool get_GameInProgressTileHasRelicReward() { }

	public static Nullable<Int32> get_GameInProgressTileId() { }

	public static int get_GameInProgressTileScore() { }

	public static int get_LastTilePlayed() { }

	public static bool get_LastTileWasCaptured() { }

	public static string get_teamId() { }

	public static string get_TeamShortCode() { }

	[AsyncStateMachine(typeof(<ReleaseTileActivityAsync>d__34))]
	private static void ReleaseTileActivityAsync(bool isTileCaptured) { }

	[AsyncStateMachine(typeof(<Restart>d__31))]
	public static Task<StartTileGameResponse> Restart() { }

	[CompilerGenerated]
	private static void set_currentGameTile(ContestedTerritoryIslandTile value) { }

	public static void SetPlayerCanAttackAnyTile(bool canAttackAnyTile) { }

	public static void SetPlayerCanViewAllTileDetails(bool canViewAllTileDetails) { }

	[AsyncStateMachine(typeof(<StartPlayingTile>d__30))]
	public static Task<StartTileGameResponse> StartPlayingTile(int tileId) { }

}

