namespace NinjaKiwi.GUTS;

[Extension]
public static class SweepstakesWebRequests
{
	[CompilerGenerated]
	private struct <SWEEPSTAKES_CanParticipate>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesParticipationResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<SweepstakesParticipationResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_Claim>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesTicketClaimResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public int taskIndex; //Field offset: 0x0
		public int taskStepIndex; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesTicketClaimResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_ClaimMulti>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesTicketClaimResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public Dictionary<Int32, List`1<Int32>> tasksStepsIndexes; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesTicketClaimResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_DEBUG_Reset>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesStatusResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		private TaskAwaiter<EmptyResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_DEBUG_Unlock>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesStatusResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesStatusResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_GetStatus>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesStatusResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public bool canForceRefresh; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesStatusResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_GetWinners>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesWinnersResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesWinnersResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_SeeShareCode>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesTicketClaimResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string shareCode; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesTicketClaimResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SWEEPSTAKES_ShareCode>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SweepstakesShareCodeResponse> <>t__builder; //Field offset: 0x0
		public Player<T> player; //Field offset: 0x0
		public string eventId; //Field offset: 0x0
		private TaskAwaiter<SweepstakesShareCodeResponse> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"response", "userId", "eventId", "cacheTime"}])]
	private static ValueTuple<SweepstakesStatusResponse, String, String, DateTime> statusCache; //Field offset: 0x0

	private static TimeSpan CacheTime
	{
		private get { } //Length: 125
	}

	private static bool CanUseCache
	{
		private get { } //Length: 207
	}

	[CompilerGenerated]
	internal static bool <SWEEPSTAKES_GetStatus>g__isCacheCurrent|5_0() { }

	private static TimeSpan get_CacheTime() { }

	private static bool get_CanUseCache() { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_CanParticipate>d__10`1))]
	[Extension]
	public static Task<SweepstakesParticipationResponse> SWEEPSTAKES_CanParticipate(Player<T> player) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_Claim>d__6`1))]
	[Extension]
	public static Task<SweepstakesTicketClaimResponse> SWEEPSTAKES_Claim(Player<T> player, string eventId, int taskIndex, int taskStepIndex) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_ClaimMulti>d__7`1))]
	[Extension]
	public static Task<SweepstakesTicketClaimResponse> SWEEPSTAKES_ClaimMulti(Player<T> player, string eventId, Dictionary<Int32, List`1<Int32>> tasksStepsIndexes) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_DEBUG_Reset>d__12`1))]
	[Extension]
	public static Task<SweepstakesStatusResponse> SWEEPSTAKES_DEBUG_Reset(Player<T> player) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_DEBUG_Unlock>d__13`1))]
	[Extension]
	public static Task<SweepstakesStatusResponse> SWEEPSTAKES_DEBUG_Unlock(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_GetStatus>d__5`1))]
	[Extension]
	public static Task<SweepstakesStatusResponse> SWEEPSTAKES_GetStatus(Player<T> player, string eventId, bool canForceRefresh = false) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_GetWinners>d__11`1))]
	[Extension]
	public static Task<SweepstakesWinnersResponse> SWEEPSTAKES_GetWinners(Player<T> player, string eventId) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_SeeShareCode>d__9`1))]
	[Extension]
	public static Task<SweepstakesTicketClaimResponse> SWEEPSTAKES_SeeShareCode(Player<T> player, string eventId, string shareCode) { }

	[AsyncStateMachine(typeof(<SWEEPSTAKES_ShareCode>d__8`1))]
	[Extension]
	public static Task<SweepstakesShareCodeResponse> SWEEPSTAKES_ShareCode(Player<T> player, string eventId) { }

}

