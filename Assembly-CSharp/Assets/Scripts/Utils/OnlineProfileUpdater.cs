namespace Assets.Scripts.Utils;

public class OnlineProfileUpdater : MonoBehaviour
{
	[CompilerGenerated]
	private struct <RunRefreshAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public OnlineProfileUpdater <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncOnlineProfile>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OnlineProfileUpdater <>4__this; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static OnlineProfileUpdater <Instance>k__BackingField; //Field offset: 0x0
	private bool isRefreshing; //Field offset: 0x20
	private bool isSyncing; //Field offset: 0x21
	private bool requiresRefresh; //Field offset: 0x22
	private DateTime lastCheckTime; //Field offset: 0x28
	private Task syncTask; //Field offset: 0x30
	private CancellationTokenSource syncTaskCanceller; //Field offset: 0x38

	public private static OnlineProfileUpdater Instance
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	public bool IsProcessing
	{
		 get { } //Length: 13
	}

	private DateTime Now
	{
		private get { } //Length: 7
	}

	private TimeSpan RefreshTimeout
	{
		private get { } //Length: 159
	}

	public OnlineProfileUpdater() { }

	private void Awake() { }

	[CompilerGenerated]
	public static OnlineProfileUpdater get_Instance() { }

	public bool get_IsProcessing() { }

	private DateTime get_Now() { }

	private TimeSpan get_RefreshTimeout() { }

	private void LateUpdate() { }

	private void OnApplicationQuit() { }

	[AsyncStateMachine(typeof(<RunRefreshAsync>d__19))]
	private void RunRefreshAsync() { }

	[CompilerGenerated]
	private static void set_Instance(OnlineProfileUpdater value) { }

	[AsyncStateMachine(typeof(<SyncOnlineProfile>d__20))]
	private Task SyncOnlineProfile(CancellationToken cancellationToken) { }

}

