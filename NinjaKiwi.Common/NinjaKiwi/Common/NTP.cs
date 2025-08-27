namespace NinjaKiwi.Common;

[Extension]
public static class NTP
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Socket client; //Field offset: 0x10
		public Byte[] buffer; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal int <SendAsync>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Socket client; //Field offset: 0x10
		public Byte[] buffer; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal int <ReceiveAsync>b__0() { }

	}

	[CompilerGenerated]
	private struct <ConnectWithTimeoutAsync>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Socket socket; //Field offset: 0x20
		public IPEndPoint endPoint; //Field offset: 0x28
		public TimeSpan timeout; //Field offset: 0x30
		private TaskAwaiter<Task> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReceiveAsync>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Int32> <>t__builder; //Field offset: 0x8
		public Socket client; //Field offset: 0x20
		public Byte[] buffer; //Field offset: 0x28
		private <>c__DisplayClass4_0 <>8__1; //Field offset: 0x30
		public int waitForFirstDelaySeconds; //Field offset: 0x38
		private int <i>5__2; //Field offset: 0x3C
		private ConfiguredTaskAwaiter <>u__1; //Field offset: 0x40
		private ConfiguredTaskAwaiter<Int32> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshNetworkTimeAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DateTime> <>t__builder; //Field offset: 0x8
		public string ntpServer; //Field offset: 0x20
		public Nullable<TimeSpan> timeout; //Field offset: 0x28
		private Socket <client>5__2; //Field offset: 0x38
		private Byte[] <ntpData>5__3; //Field offset: 0x40
		private ConfiguredTaskAwaiter<IPHostEntry> <>u__1; //Field offset: 0x48
		private ConfiguredTaskAwaiter <>u__2; //Field offset: 0x58
		private ConfiguredTaskAwaiter<Int32> <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly DateTime NTPEpoch; //Field offset: 0x0

	private static NTP() { }

	[AsyncStateMachine(typeof(<ConnectWithTimeoutAsync>d__2))]
	[Extension]
	public static Task ConnectWithTimeoutAsync(Socket socket, IPEndPoint endPoint, TimeSpan timeout) { }

	[AsyncStateMachine(typeof(<ReceiveAsync>d__4))]
	[Extension]
	private static Task<Int32> ReceiveAsync(Socket client, Byte[] buffer, int waitForFirstDelaySeconds = 3) { }

	[AsyncStateMachine(typeof(<RefreshNetworkTimeAsync>d__1))]
	public static Task<DateTime> RefreshNetworkTimeAsync(string ntpServer = "time.apple.com", Nullable<TimeSpan> timeout = null) { }

	[Extension]
	private static Task<Int32> SendAsync(Socket client, Byte[] buffer) { }

	private static ulong SwapEndianness(ulong x) { }

}

