namespace Assets.Scripts.ContestedTerritory.Managers;

public static class ContestedTerritorySyncManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Task, Boolean> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SyncGameBoardToLastMapState>b__10_0(Task x) { }

	}

	[CompilerGenerated]
	private struct <PerformFirstFullSyncIfRequired>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshCurrentTileAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshInstanceActivityAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncGameBoardToLastMapState>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private List<Task> <syncTiles>5__2; //Field offset: 0x20
		private Enumerator<Int32, ContestedTerritoryGameTile> <>7__wrap2; //Field offset: 0x28
		private KeyValuePair<Int32, ContestedTerritoryGameTile> <tile>5__4; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncMapToServerState>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ContestedTerritoryRefreshResult> <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static CancellationTokenSource mapUpdateCanceller; //Field offset: 0x0
	private static CancellationTokenSource tileUpdateCanceller; //Field offset: 0x8
	private static bool isAutoRefreshEnabled; //Field offset: 0x10

	private static ContestedTerritorySyncManager() { }

	[AsyncStateMachine(typeof(<PerformFirstFullSyncIfRequired>d__9))]
	public static Task<Boolean> PerformFirstFullSyncIfRequired() { }

	[AsyncStateMachine(typeof(<RefreshCurrentTileAsync>d__13))]
	private static void RefreshCurrentTileAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<RefreshInstanceActivityAsync>d__12))]
	private static void RefreshInstanceActivityAsync(CancellationToken cancellationToken) { }

	public static void ResumeAutoRefresh() { }

	public static void StartRefreshingMapActivity() { }

	public static void StartRefreshingTileActivity() { }

	public static void StopRefreshingMapActivity() { }

	public static void StopRefreshingTileActivity() { }

	public static void SuspendAutoRefresh() { }

	[AsyncStateMachine(typeof(<SyncGameBoardToLastMapState>d__10))]
	public static Task SyncGameBoardToLastMapState() { }

	[AsyncStateMachine(typeof(<SyncMapToServerState>d__11))]
	public static Task<ContestedTerritoryRefreshResult> SyncMapToServerState(bool forceRefresh) { }

}

