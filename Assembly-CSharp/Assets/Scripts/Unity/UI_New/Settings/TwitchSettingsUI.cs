namespace Assets.Scripts.Unity.UI_New.Settings;

public class TwitchSettingsUI : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SubPoll, Boolean> <>9__13_1; //Field offset: 0x8
		public static Func<SubPoll, IEnumerable`1<PollItem>> <>9__25_0; //Field offset: 0x10
		public static Func<PollItem, String> <>9__25_1; //Field offset: 0x18
		public static Func<SubPoll, IEnumerable`1<Choice>> <>9__27_0; //Field offset: 0x20
		public static Func<Choice, Int64> <>9__27_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<Choice> <OnPollsFinished>b__27_0(SubPoll x) { }

		internal long <OnPollsFinished>b__27_1(Choice y) { }

		internal IEnumerable<PollItem> <OnSubPollStarted>b__25_0(SubPoll x) { }

		internal string <OnSubPollStarted>b__25_1(PollItem y) { }

		internal bool <Start>b__13_1(SubPoll x) { }

	}

	[CompilerGenerated]
	private struct <OnCancelPollClicked>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TwitchSettingsUI <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnLogInClicked>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TwitchSettingsUI <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnLogOutClicked>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TwitchSettingsUI <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessTwitchRequest>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task task; //Field offset: 0x20
		public TwitchSettingsUI <>4__this; //Field offset: 0x28
		public bool showErrorPopup; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button logInBtn; //Field offset: 0x48
	public Button logOutBtn; //Field offset: 0x50
	public NK_TextMeshProUGUI usernameTxt; //Field offset: 0x58
	public Image loggingInSpinner; //Field offset: 0x60
	public GameObject signedInInfo; //Field offset: 0x68
	public TwitchPollPanel twitchPollPanel; //Field offset: 0x70
	public TwitchPollCreationPanel twitchPollCreationPanel; //Field offset: 0x78
	public Button backgroundCloseBtn; //Field offset: 0x80
	private readonly Scope[] requiredScopes; //Field offset: 0x88
	private SubPoll activeSubPoll; //Field offset: 0x90
	private bool isSubscribedToPollEvents; //Field offset: 0x98

	private bool IsCreateBtnEnabled
	{
		private set { } //Length: 186
	}

	private TwitchAnalytics TwitchAnalytics
	{
		private get { } //Length: 68
	}

	private Client TwitchClient
	{
		private get { } //Length: 54
	}

	public TwitchSettingsUI() { }

	[CompilerGenerated]
	private void <Start>b__13_0() { }

	private TwitchAnalytics get_TwitchAnalytics() { }

	private Client get_TwitchClient() { }

	[AsyncStateMachine(typeof(<OnCancelPollClicked>d__21))]
	private void OnCancelPollClicked() { }

	private void OnCreatePollClicked() { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnLogInClicked>d__17))]
	private void OnLogInClicked() { }

	[AsyncStateMachine(typeof(<OnLogOutClicked>d__18))]
	private void OnLogOutClicked() { }

	private void OnPollRefreshed() { }

	private void OnPollRefreshFailed() { }

	private void OnPollsFailed(Exception ex) { }

	private void OnPollsFinished(List<String> winningTowerIds) { }

	private void OnSubPollStarted(SubPoll subPoll) { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<ProcessTwitchRequest>d__29))]
	private Task ProcessTwitchRequest(Task task, bool showErrorPopup) { }

	private void set_IsCreateBtnEnabled(bool value) { }

	private void SetUi() { }

	private void ShowErrorPopup(Exception exception, bool showErrorPopup) { }

	private void Start() { }

	private void SubscribeToPollEvents() { }

	private void UnsubscribeFromPollEvents() { }

	private void Update() { }

}

