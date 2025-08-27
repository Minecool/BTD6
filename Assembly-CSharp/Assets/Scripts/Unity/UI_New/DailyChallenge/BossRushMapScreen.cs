namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushMapScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SubmittedScore, Int32> <>9__78_1; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__78_2; //Field offset: 0x10
		public static Func<PubSubMessageModel, DateTime> <>9__94_3; //Field offset: 0x18
		public static Func<PubSubMessageModel, DateTime> <>9__94_0; //Field offset: 0x20
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"activityTime", "playerId", "avatar", "stage"}])]
		public static Func<ValueTuple`4<DateTime, String, String, Int32>, DateTime> <>9__94_6; //Field offset: 0x28
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"activityTime", "playerId", "avatar", "stage"}])]
		public static Func<ValueTuple`4<DateTime, String, String, Int32>, String> <>9__94_7; //Field offset: 0x30
		public static Func<GuildMessage, Boolean> <>9__101_0; //Field offset: 0x38
		public static Func<GuildMessage, DateTime> <>9__101_1; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal bool <CheckForNewScores>b__101_0(GuildMessage x) { }

		internal DateTime <CheckForNewScores>b__101_1(GuildMessage x) { }

		internal DateTime <RefreshTeamActivity>b__94_0(PubSubMessageModel x) { }

		internal DateTime <RefreshTeamActivity>b__94_3(PubSubMessageModel x) { }

		internal DateTime <RefreshTeamActivity>b__94_6(ValueTuple<DateTime, String, String, Int32> x) { }

		internal string <RefreshTeamActivity>b__94_7(ValueTuple<DateTime, String, String, Int32> x) { }

		internal int <SelectTile>b__78_1(SubmittedScore submittedScore) { }

		internal int <SelectTile>b__78_2(int score) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public int index; //Field offset: 0x10
		public int daysSinceEventStart; //Field offset: 0x14

		public <>c__DisplayClass78_0() { }

		internal bool <SelectTile>b__0(SubmittedScore submittedScore) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public DateTime timeFilter; //Field offset: 0x10
		public BossRushMapScreen <>4__this; //Field offset: 0x18
		public TimeSpan activityTimeFilter; //Field offset: 0x20
		public DateTime now; //Field offset: 0x28

		public <>c__DisplayClass94_0() { }

		internal bool <RefreshTeamActivity>b__1(ValueTuple<DateTime, String, String, Int32> x) { }

		internal bool <RefreshTeamActivity>b__2(PubSubMessageModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_1
	{
		public string playerId; //Field offset: 0x10
		public <>c__DisplayClass94_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass94_1() { }

		internal bool <RefreshTeamActivity>b__4(ValueTuple<DateTime, String, String, Int32> x) { }

		internal bool <RefreshTeamActivity>b__5(ValueTuple<DateTime, String, String, Int32> x) { }

	}

	[CompilerGenerated]
	private struct <AutoSelectFirstTileAsync>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TimeSpan selectAfter; //Field offset: 0x28
		public BossRushMapScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BossDefeatedSequence>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		public int defeatedBossIndex; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckAndOpenTeamScreen>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckForActivity>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		private Nullable<TimeSpan> <checkInterval>5__2; //Field offset: 0x28
		private TimeSpan <activityTimeFilter>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckForNewScores>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		private GuildMessage <mostRecentTeamBossRushMessage>5__2; //Field offset: 0x28
		private GuildMessageBossRushEvent <guildMessageBossRushEvent>5__3; //Field offset: 0x30
		private TaskAwaiter<IEnumerable`1<GuildMessage>> <>u__1; //Field offset: 0x38
		private Nullable<UInt64> <previousLatestTeamScoreId>5__4; //Field offset: 0x40
		private YieldAwaiter <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClaimPendingTeamTrophiesAsync>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public BossRushMapScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<BossRushTeamTrophyClaimResponse> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBossRushPlayerAttack>d__95 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushPlayerAttack> <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		public int index; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x2C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetEventData>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		private BossRushSaveData <currentBossRushEventData>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"hasInternetIssues", "isNewEvent"}])]
		private TaskAwaiter<ValueTuple`2<Boolean, Boolean>> <>u__2; //Field offset: 0x38
		private TaskAwaiter<BossRushStatusResponse> <>u__3; //Field offset: 0x40
		private TaskAwaiter<BossRushPlayerScoresResponse> <>u__4; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <HideUiAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitializeBossRushPlayerAttacks>d__96 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		private int <maxActivityCount>5__2; //Field offset: 0x28
		private int <i>5__3; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshTeamActivity>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		public TimeSpan activityTimeFilter; //Field offset: 0x28
		private <>c__DisplayClass94_0 <>8__1; //Field offset: 0x30
		private int <maxActivityCount>5__2; //Field offset: 0x38
		private TaskAwaiter<PubSubChannelModel> <>u__1; //Field offset: 0x40
		private Dictionary<String, String> <appropriateDisplayNames>5__3; //Field offset: 0x48
		private TaskAwaiter<Dictionary`2<String, String>> <>u__2; //Field offset: 0x50
		private int <i>5__4; //Field offset: 0x58
		private TaskAwaiter<BossRushPlayerAttack> <>u__3; //Field offset: 0x60
		private TaskAwaiter <>u__4; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshTeamTrophyBalanceAsync>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x28
		public bool forceRefresh; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshUI>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		public bool isFirstLoad; //Field offset: 0x28
		private bool <hasPendingRewards>5__2; //Field offset: 0x29
		private bool <hasPendingCompletedStages>5__3; //Field offset: 0x2A
		private int <initialTileIndex>5__4; //Field offset: 0x2C
		private Nullable<BossType> <initialBoss>5__5; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunPendingBossDefeatedSequences>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowUiAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushMapScreen <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnBossModelSelected : MulticastDelegate
	{

		public OnBossModelSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnTileSelected : MulticastDelegate
	{

		public OnTileSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int index, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int index) { }

	}

	[CompilerGenerated]
	private static long <LatestPubSubMessageSeenTimestamp>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private GameObject eventCompleteBanner; //Field offset: 0x48
	[SerializeField]
	private GameObject titleTextContainer; //Field offset: 0x50
	[SerializeField]
	private TextMeshProUGUI stageTitleTxt; //Field offset: 0x58
	[SerializeField]
	private Button myTeamBtn; //Field offset: 0x60
	[SerializeField]
	private Button teamStoreBtn; //Field offset: 0x68
	[SerializeField]
	private GameObject healthBar; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI healthBarTxt; //Field offset: 0x78
	[SerializeField]
	private Image healthBarImg; //Field offset: 0x80
	[SerializeField]
	private BossRushTileSelectionPanel selectionPopup; //Field offset: 0x88
	[SerializeField]
	private float selectionPopupOffset; //Field offset: 0x90
	[SerializeField]
	private Button closeSelectionBtn; //Field offset: 0x98
	[SerializeField]
	private GameObject teamStatsObj; //Field offset: 0xA0
	[SerializeField]
	private GameObject eventTimer; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI timeRemainingTxt; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI teamTrophiesTxt; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI availableTicketsText; //Field offset: 0xC0
	[SerializeField]
	private GameObject ticketRefilTimerContainer; //Field offset: 0xC8
	[SerializeField]
	private TextMeshProUGUI ticketRefilTimerText; //Field offset: 0xD0
	[SerializeField]
	private GameObject availableTicketsObj; //Field offset: 0xD8
	[SerializeField]
	private BossRushStageCompletePanel bossRushStageCompletePanel; //Field offset: 0xE0
	[SerializeField]
	private Animator loadingAnimator; //Field offset: 0xE8
	[SerializeField]
	private Animator healthLossAnimator; //Field offset: 0xF0
	[SerializeField]
	private GameObject playerAttackTemplate; //Field offset: 0xF8
	[SerializeField]
	private Transform[] playerAttackPositions; //Field offset: 0x100
	[SerializeField]
	private Transform playerAttacksContainer; //Field offset: 0x108
	[SerializeField]
	private BossRushNewScoreInfo newScoreInfoPanel; //Field offset: 0x110
	[SerializeField]
	private BossRushWorld bossRushWorld; //Field offset: 0x118
	private BossRushEvent bossRushEvent; //Field offset: 0x120
	private BossRushSettings bossRushSettings; //Field offset: 0x128
	private BossRushPlayerStatus bossRushPlayerStatus; //Field offset: 0x130
	private BossRushTileRules bossRushTileRules; //Field offset: 0x138
	private bool isInitialized; //Field offset: 0x140
	private int currentActiveTileIndex; //Field offset: 0x144
	private int currentTileDamage; //Field offset: 0x148
	private int stageCount; //Field offset: 0x14C
	private Nullable<UInt64> latestTeamScoreId; //Field offset: 0x150
	private int selectedTileIndex; //Field offset: 0x160
	private bool isEventWon; //Field offset: 0x164
	private Task bossRuskPlayerAttackInitTask; //Field offset: 0x168
	[CompilerGenerated]
	private bool <IsRefreshingUi>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private bool <IsShowingUi>k__BackingField; //Field offset: 0x171
	[CompilerGenerated]
	private Task <UiAnimationTask>k__BackingField; //Field offset: 0x178
	private bool hasSelectedTile; //Field offset: 0x180
	private int availableTickets; //Field offset: 0x184
	private Nullable<DateTime> nextTicketRefilTime; //Field offset: 0x188
	private Nullable<DateTime> lastActivitySeenAt; //Field offset: 0x198
	[CompilerGenerated]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"activityTime", "playerId", "avatar", "stage"}])]
	private List<ValueTuple`4<DateTime, String, String, Int32>> <RecentActivity>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private readonly List<BossRushPlayerAttack> <BossRushPlayerAttacks>k__BackingField; //Field offset: 0x1B0

	private List<BossRushPlayerAttack> BossRushPlayerAttacks
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	private BossRushSaveData BossRushSaveData
	{
		private get { } //Length: 48
	}

	private bool IsRefreshingUi
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsShowingUi
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private static long LatestPubSubMessageSeenTimestamp
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 60
	}

	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"activityTime", "playerId", "avatar", "stage"}])]
	private List<ValueTuple`4<DateTime, String, String, Int32>> RecentActivity
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private Task UiAnimationTask
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public BossRushMapScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[AsyncStateMachine(typeof(<AutoSelectFirstTileAsync>d__66))]
	private void AutoSelectFirstTileAsync(TimeSpan selectAfter) { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<BossDefeatedSequence>d__60))]
	private Task BossDefeatedSequence(int defeatedBossIndex) { }

	private void BossModelClicked() { }

	[AsyncStateMachine(typeof(<CheckAndOpenTeamScreen>d__83))]
	private Task CheckAndOpenTeamScreen() { }

	private void CheckAndOpenTeamScreenAsync() { }

	[AsyncStateMachine(typeof(<CheckForActivity>d__85))]
	private Task CheckForActivity() { }

	[AsyncStateMachine(typeof(<CheckForNewScores>d__101))]
	private Task CheckForNewScores() { }

	[AsyncStateMachine(typeof(<ClaimPendingTeamTrophiesAsync>d__68))]
	private Task ClaimPendingTeamTrophiesAsync(string eventId) { }

	private void ClearPlayerActivity() { }

	public virtual void Close() { }

	private void CloseSelectionPopup() { }

	[CompilerGenerated]
	private List<BossRushPlayerAttack> get_BossRushPlayerAttacks() { }

	private BossRushSaveData get_BossRushSaveData() { }

	[CompilerGenerated]
	private bool get_IsRefreshingUi() { }

	[CompilerGenerated]
	private bool get_IsShowingUi() { }

	[CompilerGenerated]
	public static long get_LatestPubSubMessageSeenTimestamp() { }

	[CompilerGenerated]
	private List<ValueTuple`4<DateTime, String, String, Int32>> get_RecentActivity() { }

	[CompilerGenerated]
	private Task get_UiAnimationTask() { }

	[AsyncStateMachine(typeof(<GetBossRushPlayerAttack>d__95))]
	private Task<BossRushPlayerAttack> GetBossRushPlayerAttack(int index) { }

	[AsyncStateMachine(typeof(<GetEventData>d__80))]
	private Task GetEventData() { }

	private ValueTuple<Int32, Nullable`1<DateTime>> GetTicketStatus() { }

	private Vector2 GetTileCanvasPosition(int tileId) { }

	private TileCompletionState GetTileState(int index) { }

	[AsyncStateMachine(typeof(<HideUiAsync>d__58))]
	private void HideUiAsync() { }

	[AsyncStateMachine(typeof(<InitializeBossRushPlayerAttacks>d__96))]
	private Task InitializeBossRushPlayerAttacks() { }

	[AsyncStateMachine(typeof(<Open>d__54))]
	public virtual void Open(object data) { }

	[AsyncStateMachine(typeof(<RefreshTeamActivity>d__94))]
	private Task RefreshTeamActivity(TimeSpan activityTimeFilter) { }

	[AsyncStateMachine(typeof(<RefreshTeamTrophyBalanceAsync>d__81))]
	private void RefreshTeamTrophyBalanceAsync(bool forceRefresh) { }

	[AsyncStateMachine(typeof(<RefreshUI>d__64))]
	private Task RefreshUI(bool isFirstLoad) { }

	public virtual void ReOpen(object data) { }

	[AsyncStateMachine(typeof(<RunPendingBossDefeatedSequences>d__59))]
	private Task RunPendingBossDefeatedSequences() { }

	private void SelectTile(int index) { }

	[CompilerGenerated]
	private void set_IsRefreshingUi(bool value) { }

	[CompilerGenerated]
	private void set_IsShowingUi(bool value) { }

	[CompilerGenerated]
	private static void set_LatestPubSubMessageSeenTimestamp(long value) { }

	[CompilerGenerated]
	private void set_RecentActivity(List<ValueTuple`4<DateTime, String, String, Int32>> value) { }

	[CompilerGenerated]
	private void set_UiAnimationTask(Task value) { }

	private void SetSelectionPopupPosition() { }

	private void SetupHealthBar(int damageDone, int damageGoal) { }

	[AsyncStateMachine(typeof(<ShowUiAsync>d__57))]
	private void ShowUiAsync() { }

	private void TeamStoreClicked() { }

	private void Update() { }

	private void UpdateEventTimer() { }

	private void UpdateTicketStatus() { }

}

