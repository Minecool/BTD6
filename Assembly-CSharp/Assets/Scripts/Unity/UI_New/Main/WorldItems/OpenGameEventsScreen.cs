namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class OpenGameEventsScreen : InteractableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnInteractAsync>b__20_0() { }

	}

	[CompilerGenerated]
	private struct <OnInteractAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OpenGameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Refresh>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OpenGameEventsScreen <>4__this; //Field offset: 0x20
		private ProfileModel <playerData>5__2; //Field offset: 0x28
		private State <prevState>5__3; //Field offset: 0x30
		private DailyChallengeModel <dcm>5__4; //Field offset: 0x38
		private DailyChallengeModel <adcm>5__5; //Field offset: 0x40
		private DailyChallengeModel <coopdcm>5__6; //Field offset: 0x48
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58
		private TaskAwaiter<OnlineProfileModel> <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OpenGameEventsScreen <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum State
	{
		notSet = 0,
		off = 1,
		coop = 2,
		rank = 3,
		on = 4,
	}

	private static readonly TimeSpan refreshInterval; //Field offset: 0x0
	public GameObject questMonkeyPulse; //Field offset: 0x20
	public Animator exclamationPointAnimator; //Field offset: 0x28
	public Animator eventMonkeyAnimator; //Field offset: 0x30
	public GameObject dialogObject; //Field offset: 0x38
	public TMP_Text dialogText; //Field offset: 0x40
	public GameObject coopEventMonkey; //Field offset: 0x48
	private State currState; //Field offset: 0x50
	private bool isInitialized; //Field offset: 0x54
	private CancellableWait cancellableWait; //Field offset: 0x58

	private static OpenGameEventsScreen() { }

	public OpenGameEventsScreen() { }

	private void Awake() { }

	private bool CheckRankLocked() { }

	private void OnEnable() { }

	public virtual void OnInteract() { }

	[AsyncStateMachine(typeof(<OnInteractAsync>d__20))]
	public Task OnInteractAsync() { }

	[AsyncStateMachine(typeof(<Refresh>d__15))]
	private Task Refresh() { }

	[AsyncStateMachine(typeof(<RefreshAsync>d__13))]
	private Task RefreshAsync() { }

	public void RefreshNow() { }

	private void ShowDialog(string msg) { }

	private void UpdateAnimator() { }

}

