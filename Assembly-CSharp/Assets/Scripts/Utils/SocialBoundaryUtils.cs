namespace Assets.Scripts.Utils;

public static class SocialBoundaryUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		private struct <<TryPassSocialBoundary>g__checkValidSkuSettings|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass0_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public SocialGameplayType gameplayType; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		[AsyncStateMachine(typeof(<<TryPassSocialBoundary>g__checkValidSkuSettings|0>d))]
		internal Task<Boolean> <TryPassSocialBoundary>g__checkValidSkuSettings|0() { }

	}

	[CompilerGenerated]
	private struct <TryLoginNow>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryPassSocialBoundary>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public SocialGameplayType gameplayType; //Field offset: 0x20
		public bool silent; //Field offset: 0x24
		private <>c__DisplayClass0_0 <>8__1; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	private static void ShowMultiplayerRestrictedPopup() { }

	private static void ShowRequiresInternetPopup() { }

	private static void ShowTryAgainPopup() { }

	[AsyncStateMachine(typeof(<TryLoginNow>d__1))]
	public static Task<Boolean> TryLoginNow(Btd6Player player) { }

	[AsyncStateMachine(typeof(<TryPassSocialBoundary>d__0))]
	public static Task<Boolean> TryPassSocialBoundary(SocialGameplayType gameplayType, bool silent = false) { }

}

