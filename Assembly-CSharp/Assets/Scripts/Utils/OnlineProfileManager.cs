namespace Assets.Scripts.Utils;

[Extension]
public static class OnlineProfileManager
{
	[CompilerGenerated]
	private struct <DownloadOnlineProfile>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<OnlineProfileModel> <>t__builder; //Field offset: 0x8
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x30
		private OnlineProfileModel <onlineProfile>5__2; //Field offset: 0x38
		private TaskAwaiter<StorageModel> <>u__1; //Field offset: 0x40
		private object <>7__wrap2; //Field offset: 0x48
		private int <>7__wrap3; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MigrateLocalData>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		public OnlineProfileModel onlineProfile; //Field offset: 0x28
		private ProfileModel <playerData>5__2; //Field offset: 0x30
		private string <userPlaySaveId>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MigrateRacePass>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OnlineProfileModel onlineProfile; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunUpload>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public OnlineProfileModel onlineProfile; //Field offset: 0x28
		public Btd6Player player; //Field offset: 0x30
		private string <onlineProfileHash>5__2; //Field offset: 0x38
		private string <encodedOnlineProfile>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter<StorageModel> <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Upload>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OnlineProfileModel onlineProfile; //Field offset: 0x20
		public Btd6Player player; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private CancellationTokenSource <>7__wrap1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string OnlineProfileFilename = "OnlineProfile.Save"; //Field offset: 0x0
	public const uint kMaxEventDataListsSize = 6; //Field offset: 0x0
	private static Task uploadTask; //Field offset: 0x0
	private const int kBufferSize = 2048; //Field offset: 0x0
	private static CancellationTokenSource uploadTaskCanceller; //Field offset: 0x8
	private static bool isWaitingtoUpload; //Field offset: 0x10
	private static DateTime lastUpdateTime; //Field offset: 0x18
	private static string lastUploadHash; //Field offset: 0x20
	private static readonly JsonSerializerSettings SerializationSettings; //Field offset: 0x28

	private static DateTime Now
	{
		private get { } //Length: 7
	}

	private static OnlineProfileManager() { }

	private static OnlineProfileModel DecodeAndDeserialize(string data) { }

	[AsyncStateMachine(typeof(<DownloadOnlineProfile>d__9))]
	public static Task<OnlineProfileModel> DownloadOnlineProfile(Btd6Player player, Nullable<TimeSpan> timeoutOverride = null) { }

	private static string Encode(string json) { }

	private static DateTime get_Now() { }

	private static OnlineProfileModel GetNewOnlineProfile(Btd6Player player) { }

	private static string GetOnlinProfileHash(string json) { }

	[AsyncStateMachine(typeof(<MigrateLocalData>d__16))]
	private static Task MigrateLocalData(OnlineProfileModel onlineProfile, Btd6Player player) { }

	[AsyncStateMachine(typeof(<MigrateRacePass>d__10))]
	private static Task MigrateRacePass(OnlineProfileModel onlineProfile) { }

	private static OnlineProfileModel ParseOnlineProfile(string data) { }

	[AsyncStateMachine(typeof(<RunUpload>d__14))]
	private static Task RunUpload(Btd6Player player, OnlineProfileModel onlineProfile, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<Upload>d__13))]
	[Extension]
	public static Task Upload(OnlineProfileModel onlineProfile, Btd6Player player) { }

}

