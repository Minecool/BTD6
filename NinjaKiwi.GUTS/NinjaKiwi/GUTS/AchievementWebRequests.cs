namespace NinjaKiwi.GUTS;

[Extension]
public static class AchievementWebRequests
{
	[CompilerGenerated]
	private sealed class <>c__1
	{
		public static readonly <>c__1<T> <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Int64>, Boolean> <>9__1_0; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Int64>, String> <>9__1_1; //Field offset: 0x0

		private static <>c__1`1() { }

		public <>c__1`1() { }

		internal bool <ACHIEVEMENTS_GetClaimed>b__1_0(KeyValuePair<String, Int64> kvp) { }

		internal string <ACHIEVEMENTS_GetClaimed>b__1_1(KeyValuePair<String, Int64> kvp) { }

	}

	[CompilerGenerated]
	private struct <ACHIEVEMENTS_GetClaimed>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IEnumerable`1<String>> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<Dictionary`2<String, Int64>> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[Extension]
	public static Task<ClaimAchievementResponse> ACHIEVEMENTS_Claim(Player<T> player, string achievementId) { }

	[AsyncStateMachine(typeof(<ACHIEVEMENTS_GetClaimed>d__1`1))]
	[Extension]
	public static Task<IEnumerable`1<String>> ACHIEVEMENTS_GetClaimed(Player<T> player) { }

}

