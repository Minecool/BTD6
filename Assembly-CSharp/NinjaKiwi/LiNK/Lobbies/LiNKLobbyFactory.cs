namespace NinjaKiwi.LiNK.Lobbies;

public static class LiNKLobbyFactory
{
	[CompilerGenerated]
	private struct <Create>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LiNKLobby> <>t__builder; //Field offset: 0x8
		public Api liNK; //Field offset: 0x20
		public MatchMakingParameters parameters; //Field offset: 0x28
		private TaskAwaiter<LobbyModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Find>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LiNKLobby> <>t__builder; //Field offset: 0x8
		public Api liNK; //Field offset: 0x20
		public MatchMakingParameters parameters; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		private TaskAwaiter<Response> <>u__1; //Field offset: 0x38
		private TaskAwaiter<LobbyModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FindOrCreate>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LiNKLobby> <>t__builder; //Field offset: 0x8
		public Api liNK; //Field offset: 0x20
		public MatchMakingParameters parameters; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		private TaskAwaiter<LiNKLobby> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Join>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LiNKLobby> <>t__builder; //Field offset: 0x8
		public Api liNK; //Field offset: 0x20
		public string lobbyID; //Field offset: 0x28
		public CancellationToken canceller; //Field offset: 0x30
		public MatchMakingParameters parameters; //Field offset: 0x38
		private TaskAwaiter<LobbyModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<Create>d__2))]
	internal static Task<LiNKLobby> Create(Api liNK, MatchMakingParameters parameters, CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<Find>d__1))]
	internal static Task<LiNKLobby> Find(Api liNK, MatchMakingParameters parameters, CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<FindOrCreate>d__3))]
	internal static Task<LiNKLobby> FindOrCreate(Api liNK, MatchMakingParameters parameters, CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<Join>d__0))]
	internal static Task<LiNKLobby> Join(string lobbyID, Api liNK, MatchMakingParameters parameters, CancellationToken canceller) { }

}

