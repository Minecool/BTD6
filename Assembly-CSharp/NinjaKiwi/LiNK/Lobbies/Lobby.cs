namespace NinjaKiwi.LiNK.Lobbies;

public static class Lobby
{
	[CompilerGenerated]
	private struct <Construct>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LobbyConnection> <>t__builder; //Field offset: 0x8
		public Task<LiNKLobby> pendingLiNKLobby; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		public string playerInfo; //Field offset: 0x30
		private LiNKLobby <liNKLobby>5__2; //Field offset: 0x38
		private TaskAwaiter<LiNKLobby> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private object <>7__wrap2; //Field offset: 0x50
		private TaskAwaiter<LobbyConnection> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class BannedException : Exception
	{

		public BannedException() { }

	}

	internal class FullException : Exception
	{

		public FullException() { }

	}

	internal class NotCompatibleException : Exception
	{

		public NotCompatibleException(string message) { }

	}

	internal class NotFoundException : Exception
	{

		public NotFoundException() { }

	}


	[AsyncStateMachine(typeof(<Construct>d__4))]
	private static Task<LobbyConnection> Construct(Task<LiNKLobby> pendingLiNKLobby, string playerInfo, CancellationToken canceller) { }

	public static Task<LobbyConnection> Create(string playerInfo, Api liNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public static Task<LobbyConnection> Find(string playerInfo, Api liNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public static Task<LobbyConnection> FindOrCreate(string playerInfo, Api liNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public static Task<LobbyConnection> Join(string lobbyID, string playerInfo, Api liNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

}

