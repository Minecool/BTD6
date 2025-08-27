namespace Assets.Scripts.Unity.Player;

public static class ProfileValidation
{
	[CompilerGenerated]
	private struct <CheckCorrectVersion>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Version version; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public static void CheckCorrectSkuId(Nullable<Int32> skuId) { }

	[AsyncStateMachine(typeof(<CheckCorrectVersion>d__0))]
	public static Task CheckCorrectVersion(Version version) { }

}

