namespace Assets.Scripts.Unity.UI_New;

public class LeaderboardScreen : GameMenu
{
	[CompilerGenerated]
	private struct <_ScorePanelsLoader>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int selectedIndex; //Field offset: 0x20
		public LeaderboardScreen <>4__this; //Field offset: 0x28
		public int loadId; //Field offset: 0x30
		private <>c__DisplayClass85_0 <>8__1; //Field offset: 0x38
		private LeaderboardData <activeLeaderboard>5__2; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GuildInfo, String> <>9__83_0; //Field offset: 0x8
		public static Func<GuildMemberModel, String> <>9__83_1; //Field offset: 0x10
		public static Func<GroupScoreModel, IEnumerable`1<ScoreModel>> <>9__87_0; //Field offset: 0x18
		public static Func<ScoreModel, String> <>9__87_1; //Field offset: 0x20
		public static Func<Task, Boolean> <>9__94_2; //Field offset: 0x28
		public static Func<Task, Boolean> <>9__94_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal string <LoadLocalCtPlayerGuildIds>b__83_0(GuildInfo x) { }

		internal string <LoadLocalCtPlayerGuildIds>b__83_1(GuildMemberModel x) { }

		internal IEnumerable<ScoreModel> <LoadScorePanels>b__87_0(GroupScoreModel x) { }

		internal string <LoadScorePanels>b__87_1(ScoreModel y) { }

		internal bool <OpenRewardsScreenAsync>b__94_0(Task x) { }

		internal bool <OpenRewardsScreenAsync>b__94_2(Task x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public int selectedIndex; //Field offset: 0x10

		public <>c__DisplayClass69_0() { }

		internal bool <RefreshScreen>b__0(LeaderboardData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass85_0
	{
		public int selectedIndex; //Field offset: 0x10

		public <>c__DisplayClass85_0() { }

		internal bool <_ScorePanelsLoader>b__0(LeaderboardData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass94_0() { }

		internal bool <OpenRewardsScreenAsync>b__1(LeaderboardData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass95_0
	{
		public int currentIndex; //Field offset: 0x10

		public <>c__DisplayClass95_0() { }

		internal bool <ButtonsInteractable>b__0(LeaderboardData x) { }

	}

	[CompilerGenerated]
	private struct <GetCtLeaderboardScores>d__91 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<GroupScoreModel>> <>t__builder; //Field offset: 0x8
		public LeaderboardScreen <>4__this; //Field offset: 0x20
		public CtLeaderboardType ctLeaderboardType; //Field offset: 0x28
		public LeaderboardData leaderboard; //Field offset: 0x30
		private TaskAwaiter<CtLeaderboards> <>u__1; //Field offset: 0x38
		private TaskAwaiter<List`1<GroupScoreModel>> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeCtEventData>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadLocalCtPlayerGuildIds>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public StatusResponse ctStatus; //Field offset: 0x20
		public LeaderboardScreen <>4__this; //Field offset: 0x28
		private IEnumerator<String> <>7__wrap1; //Field offset: 0x30
		private Dictionary<String, String[]> <>7__wrap2; //Field offset: 0x38
		private string <>7__wrap3; //Field offset: 0x40
		private TaskAwaiter<GuildMemberModel[]> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadScorePanels>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardData leaderboard; //Field offset: 0x20
		public LeaderboardScreen <>4__this; //Field offset: 0x28
		public int loadId; //Field offset: 0x30
		public int selectedIndex; //Field offset: 0x34
		private List<GroupScoreModel> <groupScores>5__2; //Field offset: 0x38
		private bool <canShowMedals>5__3; //Field offset: 0x40
		private SpriteReference[] <medalSprites>5__4; //Field offset: 0x48
		private int <panelIndex>5__5; //Field offset: 0x50
		private TaskAwaiter<List`1<GroupScoreModel>> <>u__1; //Field offset: 0x58
		private TaskAwaiter<IEnumerable`1<GuildModel>> <>u__2; //Field offset: 0x60
		private TaskAwaiter <>u__3; //Field offset: 0x68
		private int <i>5__6; //Field offset: 0x70
		private GroupScoreModel <groupScore>5__7; //Field offset: 0x78
		private int <playerScoreIndex>5__8; //Field offset: 0x80
		private IEnumerator<ScoreModel> <>7__wrap8; //Field offset: 0x88
		private YieldAwaiter <>u__4; //Field offset: 0x90

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenRewardsScreenAsync>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass94_0 <>8__1; //Field offset: 0x28
		private int <requiredLeaderboardCount>5__2; //Field offset: 0x30
		private List<Task> <loadingTasks>5__3; //Field offset: 0x38
		private int <startingIndex>5__4; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x44

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshScreen>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardScreen <>4__this; //Field offset: 0x28
		private bool <hasScores>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private bool <hasPlayerPanel>5__3; //Field offset: 0x40
		private bool <hasMiniInfo>5__4; //Field offset: 0x41

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ScorePanelsLoader>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardScreen <>4__this; //Field offset: 0x20
		public int selectedIndex; //Field offset: 0x28
		public int loadId; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowScorePanelsAsync>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardScreen <>4__this; //Field offset: 0x28
		public bool forceRefresh; //Field offset: 0x30
		private int <selectedIndex>5__2; //Field offset: 0x34
		private int <currentLoadId>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button rewardsBtn; //Field offset: 0x48
	public GameObject rewardsObj; //Field offset: 0x50
	public GameObject bossHeaderGo; //Field offset: 0x58
	public GameObject raceHeaderGo; //Field offset: 0x60
	public GameObject ctHeaderGo; //Field offset: 0x68
	public GameObject competitiveCtHeaderGo; //Field offset: 0x70
	public GameObject genericHeaderGo; //Field offset: 0x78
	public GameObject scorePanelPrefab; //Field offset: 0x80
	public GameObject playerScorePanel; //Field offset: 0x88
	public LeaderboardScreenScroll scrollRect; //Field offset: 0x90
	public NK_TextMeshProUGUI rankTitleTxt; //Field offset: 0x98
	public NK_TextMeshProUGUI playerTitleTxt; //Field offset: 0xA0
	public NK_TextMeshProUGUI badgesTitleTxt; //Field offset: 0xA8
	public NK_TextMeshProUGUI bestTimeTitleTxt; //Field offset: 0xB0
	public GameObject eventTimerObj; //Field offset: 0xB8
	public NK_TextMeshProUGUI eventTimerTxt; //Field offset: 0xC0
	public NK_TextMeshProUGUI eventTimerCountdownTxt; //Field offset: 0xC8
	public GameObject mainTogglesGo; //Field offset: 0xD0
	public LeaderboardScreenToggle[] mainToggles; //Field offset: 0xD8
	public GameObject subTogglesGo; //Field offset: 0xE0
	public LeaderboardScreenToggle[] subToggles; //Field offset: 0xE8
	public GameObject joinMiniInfo; //Field offset: 0xF0
	public NK_TextMeshProUGUI joinMiniInfoTxt; //Field offset: 0xF8
	public GameObject noScoresObj; //Field offset: 0x100
	public GameObject loadingImg; //Field offset: 0x108
	public AudioClip clickSound; //Field offset: 0x110
	public AudioClip openSound; //Field offset: 0x118
	public Button refreshBtn; //Field offset: 0x120
	[SerializeField]
	private Button validateAllBtn; //Field offset: 0x128
	[SerializeField]
	private TMP_InputField replayStrInput; //Field offset: 0x130
	[SerializeField]
	private Button runReplay; //Field offset: 0x138
	private LeaderboardScreenData menuData; //Field offset: 0x140
	private readonly List<LeaderboardData> leaderboards; //Field offset: 0x148
	private readonly Dictionary<String, DateTime> leaderboardLoadTimes; //Field offset: 0x150
	private readonly TimeSpan refreshTimeout; //Field offset: 0x158
	private float updateSecondTimer; //Field offset: 0x160
	private readonly List<LeaderboardPlayerPanel> panels; //Field offset: 0x168
	private int currentLeaderboardIndex; //Field offset: 0x170
	private Task scorePanelLoadTask; //Field offset: 0x178
	private int loadId; //Field offset: 0x180
	private bool isInitializing; //Field offset: 0x184
	private bool isCtDataInitialized; //Field offset: 0x185
	private Task<CtLeaderboards> ctLeaderboardsTask; //Field offset: 0x188

	private string BestTimeTitleLocKey
	{
		private get { } //Length: 130
	}

	private BaseServerEvent EventData
	{
		private get { } //Length: 18
	}

	private bool HasRewards
	{
		private get { } //Length: 216
	}

	private bool IsBossEvent
	{
		private get { } //Length: 25
	}

	private bool IsCtEvent
	{
		private get { } //Length: 24
	}

	private bool IsEliteSelected
	{
		private get { } //Length: 18
		private set { } //Length: 21
	}

	private bool IsGenericLeaderboard
	{
		private get { } //Length: 21
	}

	private bool IsMiniSelected
	{
		private get { } //Length: 18
		private set { } //Length: 21
	}

	private bool IsRaceEvent
	{
		private get { } //Length: 22
	}

	private LeaderboardType LeaderboardType
	{
		private get { } //Length: 124
	}

	private int MainToggleIndex
	{
		private get { } //Length: 91
	}

	private Nullable<Int32> OpenAtPlayerCount
	{
		private get { } //Length: 18
		private set { } //Length: 22
	}

	private TimeSpan RandomWaitTime
	{
		private get { } //Length: 108
	}

	private int SubToggleIndex
	{
		private get { } //Length: 91
	}

	[AsyncStateMachine(typeof(<_ScorePanelsLoader>d__85))]
	private Task _ScorePanelsLoader(int selectedIndex, int loadId) { }

	public LeaderboardScreen() { }

	[CompilerGenerated]
	private void <LoadScorePanels>b__87_2() { }

	[CompilerGenerated]
	private void <LoadScorePanels>b__87_3() { }

	[CompilerGenerated]
	private void <Open>b__62_0(bool isOn) { }

	[CompilerGenerated]
	private void <Open>b__62_1(bool isOn) { }

	[CompilerGenerated]
	private bool <SetMainTogglesText>b__98_0(CtLeaderboardType x) { }

	protected virtual void Awake() { }

	private void ButtonsInteractable(bool isInteractable) { }

	private bool CanLoadMorePanels(int groupCount, int panelCount) { }

	private LeaderboardData GenerateLeaderboard(int index, Nullable<Int32> instanceId) { }

	private string get_BestTimeTitleLocKey() { }

	private BaseServerEvent get_EventData() { }

	private bool get_HasRewards() { }

	private bool get_IsBossEvent() { }

	private bool get_IsCtEvent() { }

	private bool get_IsEliteSelected() { }

	private bool get_IsGenericLeaderboard() { }

	private bool get_IsMiniSelected() { }

	private bool get_IsRaceEvent() { }

	private LeaderboardType get_LeaderboardType() { }

	private int get_MainToggleIndex() { }

	private Nullable<Int32> get_OpenAtPlayerCount() { }

	private TimeSpan get_RandomWaitTime() { }

	private int get_SubToggleIndex() { }

	[AsyncStateMachine(typeof(<GetCtLeaderboardScores>d__91))]
	private Task<List`1<GroupScoreModel>> GetCtLeaderboardScores(LeaderboardData leaderboard, CtLeaderboardType ctLeaderboardType) { }

	private int GetEnabledToggleIndex(LeaderboardScreenToggle[] toggles) { }

	private string GetMiniInfoText() { }

	private LeaderboardPlayerPanel GetScorePanel(int i) { }

	private int GetSelectedLeaderboardIndex() { }

	[AsyncStateMachine(typeof(<InitializeCtEventData>d__82))]
	private Task InitializeCtEventData() { }

	[AsyncStateMachine(typeof(<LoadLocalCtPlayerGuildIds>d__83))]
	private Task LoadLocalCtPlayerGuildIds(StatusResponse ctStatus) { }

	[AsyncStateMachine(typeof(<LoadScorePanels>d__87))]
	private Task LoadScorePanels(LeaderboardData leaderboard, int loadId, int selectedIndex) { }

	public void OnDisable() { }

	public virtual void Open(object data) { }

	public void OpenRewardsScreen() { }

	[AsyncStateMachine(typeof(<OpenRewardsScreenAsync>d__94))]
	public Task OpenRewardsScreenAsync() { }

	public virtual void ReClose() { }

	[AsyncStateMachine(typeof(<RefreshScreen>d__69))]
	private void RefreshScreen() { }

	public virtual void ReOpen(object data) { }

	[AsyncStateMachine(typeof(<ScorePanelsLoader>d__84))]
	private Task ScorePanelsLoader(int selectedIndex, int loadId) { }

	private void set_IsEliteSelected(bool value) { }

	private void set_IsMiniSelected(bool value) { }

	private void set_OpenAtPlayerCount(Nullable<Int32> value) { }

	private void SetMainTogglesText() { }

	private void SetToggleSelection() { }

	[AsyncStateMachine(typeof(<ShowScorePanelsAsync>d__81))]
	private void ShowScorePanelsAsync(bool forceRefresh = false) { }

	public void Update() { }

}

