namespace Assets.Scripts.Unity.UI_New.Pause;

public class PauseScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static ReturnCallback <>9__101_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <RestartBossRush>b__101_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass102_0
	{
		public Btd6Player player; //Field offset: 0x10
		public int purchaseTicketCost; //Field offset: 0x18
		public PauseScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass102_0() { }

		internal void <BuyBossRushTicketAndRestart>b__0() { }

		internal void <BuyBossRushTicketAndRestart>b__1() { }

	}

	[CompilerGenerated]
	private struct <CheckOnlineThenStartNewGame>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PauseScreen <>4__this; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshBossRushUiAsync>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PauseScreen <>4__this; //Field offset: 0x20
		private BossRushEvent <bossRushEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<BossRushStatusResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshRaceUiAsync>d__111 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public PauseScreen <>4__this; //Field offset: 0x28
		private Race <race>5__2; //Field offset: 0x30
		private TaskAwaiter<Race> <>u__1; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnCloseMenu : MulticastDelegate
	{

		public OnCloseMenu(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnOpenMenu : MulticastDelegate
	{

		public OnOpenMenu(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private const int animationStateClosed = 0; //Field offset: 0x0
	private const int animationStateOpen = 1; //Field offset: 0x0
	private readonly string visibleStateLabel; //Field offset: 0x48
	public MiniJukeBoxPlayer jukeBoxPlayer; //Field offset: 0x50
	public Lightbox backgroundBtn; //Field offset: 0x58
	public Animator dragAndDropAnim; //Field offset: 0x60
	public Animator continuousPlayAnim; //Field offset: 0x68
	public Animator gameHintsAnim; //Field offset: 0x70
	public Animator disableNudgeModeAnim; //Field offset: 0x78
	public TMP_Text ctTileId; //Field offset: 0x80
	public TMP_Text txtInfo; //Field offset: 0x88
	public Toggle dragAndDropToggle; //Field offset: 0x90
	public Toggle continuousPlayToggle; //Field offset: 0x98
	public Toggle gameHintsToggle; //Field offset: 0xA0
	public Toggle disableNudgeModeToggle; //Field offset: 0xA8
	public PetSoundToggleControl petSoundControl; //Field offset: 0xB0
	public GameObject disableNudgeModeGO; //Field offset: 0xB8
	public NK_TextMeshProUGUI lockAndDropText; //Field offset: 0xC0
	public Button storeButton; //Field offset: 0xC8
	public Button hotkeysButton; //Field offset: 0xD0
	public Button accessibilityButton; //Field offset: 0xD8
	public Button homeButton; //Field offset: 0xE0
	public Button restartButton; //Field offset: 0xE8
	public Button retryFromCheckpointButton; //Field offset: 0xF0
	public Button editorSaveExitButton; //Field offset: 0xF8
	public NK_TextMeshProUGUI retryFromCheckpointCostTxt; //Field offset: 0x100
	public NK_TextMeshProUGUI retryFromCheckpointDescTxt; //Field offset: 0x108
	public Button retryForMMButton; //Field offset: 0x110
	public NK_TextMeshProUGUI retryMMCostTxt; //Field offset: 0x118
	public Button buyRacePassesButton; //Field offset: 0x120
	public Button continueButton; //Field offset: 0x128
	public GameObject challengeRulesButton; //Field offset: 0x130
	public GameObject sidePanel; //Field offset: 0x138
	public Slider heroVOSlider; //Field offset: 0x140
	public Button reportButton; //Field offset: 0x148
	public GameObject nkVerifiedContent; //Field offset: 0x150
	public GameObject reportPopup; //Field offset: 0x158
	private RaceEvent raceEvent; //Field offset: 0x160
	private KonFuze retryMMCost; //Field offset: 0x168
	private RaceStartMethod startMethod; //Field offset: 0x170
	private KonFuze checkpointPrice; //Field offset: 0x178
	private bool hasEditorSaveDataToOverride; //Field offset: 0x180
	private Nullable<Boolean> _isMapEditorCreationMode; //Field offset: 0x181
	[SerializeField]
	private Button restartBossRushBtn; //Field offset: 0x188
	[SerializeField]
	private Button restartBossRushBtnMM; //Field offset: 0x190
	[SerializeField]
	private NK_TextMeshProUGUI bossRushTicketCostTxt; //Field offset: 0x198
	[SerializeField]
	private NK_TextMeshProUGUI bossRushTicketsAvailableTxt; //Field offset: 0x1A0
	[SerializeField]
	private GameObject bossRushTicketsObj; //Field offset: 0x1A8
	[SerializeField]
	private GameObject rogueLivesObj; //Field offset: 0x1B0
	[SerializeField]
	private Transform rogueLivesContainer; //Field offset: 0x1B8
	[SerializeField]
	private GameObject rogueLivesPrefab; //Field offset: 0x1C0
	[SerializeField]
	private GameObject rogueRestartObj; //Field offset: 0x1C8
	[SerializeField]
	private NK_TextMeshProUGUI stageTxt; //Field offset: 0x1D0
	[SerializeField]
	private GameObject scoreContainer; //Field offset: 0x1D8
	[SerializeField]
	private GameObject[] scoreObjects; //Field offset: 0x1E0
	private Nullable<Boolean> _canUseCheckpoint; //Field offset: 0x1E8

	private bool CanRaceAgain
	{
		private get { } //Length: 176
	}

	private bool CanUseCheckpoint
	{
		private get { } //Length: 692
	}

	private string ContinueMapSaveId
	{
		private get { } //Length: 582
	}

	private string DropAndLockKey
	{
		private get { } //Length: 195
	}

	private bool IsFirstRound
	{
		private get { } //Length: 98
	}

	private bool IsMapEditorCreationMode
	{
		private get { } //Length: 348
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private bool RestartCostsLivesRogue
	{
		private get { } //Length: 262
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	private bool UseRogueLives
	{
		private get { } //Length: 171
	}

	public PauseScreen() { }

	[CompilerGenerated]
	private GameObject <Awake>b__68_0() { }

	[CompilerGenerated]
	private void <QuitToMenu>b__78_0() { }

	[CompilerGenerated]
	private void <QuitToMenuAndSaveMapEditor>b__79_0() { }

	[CompilerGenerated]
	private void <Restart>b__88_0() { }

	[CompilerGenerated]
	private void <RestartBossRush>b__101_1() { }

	[CompilerGenerated]
	private void <TryQuitToMenu>b__77_0() { }

	[CompilerGenerated]
	private void <TryQuitToMenu>b__77_1() { }

	private void AccessibilityClicked() { }

	protected virtual void Awake() { }

	private void ButtonsInteractive(bool isInteractable) { }

	private void BuyBossRushTicketAndRestart() { }

	private void BuyRacePassClicked() { }

	private void CancelStartNewGame() { }

	private static bool CanShowRestartButton(InGame ingame, bool isMapEditorCreationMode) { }

	private bool CanShowRestartRogue() { }

	[AsyncStateMachine(typeof(<CheckOnlineThenStartNewGame>d__115))]
	private void CheckOnlineThenStartNewGame() { }

	private void CheckpointClicked() { }

	private void CheckTutorial() { }

	public virtual void Close() { }

	private void ContinueClicked() { }

	private bool get_CanRaceAgain() { }

	private bool get_CanUseCheckpoint() { }

	private string get_ContinueMapSaveId() { }

	private string get_DropAndLockKey() { }

	private bool get_IsFirstRound() { }

	private bool get_IsMapEditorCreationMode() { }

	private LegendsDataModel get_LegendsData() { }

	private bool get_RestartCostsLivesRogue() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private bool get_UseRogueLives() { }

	private void HotkeysClicked() { }

	private bool IsMapEditorCreationModeCheck() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public virtual void Open(object menuData) { }

	private void QuitToMenu() { }

	public void QuitToMenuAndSaveMapEditor() { }

	public virtual void ReClose() { }

	[AsyncStateMachine(typeof(<RefreshBossRushUiAsync>d__100))]
	private Task RefreshBossRushUiAsync() { }

	[AsyncStateMachine(typeof(<RefreshRaceUiAsync>d__111))]
	private void RefreshRaceUiAsync() { }

	public void Restart() { }

	private void RestartBossRush() { }

	private void RetryForMMClicked() { }

	private void RunCheckpoint() { }

	private void RunRestart() { }

	private void SaveSettings() { }

	private void SetupRogueLives() { }

	private void SetupRogueMinigameGoal() { }

	public void ShowChallengeRules() { }

	private void StoreClicked() { }

	public void ToggleContinuousPlay(bool on) { }

	public void ToggleDisableNudgeMode(bool on) { }

	public void ToggleDragAndDrop(bool on) { }

	public void ToggleGameHints(bool on) { }

	public void TryQuitToMenu() { }

	public void Update() { }

	private void UpdateNavigation() { }

}

