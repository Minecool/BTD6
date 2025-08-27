namespace Assets.Scripts.Utils;

[Extension]
public static class NetworkUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<IPAddress, Boolean> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <IsDnsBlocked>b__7_0(IPAddress a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		private struct <<GetBlockedHostnames>g__checkDnsForHost|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public string hostname; //Field offset: 0x20
			public <>c__DisplayClass5_0 <>4__this; //Field offset: 0x28
			private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public TimeSpan timeout; //Field offset: 0x10
		public List<String> blockedHostnames; //Field offset: 0x18

		public <>c__DisplayClass5_0() { }

		internal Task <GetBlockedHostnames>b__0(string hostname) { }

		[AsyncStateMachine(typeof(<<GetBlockedHostnames>g__checkDnsForHost|1>d))]
		internal Task <GetBlockedHostnames>g__checkDnsForHost|1(string hostname) { }

	}

	[CompilerGenerated]
	private struct <GetBlockedHostnames>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<String>> <>t__builder; //Field offset: 0x8
		public TimeSpan timeout; //Field offset: 0x20
		public String[] hostnames; //Field offset: 0x28
		private <>c__DisplayClass5_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <IsDnsBlocked>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string hostname; //Field offset: 0x20
		public TimeSpan timeout; //Field offset: 0x28
		private Task<IPHostEntry> <hostEntryTask>5__2; //Field offset: 0x30
		private TimeSpan <startTime>5__3; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly TimeSpan kDefaultTimeout; //Field offset: 0x0
	private const string kInternetNotReachableError = "INTERNET_NOT_REACHABLE"; //Field offset: 0x0

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	private static NetworkUtils() { }

	private static TimeSpan get_Now() { }

	[AsyncStateMachine(typeof(<GetBlockedHostnames>d__5))]
	public static Task<List`1<String>> GetBlockedHostnames(String[] hostnames, TimeSpan timeout) { }

	public static Task<List`1<String>> GetBlockedNkHostnames(TimeSpan timeout) { }

	public static Task<Boolean> IsDnsBlocked(string hostname) { }

	[AsyncStateMachine(typeof(<IsDnsBlocked>d__7))]
	public static Task<Boolean> IsDnsBlocked(string hostname, TimeSpan timeout) { }

	[Extension]
	private static bool IsPrivate(IPAddress ip) { }

	[Extension]
	private static bool IsReserved(IPAddress ip) { }

}

