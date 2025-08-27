namespace Assets.Scripts.Unity.UI_New.Coop;

public class PlaySocialScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public PlaySocialScreen <>4__this; //Field offset: 0x10
		public Func<Task> buttonTask; //Field offset: 0x18
		public bool requiresInternet; //Field offset: 0x20
		public bool isCoopCheck; //Field offset: 0x21

		public <>c__DisplayClass33_0() { }

		internal Task <ButtonClicked>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public BossEvent bossEvent; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal void <BossEventBtnDown>b__0() { }

	}

	[CompilerGenerated]
	private struct <BossEventBtnDown>d__43 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass43_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckBossEvent>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private BossDataModel <bossDataModel>5__2; //Field offset: 0x28
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckCoopChallenge>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EditChallengeBtnDown>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EditOdysseyBtnDown>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GameEditorBtnDown>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MapEditorBtnDown>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MyTeamBtnDown>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnBtnDown>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		public string sceneName; //Field offset: 0x28
		public object metaData; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCreateGameBtnDown>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private Btd6LobbyParameters <lobbyParameters>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private CancellationTokenSource <canceller>5__3; //Field offset: 0x38
		private TaskAwaiter<LobbyConnection> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessButtonClicked>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		public bool requiresInternet; //Field offset: 0x28
		public bool isCoopCheck; //Field offset: 0x29
		public Func<Task> buttonTask; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetCtIconTitle>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private CtEvent <upcomintCtEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<CtEvent> <>u__1; //Field offset: 0x30
		private DateTime <signUpCutoffTime>5__3; //Field offset: 0x38
		private TaskAwaiter<Btd6CtSettings> <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TeamEventBtnDown>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ViewBrowserBtnDown>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlaySocialScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button quickGameBtn; //Field offset: 0x48
	public Button createGameBtn; //Field offset: 0x50
	public Button joinGameBtn; //Field offset: 0x58
	public Button coopChallengeBtn; //Field offset: 0x60
	public Button bossEventBtn; //Field offset: 0x68
	public Button ctBtn; //Field offset: 0x70
	public Button bossRushBtn; //Field offset: 0x78
	public TMP_Text ctBtnTxt; //Field offset: 0x80
	public Image bossEventBtnImg; //Field offset: 0x88
	public GameObject contentBrowserPanel; //Field offset: 0x90
	public Button viewBrowserBtn; //Field offset: 0x98
	public Button editChallengeBtn; //Field offset: 0xA0
	public Button editOdysseyBtn; //Field offset: 0xA8
	public Button mapEditorBtn; //Field offset: 0xB0
	public Button gameEditorBtn; //Field offset: 0xB8
	public GameObject mapEditorUnlockGo; //Field offset: 0xC0
	public GameObject gameEditorUnlockGo; //Field offset: 0xC8
	public GameObject gameEditorNewRibbon; //Field offset: 0xD0
	public Button myTeamBtn; //Field offset: 0xD8
	[SerializeField]
	private AccoladeNotificationButton accoladeNotifBtn; //Field offset: 0xE0
	[SerializeField]
	private AccoladesNotificationPanel accoladesNotificationPanel; //Field offset: 0xE8
	public Button lockMapDebug; //Field offset: 0xF0
	public GameObject signUpCompCtObj; //Field offset: 0xF8
	public NK_TextMeshProUGUI ctTitleTxt; //Field offset: 0x100
	public GameObject newCtEventPip; //Field offset: 0x108
	public GameObject newBossRushEventPip; //Field offset: 0x110
	private DailyChallengeModel coopDC; //Field offset: 0x118
	[CompilerGenerated]
	private Action CancelCreateLobbyEvent; //Field offset: 0x120

	private event Action CancelCreateLobbyEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public PlaySocialScreen() { }

	[CompilerGenerated]
	private void <Start>b__30_0() { }

	[CompilerGenerated]
	private void <Start>b__30_1() { }

	[CompilerGenerated]
	private void <Start>b__30_10() { }

	[CompilerGenerated]
	private void <Start>b__30_11() { }

	[CompilerGenerated]
	private void <Start>b__30_12() { }

	[CompilerGenerated]
	private Task <Start>b__30_13() { }

	[CompilerGenerated]
	private Task <Start>b__30_14() { }

	[CompilerGenerated]
	private Task <Start>b__30_15() { }

	[CompilerGenerated]
	private void <Start>b__30_2() { }

	[CompilerGenerated]
	private void <Start>b__30_3() { }

	[CompilerGenerated]
	private void <Start>b__30_4() { }

	[CompilerGenerated]
	private void <Start>b__30_5() { }

	[CompilerGenerated]
	private void <Start>b__30_6() { }

	[CompilerGenerated]
	private void <Start>b__30_7() { }

	[CompilerGenerated]
	private void <Start>b__30_8() { }

	[CompilerGenerated]
	private void <Start>b__30_9() { }

	[CompilerGenerated]
	private void add_CancelCreateLobbyEvent(Action value) { }

	[AsyncStateMachine(typeof(<BossEventBtnDown>d__43))]
	private Task BossEventBtnDown() { }

	private void ButtonClicked(Func<Task> buttonTask, bool requiresInternet, bool isCoopCheck) { }

	[AsyncStateMachine(typeof(<CheckBossEvent>d__37))]
	private Task CheckBossEvent() { }

	[AsyncStateMachine(typeof(<CheckCoopChallenge>d__36))]
	private Task CheckCoopChallenge() { }

	private void CheckMyTeamBtn() { }

	private void CheckTeamEvents() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<EditChallengeBtnDown>d__47))]
	private Task EditChallengeBtnDown() { }

	[AsyncStateMachine(typeof(<EditOdysseyBtnDown>d__48))]
	private Task EditOdysseyBtnDown() { }

	[AsyncStateMachine(typeof(<GameEditorBtnDown>d__50))]
	private Task GameEditorBtnDown() { }

	[AsyncStateMachine(typeof(<MapEditorBtnDown>d__49))]
	private Task MapEditorBtnDown() { }

	[AsyncStateMachine(typeof(<MyTeamBtnDown>d__45))]
	private Task MyTeamBtnDown() { }

	[AsyncStateMachine(typeof(<OnBtnDown>d__41))]
	private Task OnBtnDown(string sceneName, object metaData = null) { }

	[AsyncStateMachine(typeof(<OnCreateGameBtnDown>d__42))]
	private Task OnCreateGameBtnDown() { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<ProcessButtonClicked>d__34))]
	private Task ProcessButtonClicked(Func<Task> buttonTask, bool requiresInternet, bool isCoopCheck) { }

	[CompilerGenerated]
	private void remove_CancelCreateLobbyEvent(Action value) { }

	private void SetButtonsInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<SetCtIconTitle>d__39))]
	private Task SetCtIconTitle() { }

	public void Start() { }

	[AsyncStateMachine(typeof(<TeamEventBtnDown>d__44))]
	private Task TeamEventBtnDown() { }

	private void ToggleAccoladeNotificationPanel() { }

	[AsyncStateMachine(typeof(<ViewBrowserBtnDown>d__46))]
	private Task ViewBrowserBtnDown() { }

}

