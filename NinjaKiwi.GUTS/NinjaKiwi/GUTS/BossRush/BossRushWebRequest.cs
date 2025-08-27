namespace NinjaKiwi.GUTS.BossRush;

internal static class BossRushWebRequest
{
	[CompilerGenerated]
	private struct <GetFromGuts>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<T> <>t__builder; //Field offset: 0x0
		public T2 payload; //Field offset: 0x0
		public string endpoint; //Field offset: 0x0
		public string playerId; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter<T> <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[CompilerGenerated]
	internal static void <GetFromGuts>g__prepareWebRequest|0_0(UnityWebRequest webRequest) { }

	[AsyncStateMachine(typeof(<GetFromGuts>d__0`2))]
	internal static Task<T> GetFromGuts(string endpoint, T2 payload, string playerId) { }

}

