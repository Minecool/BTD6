namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class RaceEventScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public ChallengeModifierData mod; //Field offset: 0x10
		public GameObject newModifierObj; //Field offset: 0x40
		public RaceEventScreen <>4__this; //Field offset: 0x48

		public <>c__DisplayClass59_0() { }

		internal void <ShowModIcons>b__0(BaseEventData _) { }

	}

	[CompilerGenerated]
	private struct <CheckOnlineThenStartNewGame>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceEventScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GoToLeaderboardAsync>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceEventScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<LeaderboardReward[][]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPreviousEventRewards>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceEventScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<RaceEvent> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceEventScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private TaskAwaiter<Race> <>u__1; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncTrophyCountWithLiNKAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceEventScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text mapName; //Field offset: 0x48
	public TMP_Text difficulty; //Field offset: 0x50
	public Button playBtn; //Field offset: 0x58
	public GameObject playBtnLockObj; //Field offset: 0x60
	public GameObject playBtnEntryCostObj; //Field offset: 0x68
	public TMP_Text playBtnEntryCostTxt; //Field offset: 0x70
	public GameObject freeEntryTimerObj; //Field offset: 0x78
	public TMP_Text freeEntryTimeTxt; //Field offset: 0x80
	public GameObject freeEntriesObj; //Field offset: 0x88
	public TMP_Text freeEntriesTxt; //Field offset: 0x90
	public Image mapImage; //Field offset: 0x98
	public GameObject towerDisplayPrefab; //Field offset: 0xA0
	public GameObject selectedHeroDisplayPrefab; //Field offset: 0xA8
	public Transform towerContainer; //Field offset: 0xB0
	public ScrollRect towerScrollRect; //Field offset: 0xB8
	public Material grayscaleMaterial; //Field offset: 0xC0
	public GameObject lockedMessagePanel; //Field offset: 0xC8
	public TMP_Text date; //Field offset: 0xD0
	public TMP_Text timeRemaining; //Field offset: 0xD8
	public TMP_Text monkeysAvaliableTxt; //Field offset: 0xE0
	public Color monkeysExcludedTxtColor; //Field offset: 0xE8
	public GameObject maxTowerObject; //Field offset: 0xF8
	public TMP_Text maxTowerTxt; //Field offset: 0x100
	public Transform modifierContent; //Field offset: 0x108
	public GameObject modifierPrefab; //Field offset: 0x110
	public ModIconTheme modTheme; //Field offset: 0x118
	public GameObject modifierInfo; //Field offset: 0x120
	public TMP_Text trophiesTxt; //Field offset: 0x128
	public Button leaderboardBtn; //Field offset: 0x130
	public Button raceBuyPassesBtn; //Field offset: 0x138
	public GameObject racePassCountObj; //Field offset: 0x140
	public TMP_Text racePassCountTxt; //Field offset: 0x148
	public GameObject racePassActiveObj; //Field offset: 0x150
	public TMP_Text lockedPopupTxt; //Field offset: 0x158
	public GameObject tooLateToStartObj; //Field offset: 0x160
	private Race race; //Field offset: 0x168
	private RaceEvent raceEvent; //Field offset: 0x170
	private DailyChallengeModel dcm; //Field offset: 0x178
	private float playDownStartTime; //Field offset: 0x180
	private float modDownStartTime; //Field offset: 0x184
	private float playPopupDelay; //Field offset: 0x188
	private float modPopupDelay; //Field offset: 0x18C
	private int setScrollPosition; //Field offset: 0x190
	private KonFuze raceEntryCost; //Field offset: 0x198
	private bool isStartingGame; //Field offset: 0x1A0
	private bool isCheckingOnline; //Field offset: 0x1A1
	private bool hasEnoughTowers; //Field offset: 0x1A2
	private RaceStartMethod startMethod; //Field offset: 0x1A4

	private bool IsEndingSoon
	{
		private get { } //Length: 84
	}

	private string LockedMessage
	{
		private get { } //Length: 104
	}

	private int RacePassCount
	{
		private get { } //Length: 32
	}

	public RaceEventScreen() { }

	[CompilerGenerated]
	private void <ShowModIcons>b__59_1(BaseEventData _) { }

	protected virtual void Awake() { }

	private void ButtonsInteractive(bool isInteractable) { }

	public void BuyRacePassClicked() { }

	[AsyncStateMachine(typeof(<CheckOnlineThenStartNewGame>d__67))]
	private void CheckOnlineThenStartNewGame() { }

	private bool get_IsEndingSoon() { }

	private string get_LockedMessage() { }

	private int get_RacePassCount() { }

	public void GoToLeaderboard() { }

	[AsyncStateMachine(typeof(<GoToLeaderboardAsync>d__63))]
	public Task GoToLeaderboardAsync() { }

	[AsyncStateMachine(typeof(<LoadPreviousEventRewards>d__54))]
	private Task LoadPreviousEventRewards() { }

	public void LoadTowers(out bool hasEnoughTowers) { }

	private void OnDestroy() { }

	public void OnPlayBtnDown(BaseEventData eventData) { }

	public void OnPlayBtnUp(BaseEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__53))]
	public virtual void Open(object data) { }

	public void Play() { }

	private void PurchaseComplete() { }

	public void ShowModIcons() { }

	private void StartNewGame() { }

	[AsyncStateMachine(typeof(<SyncTrophyCountWithLiNKAsync>d__55))]
	private void SyncTrophyCountWithLiNKAsync() { }

	public void Update() { }

	public void UpdateRaceEntryUI() { }

}

