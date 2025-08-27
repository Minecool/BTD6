namespace NinjaKiwi.LiNK.Lobbies;

public class NKMultiConnection
{
	[CompilerGenerated]
	private struct <Connect>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<NKMultiConnection> <>t__builder; //Field offset: 0x8
		public ConnectionDetails connectionDetails; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		private NKMultiConnection <connection>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class LatencyUpdate : MulticastDelegate
	{

		public LatencyUpdate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TimeSpan latency, uint counter, bool isDelayed, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(TimeSpan latency, uint counter, bool isDelayed) { }

	}

	public readonly ConnectionDetails Details; //Field offset: 0x10
	public readonly Queue<ReceivedMessage> ReceiveQueue; //Field offset: 0x18
	public int LatencyFailCountThreshold; //Field offset: 0x20
	private readonly NKMultiGameInterface NKGI; //Field offset: 0x28
	private int LatencyFailCounter; //Field offset: 0x30
	[CompilerGenerated]
	private Action<Exception> DisconnectedEvent; //Field offset: 0x38
	[CompilerGenerated]
	private Action<Byte> PlayerConnectedEvent; //Field offset: 0x40
	[CompilerGenerated]
	private Action<Byte> PlayerDisconnectedEvent; //Field offset: 0x48
	[CompilerGenerated]
	private LatencyUpdate LatencyUpdateEvent; //Field offset: 0x50

	public event Action<Exception> DisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event LatencyUpdate LatencyUpdateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<Byte> PlayerConnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Byte> PlayerDisconnectedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	private NKMultiConnection(ConnectionDetails connectionDetails) { }

	[CompilerGenerated]
	private void <.ctor>b__18_0(Exception ex) { }

	[CompilerGenerated]
	private void <.ctor>b__18_1(int pNum) { }

	[CompilerGenerated]
	private void <.ctor>b__18_2(int pNum) { }

	[CompilerGenerated]
	internal static void <.ctor>g__CheckForByteOverflow|18_3(Action<Byte> action, int input) { }

	[CompilerGenerated]
	public void add_DisconnectedEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void add_LatencyUpdateEvent(LatencyUpdate value) { }

	[CompilerGenerated]
	public void add_PlayerConnectedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void add_PlayerDisconnectedEvent(Action<Byte> value) { }

	public void ClearEvents() { }

	[AsyncStateMachine(typeof(<Connect>d__19))]
	public static Task<NKMultiConnection> Connect(ConnectionDetails connectionDetails, CancellationToken canceller) { }

	public void Disconnect() { }

	private void OnLatencyUpdate(LatencyMeasurement measurement) { }

	[CompilerGenerated]
	public void remove_DisconnectedEvent(Action<Exception> value) { }

	[CompilerGenerated]
	public void remove_LatencyUpdateEvent(LatencyUpdate value) { }

	[CompilerGenerated]
	public void remove_PlayerConnectedEvent(Action<Byte> value) { }

	[CompilerGenerated]
	public void remove_PlayerDisconnectedEvent(Action<Byte> value) { }

	public void Send(Writable content) { }

	public void Update() { }

}

