namespace Assets.Scripts.Unity.PlatformLogins;

public static class GooglePlayAchievements
{
	[CompilerGenerated]
	private struct <PostAchivementCompleteAsync>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public static bool Available
	{
		 get { } //Length: 3
	}

	public static bool get_Available() { }

	[AsyncStateMachine(typeof(<PostAchivementCompleteAsync>d__3))]
	public static Task PostAchivementCompleteAsync(int achievementID, Action<Int32> onComplete) { }

	public static void ShowAchievementsUI() { }

}

