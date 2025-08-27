namespace NinjaKiwi.NKMulti;

public static class NKMultiConnector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPAddress, AddressFamily> <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AddressFamily <Connect>b__0_0(IPAddress ip) { }

	}

	[CompilerGenerated]
	private struct <Connect>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<NKMultiConnection> <>t__builder; //Field offset: 0x8
		public string host; //Field offset: 0x20
		public CancellationToken canceller; //Field offset: 0x28
		public int port; //Field offset: 0x30
		public int playerNumber; //Field offset: 0x34
		private TaskAwaiter<IPAddress[]> <>u__1; //Field offset: 0x38
		private IEnumerator<IPAddress> <>7__wrap1; //Field offset: 0x40
		private TaskAwaiter<Socket> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ConnectTo>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Socket> <>t__builder; //Field offset: 0x8
		public IPAddress ip; //Field offset: 0x20
		public int port; //Field offset: 0x28
		private Socket <socket>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[AsyncStateMachine(typeof(<Connect>d__0))]
	public static Task<NKMultiConnection> Connect(string host, int port, int playerNumber, CancellationToken canceller) { }

	[AsyncStateMachine(typeof(<ConnectTo>d__1))]
	private static Task<Socket> ConnectTo(IPAddress ip, int port) { }

}

