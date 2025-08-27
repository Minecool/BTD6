namespace Assets.Scripts.Unity.UI_New.LiNKSocial;

public class LinkFriendsScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnValidateInput <>9__37_1; //Field offset: 0x8
		public static Func<Tuple`3<Boolean, String, LinkFriendPanel>, Boolean> <>9__39_4; //Field offset: 0x10
		public static Func<Tuple`3<Boolean, String, LinkFriendPanel>, String> <>9__39_5; //Field offset: 0x18
		public static Func<LiNKFriendData, Boolean> <>9__39_0; //Field offset: 0x20
		public static Func<LiNKFriendData, Boolean> <>9__39_1; //Field offset: 0x28
		public static Func<LiNKFriendData, Boolean> <>9__39_2; //Field offset: 0x30
		public static Func<LiNKFriendData, Boolean> <>9__39_3; //Field offset: 0x38
		public static Func<FriendModel, Boolean> <>9__41_0; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal char <Open>b__37_1(string s, int i, char c) { }

		internal bool <Task_FetchAndBind>b__39_0(LiNKFriendData x) { }

		internal bool <Task_FetchAndBind>b__39_1(LiNKFriendData x) { }

		internal bool <Task_FetchAndBind>b__39_2(LiNKFriendData x) { }

		internal bool <Task_FetchAndBind>b__39_3(LiNKFriendData x) { }

		internal bool <Task_FetchAndBind>b__39_4(Tuple<Boolean, String, LinkFriendPanel> x) { }

		internal string <Task_FetchAndBind>b__39_5(Tuple<Boolean, String, LinkFriendPanel> x) { }

		internal bool <UpdateNotificationPip>b__41_0(FriendModel x) { }

	}

	[CompilerGenerated]
	private struct <AnimatePopupPanel>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject panel; //Field offset: 0x20
		public int seconds; //Field offset: 0x28
		public LinkFriendsScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchAndBind>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScreen <>4__this; //Field offset: 0x20
		public bool forceUpdate; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickSendFriendRequest>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnToggleFriendRequestsAllowed>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowCopiedTick>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_FetchAndBind>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkFriendsScreen <>4__this; //Field offset: 0x20
		public bool forceUpdate; //Field offset: 0x28
		private float <startAt>5__2; //Field offset: 0x2C
		private List<LiNKFriendData> <friendsData>5__3; //Field offset: 0x30
		private List<Tuple`3<Boolean, String, LinkFriendPanel>> <panelsToSort>5__4; //Field offset: 0x38
		private TaskAwaiter<List`1<LiNKFriendData>> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private Enumerator<LiNKFriendData> <>7__wrap4; //Field offset: 0x50
		private LiNKFriendData <friendData>5__6; //Field offset: 0x68
		private Btd6PlayerStats <playerStats>5__7; //Field offset: 0x70
		private LinkFriendPanel <playerPanel>5__8; //Field offset: 0x78
		private TaskAwaiter<Btd6PlayerStats> <>u__3; //Field offset: 0x80

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button refreshButton; //Field offset: 0x48
	public Button addFriendButton; //Field offset: 0x50
	public Button sendFriendInvButton; //Field offset: 0x58
	public Button shareFriendCodeButton; //Field offset: 0x60
	public Lightbox closeAddFriendsButton; //Field offset: 0x68
	public Toggle friendsToggle; //Field offset: 0x70
	public Toggle requestsToggle; //Field offset: 0x78
	public Toggle friendRequestToggle; //Field offset: 0x80
	public Toggle codeVisibilityToggle; //Field offset: 0x88
	public GameObject friendsTab; //Field offset: 0x90
	public GameObject requestsTab; //Field offset: 0x98
	public GameObject copyCodeTick; //Field offset: 0xA0
	public GameObject friendsGroup; //Field offset: 0xA8
	public GameObject blockedGroup; //Field offset: 0xB0
	public GameObject outgoingGroup; //Field offset: 0xB8
	public GameObject incomingGroup; //Field offset: 0xC0
	public GameObject searchingImage; //Field offset: 0xC8
	public GameObject friendCodePanel; //Field offset: 0xD0
	public GameObject friendRequestPip; //Field offset: 0xD8
	public GameObject foundNothingPanel; //Field offset: 0xE0
	public GameObject friendCodeLoadingImg; //Field offset: 0xE8
	public GameObject enterFriendCodePanel; //Field offset: 0xF0
	public GameObject friendCodeSuccessTick; //Field offset: 0xF8
	public GameObject friendCodeHiddenPanel; //Field offset: 0x100
	public GameObject friendRequestDisabledTooltip; //Field offset: 0x108
	public NK_TextMeshProUGUI foundNothingText; //Field offset: 0x110
	public NK_TextMeshProUGUI playersFriendCodeText; //Field offset: 0x118
	public NK_TextMeshProUGUI friendRequestDisabledText; //Field offset: 0x120
	public TMP_InputField addFriendInput; //Field offset: 0x128
	public LinkFriendPanel playerPanelPrefab; //Field offset: 0x130
	public AudioClip clickSound; //Field offset: 0x138
	public AudioClip openSound; //Field offset: 0x140
	private readonly List<LinkFriendPanel> playerPanels; //Field offset: 0x148
	private Task fetchAndBindTask; //Field offset: 0x150
	private bool showingFriendsPanel; //Field offset: 0x158
	private bool isInitialised; //Field offset: 0x159

	public LinkFriendsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__36_0() { }

	[CompilerGenerated]
	private void <Awake>b__36_1() { }

	[CompilerGenerated]
	private void <Awake>b__36_2() { }

	[CompilerGenerated]
	private void <Awake>b__36_3() { }

	[CompilerGenerated]
	private void <Open>b__37_0(string s) { }

	[AsyncStateMachine(typeof(<AnimatePopupPanel>d__47))]
	public Task AnimatePopupPanel(GameObject panel, int seconds = 1) { }

	protected virtual void Awake() { }

	private void CleanUpPanels() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<FetchAndBind>d__38))]
	public Task FetchAndBind(bool forceUpdate = false) { }

	private Transform GetFriendsGroupType(FriendModel model) { }

	[AsyncStateMachine(typeof(<OnClickSendFriendRequest>d__45))]
	public void OnClickSendFriendRequest() { }

	public void OnToggleFriendCodePanel(bool showPanel) { }

	[AsyncStateMachine(typeof(<OnToggleFriendRequestsAllowed>d__46))]
	public void OnToggleFriendRequestsAllowed() { }

	public void OnToggleShowFriendsRequestsPanel(bool showFriendsPanel) { }

	public void OnToggleYourFriendCodeVisibility() { }

	[AsyncStateMachine(typeof(<Open>d__37))]
	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	[AsyncStateMachine(typeof(<ShowCopiedTick>d__48))]
	public void ShowCopiedTick() { }

	private void ShowSearching(bool show) { }

	[AsyncStateMachine(typeof(<Task_FetchAndBind>d__39))]
	private Task Task_FetchAndBind(bool forceUpdate) { }

	public void ToggleUiInteractable(bool interactable) { }

	private void UpdateGroupsVisibility() { }

	private void UpdateGroupVisibily(GameObject group) { }

	public void UpdateNotificationPip() { }

	public void UpdatePanels() { }

}

