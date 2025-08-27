namespace NinjaKiwi.Common.Attribution;

public static class NKAttribution
{
	[CompilerGenerated]
	private struct <AdId>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public int appId; //Field offset: 0x20
		private object <>7__wrap1; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AttributionId>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<String> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <NKUniqueDeviceId>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public static bool IsSupported
	{
		 get { } //Length: 3
	}

	[AsyncStateMachine(typeof(<AdId>d__0))]
	public static Task<String> AdId(int appId) { }

	[AsyncStateMachine(typeof(<AttributionId>d__1))]
	public static Task<String> AttributionId() { }

	public static bool get_IsSupported() { }

	private static string NewUUID() { }

	[AsyncStateMachine(typeof(<NKUniqueDeviceId>d__5))]
	private static Task<String> NKUniqueDeviceId() { }

}

