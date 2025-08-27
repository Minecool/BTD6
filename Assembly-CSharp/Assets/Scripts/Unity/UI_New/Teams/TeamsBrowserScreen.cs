namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamsBrowserScreen : GameMenu
{
	[CompilerGenerated]
	private struct <<Awake>b__66_7>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Awake>b__66_8>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GuildModel, String> <>9__71_0; //Field offset: 0x8
		public static Func<RankModel, Boolean> <>9__71_2; //Field offset: 0x10
		public static Func<LiNKFriendData, Boolean> <>9__74_0; //Field offset: 0x18
		public static Func<LiNKFriendData, String> <>9__74_1; //Field offset: 0x20
		public static Func<String, Boolean> <>9__74_2; //Field offset: 0x28
		public static Func<LiNKGuildPanel, String> <>9__74_4; //Field offset: 0x30
		public static Func<LiNKGuildPanel, String> <>9__75_0; //Field offset: 0x38
		public static ReturnCallback <>9__91_0; //Field offset: 0x40
		public static ReturnCallback <>9__94_0; //Field offset: 0x48
		public static Func<Tuple`3<Int32, Int32, GuildModel>, Boolean> <>9__94_3; //Field offset: 0x50
		public static Func<Tuple`3<Int32, Int32, GuildModel>, Int32> <>9__94_1; //Field offset: 0x58
		public static Func<Tuple`3<Int32, Int32, GuildModel>, Int32> <>9__94_2; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal void <OnClickCreateGuildAsync>b__91_0() { }

		internal void <OnClickQuickJoinGuild>b__94_0() { }

		internal int <OnClickQuickJoinGuild>b__94_1(Tuple<Int32, Int32, GuildModel> x) { }

		internal int <OnClickQuickJoinGuild>b__94_2(Tuple<Int32, Int32, GuildModel> x) { }

		internal bool <OnClickQuickJoinGuild>b__94_3(Tuple<Int32, Int32, GuildModel> x) { }

		internal string <Task_FetchAndBind>b__71_0(GuildModel x) { }

		internal bool <Task_FetchAndBind>b__71_2(RankModel x) { }

		internal bool <Task_FetchFriendsTeamData>b__74_0(LiNKFriendData x) { }

		internal string <Task_FetchFriendsTeamData>b__74_1(LiNKFriendData linkFriendData) { }

		internal bool <Task_FetchFriendsTeamData>b__74_2(string guildId) { }

		internal string <Task_FetchFriendsTeamData>b__74_4(LiNKGuildPanel p) { }

		internal string <Task_FetchGuildInvitesGuildModelsData>b__75_0(LiNKGuildPanel p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public GuildModel guild; //Field offset: 0x10

		public <>c__DisplayClass71_0() { }

		internal bool <Task_FetchAndBind>b__1(RankModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public LiNKFriendData friendData; //Field offset: 0x10

		public <>c__DisplayClass74_0() { }

		internal bool <Task_FetchFriendsTeamData>b__3(RankModel x) { }

	}

	[CompilerGenerated]
	private struct <ChangePageAsync>d__88 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x28
		public int pageNumber; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CustomSearchAsync>d__97 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchAndBind>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchFriendsTeamData>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FetchGuildInvitesGuildModelsData>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickCancelQuickJoin>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickCreateGuildAsync>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickQuickJoinGuild>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private AsyncOperationHandle<GameObject> <handle>5__2; //Field offset: 0x28
		private List<Tuple`3<Int32, Int32, GuildModel>> <guildToSort>5__3; //Field offset: 0x40
		private TimeSpan <startSearchTime>5__4; //Field offset: 0x48
		private int <currSearchOffset>5__5; //Field offset: 0x50
		private int <itterationCount>5__6; //Field offset: 0x54
		private bool <searchTimedOut>5__7; //Field offset: 0x58
		private int <failedJoinAttempts>5__8; //Field offset: 0x5C
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x60
		private TaskAwaiter<GameObject> <>u__2; //Field offset: 0x68
		private TaskAwaiter<Response> <>u__3; //Field offset: 0x70
		private TaskAwaiter <>u__4; //Field offset: 0x78
		private Enumerator<Tuple<Int32, Int32, GuildModel>> <>7__wrap8; //Field offset: 0x80
		private TaskAwaiter<GuildMembershipState> <>u__5; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRefreshButtonClicked>d__89 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnToggleTeamRequestsAllowed>d__98 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x28
		public bool isOn; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_FetchAndBind>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private bool <isDefaultSearch>5__2; //Field offset: 0x28
		private int <teamsPerPage>5__3; //Field offset: 0x2C
		private TaskAwaiter<Response> <>u__1; //Field offset: 0x30
		private TaskAwaiter<RankModel[]> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_FetchFriendsTeamData>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private RankModel[] <teamRanks>5__2; //Field offset: 0x28
		private IEnumerable<LiNKFriendData> <realFriends>5__3; //Field offset: 0x30
		private TaskAwaiter<List`1<LiNKFriendData>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<RankModel[]> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Task_FetchGuildInvitesGuildModelsData>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamsBrowserScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Dictionary`2<String, Invitation>> <>u__1; //Field offset: 0x28
		private Enumerator<String, Invitation> <>7__wrap1; //Field offset: 0x30
		private Invitation <invModel>5__3; //Field offset: 0x48
		private TaskAwaiter<Guild_GetMemberResponse> <>u__2; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string kDefaultSearchQuery = "SIMPLE_GUILD_LIST"; //Field offset: 0x0
	private const int TIMEOUT_TIME = 15; //Field offset: 0x0
	public const int MinTeamSize = 1; //Field offset: 0x0
	public LiNKGuildPanel guildPanelPrefab; //Field offset: 0x48
	public ButtonWithSyncingState createButton; //Field offset: 0x50
	public ButtonWithSyncingState quickJoinButton; //Field offset: 0x58
	public Button advSearchOptionsButton; //Field offset: 0x60
	public Button advSearchButton; //Field offset: 0x68
	public Button refreshButton; //Field offset: 0x70
	public Button introPanelButton; //Field offset: 0x78
	public Button screenClickBlockPanel; //Field offset: 0x80
	public Button firstPageButton; //Field offset: 0x88
	public Button prevPageButton; //Field offset: 0x90
	public Button nextPageButton; //Field offset: 0x98
	public Button lastPageButton; //Field offset: 0xA0
	public Lightbox introBackgroundPanelCloseButton; //Field offset: 0xA8
	public Button introOkClosePanelButton; //Field offset: 0xB0
	public NK_TextMeshProUGUI pageText; //Field offset: 0xB8
	public NK_TextMeshProUGUI introPanelText; //Field offset: 0xC0
	public NK_TextMeshProInputField searchFieldInput; //Field offset: 0xC8
	public GameObject openGroup; //Field offset: 0xD0
	public GameObject blockedGroup; //Field offset: 0xD8
	public GameObject friendsGroup; //Field offset: 0xE0
	public GameObject incomingGroup; //Field offset: 0xE8
	public GameObject outgoingGroup; //Field offset: 0xF0
	public GameObject openTeamsTab; //Field offset: 0xF8
	public GameObject friendsTeamsTab; //Field offset: 0x100
	public GameObject requestsTeamsTab; //Field offset: 0x108
	public GameObject introPanel; //Field offset: 0x110
	public GameObject nothingFoundPanel; //Field offset: 0x118
	public GameObject searchingPanel; //Field offset: 0x120
	public GameObject paginationPanel; //Field offset: 0x128
	public GameObject requestsPip; //Field offset: 0x130
	public Toggle teamsAllTgl; //Field offset: 0x138
	public Toggle teamsFriendsTgl; //Field offset: 0x140
	public Toggle teamsRequestsTgl; //Field offset: 0x148
	public TeamBrowserAdvancedPanel advSearchPanel; //Field offset: 0x150
	public ToggleWithSyncingState teamRequestTgl; //Field offset: 0x158
	public AudioClip tabSound; //Field offset: 0x160
	public AudioClip clickSound; //Field offset: 0x168
	private readonly Dictionary<String, LiNKGuildPanel> teamPanels; //Field offset: 0x170
	private readonly Dictionary<String, LiNKGuildPanel> teamFriendsPanels; //Field offset: 0x178
	private readonly Dictionary<String, LiNKGuildPanel> teamInvitationPanels; //Field offset: 0x180
	private Task findFriendsGuildsTask; //Field offset: 0x188
	private Task findGuildInvitesTask; //Field offset: 0x190
	private Task fetchAndBindTask; //Field offset: 0x198
	private bool isAnyTeamPanelShowing; //Field offset: 0x1A0
	private string advSerarchString; //Field offset: 0x1A8
	private readonly GuildSearchFilters searchFilters; //Field offset: 0x1B0
	private TeamsBrowserTab selectedTab; //Field offset: 0x1B8
	[CompilerGenerated]
	private readonly Dictionary<Int32, CachedGuildSearchResult> <CachedPagedData>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private Response <TeamListResponse>k__BackingField; //Field offset: 0x1C8
	private int currentPage; //Field offset: 0x1D0
	private int totalPages; //Field offset: 0x1D4
	private bool quickJoinCancelClicked; //Field offset: 0x1D8
	private Popup quickJoinPopup; //Field offset: 0x1E0

	public Dictionary<Int32, CachedGuildSearchResult> CachedPagedData
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private bool CanCreateOrJoinATeam
	{
		private get { } //Length: 109
	}

	private bool HasOutgoingApplicationToShow
	{
		private get { } //Length: 413
	}

	private int MaxPages
	{
		private get { } //Length: 238
	}

	public static int MaxTeamSize
	{
		 get { } //Length: 78
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	private Response TeamListResponse
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public TeamsBrowserScreen() { }

	[CompilerGenerated]
	private void <Awake>b__66_0() { }

	[CompilerGenerated]
	private void <Awake>b__66_1() { }

	[CompilerGenerated]
	private void <Awake>b__66_10(bool isOn) { }

	[CompilerGenerated]
	private void <Awake>b__66_11(bool isOn) { }

	[CompilerGenerated]
	private void <Awake>b__66_12(bool isOn) { }

	[CompilerGenerated]
	private void <Awake>b__66_2() { }

	[CompilerGenerated]
	private void <Awake>b__66_3() { }

	[CompilerGenerated]
	private void <Awake>b__66_4() { }

	[CompilerGenerated]
	private void <Awake>b__66_5() { }

	[CompilerGenerated]
	private void <Awake>b__66_6() { }

	[AsyncStateMachine(typeof(<<Awake>b__66_7>d))]
	[CompilerGenerated]
	private void <Awake>b__66_7() { }

	[AsyncStateMachine(typeof(<<Awake>b__66_8>d))]
	[CompilerGenerated]
	private void <Awake>b__66_8() { }

	[CompilerGenerated]
	private void <Awake>b__66_9(string inputText) { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<ChangePageAsync>d__88))]
	public void ChangePageAsync(int pageNumber) { }

	public virtual void Close() { }

	private void ClosePopups() { }

	[AsyncStateMachine(typeof(<CustomSearchAsync>d__97))]
	private void CustomSearchAsync() { }

	private void DestroyGroupChildren(GameObject group) { }

	private void DestroyGroupsChildren() { }

	[AsyncStateMachine(typeof(<FetchAndBind>d__69))]
	public Task FetchAndBind() { }

	[AsyncStateMachine(typeof(<FetchFriendsTeamData>d__72))]
	private Task FetchFriendsTeamData() { }

	[AsyncStateMachine(typeof(<FetchGuildInvitesGuildModelsData>d__73))]
	private Task FetchGuildInvitesGuildModelsData() { }

	[CompilerGenerated]
	public Dictionary<Int32, CachedGuildSearchResult> get_CachedPagedData() { }

	private bool get_CanCreateOrJoinATeam() { }

	private bool get_HasOutgoingApplicationToShow() { }

	private int get_MaxPages() { }

	public static int get_MaxTeamSize() { }

	private static TimeSpan get_Now() { }

	[CompilerGenerated]
	private Response get_TeamListResponse() { }

	private Transform GetMembersGroupType(GuildAndScore data) { }

	private string GetSearchString(bool isDefaultSearch = false) { }

	private void OnAdvSearchInputChanged(string value) { }

	[AsyncStateMachine(typeof(<OnClickCancelQuickJoin>d__95))]
	private Task OnClickCancelQuickJoin() { }

	public void OnClickCreateGuild() { }

	[AsyncStateMachine(typeof(<OnClickCreateGuildAsync>d__91))]
	private Task OnClickCreateGuildAsync() { }

	[AsyncStateMachine(typeof(<OnClickQuickJoinGuild>d__94))]
	private Task OnClickQuickJoinGuild() { }

	private void OnClickShowIntroPanel(bool showPanel) { }

	private void OnDestroy() { }

	public void OnLateFriendsLoadedUpdate() { }

	[AsyncStateMachine(typeof(<OnRefreshButtonClicked>d__89))]
	private Task OnRefreshButtonClicked() { }

	[AsyncStateMachine(typeof(<OnToggleTeamRequestsAllowed>d__98))]
	private void OnToggleTeamRequestsAllowed(bool isOn) { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	private Task RandomTime(float maxSeconds = 1.5) { }

	public void RemoveInvitationPanel(LiNKGuildPanel invitationPanel) { }

	public virtual void ReOpen(object data) { }

	public void ResetPagedResults() { }

	[CompilerGenerated]
	private void set_TeamListResponse(Response value) { }

	private void SetPageText(int totalResults) { }

	public void SetTotalPages(int teamsPerPage, int totalResults) { }

	[AsyncStateMachine(typeof(<Task_FetchAndBind>d__71))]
	private Task Task_FetchAndBind() { }

	[AsyncStateMachine(typeof(<Task_FetchFriendsTeamData>d__74))]
	private Task Task_FetchFriendsTeamData() { }

	[AsyncStateMachine(typeof(<Task_FetchGuildInvitesGuildModelsData>d__75))]
	private Task Task_FetchGuildInvitesGuildModelsData() { }

	private int TeamsPerPage(bool isDefaultSearch) { }

	public void ToggleUiInteractable(bool interactable) { }

	private void TrySwitchTab(bool isOn, TeamsBrowserTab selectedTab) { }

	private void UpdateGroupVisibily(GameObject group, TeamsBrowserTab requiredTab) { }

	public void UpdatePanels() { }

	private void UpdateSearching() { }

}

