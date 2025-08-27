namespace NinjaKiwi.NKMulti;

public class NKMultiGameInterface
{
	[CompilerGenerated]
	private struct <Connect>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NKMultiGameInterface <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private TaskAwaiter<NKMultiConnection> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFreshLatency>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TimeSpan> <>t__builder; //Field offset: 0x8
		public NKMultiGameInterface <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<TimeSpan> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <IsConnectionOk>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public NKMultiGameInterface <>4__this; //Field offset: 0x20
		public int thresholdMs; //Field offset: 0x28
		private TaskAwaiter<TimeSpan> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Join>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NKMultiGameInterface <>4__this; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MeasureLatency>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NKMultiGameInterface <>4__this; //Field offset: 0x28
		public bool isDelayed; //Field offset: 0x30
		public uint measurementCount; //Field offset: 0x34
		private Task<TimeSpan> <measurement>5__2; //Field offset: 0x38
		private TimeSpan <timeBeforeYield>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendPing>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NKMultiGameInterface <>4__this; //Field offset: 0x28
		public Ping ping; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class Ping : TaskCompletionSource<TimeSpan>
	{
		public readonly TimeSpan SentAt; //Field offset: 0x18

		public TimeSpan TimeSinceSent
		{
			 get { } //Length: 209
		}

		public Ping() { }

		public TimeSpan get_TimeSinceSent() { }

		public void SetComplete() { }

		public void SetTimedOut() { }

	}

	public static readonly Version Version; //Field offset: 0x0
	public static int QUEUE_WARNING_LIMIT; //Field offset: 0x8
	public static TimeSpan LATENCY_CHECK_INTERVAL; //Field offset: 0x10
	public static TimeSpan LATENCY_CHECK_TIMEOUT; //Field offset: 0x18
	public readonly string RelayHostName; //Field offset: 0x10
	public readonly int RelayPort; //Field offset: 0x18
	public readonly Version RelayBinaryVersion; //Field offset: 0x20
	public readonly int PeerID; //Field offset: 0x28
	public readonly string PlayerGlobalID; //Field offset: 0x30
	public readonly string MatchID; //Field offset: 0x38
	public readonly Queue<BinaryReader> Received; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Action<Exception> DisconnectedEvent; //Field offset: 0x50
	[CompilerGenerated]
	private Action<Int32> PeerConnectedEvent; //Field offset: 0x58
	[CompilerGenerated]
	private Action<Int32> PeerDisconnectedEvent; //Field offset: 0x60
	[CompilerGenerated]
	private Action<LatencyMeasurement> LatencyUpdateEvent; //Field offset: 0x68
	private NKMultiConnection relayConnection; //Field offset: 0x70
	private readonly TaskCompletionSource<Boolean> JoinTaskCompletionSource; //Field offset: 0x78
	private TimeSpan NextLatencyCheckAtElapsedTime; //Field offset: 0x80
	private Task<TimeSpan> LatencyMeasurmentInProgress; //Field offset: 0x88
	private uint LatencyMeasurementCounter; //Field offset: 0x90
	private readonly Dictionary<Int64, Ping> PingsInFlight; //Field offset: 0x98

	public event Action<Exception> DisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<LatencyMeasurement> LatencyUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Int32> PeerConnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Int32> PeerDisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	private static TimeSpan ElapsedTime
	{
		private get { } //Length: 91
	}

	public private bool IsConnected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private static NKMultiGameInterface() { }

	public NKMultiGameInterface(string relayHostName, int relayPort, Version relayBinaryVersion, string matchID, int peerID, string playerGlobalID) { }

	[CompilerGenerated]
	public void add_DisconnectedEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void add_LatencyUpdateEvent(Action<LatencyMeasurement> value) { }

	[CompilerGenerated]
	public void add_PeerConnectedEvent(Action<Int32> value) { }

	[CompilerGenerated]
	public void add_PeerDisconnectedEvent(Action<Int32> value) { }

	[AsyncStateMachine(typeof(<Connect>d__35))]
	public Task Connect(CancellationToken canceller = null) { }

	public void Disconnect() { }

	private static TimeSpan get_ElapsedTime() { }

	[CompilerGenerated]
	public bool get_IsConnected() { }

	[AsyncStateMachine(typeof(<GetFreshLatency>d__43))]
	[Obsolete]
	public Task<TimeSpan> GetFreshLatency() { }

	[AsyncStateMachine(typeof(<IsConnectionOk>d__44))]
	[Obsolete]
	public Task<Boolean> IsConnectionOk(int thresholdMs) { }

	[AsyncStateMachine(typeof(<Join>d__36))]
	private Task Join(CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<MeasureLatency>d__42))]
	private void MeasureLatency(uint measurementCount, bool isDelayed) { }

	private Task<TimeSpan> PingRelay() { }

	private void ReceiveJoinResponse(JoinSessionResponseMessage response) { }

	private void ReceivePingReply(LatencyTestMessage pingReply) { }

	[CompilerGenerated]
	public void remove_DisconnectedEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void remove_LatencyUpdateEvent(Action<LatencyMeasurement> value) { }

	[CompilerGenerated]
	public void remove_PeerConnectedEvent(Action<Int32> value) { }

	[CompilerGenerated]
	public void remove_PeerDisconnectedEvent(Action<Int32> value) { }

	public void Send(Writable content) { }

	[AsyncStateMachine(typeof(<SendPing>d__48))]
	private void SendPing(Ping ping) { }

	public void SendToPeer(int peerID, Message msg) { }

	[CompilerGenerated]
	private void set_IsConnected(bool value) { }

	public void Update() { }

}

