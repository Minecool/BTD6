namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DailyChallengeScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public ChallengeModifierData mod; //Field offset: 0x10
		public GameObject newModifierObj; //Field offset: 0x40
		public DailyChallengeScreen <>4__this; //Field offset: 0x48

		public <>c__DisplayClass51_0() { }

		internal void <ShowModIcons>b__0(BaseEventData _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public DailyChallengeScreen <>4__this; //Field offset: 0x10
		public bool quickMatch; //Field offset: 0x18

		public <>c__DisplayClass66_0() { }

		internal Task <OnGo>b__0() { }

	}

	[CompilerGenerated]
	private struct <OnGoAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DailyChallengeScreen <>4__this; //Field offset: 0x20
		public bool quickMatch; //Field offset: 0x28
		private Btd6LobbyParameters <lobbyParameters>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private CancellationTokenSource <canceller>5__3; //Field offset: 0x40
		private TaskAwaiter<LobbyConnection> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DailyChallengeScreen <>4__this; //Field offset: 0x28
		public object data; //Field offset: 0x30
		private LocalizationManager <loc>5__2; //Field offset: 0x38
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StatsBtnClicked>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DailyChallengeScreen <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Update>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DailyChallengeScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text title; //Field offset: 0x48
	public Image titleBannerImg; //Field offset: 0x50
	public Color[] titleBannerColors; //Field offset: 0x58
	public TMP_Text mapName; //Field offset: 0x60
	public TMP_Text difficulty; //Field offset: 0x68
	public Button continueBtn; //Field offset: 0x70
	public TMP_Text continueTxt; //Field offset: 0x78
	public Button playBtn; //Field offset: 0x80
	public Image mapImage; //Field offset: 0x88
	public Image difficultyImage; //Field offset: 0x90
	public LootPanel lootPanel; //Field offset: 0x98
	public SpriteReference[] difficultySprites; //Field offset: 0xA0
	public GameObject towerDisplayPrefab; //Field offset: 0xA8
	public GameObject selectedHeroDisplayPrefab; //Field offset: 0xB0
	public Transform towerContainer; //Field offset: 0xB8
	public ScrollRect towerScrollRect; //Field offset: 0xC0
	public Material grayscaleMaterial; //Field offset: 0xC8
	public GameObject lockedMessagePanel; //Field offset: 0xD0
	public TMP_Text date; //Field offset: 0xD8
	public TMP_Text timeRemaining; //Field offset: 0xE0
	public TMP_Text rewards; //Field offset: 0xE8
	public GameObject claimedPanel; //Field offset: 0xF0
	public TMP_Text monkeysAvaliableTxt; //Field offset: 0xF8
	public Color monkeysExcludedTxtColor; //Field offset: 0x100
	public GameObject maxTowerObject; //Field offset: 0x110
	public TMP_Text maxTowerTxt; //Field offset: 0x118
	public Transform modifierContent; //Field offset: 0x120
	public GameObject modifierPrefab; //Field offset: 0x128
	public ModIconTheme modTheme; //Field offset: 0x130
	public GameObject modifierInfo; //Field offset: 0x138
	public GameObject regularButtons; //Field offset: 0x140
	public GameObject coopButtons; //Field offset: 0x148
	public Button coopQuickMatchBtn; //Field offset: 0x150
	public Button coopCreateMatchBtn; //Field offset: 0x158
	public Button coopJoinMatchBtn; //Field offset: 0x160
	public Animator lookingForGame; //Field offset: 0x168
	public GameObject challengeRulesButton; //Field offset: 0x170
	public Button statsBtn; //Field offset: 0x178
	public PlayerContentStatsPanel playerContentStatsPanel; //Field offset: 0x180
	private DailyChallengeModel dcm; //Field offset: 0x188
	private MapSaveDataModel savedData; //Field offset: 0x190
	private DailyChallengeModel savedDcm; //Field offset: 0x198
	private bool locked; //Field offset: 0x1A0
	private float modDownStartTime; //Field offset: 0x1A4
	private float playDownStartTime; //Field offset: 0x1A8
	private float playPopupDelay; //Field offset: 0x1AC
	private float modPopupDelay; //Field offset: 0x1B0
	private int setScrollPosition; //Field offset: 0x1B4
	private bool isClosed; //Field offset: 0x1B8

	public DailyChallengeScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object data) { }

	[CompilerGenerated]
	private GameObject <Open>b__48_0() { }

	[CompilerGenerated]
	private void <ShowModIcons>b__51_1(BaseEventData _) { }

	private void CancelOverride() { }

	public virtual void Close() { }

	public void ContinueClicked() { }

	public void CoopCreateMatchClicked() { }

	public void CoopJoinMatchClicked() { }

	public void CoopQuickMatchClicked() { }

	private void EnableButtons(bool yes) { }

	public SpriteReference GetDifficultySprite(string difficulty) { }

	private LootSet GetVictoryLoot() { }

	private void OnGo(bool quickMatch) { }

	[AsyncStateMachine(typeof(<OnGoAsync>d__67))]
	private Task OnGoAsync(bool quickMatch) { }

	private void OnPlayBtnDown(BaseEventData eventData) { }

	private void OnPlayBtnUp(BaseEventData eventData) { }

	[AsyncStateMachine(typeof(<Open>d__48))]
	public virtual void Open(object data) { }

	public void Play() { }

	private void ShowCancellingUI() { }

	public void ShowChallengeRules() { }

	private void ShowModIcons() { }

	private void ShowTowers() { }

	private void StartNewGame() { }

	[AsyncStateMachine(typeof(<StatsBtnClicked>d__70))]
	private void StatsBtnClicked() { }

	[AsyncStateMachine(typeof(<Update>d__61))]
	public void Update() { }

}

