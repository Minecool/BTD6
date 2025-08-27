namespace NinjaKiwi.LiNK.Lobbies;

public class LobbyConnection : IDisposable
{
	[CompilerGenerated]
	private struct <Connect>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LobbyConnection> <>t__builder; //Field offset: 0x8
		public LiNKLobby liNKLobby; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		public string playerInfo; //Field offset: 0x30
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDisconnected>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LobbyConnection <>4__this; //Field offset: 0x28
		public Exception reason; //Field offset: 0x30
		private int <retries>5__2; //Field offset: 0x38
		private TimeSpan <startTime>5__3; //Field offset: 0x40
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Reconnect>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<NKMultiConnection> <>t__builder; //Field offset: 0x8
		public LobbyConnection <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<NKMultiConnection> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTillDisposed>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LobbyConnection <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class ExternalMessageToSend : MessageToSend, Writable, Writable
	{
		private readonly Writable Content; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public ExternalMessageToSend(Writable content) { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private enum MessageCode
	{
		External = 0,
		PlayerInfo = 1,
		RequestStart = 2,
		Start = 3,
		GameSettings = 4,
	}

	private interface MessageToSend : Writable, Writable
	{

		public MessageCode Code
		{
			 get { } //Length: 0
		}

		public MessageCode get_Code() { }

	}

	private class PlayerInfoMessage : MessageToSend, Writable, Writable
	{
		public readonly string PlayerInfo; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public PlayerInfoMessage(string playerInfo) { }

		public override MessageCode get_Code() { }

		public static string ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class RequestStartMessage : MessageToSend, Writable, Writable
	{

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public RequestStartMessage() { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class StartMessage : MessageToSend, Writable, Writable
	{
		private const int ZLIB_BUFFER_SIZE = 2048; //Field offset: 0x0
		public readonly Dictionary<Byte, String> Players; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public StartMessage(Dictionary<Byte, String> players) { }

		public override MessageCode get_Code() { }

		public static Dictionary<Byte, String> ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	public static int LatencyFailCountThreshold; //Field offset: 0x0
	public readonly LiNKLobby LiNKLobby; //Field offset: 0x10
	public readonly Dictionary<Byte, String> OtherPlayers; //Field offset: 0x18
	public readonly Queue<ReceivedMessage> ReceiveQueue; //Field offset: 0x20
	private readonly CancellationTokenSource ReconnectCanceller; //Field offset: 0x28
	public int MaxRetries; //Field offset: 0x30
	[CompilerGenerated]
	private GameConnection <Game>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string <OwnPlayerInfo>k__BackingField; //Field offset: 0x40
	public bool DebugMode; //Field offset: 0x48
	[CompilerGenerated]
	private Action<GameConnection> StartEvent; //Field offset: 0x50
	[CompilerGenerated]
	private Action<Byte> PlayerChangedEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action<Byte> PlayerJoinedEvent; //Field offset: 0x60
	[CompilerGenerated]
	private Action<Byte> PlayerLeftEvent; //Field offset: 0x68
	[CompilerGenerated]
	private Action<Exception> ReconnectingEvent; //Field offset: 0x70
	[CompilerGenerated]
	private Action ReconnectedEvent; //Field offset: 0x78
	[CompilerGenerated]
	private Action DisconnectedEvent; //Field offset: 0x80
	[CompilerGenerated]
	private Action<String> NotAvailableEvent; //Field offset: 0x88
	private NKMultiConnection Connection; //Field offset: 0x90
	private bool IsDisposed; //Field offset: 0x98

	public event Action DisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<String> NotAvailableEvent
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Byte> PlayerChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Byte> PlayerJoinedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Byte> PlayerLeftEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action ReconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<Exception> ReconnectingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<GameConnection> StartEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public Dictionary<Byte, String> AllPlayers
	{
		 get { } //Length: 177
	}

	private TimeSpan ElapsedTime
	{
		private get { } //Length: 91
	}

	public private GameConnection Game
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public string ID
	{
		 get { } //Length: 36
	}

	public bool IsAuthority
	{
		 get { } //Length: 39
	}

	public MatchMakingParameters MatchMakingParameters
	{
		 get { } //Length: 27
	}

	public JObject MetaData
	{
		 get { } //Length: 36
	}

	public private string OwnPlayerInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public byte OwnPlayerNumber
	{
		 get { } //Length: 36
	}

	private static LobbyConnection() { }

	private LobbyConnection(LiNKLobby liNKLobby, NKMultiConnection connection, string playerInfo) { }

	[CompilerGenerated]
	public void add_DisconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void add_NotAvailableEvent(Action<String> value) { }

	[CompilerGenerated]
	public void add_PlayerChangedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerJoinedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerLeftEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_ReconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void add_ReconnectingEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void add_StartEvent(Action<GameConnection> value) { }

	public void ChangePlayerInfo(string newInfo) { }

	[AsyncStateMachine(typeof(<Connect>d__56))]
	public static Task<LobbyConnection> Connect(LiNKLobby liNKLobby, string playerInfo, CancellationToken canceller = null) { }

	public override void Dispose() { }

	public Dictionary<Byte, String> get_AllPlayers() { }

	private TimeSpan get_ElapsedTime() { }

	[CompilerGenerated]
	public GameConnection get_Game() { }

	public string get_ID() { }

	public bool get_IsAuthority() { }

	public MatchMakingParameters get_MatchMakingParameters() { }

	public JObject get_MetaData() { }

	[CompilerGenerated]
	public string get_OwnPlayerInfo() { }

	public byte get_OwnPlayerNumber() { }

	private void GiveConnectionToGameConnection(Dictionary<Byte, String> players) { }

	[AsyncStateMachine(typeof(<OnDisconnected>d__70))]
	private void OnDisconnected(Exception reason) { }

	private void OnOtherPlayerConnected(byte playerNumber) { }

	private void OnOtherPlayerDisconnected(byte playerNumber) { }

	private void ReceivePlayerInfoMessage(ReceivedMessage received) { }

	private void ReceiveStartMessage(ReceivedMessage received) { }

	private void ReceiveStartRequestMessage(ReceivedMessage received) { }

	[AsyncStateMachine(typeof(<Reconnect>d__71))]
	private Task<NKMultiConnection> Reconnect(CancellationToken canceller) { }

	[CompilerGenerated]
	public void remove_DisconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_NotAvailableEvent(Action<String> value) { }

	[CompilerGenerated]
	public void remove_PlayerChangedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerJoinedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerLeftEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_ReconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_ReconnectingEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void remove_StartEvent(Action<GameConnection> value) { }

	public void Send(Writable content) { }

	private void Send(MessageToSend toSend) { }

	[CompilerGenerated]
	private void set_Game(GameConnection value) { }

	[CompilerGenerated]
	private void set_OwnPlayerInfo(string value) { }

	private void SetConnection(NKMultiConnection connection) { }

	public bool Start() { }

	[AsyncStateMachine(typeof(<UpdateTillDisposed>d__57))]
	private void UpdateTillDisposed() { }

}

