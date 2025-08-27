namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class TeamEventTitleScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__69_0; //Field offset: 0x8
		public static ReturnCallback <>9__72_0; //Field offset: 0x10
		public static ReturnCallback <>9__74_0; //Field offset: 0x18
		public static ReturnCallback <>9__77_0; //Field offset: 0x20
		public static ReturnCallback <>9__79_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal void <LeaderboardsClickedAsync>b__77_0() { }

		internal void <MyTeamClickedAsync>b__74_0() { }

		internal void <PlayBossRushClickedAsync>b__72_0() { }

		internal void <PlayCTClickedAsync>b__69_0() { }

		internal void <TeamStoreClickedAsync>b__79_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		public TeamEventTitleScreen <>4__this; //Field offset: 0x10
		public bool forceShowCompetitivePanel; //Field offset: 0x18

		public <>c__DisplayClass73_0() { }

		internal Task <MyTeamClicked>b__0() { }

	}

	[CompilerGenerated]
	private struct <BossRushInfoOpenAsync>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckForEventStartedEnded>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		public CtEvent activeCtEvent; //Field offset: 0x28
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"hasInternetIssues", "isNewEvent"}])]
		private TaskAwaiter<ValueTuple`2<Boolean, Boolean>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EnablePlayBtnTicketPipAsync>d__51 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Task<Boolean> canUseTicketTask; //Field offset: 0x28
		public TeamEventTitleScreen <>4__this; //Field offset: 0x30
		public GameObject playBtnTicketPip; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LeaderboardsClickedAsync>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private CtEvent <ctEvent>5__2; //Field offset: 0x28
		private Nullable<Int32> <instanceId>5__3; //Field offset: 0x30
		private LeaderboardType <ctLeaderboardType>5__4; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private TaskAwaiter<CompetitiveResponse> <>u__2; //Field offset: 0x48
		private TaskAwaiter<Btd6CtSettings> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWorld>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private ContestedTerritoryData <ctData>5__2; //Field offset: 0x28
		private EventName <currentSkinEvent>5__3; //Field offset: 0x30
		private BossRushEvent <activeBossRushEvent>5__4; //Field offset: 0x38
		private BossRushTileRules <bossRushTileRules>5__5; //Field offset: 0x40
		private BossType <activeBossType>5__6; //Field offset: 0x48
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter<BossRushSettings> <>u__3; //Field offset: 0x60
		private TaskAwaiter<BossRushStatusResponse> <>u__4; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MyTeamClickedAsync>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		public bool forceShowCompetitivePanel; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38
		private TaskAwaiter <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayBossRushClickedAsync>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayCTClickedAsync>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshTeamTrophyBalanceAsync>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshUi>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private CtEvent <currOrNextCTEvent>5__2; //Field offset: 0x28
		private bool <isCurrentCTEvent>5__3; //Field offset: 0x30
		private bool <isCurrentRushEvent>5__4; //Field offset: 0x31
		private string <competitiveStatusEventId>5__5; //Field offset: 0x38
		private GuildCompetitiveStatus <guildCompetitiveStatus>5__6; //Field offset: 0x40
		private Btd6CtSettings <ctSettings>5__7; //Field offset: 0x48
		private string <ctSettingsId>5__8; //Field offset: 0x50
		private BossRushEvent <currentBossRushEvent>5__9; //Field offset: 0x58
		private TaskAwaiter<CtEvent> <>u__1; //Field offset: 0x60
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x68
		private TaskAwaiter<CompetitiveResponse> <>u__3; //Field offset: 0x70
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"hasInternetIssues", "isNewEvent"}])]
		private TaskAwaiter<ValueTuple`2<Boolean, Boolean>> <>u__4; //Field offset: 0x78
		private Nullable<CompetitiveStatus> <competitiveStatus>5__10; //Field offset: 0x80
		private CtEventStatus <ctEventStatus>5__11; //Field offset: 0x82
		private TaskAwaiter<CtEventStatus> <>u__5; //Field offset: 0x88
		private TaskAwaiter<Btd6CtSettings> <>u__6; //Field offset: 0x90
		private TaskAwaiter <>u__7; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshWorldCosmetics>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ReOpen>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TeamStoreClickedAsync>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTeamsStoreNewPipAsync>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TeamEventTitleScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int cloudCloseAnimationMs = 1000; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsPendingCompetitiveStatusRefresh>k__BackingField; //Field offset: 0x0
	public NK_TextMeshProUGUI timerPrefixTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI timeRemainingTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI eventEndedTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI teamTrophiesTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI teamButtonTxt; //Field offset: 0x68
	public Button playCtBtn; //Field offset: 0x70
	public Button myTeamBtn; //Field offset: 0x78
	public Button leaderboardBtn; //Field offset: 0x80
	public GameObject leaderboardBtnObj; //Field offset: 0x88
	public Button teamStoreBtn; //Field offset: 0x90
	public GameObject invitationsPip; //Field offset: 0x98
	public Button infoOpenBtn; //Field offset: 0xA0
	public GameObject infoPanel; //Field offset: 0xA8
	public Lightbox infoBackgroundCloseBtn; //Field offset: 0xB0
	public Button infoOkBtn; //Field offset: 0xB8
	public Animator infoAnimator; //Field offset: 0xC0
	[SerializeField]
	private GameObject bossRushInfoPanel; //Field offset: 0xC8
	[SerializeField]
	private Button bossRushInfoOpenBtn; //Field offset: 0xD0
	[SerializeField]
	private Button bossRushInfoCloseBtn; //Field offset: 0xD8
	[SerializeField]
	private Lightbox bossRushInfoCloseBGBtn; //Field offset: 0xE0
	public AudioClip click2Sound; //Field offset: 0xE8
	public Animator loadingAnimator; //Field offset: 0xF0
	public GameObject newPipTeamStore; //Field offset: 0xF8
	public GameObject newPipMyTeam; //Field offset: 0x100
	public GameObject worldParent; //Field offset: 0x108
	public GameObject ctTicketsTicketPip; //Field offset: 0x110
	public GameObject bossRushTicketPip; //Field offset: 0x118
	public GameObject competitiveModeSignUpObj; //Field offset: 0x120
	public Button competitiveModeSignUpBtn; //Field offset: 0x128
	public GameObject competitiveModeSignedUpObj; //Field offset: 0x130
	public NK_TextMeshProUGUI compModeTimeLeft; //Field offset: 0x138
	public GameObject[] competitiveModePips; //Field offset: 0x140
	public GameObject compModePopup; //Field offset: 0x148
	public Button compModePopupSignUpBtn; //Field offset: 0x150
	public Button compModePopupCloseBtn; //Field offset: 0x158
	public Lightbox compModePopupBackgroundCloseBtn; //Field offset: 0x160
	public NK_TextMeshProUGUI compModeTimeDisclaimer; //Field offset: 0x168
	private GameObject gameWorld; //Field offset: 0x170
	private CTBaseIsland baseIsland; //Field offset: 0x178
	private AsyncOperationHandle<GameObject> worldSceneAssetHandle; //Field offset: 0x180
	[SerializeField]
	private GameObject ctBannerObj; //Field offset: 0x198
	[SerializeField]
	private Button playBossRushBtn; //Field offset: 0x1A0
	[SerializeField]
	private GameObject bossRushBannerObj; //Field offset: 0x1A8
	[SerializeField]
	private GameObject teamEventsBannerObj; //Field offset: 0x1B0
	[SerializeField]
	private GameObject playButtonContainer; //Field offset: 0x1B8
	private bool isCheckingForEventStart; //Field offset: 0x1C0
	private Task<CompetitiveResponse> guildCompetitiveStatusTask; //Field offset: 0x1C8
	private bool isRefreshingUi; //Field offset: 0x1D0
	private bool isFirstRefreshFinished; //Field offset: 0x1D1

	public static bool IsPendingCompetitiveStatusRefresh
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		 set { } //Length: 59
	}

	public TeamEventTitleScreen() { }

	[CompilerGenerated]
	private void <Awake>b__45_0() { }

	[CompilerGenerated]
	private void <Awake>b__45_1() { }

	protected virtual void Awake() { }

	private void BossRushInfoClose() { }

	[AsyncStateMachine(typeof(<BossRushInfoOpenAsync>d__84))]
	private void BossRushInfoOpenAsync() { }

	private void ButtonsInteractable(bool value) { }

	[AsyncStateMachine(typeof(<CheckForEventStartedEnded>d__50))]
	private Task CheckForEventStartedEnded(CtEvent activeCtEvent) { }

	public virtual void Close() { }

	private void CloseCompModePopup() { }

	[AsyncStateMachine(typeof(<EnablePlayBtnTicketPipAsync>d__51))]
	private void EnablePlayBtnTicketPipAsync(GameObject playBtnTicketPip, Task<Boolean> canUseTicketTask) { }

	[CompilerGenerated]
	public static bool get_IsPendingCompetitiveStatusRefresh() { }

	private void InfoClose() { }

	private void InfoOpenClicked() { }

	private static bool IsMyPlayerId(string playerId) { }

	private void LeaderboardsClicked() { }

	[AsyncStateMachine(typeof(<LeaderboardsClickedAsync>d__77))]
	public Task LeaderboardsClickedAsync() { }

	[AsyncStateMachine(typeof(<LoadWorld>d__57))]
	private Task LoadWorld() { }

	private void MyTeamClicked(bool forceShowCompetitivePanel = false) { }

	[AsyncStateMachine(typeof(<MyTeamClickedAsync>d__74))]
	private Task MyTeamClickedAsync(bool forceShowCompetitivePanel) { }

	private void NavigateToCorrectTeamsScreen(bool forceShowCompetitivePanel = false) { }

	private void OnDestroy() { }

	[AsyncStateMachine(typeof(<Open>d__48))]
	public virtual void Open(object data) { }

	private void OpenCompModePopup() { }

	public virtual bool OverrideClose() { }

	private void PlayBossRushClicked() { }

	[AsyncStateMachine(typeof(<PlayBossRushClickedAsync>d__72))]
	private Task PlayBossRushClickedAsync() { }

	private void PlayCTClicked() { }

	[AsyncStateMachine(typeof(<PlayCTClickedAsync>d__69))]
	private Task PlayCTClickedAsync() { }

	public virtual void ReClose() { }

	[AsyncStateMachine(typeof(<RefreshTeamTrophyBalanceAsync>d__52))]
	private void RefreshTeamTrophyBalanceAsync() { }

	[AsyncStateMachine(typeof(<RefreshUi>d__65))]
	private Task RefreshUi() { }

	[AsyncStateMachine(typeof(<RefreshWorldCosmetics>d__58))]
	private Task RefreshWorldCosmetics() { }

	[AsyncStateMachine(typeof(<ReOpen>d__53))]
	public virtual void ReOpen(object data) { }

	[CompilerGenerated]
	public static void set_IsPendingCompetitiveStatusRefresh(bool value) { }

	private void TeamStoreClicked() { }

	[AsyncStateMachine(typeof(<TeamStoreClickedAsync>d__79))]
	private Task TeamStoreClickedAsync() { }

	[AsyncStateMachine(typeof(<UpdateTeamsStoreNewPipAsync>d__86))]
	private void UpdateTeamsStoreNewPipAsync() { }

}

