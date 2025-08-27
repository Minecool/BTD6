namespace NinjaKiwi.LiNK.Lobbies;

public class GameConnection : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public byte playerNumber; //Field offset: 0x10
		public GameConnection <>4__this; //Field offset: 0x18

		public <>c__DisplayClass63_0() { }

		internal void <.ctor>b__0() { }

		internal void <.ctor>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <get_AllPlayers>d__7 : IEnumerable<Player>, IEnumerable, IEnumerator<Player>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Player <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public GameConnection <>4__this; //Field offset: 0x28
		private bool <hasInserted>5__2; //Field offset: 0x30
		private IEnumerator<OtherPlayerPrivate> <>7__wrap2; //Field offset: 0x38
		private OtherPlayerPrivate <p>5__4; //Field offset: 0x40

		private override Player System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.Player>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_AllPlayers>d__7(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Player> System.Collections.Generic.IEnumerable<NinjaKiwi.LiNK.Lobbies.Player>.GetEnumerator() { }

		[DebuggerHidden]
		private override Player System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.Player>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <get_OtherPlayers>d__5 : IEnumerable<Player>, IEnumerable, IEnumerator<Player>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Player <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public GameConnection <>4__this; //Field offset: 0x28
		private IEnumerator<OtherPlayerPrivate> <>7__wrap1; //Field offset: 0x30

		private override Player System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.Player>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_OtherPlayers>d__5(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Player> System.Collections.Generic.IEnumerable<NinjaKiwi.LiNK.Lobbies.Player>.GetEnumerator() { }

		[DebuggerHidden]
		private override Player System.Collections.Generic.IEnumerator<NinjaKiwi.LiNK.Lobbies.Player>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <GetRejoinConnection>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GameConnection> <>t__builder; //Field offset: 0x8
		public ConnectionDetails connectionDetails; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		public bool debugMode; //Field offset: 0x30
		public Dictionary<Byte, String> players; //Field offset: 0x38
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnDisconnected>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameConnection <>4__this; //Field offset: 0x28
		public Exception reason; //Field offset: 0x30
		private CancellationTokenSource <>7__wrap1; //Field offset: 0x38
		private ManualCountdown <countdown>5__3; //Field offset: 0x40
		private TimeSpan <startTime>5__4; //Field offset: 0x48
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x50
		private YieldAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnOtherPlayerAWOL>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameConnection <>4__this; //Field offset: 0x28
		public byte playerNumber; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveAwolMessage>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ReceivedMessage received; //Field offset: 0x28
		public GameConnection <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Reconnect>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<NKMultiConnection> <>t__builder; //Field offset: 0x8
		public GameConnection <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Rejoin>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameConnection <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TimeSpan <endWaitAt>5__2; //Field offset: 0x30
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TestIfGameCanBeRejoined>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public ConnectionDetails connectionDetails; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private NKMultiConnection <connection>5__2; //Field offset: 0x30
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x38
		private TimeSpan <waitEndTime>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateUntilDisposedAsync>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public GameConnection <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitAndKick>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OtherPlayerPrivate player; //Field offset: 0x20
		public GameConnection <>4__this; //Field offset: 0x28
		public byte playerNumber; //Field offset: 0x30
		private TimeSpan <timeTillDisconnect>5__2; //Field offset: 0x38
		private SecondsCountdown <countdown>5__3; //Field offset: 0x40
		private TimeSpan <startTime>5__4; //Field offset: 0x48
		private YieldAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class AwolMessage : MessageToSend, Writable, Writable
	{
		public readonly byte PlayerNumber; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public AwolMessage(byte playerNumber) { }

		public override MessageCode get_Code() { }

		public static byte ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class BanMessage : MessageToSend, Writable, Writable
	{
		private readonly byte PlayerNumber; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public BanMessage(byte playerNumber) { }

		public override MessageCode get_Code() { }

		public static byte ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class ExternalMessageToSend : MessageToSend, Writable, Writable
	{
		public readonly int MessageNumber; //Field offset: 0x10
		private readonly Writable Content; //Field offset: 0x18

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public ExternalMessageToSend(int messageNumber, Writable content) { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class KickMessage : MessageToSend, Writable, Writable
	{
		public readonly byte PlayerNumber; //Field offset: 0x10
		public readonly string Reason; //Field offset: 0x18
		private readonly Byte[] ReasonBytes; //Field offset: 0x20

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public KickMessage(byte playerNumber, string reason) { }

		private KickMessage(byte playerNumber, Byte[] reasonBytes) { }

		public override MessageCode get_Code() { }

		public static KickMessage ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class LeaveMessage : MessageToSend, Writable, Writable
	{

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public LeaveMessage() { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private enum MessageCode
	{
		External = 0,
		Leave = 1,
		Status = 2,
		Reconnect = 3,
		Awol = 4,
		NotAwol = 5,
		Kick = 6,
		Started = 7,
		Rejoin = 8,
		RejoinConfirm = 9,
		RejoinTest = 10,
		RejoinAllowed = 11,
		Ban = 12,
	}

	private interface MessageToSend : Writable, Writable
	{

		public MessageCode Code
		{
			 get { } //Length: 0
		}

		public MessageCode get_Code() { }

	}

	private class NotAwolMessage : AwolMessage
	{

		public virtual MessageCode Code
		{
			 get { } //Length: 3
		}

		public NotAwolMessage(byte playerNumber) { }

		public virtual MessageCode get_Code() { }

	}

	private class ReconnectMessage : MessageToSend, Writable, Writable
	{

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public ReconnectMessage() { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class RejoinAllowedMessage : MessageToSend, Writable, Writable
	{
		private readonly byte PlayerNumber; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public RejoinAllowedMessage(byte playerNumber) { }

		public override MessageCode get_Code() { }

		public static byte ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class RejoinConfirmMessage : MessageToSend, Writable, Writable
	{
		public readonly int CurrentMessageNumber; //Field offset: 0x10

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public RejoinConfirmMessage(int currentMessageNumber) { }

		public override MessageCode get_Code() { }

		public static int ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class RejoinMessage : MessageToSend, Writable, Writable
	{

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public RejoinMessage() { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class RejoinTestMessage : MessageToSend, Writable, Writable
	{

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public RejoinTestMessage() { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class StartedMessage : MessageToSend, Writable, Writable
	{

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public StartedMessage() { }

		public override MessageCode get_Code() { }

		public override void WriteTo(BinaryWriter output) { }

	}

	private class StatusMessage : MessageToSend, Writable, Writable
	{
		public readonly uint Counter; //Field offset: 0x10
		public readonly TimeSpan Latency; //Field offset: 0x18
		public readonly bool IsDelayed; //Field offset: 0x20
		public readonly Dictionary<Byte, Int32> LastReceived; //Field offset: 0x28

		public override MessageCode Code
		{
			 get { } //Length: 3
		}

		public StatusMessage(uint counter, TimeSpan latency, bool isDelayed, Dictionary<Byte, Int32> lastReceived) { }

		public override MessageCode get_Code() { }

		public static StatusMessage ReadFrom(BinaryReader received) { }

		public override void WriteTo(BinaryWriter output) { }

	}

	public static readonly ConnectionConfig Config; //Field offset: 0x0
	public readonly byte OwnPlayerNumber; //Field offset: 0x10
	public readonly string LobbyID; //Field offset: 0x18
	public readonly Queue<ReceivedMessage> ReceiveQueue; //Field offset: 0x20
	[CompilerGenerated]
	private Action<LatencyMeasurement> OwnLatencyUpdatedEvent; //Field offset: 0x28
	[CompilerGenerated]
	private Action LatencyWarningEvent; //Field offset: 0x30
	[CompilerGenerated]
	private Action<Exception> RelayDisconnectedEvent; //Field offset: 0x38
	[CompilerGenerated]
	private Action<IEnumerable`1<Task`1<Int32>>> ReconnectingEvent; //Field offset: 0x40
	[CompilerGenerated]
	private Action ReconnectedEvent; //Field offset: 0x48
	[CompilerGenerated]
	private Action RejoinedEvent; //Field offset: 0x50
	[CompilerGenerated]
	private Action<String> DisconnectedEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action<IEnumerable`1<Task`1<Int32>>, Byte> PlayerAWOLEvent; //Field offset: 0x60
	[CompilerGenerated]
	private Action<Byte> PlayerNotAWOLEvent; //Field offset: 0x68
	[CompilerGenerated]
	private Action NoPlayersAWOLEvent; //Field offset: 0x70
	[CompilerGenerated]
	private Action<Byte, String> PlayerLeftEvent; //Field offset: 0x78
	[CompilerGenerated]
	private Action<Byte> PlayerRejoinedEvent; //Field offset: 0x80
	[CompilerGenerated]
	private Action<String> LogEvent; //Field offset: 0x88
	private readonly SelfPlayer SelfPlayer; //Field offset: 0x90
	private readonly Queue<ExternalMessageToSend> SentMessages; //Field offset: 0x98
	private readonly OtherPlayersPrivate otherPlayersPrivate; //Field offset: 0xA0
	private NKMultiConnection Connection; //Field offset: 0xA8
	private ConnectionDetails ConnectionDetails; //Field offset: 0xB0
	private CancellationTokenSource ReconnectCanceller; //Field offset: 0xB8
	private bool IsDisposed; //Field offset: 0xC0
	private int MessageCounter; //Field offset: 0xC4

	public event Action<String> DisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action LatencyWarningEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<String> LogEvent
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public event Action NoPlayersAWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<LatencyMeasurement> OwnLatencyUpdatedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<IEnumerable`1<Task`1<Int32>>, Byte> PlayerAWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Byte, String> PlayerLeftEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Byte> PlayerNotAWOLEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Byte> PlayerRejoinedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public event Action ReconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<IEnumerable`1<Task`1<Int32>>> ReconnectingEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action RejoinedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<Exception> RelayDisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public IEnumerable<Player> AllPlayers
	{
		[IteratorStateMachine(typeof(<get_AllPlayers>d__7))]
		 get { } //Length: 100
	}

	private static TimeSpan ElapsedTime
	{
		private get { } //Length: 91
	}

	public GameDetails GameDetails
	{
		 get { } //Length: 177
	}

	public IEnumerable<Player> OtherPlayers
	{
		[IteratorStateMachine(typeof(<get_OtherPlayers>d__5))]
		 get { } //Length: 100
	}

	public TimeSpan SelfLatency
	{
		 get { } //Length: 30
	}

	public TimeSpan SelfLatencyVariance
	{
		 get { } //Length: 30
	}

	private static GameConnection() { }

	public GameConnection(NKMultiConnection connection, string lobbyID, Dictionary<Byte, String> players) { }

	[CompilerGenerated]
	private bool <Rejoin>g__waitingForAnyOtherPlayer|88_0() { }

	[CompilerGenerated]
	public void add_DisconnectedEvent(Action<String> value) { }

	[CompilerGenerated]
	public void add_LatencyWarningEvent(Action value) { }

	[CompilerGenerated]
	public void add_LogEvent(Action<String> value) { }

	[CompilerGenerated]
	public void add_NoPlayersAWOLEvent(Action value) { }

	[CompilerGenerated]
	public void add_OwnLatencyUpdatedEvent(Action<LatencyMeasurement> value) { }

	[CompilerGenerated]
	public void add_PlayerAWOLEvent(Action<IEnumerable`1<Task`1<Int32>>, Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerLeftEvent(Action<Byte, String> value) { }

	[CompilerGenerated]
	public void add_PlayerNotAWOLEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerRejoinedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_ReconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void add_ReconnectingEvent(Action<IEnumerable`1<Task`1<Int32>>> value) { }

	[CompilerGenerated]
	public void add_RejoinedEvent(Action value) { }

	[CompilerGenerated]
	public void add_RelayDisconnectedEvent(Action<Exception> value) { }

	public void Ban(byte playerNumber) { }

	private void BanPlayer(byte playerNumber) { }

	private bool CheckPlayerStarted(byte playerNumber, byte code) { }

	private void DiscardConfirmedMessages() { }

	public override void Dispose() { }

	private void EnqueueExternalMessage(ReceivedMessage received) { }

	[IteratorStateMachine(typeof(<get_AllPlayers>d__7))]
	public IEnumerable<Player> get_AllPlayers() { }

	private static TimeSpan get_ElapsedTime() { }

	public GameDetails get_GameDetails() { }

	[IteratorStateMachine(typeof(<get_OtherPlayers>d__5))]
	public IEnumerable<Player> get_OtherPlayers() { }

	public TimeSpan get_SelfLatency() { }

	public TimeSpan get_SelfLatencyVariance() { }

	[AsyncStateMachine(typeof(<GetRejoinConnection>d__86))]
	public static Task<GameConnection> GetRejoinConnection(ConnectionDetails connectionDetails, Dictionary<Byte, String> players, CancellationToken canceller, bool debugMode = false) { }

	private static bool IsDisconnected(OtherPlayerPrivate player) { }

	private static bool IsNotDisconnected(OtherPlayerPrivate player) { }

	private static bool IsPlayerAWOL(OtherPlayerPrivate player) { }

	public void Kick(byte playerNumber, string reason) { }

	[AsyncStateMachine(typeof(<OnDisconnected>d__76))]
	private void OnDisconnected(Exception reason) { }

	[AsyncStateMachine(typeof(<OnOtherPlayerAWOL>d__94))]
	private void OnOtherPlayerAWOL(byte playerNumber) { }

	private void OnOwnLatencyUpdated(TimeSpan latency, uint counter, bool isDelayed) { }

	[AsyncStateMachine(typeof(<ReceiveAwolMessage>d__95))]
	private void ReceiveAwolMessage(ReceivedMessage received) { }

	private void ReceiveBanMessage(ReceivedMessage received) { }

	private void ReceiveKickMessage(ReceivedMessage received) { }

	private void ReceiveLeaveMessage(ReceivedMessage received) { }

	private void ReceiveNotAwolMessage(ReceivedMessage received) { }

	private void ReceiveReconnectMessage(ReceivedMessage received) { }

	private void ReceiveRejoinConfirmMessage(ReceivedMessage received) { }

	private void ReceiveRejoinMessage(ReceivedMessage received) { }

	private void ReceiveRejoinTestMessage(ReceivedMessage received) { }

	private void ReceiveStartedMessage(ReceivedMessage received) { }

	private void ReceiveStatusMessage(ReceivedMessage received) { }

	[AsyncStateMachine(typeof(<Reconnect>d__77))]
	private Task<NKMultiConnection> Reconnect(CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<Rejoin>d__88))]
	public Task Rejoin(CancellationToken canceller) { }

	[CompilerGenerated]
	public void remove_DisconnectedEvent(Action<String> value) { }

	[CompilerGenerated]
	public void remove_LatencyWarningEvent(Action value) { }

	[CompilerGenerated]
	public void remove_LogEvent(Action<String> value) { }

	[CompilerGenerated]
	public void remove_NoPlayersAWOLEvent(Action value) { }

	[CompilerGenerated]
	public void remove_OwnLatencyUpdatedEvent(Action<LatencyMeasurement> value) { }

	[CompilerGenerated]
	public void remove_PlayerAWOLEvent(Action<IEnumerable`1<Task`1<Int32>>, Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerLeftEvent(Action<Byte, String> value) { }

	[CompilerGenerated]
	public void remove_PlayerNotAWOLEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerRejoinedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_ReconnectedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_ReconnectingEvent(Action<IEnumerable`1<Task`1<Int32>>> value) { }

	[CompilerGenerated]
	public void remove_RejoinedEvent(Action value) { }

	[CompilerGenerated]
	public void remove_RelayDisconnectedEvent(Action<Exception> value) { }

	private void RemovePlayer(byte playerNumber, string reason) { }

	public void Send(Writable content) { }

	private void Send(MessageToSend toSend) { }

	private void SetConnection(NKMultiConnection connection) { }

	[AsyncStateMachine(typeof(<TestIfGameCanBeRejoined>d__87))]
	public static Task<Int32> TestIfGameCanBeRejoined(ConnectionDetails connectionDetails, CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<UpdateUntilDisposedAsync>d__68))]
	private void UpdateUntilDisposedAsync() { }

	[AsyncStateMachine(typeof(<WaitAndKick>d__97))]
	private Task WaitAndKick(byte playerNumber, OtherPlayerPrivate player) { }

}

