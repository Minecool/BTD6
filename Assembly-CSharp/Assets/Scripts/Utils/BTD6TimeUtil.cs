namespace Assets.Scripts.Utils;

public static class BTD6TimeUtil
{
	[CompilerGenerated]
	private struct <_GetServerTime>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DateTime> <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x28
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetServerTime>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DateTime> <>t__builder; //Field offset: 0x8
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x20
		public bool forceRefresh; //Field offset: 0x30
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static DateTime lastUpdateTime; //Field offset: 0x0
	private static readonly TimeSpan kArcadeMinTimeout; //Field offset: 0x8
	private static readonly TimeSpan kArcadeRefreshMinInterval; //Field offset: 0x10
	private static readonly TimeSpan kRefreshMinInterval; //Field offset: 0x18
	private static Task<DateTime> serverTimeRefreshTask; //Field offset: 0x20

	private static TimeSpan DCResetOffsetTimeSpan
	{
		private get { } //Length: 203
	}

	private static DateTime LastOnlineTimeDailyResetDate
	{
		private get { } //Length: 154
	}

	[AsyncStateMachine(typeof(<_GetServerTime>d__6))]
	private static Task<DateTime> _GetServerTime(Nullable<TimeSpan> timeoutOverride, bool forceRefresh) { }

	private static BTD6TimeUtil() { }

	private static TimeSpan get_DCResetOffsetTimeSpan() { }

	private static DateTime get_LastOnlineTimeDailyResetDate() { }

	public static DateTime GetDailyTimeNow() { }

	public static TimeSpan GetDailyTimeRemaining(DateTime endTimeUTC) { }

	public static DateTime GetNextDailyResetTime() { }

	[AsyncStateMachine(typeof(<GetServerTime>d__5))]
	public static Task<DateTime> GetServerTime(Nullable<TimeSpan> timeoutOverride = null, bool forceRefresh = false) { }

	public static bool IsAdvancedDailyChallengeAvailable() { }

	public static bool IsDailyChallengeAvailable() { }

	public static bool IsDailyChestAvailable() { }

}

