namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsScreen : GameMenu
{
	[CompilerGenerated]
	private struct <<Awake>b__95_7>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		public bool isOn; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnValidateInput <>9__95_9; //Field offset: 0x8
		public static ReturnCallback <>9__104_0; //Field offset: 0x10
		public static ReturnCallback <>9__109_0; //Field offset: 0x18
		public static ReturnCallback <>9__110_0; //Field offset: 0x20
		public static Func<GuildMemberModel, String> <>9__111_0; //Field offset: 0x28
		public static Func<ScoreModel, String> <>9__111_3; //Field offset: 0x30
		public static Func<ScoreModel, Int64> <>9__111_4; //Field offset: 0x38
		public static Func<KeyValuePair`2<String, UInt64>, String> <>9__111_5; //Field offset: 0x40
		public static Func<KeyValuePair`2<String, UInt64>, Int64> <>9__111_6; //Field offset: 0x48
		public static Func<LiNKGuildMemberPanel, Int64> <>9__111_1; //Field offset: 0x50
		public static Func<LiNKGuildMemberPanel, String> <>9__111_2; //Field offset: 0x58
		public static Func<GuildMessage, String> <>9__116_0; //Field offset: 0x60
		public static Func<CtTileFocus, DateTime> <>9__117_0; //Field offset: 0x68
		public static Func<Tuple`2<DateTime, LiNKGuildMessagePanel>, DateTime> <>9__117_4; //Field offset: 0x70
		public static ReturnCallback <>9__155_0; //Field offset: 0x78

		private static <>c() { }

		public <>c() { }

		internal char <Awake>b__95_9(string s, int i, char c) { }

		internal void <FetchAndBind>b__109_0() { }

		internal string <FetchGuildMessagesAsync>b__116_0(GuildMessage x) { }

		internal void <OnExecuteLeaveTeam>b__155_0() { }

		internal void <Open>b__104_0() { }

		internal DateTime <PopulateMessagePanels>b__117_0(CtTileFocus x) { }

		internal DateTime <PopulateMessagePanels>b__117_4(Tuple<DateTime, LiNKGuildMessagePanel> x) { }

		internal string <PopulatePanels>b__111_0(GuildMemberModel x) { }

		internal long <PopulatePanels>b__111_1(LiNKGuildMemberPanel x) { }

		internal string <PopulatePanels>b__111_2(LiNKGuildMemberPanel x) { }

		internal string <PopulatePanels>b__111_3(ScoreModel x) { }

		internal long <PopulatePanels>b__111_4(ScoreModel z) { }

		internal string <PopulatePanels>b__111_5(KeyValuePair<String, UInt64> x) { }

		internal long <PopulatePanels>b__111_6(KeyValuePair<String, UInt64> z) { }

		internal void <Task_FetchAndBind>b__110_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_0
	{
		public TeamsScreen <>4__this; //Field offset: 0x10
		public Dictionary<String, Int64> teamCtScores; //Field offset: 0x18
		public Dictionary<String, Int64> teamBossRushScores; //Field offset: 0x20
		public List<Task> subTasks; //Field offset: 0x28

		public <>c__DisplayClass111_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_1
	{
		public GuildMemberModel memberData; //Field offset: 0x10
		public <>c__DisplayClass111_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass111_1() { }

		internal void <PopulatePanels>b__7(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_0
	{
		public List<Task> subTasks; //Field offset: 0x10
		public TeamsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass117_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass117_1
	{
		public GuildMessage message; //Field offset: 0x10
		public <>c__DisplayClass117_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass117_1() { }

		internal void <PopulateMessagePanels>b__1(AsyncOperationHandle<GameObject> h) { }

		internal void <PopulateMessagePanels>b__2(AsyncOperationHandle<GameObject> h) { }

		internal void <PopulateMessagePanels>b__3(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass118_0
	{
		public CtTileFocus tile; //Field offset: 0x10
		public TeamsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass118_0() { }

		internal void <InsertFocusMarkerMessages>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass157_0
	{
		public TeamsScreen <>4__this; //Field offset: 0x10
		public LiNKGuildMemberPanel member; //Field offset: 0x18

		public <>c__DisplayClass157_0() { }

		internal void <OnClickTransferOwnership>b__0() { }

	}

	[CompilerGenerated]
	private struct <FetchAndBind>d__109 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x20
		public bool forceRefresh; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchAndBindAsync>d__108 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		public bool forceRefresh; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchGuildMessagesAsync>d__116 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private GuildData <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<IEnumerable`1<GuildMessage>> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HideTeamCode>d__128 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x20
		public bool isHidden; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InsertRandomWaitTime>d__130 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public float startAt; //Field offset: 0x20
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickAcceptJoinTeam>d__153 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickDeclineJoinTeam>d__154 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickJoinTeam>d__156 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<GuildMembershipState> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickRefreshAsync>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickSendMemberRequest>d__152 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnConfirmTransferOwnership>d__158 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		public LiNKGuildMemberPanel member; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnExecuteLeaveTeam>d__155 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__104 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PopulateMedalsAsync>d__114 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x28
		public TeamsScreen <>4__this; //Field offset: 0x30
		private Dictionary<String, Int32> <guildBadges>5__2; //Field offset: 0x38
		private TaskAwaiter<Dictionary`2<String, Int32>> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PopulateMessagePanels>d__117 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass117_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PopulatePanels>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass111_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<CtApiActionResult> <>u__2; //Field offset: 0x38
		private TaskAwaiter<CtLeaderboards> <>u__3; //Field offset: 0x40
		private TaskAwaiter<BossRushStatusResponse> <>u__4; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PreCacheMessageNamesAndData>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<GuildMessage> messages; //Field offset: 0x20
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshAsync>d__145 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowCopiedTick>d__139 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_FetchAndBind>d__110 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsScreen <>4__this; //Field offset: 0x20
		public bool forceRefresh; //Field offset: 0x28
		private float <startAt>5__2; //Field offset: 0x2C
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<Tuple`2<GuildModel, GuildMemberModel[]>> <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum TeamsTab
	{
		Messages = 0,
		Roster = 1,
		Requests = 2,
	}

	private const string kTeamAdminPrefKey = "teamAdminEnabled"; //Field offset: 0x0
	public NK_TextMeshProUGUI teamNameTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI teamStatusTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI memberCountTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI pendingCountTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI publicPrivateText; //Field offset: 0x68
	public Image teamIconImg; //Field offset: 0x70
	public Image teamFrameImg; //Field offset: 0x78
	public Image teamBannerImg; //Field offset: 0x80
	public Toggle messagesToggle; //Field offset: 0x88
	public Toggle requestsToggle; //Field offset: 0x90
	public Toggle rosterToggle; //Field offset: 0x98
	public GameObject rosterGroup; //Field offset: 0xA0
	public GameObject medalsGroup; //Field offset: 0xA8
	public GameObject messagesGroup; //Field offset: 0xB0
	public GameObject blockedGroup; //Field offset: 0xB8
	public GameObject outgoingGroup; //Field offset: 0xC0
	public GameObject incomingGroup; //Field offset: 0xC8
	public GameObject requestsPip; //Field offset: 0xD0
	public GameObject messagesPip; //Field offset: 0xD8
	public GameObject teamBrowserPip; //Field offset: 0xE0
	public GameObject nothingFoundPanel; //Field offset: 0xE8
	public GameObject noMedalsPanel; //Field offset: 0xF0
	public GameObject loadingPanel; //Field offset: 0xF8
	public GameObject addMemberPanel; //Field offset: 0x100
	public GameObject addMemberSuccessTickImg; //Field offset: 0x108
	public GameObject addMemberSuccessCrossImg; //Field offset: 0x110
	public GameObject addMemberLoadingImg; //Field offset: 0x118
	public GameObject teamMedals; //Field offset: 0x120
	public RectTransform scrollRect; //Field offset: 0x128
	public TMP_InputField addMemberInputField; //Field offset: 0x130
	public Button teamEditButton; //Field offset: 0x138
	public Button addMemberButton; //Field offset: 0x140
	public Button prefabCancelAddMemberButton; //Field offset: 0x148
	public Lightbox prefabCloseAddMemberPanelButton; //Field offset: 0x150
	public Button prefabAddMemberButton; //Field offset: 0x158
	public Button refreshButton; //Field offset: 0x160
	public Button leaveButton; //Field offset: 0x168
	public Button joinButton; //Field offset: 0x170
	public Button acceptButton; //Field offset: 0x178
	public Button declineButton; //Field offset: 0x180
	public Button pendingButton; //Field offset: 0x188
	public Button cancelJoinButton; //Field offset: 0x190
	public Button disbandButton; //Field offset: 0x198
	public Button teamsButton; //Field offset: 0x1A0
	public Button inviteToTeamButton; //Field offset: 0x1A8
	public Button teamAdminButton; //Field offset: 0x1B0
	public AudioClip clickSound; //Field offset: 0x1B8
	public AudioClip openSound; //Field offset: 0x1C0
	public Button shareTeamCodeButton; //Field offset: 0x1C8
	public Toggle hideTeamCodeButton; //Field offset: 0x1D0
	public GameObject teamCodePanel; //Field offset: 0x1D8
	public GameObject teamCodeSuccessTick; //Field offset: 0x1E0
	public GameObject teamCodeHiddenPanel; //Field offset: 0x1E8
	public NK_TextMeshProUGUI teamCodeText; //Field offset: 0x1F0
	public CompetitiveModePanel competitiveModePanel; //Field offset: 0x1F8
	private readonly List<LiNKGuildMemberPanel> teamMembersList; //Field offset: 0x200
	private readonly List<LiNKGuildMessagePanel> teamMessagesList; //Field offset: 0x208
	[CompilerGenerated]
	private GuildData <ThisGuildData>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private GuildModPermissions <MyPlayerPerms>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	private bool <IsTeamCtBlacklisted>k__BackingField; //Field offset: 0x220
	private bool isInitialised; //Field offset: 0x221
	private bool isSearching; //Field offset: 0x222
	private bool isLoadingMessages; //Field offset: 0x223
	private bool hasSeenPendingApplicationsTab; //Field offset: 0x224
	private DateTime lastCheckedMessage; //Field offset: 0x228
	private TeamsTab selectedTab; //Field offset: 0x230
	private int scrollRectYPosition; //Field offset: 0x234
	private Nullable<Boolean> _isTeamAdminEnabled; //Field offset: 0x238
	private bool forceShowCompetitivePanel; //Field offset: 0x23A
	private bool isFetching; //Field offset: 0x23B
	private bool isFirstFetch; //Field offset: 0x23C
	private TimeSpan lastRefreshAt; //Field offset: 0x240

	public bool IsMemberOfGuild
	{
		 get { } //Length: 401
	}

	public bool IsModeratorOfGuild
	{
		 get { } //Length: 166
	}

	public bool IsOwnerOfGuild
	{
		 get { } //Length: 133
	}

	public bool IsOwnerOrModerator
	{
		 get { } //Length: 43
	}

	public bool IsPendingApplicationToGuild
	{
		 get { } //Length: 394
	}

	public private bool IsTeamAdminEnabled
	{
		 get { } //Length: 168
		private set { } //Length: 129
	}

	public private bool IsTeamCtBlacklisted
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private GuildModPermissions MyPlayerPerms
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private TimeSpan Now
	{
		private get { } //Length: 91
	}

	public int PendingApplicationsCount
	{
		 get { } //Length: 109
	}

	public private GuildData ThisGuildData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public GuildMemberModel[] ThisGuildMemberModel
	{
		 get { } //Length: 18
	}

	private IEnumerable<GuildMessage> ThisGuildMessages
	{
		private get { } //Length: 18
	}

	public GuildModel ThisGuildModel
	{
		 get { } //Length: 18
	}

	public TeamsScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private void <Awake>b__95_0() { }

	[CompilerGenerated]
	private void <Awake>b__95_1() { }

	[CompilerGenerated]
	private void <Awake>b__95_2() { }

	[CompilerGenerated]
	private void <Awake>b__95_3() { }

	[CompilerGenerated]
	private void <Awake>b__95_4(bool isOn) { }

	[CompilerGenerated]
	private void <Awake>b__95_5(bool isOn) { }

	[CompilerGenerated]
	private void <Awake>b__95_6(bool isOn) { }

	[AsyncStateMachine(typeof(<<Awake>b__95_7>d))]
	[CompilerGenerated]
	private void <Awake>b__95_7(bool isOn) { }

	[CompilerGenerated]
	private void <Awake>b__95_8(string s, int i, int i2) { }

	protected virtual void Awake() { }

	private void ClearListChildren(List<T> group) { }

	private void ClearListsChildren() { }

	public virtual void Close() { }

	public void CloseOtherPopups(LiNKGuildMemberPanel memberPopupShowing) { }

	[AsyncStateMachine(typeof(<FetchAndBind>d__109))]
	private Task FetchAndBind(bool forceRefresh = false) { }

	[AsyncStateMachine(typeof(<FetchAndBindAsync>d__108))]
	private void FetchAndBindAsync(bool forceRefresh = false) { }

	[AsyncStateMachine(typeof(<FetchGuildMessagesAsync>d__116))]
	public void FetchGuildMessagesAsync() { }

	private void ForceClose() { }

	public bool get_IsMemberOfGuild() { }

	public bool get_IsModeratorOfGuild() { }

	public bool get_IsOwnerOfGuild() { }

	public bool get_IsOwnerOrModerator() { }

	public bool get_IsPendingApplicationToGuild() { }

	public bool get_IsTeamAdminEnabled() { }

	[CompilerGenerated]
	public bool get_IsTeamCtBlacklisted() { }

	[CompilerGenerated]
	public GuildModPermissions get_MyPlayerPerms() { }

	private TimeSpan get_Now() { }

	public int get_PendingApplicationsCount() { }

	[CompilerGenerated]
	public GuildData get_ThisGuildData() { }

	public GuildMemberModel[] get_ThisGuildMemberModel() { }

	private IEnumerable<GuildMessage> get_ThisGuildMessages() { }

	public GuildModel get_ThisGuildModel() { }

	private static string GetGuildSubtitle(GuildData guildData) { }

	private Transform GetMembersGroupType(GuildMembershipState permissions) { }

	[AsyncStateMachine(typeof(<HideTeamCode>d__128))]
	private Task HideTeamCode(bool isHidden) { }

	private void InsertFocusMarkerMessages(IEnumerable<CtTileFocus> focusMarkers) { }

	[AsyncStateMachine(typeof(<InsertRandomWaitTime>d__130))]
	public Task InsertRandomWaitTime(float startAt) { }

	private static int MemberPermissionComparer(LiNKGuildMemberPanel teamMemberPanel) { }

	private void OnCancelLeaveTeam() { }

	[AsyncStateMachine(typeof(<OnClickAcceptJoinTeam>d__153))]
	public void OnClickAcceptJoinTeam() { }

	[AsyncStateMachine(typeof(<OnClickDeclineJoinTeam>d__154))]
	public void OnClickDeclineJoinTeam() { }

	private void OnClickInviteToTeam(bool showPanel) { }

	[AsyncStateMachine(typeof(<OnClickJoinTeam>d__156))]
	private void OnClickJoinTeam() { }

	public void OnClickLeaveTeam() { }

	[AsyncStateMachine(typeof(<OnClickRefreshAsync>d__144))]
	public void OnClickRefreshAsync() { }

	[AsyncStateMachine(typeof(<OnClickSendMemberRequest>d__152))]
	private void OnClickSendMemberRequest() { }

	public void OnClickShowTeamsScreen() { }

	public void OnClickTransferOwnership(LiNKGuildMemberPanel member) { }

	[AsyncStateMachine(typeof(<OnConfirmTransferOwnership>d__158))]
	private void OnConfirmTransferOwnership(LiNKGuildMemberPanel member) { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnExecuteLeaveTeam>d__155))]
	private void OnExecuteLeaveTeam() { }

	public void OnLateFriendsLoadedUpdate() { }

	public void OnScrollRectMoving() { }

	private void OnTextSelectedAddMemberInputField() { }

	public void OnToggleEditTeamPanel() { }

	private void OnValueChangedAddMemberInputField(string value) { }

	[AsyncStateMachine(typeof(<Open>d__104))]
	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	private int PanelComparer(Tuple<GuildMembershipState, Int64, String, LiNKGuildMemberPanel> x, Tuple<GuildMembershipState, Int64, String, LiNKGuildMemberPanel> y) { }

	[AsyncStateMachine(typeof(<PopulateMedalsAsync>d__114))]
	private void PopulateMedalsAsync(string guildId) { }

	[AsyncStateMachine(typeof(<PopulateMessagePanels>d__117))]
	public Task PopulateMessagePanels() { }

	[AsyncStateMachine(typeof(<PopulatePanels>d__111))]
	public Task PopulatePanels() { }

	[AsyncStateMachine(typeof(<PreCacheMessageNamesAndData>d__119))]
	private Task PreCacheMessageNamesAndData(IEnumerable<GuildMessage> messages) { }

	[AsyncStateMachine(typeof(<RefreshAsync>d__145))]
	public void RefreshAsync() { }

	public virtual void ReOpen(object data) { }

	private void set_IsTeamAdminEnabled(bool value) { }

	[CompilerGenerated]
	private void set_IsTeamCtBlacklisted(bool value) { }

	[CompilerGenerated]
	private void set_MyPlayerPerms(GuildModPermissions value) { }

	[CompilerGenerated]
	private void set_ThisGuildData(GuildData value) { }

	[AsyncStateMachine(typeof(<ShowCopiedTick>d__139))]
	public void ShowCopiedTick() { }

	private void ShowHideChildren(List<T> group, bool isVisible) { }

	private void ShowHideListsChildren(bool isVisible) { }

	private void ShowMedals(GameObject medalContainer, Dictionary<String, Int32> medalNamesCount, string objectNamePrefix, string badgeNamePrefix) { }

	public void ShowSearching(bool isSearching) { }

	public void ShowTeamCosmetics() { }

	[AsyncStateMachine(typeof(<Task_FetchAndBind>d__110))]
	private Task Task_FetchAndBind(bool forceRefresh = false) { }

	private void ToggleTeamAdminButtons() { }

	public void ToggleUiInteractable(bool interactable) { }

	private void TrySwitchTab(bool isOn, TeamsTab selectedTab) { }

	public void Update() { }

	private void UpdateGroupsVisibility() { }

	private void UpdateGroupVisibily(GameObject group, bool groupVisible) { }

	public void UpdatePanels() { }

}

