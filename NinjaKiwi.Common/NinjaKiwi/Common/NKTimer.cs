namespace NinjaKiwi.Common;

public static class NKTimer
{
	[CompilerGenerated]
	private struct <RefreshServerDateTime>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DateTime> <>t__builder; //Field offset: 0x8
		public Task<DateTime> serverTimeTask; //Field offset: 0x20
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static class SavedTimes
	{
		private const string ONLINE_TIME = "NKTimer.online_time"; //Field offset: 0x0
		private const string OFFLINE_TIME = "NKTimer.offline_time"; //Field offset: 0x0
		private const string DELTA_TIME = "NKTimer.dt"; //Field offset: 0x0
		private static Nullable<TimeSpan> _deltaTime; //Field offset: 0x0

		internal static TimeSpan DeltaTime
		{
			internal get { } //Length: 203
			internal set { } //Length: 105
		}

		internal static DateTime OfflineTime
		{
			internal get { } //Length: 91
			internal set { } //Length: 122
		}

		internal static DateTime OnlineTime
		{
			internal get { } //Length: 91
			internal set { } //Length: 122
		}

		internal static TimeSpan get_DeltaTime() { }

		internal static DateTime get_OfflineTime() { }

		internal static DateTime get_OnlineTime() { }

		internal static bool HasSaveData() { }

		internal static void set_DeltaTime(TimeSpan value) { }

		internal static void set_OfflineTime(DateTime value) { }

		internal static void set_OnlineTime(DateTime value) { }

		internal static void StoreDeltaTime() { }

	}

	public static readonly DateTime UnixEpoch; //Field offset: 0x0
	private static DateTime m_OnlineTimestamp; //Field offset: 0x8
	private static DateTime m_OfflineTimestamp; //Field offset: 0x10
	private static readonly TimeSpan kZeroTimespan; //Field offset: 0x18
	[CompilerGenerated]
	private static bool <IsUsingServerTime>k__BackingField; //Field offset: 0x20
	private static float saveTicker; //Field offset: 0x24

	internal static DateTime EstimatedLocalUTC
	{
		internal get { } //Length: 79
	}

	internal static DateTime EstimatedServerUTC
	{
		internal get { } //Length: 79
	}

	internal static bool IsUsingServerTime
	{
		[CompilerGenerated]
		internal get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	private static DateTime LocalUtcNow
	{
		private get { } //Length: 64
	}

	private static NKTimer() { }

	internal static DateTime get_EstimatedLocalUTC() { }

	internal static DateTime get_EstimatedServerUTC() { }

	[CompilerGenerated]
	internal static bool get_IsUsingServerTime() { }

	private static DateTime get_LocalUtcNow() { }

	internal static bool InternetConnectionRequired(TimeSpan timeLimit) { }

	public static void InvalidateServerTime() { }

	private static void OnTimeUpdated() { }

	[AsyncStateMachine(typeof(<RefreshServerDateTime>d__17))]
	public static Task<DateTime> RefreshServerDateTime(Task<DateTime> serverTimeTask = null) { }

	private static void ServerTimeFailure(DateTime localUtcNow) { }

	private static void ServerTimeSuccess(DateTime remoteUtcNow) { }

	[CompilerGenerated]
	private static void set_IsUsingServerTime(bool value) { }

	public static void Tick(float deltaSeconds) { }

}

