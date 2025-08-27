namespace Assets.Scripts.Utils;

public class CoopInvitationListener : MonoBehaviourSingleton<CoopInvitationListener>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public LobbyInviteModel lobbyInvite; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <GetAndEnqueueInvites>b__0(CoopInvite inviteData) { }

	}

	[CompilerGenerated]
	private struct <GetAndEnqueueInvites>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Btd6Player player; //Field offset: 0x20
		private <>c__DisplayClass15_0 <>8__1; //Field offset: 0x28
		public CoopInvitationListener <>4__this; //Field offset: 0x30
		private TaskAwaiter<List`1<LobbyInviteModel>> <>u__1; //Field offset: 0x38
		private Enumerator<LobbyInviteModel> <>7__wrap1; //Field offset: 0x40
		private TaskAwaiter<LobbyModel> <>u__2; //Field offset: 0x58
		private TaskAwaiter<String> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopInvitationListener <>4__this; //Field offset: 0x28
		private DateTime <lastCheckTime>5__2; //Field offset: 0x30
		private Btd6Player <player>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private CoopInvite <coopInvite>5__4; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowPopupAndWaitForResponse>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public string playerName; //Field offset: 0x20
		private AsyncOperationHandle<GameObject> <popupOpHandle>5__2; //Field offset: 0x28
		private GameObject <coopInvitePanelGo>5__3; //Field offset: 0x40
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly TimeSpan minCheckInterval; //Field offset: 0x0
	private static bool isInitialized; //Field offset: 0x8
	private readonly Queue<CoopInvite> coopInviteQueue; //Field offset: 0x20
	private CancellableWait cancellableWait; //Field offset: 0x28
	private TimeSpan checkInterval; //Field offset: 0x30

	private static CoopInviteSettings CoopInviteSettings
	{
		private get { } //Length: 206
	}

	private static DateTime Now
	{
		private get { } //Length: 64
	}

	private static CoopInvitationListener() { }

	public CoopInvitationListener() { }

	public void DismissAllCoopInvites() { }

	private static CoopInviteSettings get_CoopInviteSettings() { }

	private static DateTime get_Now() { }

	[AsyncStateMachine(typeof(<GetAndEnqueueInvites>d__15))]
	private Task GetAndEnqueueInvites(Btd6Player player) { }

	private TimeSpan GetWaitTime(DateTime lastCheckTime) { }

	public static void Init() { }

	protected virtual void OnApplicationQuit() { }

	[AsyncStateMachine(typeof(<RunAsync>d__10))]
	private void RunAsync() { }

	[AsyncStateMachine(typeof(<ShowPopupAndWaitForResponse>d__16))]
	private Task<Boolean> ShowPopupAndWaitForResponse(string playerName) { }

	public void UseFrequentCheckInterval() { }

	public void UseNormalCheckInterval() { }

}

