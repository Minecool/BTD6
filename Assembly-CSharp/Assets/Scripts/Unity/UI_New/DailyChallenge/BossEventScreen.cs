namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossEventScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BossEvent, DateTime> <>9__101_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <Open>b__101_1(BossEvent endedEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass132_0
	{
		public BossType bossType; //Field offset: 0x10
		public BossEventScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass132_0() { }

		internal void <LoadBossBackground>b__0(AsyncOperationHandle<GameObject> h) { }

		internal void <LoadBossBackground>b__1(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <AsyncCoopChallengeClicked>d__105 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEventScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPreviousEventRewards>d__114 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEventScreen <>4__this; //Field offset: 0x20
		private BossEvent <bossPendingRewards>5__2; //Field offset: 0x28
		private TaskAwaiter<BossEvent> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__101 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object data; //Field offset: 0x28
		public BossEventScreen <>4__this; //Field offset: 0x30
		private BossEvent <menuBossEventData>5__2; //Field offset: 0x38
		private bool <ignoreFirstTimePopup>5__3; //Field offset: 0x40
		private TaskAwaiter<ValueTuple`2<BossEvent, BossDataModel>> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetupBossEvent>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEvent bossEvent; //Field offset: 0x20
		public BossEventScreen <>4__this; //Field offset: 0x28
		public bool ignoreFirstTimePopup; //Field offset: 0x30
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryGetActiveBossEvent>d__160 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ValueTuple`2<BossEvent, BossDataModel>> <>t__builder; //Field offset: 0x8
		private BossEvent <bossEvent>5__2; //Field offset: 0x20
		private TaskAwaiter<BossDataModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class BossBackgroundChangeEvent : MulticastDelegate
	{

		public BossBackgroundChangeEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(BossType boss, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(BossType boss) { }

	}

	public const string bossChallengeEventID = "BossChallenge"; //Field offset: 0x0
	public Transform worldParent; //Field offset: 0x48
	public Animator titleAnimator; //Field offset: 0x50
	public Animator doorAnimator; //Field offset: 0x58
	public Transform titleParent; //Field offset: 0x60
	public TMP_Text timeRemainingTxt; //Field offset: 0x68
	public Button bossInfoOpenBtn; //Field offset: 0x70
	public Button bossChallengeInfoOpenBtn; //Field offset: 0x78
	public Button leaderboardBtn; //Field offset: 0x80
	public Toggle rankedToggle; //Field offset: 0x88
	public Image normalTogImg; //Field offset: 0x90
	public TMP_Text normalTogTxt; //Field offset: 0x98
	public Toggle eliteTog; //Field offset: 0xA0
	public Toggle normalTog; //Field offset: 0xA8
	public Image eliteTogImg; //Field offset: 0xB0
	public TMP_Text eliteTogTxt; //Field offset: 0xB8
	public GameObject eliteLockedPanel; //Field offset: 0xC0
	public Animator eliteUnlockedAnim; //Field offset: 0xC8
	public GameObject startBossEventBtnDisabled; //Field offset: 0xD0
	public Button startBossEventBtn; //Field offset: 0xD8
	public TMP_Text startBossEventBtnTxt; //Field offset: 0xE0
	public GameObject bossInfoPanel; //Field offset: 0xE8
	public Lightbox bossInfoBackgroundCloseBtn; //Field offset: 0xF0
	public TMP_Text bossInfoNameTxt; //Field offset: 0xF8
	public Image bossInfoIconImg; //Field offset: 0x100
	public TMP_Text bossInfoDescTxt; //Field offset: 0x108
	public Button bossInfoOkBtn; //Field offset: 0x110
	public Animator bossInfoAnimator; //Field offset: 0x118
	public GameObject challengeInfoPanel; //Field offset: 0x120
	public Animator challengeInfoAnimator; //Field offset: 0x128
	public Lightbox challengeInfoBackgroundCloseBtn; //Field offset: 0x130
	public Button challengeInfoOkBtn; //Field offset: 0x138
	public AudioClip click2Sound; //Field offset: 0x140
	public BossEvent bossEvent; //Field offset: 0x148
	private BossDataModel bossDataModel; //Field offset: 0x150
	private AsyncOperationHandle<GameObject> worldSceneAssetHandle; //Field offset: 0x158
	private Animator worldAnimator; //Field offset: 0x170
	private bool screenReady; //Field offset: 0x178
	public Nullable<DateTime> nextBossEventStartDate; //Field offset: 0x180
	public Button bossChallengeBtn; //Field offset: 0x190
	public Button bossEventBtn; //Field offset: 0x198
	public Image bossEventBtnImage; //Field offset: 0x1A0
	public GameObject bossEventCountdownObj; //Field offset: 0x1A8
	public TextMeshProUGUI bossEventCountdown; //Field offset: 0x1B0
	public GameObject savedGameObj; //Field offset: 0x1B8
	public Button savedGameBtn; //Field offset: 0x1C0
	public NK_TextMeshProUGUI savedGameMapTxt; //Field offset: 0x1C8
	public NK_TextMeshProUGUI savedGameRoundTxt; //Field offset: 0x1D0
	public NK_TextMeshProUGUI savedGameEliteTxt; //Field offset: 0x1D8
	public Button selectMapBtn; //Field offset: 0x1E0
	public BossSelectPanel bossSelectPanel; //Field offset: 0x1E8
	public MapSelectPanel mapSelectPanel; //Field offset: 0x1F0
	public Image selectedMapDisplay; //Field offset: 0x1F8
	public NK_TextMeshProUGUI mapName; //Field offset: 0x200
	public GameObject recordsOffObj; //Field offset: 0x208
	public GameObject bossDefeatedObj; //Field offset: 0x210
	public GameObject bossNotDefeatedObj; //Field offset: 0x218
	public GameObject recordsObj; //Field offset: 0x220
	public Toggle leastCashTog; //Field offset: 0x228
	public Toggle leastTiersTog; //Field offset: 0x230
	public Toggle gameTimeTog; //Field offset: 0x238
	public NK_TextMeshProUGUI bossTierRecord; //Field offset: 0x240
	public NK_TextMeshProUGUI timeRecord; //Field offset: 0x248
	public NK_TextMeshProUGUI cashRecord; //Field offset: 0x250
	public NK_TextMeshProUGUI tiersRecord; //Field offset: 0x258
	public Image playerIconBossTiers; //Field offset: 0x260
	public Image playerIconTime; //Field offset: 0x268
	public Image playerIconCash; //Field offset: 0x270
	public Image playerIconTiers; //Field offset: 0x278
	public SpriteReference[] playerIcons; //Field offset: 0x280
	private string selectedMapID; //Field offset: 0x288
	private BossType challengeBossType; //Field offset: 0x290
	[HideInInspector]
	public BossType eventBossType; //Field offset: 0x294
	private readonly List<String> currentRecordsCategories; //Field offset: 0x298
	public Button coopBossChallengeBtn; //Field offset: 0x2A0
	public GameObject coopBossChallengeObj; //Field offset: 0x2A8
	public Button selectBoss; //Field offset: 0x2B0
	public Button startBossChallenge; //Field offset: 0x2B8
	public Button loadBossChallenge; //Field offset: 0x2C0
	public TMP_Dropdown recordCategoryDropdown; //Field offset: 0x2C8
	private BossScoreComponents[] allBossChallengeRecords; //Field offset: 0x2D0
	public Toggle recordsToggle; //Field offset: 0x2D8
	public GameObject bossSelectScreen; //Field offset: 0x2E0
	public GameObject mapSelectScreen; //Field offset: 0x2E8
	public GameObject bossChallengeObj; //Field offset: 0x2F0
	private MapSaveDataModel selectedChallengeSave; //Field offset: 0x2F8
	private bool willOverwriteSave; //Field offset: 0x300
	private bool inTransitionAnimation; //Field offset: 0x301
	private Nullable<BossType> worldBossType; //Field offset: 0x304

	private BossType BossType
	{
		private get { } //Length: 29
	}

	private DailyChallengeModel EliteDcm
	{
		private get { } //Length: 30
	}

	private bool IsEliteSelected
	{
		private get { } //Length: 81
		private set { } //Length: 86
	}

	private bool IsEndingSoon
	{
		private get { } //Length: 87
	}

	private bool IsRankedSelected
	{
		private get { } //Length: 81
		private set { } //Length: 86
	}

	private DailyChallengeModel NormalDcm
	{
		private get { } //Length: 30
	}

	public BossEventScreen() { }

	[CompilerGenerated]
	private void <BossEventClicked>b__106_0() { }

	[CompilerGenerated]
	private void <BossModeTransitionEnd>b__108_0() { }

	[CompilerGenerated]
	private void <Open>b__101_0() { }

	[CompilerGenerated]
	private void <ReOpen>b__100_0() { }

	[AsyncStateMachine(typeof(<AsyncCoopChallengeClicked>d__105))]
	private Task AsyncCoopChallengeClicked() { }

	protected virtual void Awake() { }

	private void BossChallengeClicked() { }

	private void BossChallengeInfoOpenClicked() { }

	private void BossEventClicked() { }

	private void BossInfoClose() { }

	private void BossInfoOpenClicked() { }

	private void BossModeTransitionEnd() { }

	private void BossModeTransitionStart(Action callback) { }

	public void ButtonsInteractable(bool interactable) { }

	private void ClearBossVisuals() { }

	public virtual void Close() { }

	private void CoopChallengeClicked() { }

	private void DisplayBossChallengeRecords(string displayCategory) { }

	private void EliteTogPointerDown(BaseEventData eventData) { }

	private void EliteTogPointerUp(BaseEventData eventData) { }

	private void EnterSelectionPanelUI(bool openPanel) { }

	private DailyChallengeModel GenerateChallengeDCM() { }

	private BossType get_BossType() { }

	private DailyChallengeModel get_EliteDcm() { }

	private bool get_IsEliteSelected() { }

	private bool get_IsEndingSoon() { }

	private bool get_IsRankedSelected() { }

	private DailyChallengeModel get_NormalDcm() { }

	private void GetBossChallengeRecords() { }

	private void GetChallengeSave(bool ignoreMap = false) { }

	public LeaderboardScoringType GetScoringType() { }

	private void LeaderboardClicked() { }

	private void LoadBossBackground(BossType bossType) { }

	private void LoadClicked() { }

	[AsyncStateMachine(typeof(<LoadPreviousEventRewards>d__114))]
	private Task LoadPreviousEventRewards() { }

	private void MapSelectClicked() { }

	public void OnDisable() { }

	private void OnEliteModeToggled(bool isElite) { }

	public void OnEnable() { }

	private void OnRankedToggled(bool isRanked) { }

	private void OnRecordsToggled(bool value) { }

	[AsyncStateMachine(typeof(<Open>d__101))]
	public virtual void Open(object data) { }

	private void OpenBossSelect() { }

	private void OpenPlayPanel() { }

	public virtual bool OverrideClose() { }

	private void RecieveMapInfo(string mapID) { }

	public virtual void ReClose() { }

	private void RecordsDropdownChanged(int selection) { }

	public virtual void ReOpen(object data) { }

	private void ScoringTypeChanged(bool _) { }

	private void SelectBoss(BossType bossType) { }

	private void set_IsEliteSelected(bool value) { }

	private void set_IsRankedSelected(bool value) { }

	private void SetEliteAndRankedSettings(BossEventData bossEventData) { }

	private void SetEliteMode(bool isElite) { }

	private void SetMapDisplay() { }

	private void SetRankedMode(bool isRanked) { }

	private void SetSavedGameButtons() { }

	private void SetScoreFields(int bossTier, int cash, int leastTiers, TimeSpan time) { }

	private void SetupBossChallenge() { }

	[AsyncStateMachine(typeof(<SetupBossEvent>d__111))]
	private Task SetupBossEvent(BossEvent bossEvent, bool ignoreFirstTimePopup) { }

	private void SetupSavedGame() { }

	public void ShowInternetPopup() { }

	private void StartChallengeClicked() { }

	private void StartChallengeGame() { }

	private void ToggleEventSpecificUI(bool isEventMode) { }

	private void TogglePlayerCountIcons(bool isOn) { }

	[AsyncStateMachine(typeof(<TryGetActiveBossEvent>d__160))]
	private static Task<ValueTuple`2<BossEvent, BossDataModel>> TryGetActiveBossEvent() { }

	private void Update() { }

}

