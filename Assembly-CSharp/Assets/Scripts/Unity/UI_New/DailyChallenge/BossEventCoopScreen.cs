namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossEventCoopScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public BossEventCoopScreen <>4__this; //Field offset: 0x10
		public string gameCode; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal Task <JoinGameClicked>b__0() { }

	}

	[CompilerGenerated]
	private struct <CreateJoinLobbyAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEventCoopScreen <>4__this; //Field offset: 0x20
		public bool join; //Field offset: 0x28
		public bool quickMatch; //Field offset: 0x29
		public string gameCode; //Field offset: 0x30
		private Btd6MatchMakingParameters <matchmakingParameters>5__2; //Field offset: 0x38
		private Api <liNK>5__3; //Field offset: 0x40
		private PlayerInfo <playerInfo>5__4; //Field offset: 0x48
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x50
		private TaskAwaiter<LobbyConnection> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public BossEventCoopScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReenableBackButtonAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TimeSpan timeSpan; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public BossEventCoopScreen <>4__this; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly TimeSpan lobbyTimeout; //Field offset: 0x0
	public CanvasGroup canvasGroup; //Field offset: 0x48
	public Lightbox backgroundCloseBtn; //Field offset: 0x50
	public Button quickGameBtn; //Field offset: 0x58
	public Button createGameBtn; //Field offset: 0x60
	public TMP_InputField inputField; //Field offset: 0x68
	public Button joinBtn; //Field offset: 0x70
	private BossEvent bossEvent; //Field offset: 0x78
	private BossChallengeMenuData bossChallengeData; //Field offset: 0x80
	private bool invokedclose; //Field offset: 0x88
	private CancellationTokenSource canceller; //Field offset: 0x90

	private static BossEventCoopScreen() { }

	public BossEventCoopScreen() { }

	[CompilerGenerated]
	private void <Awake>b__8_0(string _) { }

	[CompilerGenerated]
	private Task <CreateGameClicked>b__12_0() { }

	[CompilerGenerated]
	private Task <QuickGameClicked>b__11_0() { }

	protected virtual void Awake() { }

	private void BackgroundCloseClicked() { }

	private void ButtonsInteractive(bool isInteractable) { }

	public virtual void Close() { }

	private void CreateGameClicked() { }

	[AsyncStateMachine(typeof(<CreateJoinLobbyAsync>d__17))]
	private Task CreateJoinLobbyAsync(bool quickMatch, bool join, string gameCode = null) { }

	private void JoinGameClicked() { }

	[AsyncStateMachine(typeof(<Open>d__9))]
	public virtual void Open(object data) { }

	private void QuickGameClicked() { }

	[AsyncStateMachine(typeof(<ReenableBackButtonAsync>d__19))]
	public void ReenableBackButtonAsync(TimeSpan timeSpan, CancellationToken cancellationToken) { }

	private void Update() { }

}

