namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class ContestedTerritoryMapScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CtTileFocus, Int32> <>9__57_0; //Field offset: 0x8
		public static Func<ContestedTerritoryTeamDetails, Boolean> <>9__69_0; //Field offset: 0x10
		public static Func<CTMapScorePanel, Int64> <>9__69_3; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <Open>b__57_0(CtTileFocus x) { }

		internal bool <UpdateTeamScores>b__69_0(ContestedTerritoryTeamDetails x) { }

		internal long <UpdateTeamScores>b__69_3(CTMapScorePanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x10
		public bool gotoSelectedTile; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal void <LoadWorld>b__0() { }

		internal void <LoadWorld>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_0
	{
		public ContestedTerritoryTeamDetails team; //Field offset: 0x10

		public <>c__DisplayClass69_0() { }

		internal bool <UpdateTeamScores>b__1(CTMapScorePanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass69_1
	{
		public string guildId; //Field offset: 0x10

		public <>c__DisplayClass69_1() { }

		internal bool <UpdateTeamScores>b__2(CTMapScorePanel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public string upperCaseCode; //Field offset: 0x10

		public <>c__DisplayClass88_0() { }

		internal bool <TileSearch>b__0(KeyValuePair<Int32, String> x) { }

	}

	[CompilerGenerated]
	private struct <GetTicketStatusAsync>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<CtApiFunctionResult`1<TicketResponse>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWorld>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x20
		public bool gotoSelectedTile; //Field offset: 0x28
		public bool isFirstLoad; //Field offset: 0x29
		private <>c__DisplayClass67_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private TaskAwaiter<ContestedTerritoryRefreshResult> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <MyTeamClickedAsync>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private bool <gotoSelectedTile>5__2; //Field offset: 0x38
		private bool <firstSync>5__3; //Field offset: 0x39
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncMapAsync>d__92 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<ContestedTerritoryRefreshResult> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryGenerateMap>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTeamScoresAsync>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<CtLeaderboards> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTeamsStoreNewPipAsync>d__94 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryMapScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static Action OnTeamTrophiesRefreshed; //Field offset: 0x0
	private static int lastSelectedTileId; //Field offset: 0x8
	public NK_TextMeshProUGUI watermarkTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI timeRemainingTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI teamTrophiesTxt; //Field offset: 0x58
	public GameObject tokensObj; //Field offset: 0x60
	public GameObject teamTokensObj; //Field offset: 0x68
	public GameObject tokenTimerObj; //Field offset: 0x70
	public NK_TextMeshProUGUI tokensTxt; //Field offset: 0x78
	public NK_TextMeshProUGUI teamTokensTxt; //Field offset: 0x80
	public NK_TextMeshProUGUI tokensRefillAtTxt; //Field offset: 0x88
	public Button tileSearchBtn; //Field offset: 0x90
	public Animator tileSearchAnimator; //Field offset: 0x98
	public TMP_InputField tileSearchInput; //Field offset: 0xA0
	public Button colourBlindBtn; //Field offset: 0xA8
	public GameObject colourBlindOnObj; //Field offset: 0xB0
	public GameObject colourBlindOffObj; //Field offset: 0xB8
	public Button scorePanelToggleBtn; //Field offset: 0xC0
	public Animator scorePanelAnimator; //Field offset: 0xC8
	public CTMapScorePanel mapScorePanelPrefab; //Field offset: 0xD0
	public Transform scorePanelParent; //Field offset: 0xD8
	public ContestedTerritoryTilePopup ctTilePopup; //Field offset: 0xE0
	public CTTeamPopup ctTeamPopup; //Field offset: 0xE8
	public GameObject ctTileSavePopup; //Field offset: 0xF0
	public Button myTeamBtn; //Field offset: 0xF8
	public Button leaderboardBtn; //Field offset: 0x100
	public Button teamStoreBtn; //Field offset: 0x108
	public Button dailyRewardsBtn; //Field offset: 0x110
	public Animator loadingAnimator; //Field offset: 0x118
	public GameObject worldParent; //Field offset: 0x120
	public AudioClip returnSound; //Field offset: 0x128
	public AudioClip popSound; //Field offset: 0x130
	public AudioClip tileSelectSound; //Field offset: 0x138
	public GameObject newPipTeamStore; //Field offset: 0x140
	public GameObject newPipMyTeam; //Field offset: 0x148
	public CTDailyRewardPopup ctDailyRewardPopup; //Field offset: 0x150
	public Image competitiveLeaderboardImg; //Field offset: 0x158
	private ContestedTerritoryWorld ctWorld; //Field offset: 0x160
	private AsyncOperationHandle<GameObject> worldSceneAssetHandle; //Field offset: 0x168
	private int mapSaveTileId; //Field offset: 0x180
	private List<CTMapScorePanel> mapScorePanels; //Field offset: 0x188
	private bool tileSearchOpen; //Field offset: 0x190
	private bool scorePanelCollapsed; //Field offset: 0x191
	private ScoreModel[] guildScores; //Field offset: 0x198
	private ContestedTerritoryIslandTile currSelectedTile; //Field offset: 0x1A0
	private bool isOpened; //Field offset: 0x1A8
	private bool isClosing; //Field offset: 0x1A9
	private List<GameObject> visibleObjs; //Field offset: 0x1B0
	private float updateSecondTimer; //Field offset: 0x1B8

	private CtEvent CtEvent
	{
		private get { } //Length: 138
	}

	private Btd6CtSettings CtSettings
	{
		private get { } //Length: 138
	}

	private StatusResponse CtStatus
	{
		private get { } //Length: 138
	}

	private Animator recapAnimator
	{
		private get { } //Length: 77
	}

	private static ContestedTerritoryMapScreen() { }

	public ContestedTerritoryMapScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	protected virtual void Awake() { }

	private void ButtonsInteractable(bool value) { }

	private void CameraRefreshAnimFinished(bool gotoSelectedTile = false) { }

	private void CheckMapSaveIsValid() { }

	public virtual void Close() { }

	private void CloseMenu() { }

	private void ConfigureDailyRewardsPopup() { }

	private void DailyRewardPopupClosed(object sender, EventArgs eventArgs) { }

	private void DetailedScorePanelOpened(object sender, EventArgs e) { }

	private CtEvent get_CtEvent() { }

	private Btd6CtSettings get_CtSettings() { }

	private StatusResponse get_CtStatus() { }

	private Animator get_recapAnimator() { }

	private ValueTuple<Int32, Int64> GetTeamPositionAndScore(string teamId) { }

	[AsyncStateMachine(typeof(<GetTicketStatusAsync>d__74))]
	private void GetTicketStatusAsync() { }

	private Vector2 GetTileCanvasPosition(int tileId) { }

	private void LeaderboardsClicked() { }

	[AsyncStateMachine(typeof(<LoadWorld>d__67))]
	private Task LoadWorld(bool isFirstLoad, bool gotoSelectedTile) { }

	private void MyTeamClicked() { }

	[AsyncStateMachine(typeof(<MyTeamClickedAsync>d__83))]
	private Task MyTeamClickedAsync() { }

	private void OnDestroy() { }

	private void OnTilePopupCloseClicked() { }

	public void OnWorldUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__57))]
	public virtual void Open(object data) { }

	private void OpenDailyRewardsPopup() { }

	public virtual bool OverrideClose() { }

	public virtual void ReClose() { }

	private void RefreshTeamTrophies() { }

	public virtual void ReOpen(object data) { }

	[AsyncStateMachine(typeof(<SyncMapAsync>d__92))]
	private void SyncMapAsync() { }

	private void TeamStoreClicked() { }

	private void TileSearch(string code) { }

	private void TileSelected(int tileIndex, bool dontTransistionToTile = false) { }

	private void TileSelected(int tileIndex) { }

	private void ToggleColourblindMode() { }

	private void ToggleScorePanel() { }

	private void ToggleTileSearch() { }

	[AsyncStateMachine(typeof(<TryGenerateMap>d__60))]
	private Task<Boolean> TryGenerateMap() { }

	private void Update() { }

	private void UpdateTeamScores(CtLeaderboards ctLeaderboards) { }

	[AsyncStateMachine(typeof(<UpdateTeamScoresAsync>d__68))]
	private void UpdateTeamScoresAsync() { }

	[AsyncStateMachine(typeof(<UpdateTeamsStoreNewPipAsync>d__94))]
	private void UpdateTeamsStoreNewPipAsync() { }

	private void UpdateTokens() { }

}

