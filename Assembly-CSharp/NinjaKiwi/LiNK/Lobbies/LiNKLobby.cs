namespace NinjaKiwi.LiNK.Lobbies;

public class LiNKLobby
{
	[CompilerGenerated]
	private struct <Migrate>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKLobby <>4__this; //Field offset: 0x20
		public string newBucket; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Rejoin>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LiNKLobby <>4__this; //Field offset: 0x20
		private TaskAwaiter<LobbyModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class FullException : NotAvailableException
	{

		public FullException() { }

	}

	internal class NotAvailableException : Exception
	{

		public NotAvailableException() { }

		public NotAvailableException(string message) { }

	}

	internal class NotCompatibleException : NotAvailableException
	{

		public NotCompatibleException(string message) { }

	}

	internal class NotFoundException : NotAvailableException
	{

		public NotFoundException() { }

	}

	[CompilerGenerated]
	private readonly MatchMakingParameters <MatchmakingParameters>k__BackingField; //Field offset: 0x10
	private readonly Api LiNK; //Field offset: 0x18
	private LobbyModel Model; //Field offset: 0x20

	public string ID
	{
		 get { } //Length: 27
	}

	public MatchMakingParameters MatchmakingParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public JObject MetaData
	{
		 get { } //Length: 27
	}

	public string PlayerID
	{
		 get { } //Length: 27
	}

	public int PlayerNumber
	{
		 get { } //Length: 26
	}

	public RelayInfo Relay
	{
		 get { } //Length: 27
	}

	public LiNKLobby(Api liNK, LobbyModel model, MatchMakingParameters parameters) { }

	public static Task<LiNKLobby> Create(Api LiNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public Task Delete() { }

	public static Task<LiNKLobby> Find(Api LiNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public static Task<LiNKLobby> FindOrCreate(Api LiNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public string get_ID() { }

	[CompilerGenerated]
	public MatchMakingParameters get_MatchmakingParameters() { }

	public JObject get_MetaData() { }

	public string get_PlayerID() { }

	public int get_PlayerNumber() { }

	public RelayInfo get_Relay() { }

	public static Task<LiNKLobby> Join(string lobbyID, Api liNK, MatchMakingParameters parameters, CancellationToken canceller = null) { }

	public Task Leave() { }

	[AsyncStateMachine(typeof(<Migrate>d__19))]
	public Task Migrate(string newBucket) { }

	public Task<String[]> Purge() { }

	[AsyncStateMachine(typeof(<Rejoin>d__20))]
	public Task Rejoin() { }

	public static void RethrowAsLiNKLobbyException(InvalidRequestException ex) { }

}

