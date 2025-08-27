namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopJoinMatchScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LocalNetworkLobby, Boolean> <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ShowLocalLobbies>b__25_0(LocalNetworkLobby lobby) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public CoopJoinMatchScreen <>4__this; //Field offset: 0x10
		public string gameCode; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal Task <JoinLobby>b__0() { }

	}

	[CompilerGenerated]
	private struct <JoinLobbyAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopJoinMatchScreen <>4__this; //Field offset: 0x20
		public string gameCode; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private CancellationTokenSource <canceller>5__2; //Field offset: 0x38
		private TaskAwaiter<LobbyConnection> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickRefreshLocalLobbies>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopJoinMatchScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowLocalLobbies>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopJoinMatchScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<LocalNetworkLobby[]> <>u__1; //Field offset: 0x28
		private IEnumerator<LocalNetworkLobby> <>7__wrap1; //Field offset: 0x30
		private GameObject <localLobbyPanelPrefab>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryShowLocalLobbiesAsync>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopJoinMatchScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_InputField inputField; //Field offset: 0x48
	public NK_TextMeshProUGUI txtGameCode; //Field offset: 0x50
	public Animator lookingForGame; //Field offset: 0x58
	public Button btnOk; //Field offset: 0x60
	public Button btnCancel; //Field offset: 0x68
	public Button btnLocalLobbyRefresh; //Field offset: 0x70
	public GameObject localNetworkPanel; //Field offset: 0x78
	public GameObject localNetworkContentPanel; //Field offset: 0x80
	public GameObject prefabLocalNetworkDetails; //Field offset: 0x88
	[CompilerGenerated]
	private Action CancelEvent; //Field offset: 0x90
	private bool ignoreNextEnter; //Field offset: 0x98
	private float timeToNextRefresh; //Field offset: 0x9C
	private readonly TimeSpan REFRESH_TIMER; //Field offset: 0xA0
	private readonly List<GameObject> localLobbies; //Field offset: 0xA8

	private event Action CancelEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public CoopJoinMatchScreen() { }

	[CompilerGenerated]
	private void <Open>b__16_0(string _) { }

	[CompilerGenerated]
	private void add_CancelEvent(Action value) { }

	public void ClickedGoLocalBtn(string coopId) { }

	public virtual void Close() { }

	private void JoinLobby(string gameCode) { }

	[AsyncStateMachine(typeof(<JoinLobbyAsync>d__20))]
	private Task JoinLobbyAsync(string gameCode) { }

	public void OnCancel() { }

	[AsyncStateMachine(typeof(<OnClickRefreshLocalLobbies>d__23))]
	public void OnClickRefreshLocalLobbies() { }

	public void OnGo() { }

	public virtual void Open(object data) { }

	[CompilerGenerated]
	private void remove_CancelEvent(Action value) { }

	[AsyncStateMachine(typeof(<ShowLocalLobbies>d__25))]
	private Task ShowLocalLobbies() { }

	private void ShowSearchingUi(bool searching) { }

	[AsyncStateMachine(typeof(<TryShowLocalLobbiesAsync>d__24))]
	private void TryShowLocalLobbiesAsync() { }

	private void Update() { }

}

