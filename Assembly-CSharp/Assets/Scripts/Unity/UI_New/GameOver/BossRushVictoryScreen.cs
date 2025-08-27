namespace Assets.Scripts.Unity.UI_New.GameOver;

public class BossRushVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SubmittedScore, Int32> <>9__36_1; //Field offset: 0x8
		public static Func<Int32, Int32> <>9__36_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal int <Open>b__36_1(SubmittedScore submittedScore) { }

		internal int <Open>b__36_2(int score) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public BossRushVictoryScreen <>4__this; //Field offset: 0x10
		public int daysSinceEventStart; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal bool <Open>b__0(SubmittedScore submittedScore) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public Btd6Player player; //Field offset: 0x10
		public int purchaseTicketCost; //Field offset: 0x18
		public BossRushVictoryScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass38_0() { }

		internal void <BuyTicketAndStartGame>b__0() { }

		internal void <BuyTicketAndStartGame>b__1() { }

	}

	[CompilerGenerated]
	private struct <Open>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushVictoryScreen <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30
		private <>c__DisplayClass36_0 <>8__1; //Field offset: 0x38
		private int <score>5__2; //Field offset: 0x40
		private BossRushScoreResponse <scoreSubmissionResult>5__3; //Field offset: 0x48
		private bool <isKillingBlow>5__4; //Field offset: 0x50
		private bool <isScoreSubmitted>5__5; //Field offset: 0x51
		private bool <isOldScoreImproved>5__6; //Field offset: 0x52
		private bool <isTierCompleted>5__7; //Field offset: 0x53
		private List<Int32> <sortedActiveScores>5__8; //Field offset: 0x58
		private TaskAwaiter<BossRushScoreResponse> <>u__1; //Field offset: 0x60
		private YieldAwaiter <>u__2; //Field offset: 0x68
		private TaskAwaiter <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySubmitScore>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<BossRushScoreResponse> <>t__builder; //Field offset: 0x8
		public BossRushVictoryScreen <>4__this; //Field offset: 0x20
		public int score; //Field offset: 0x28
		private BossRushScoreResponse <scoreSubmissionResult>5__2; //Field offset: 0x30
		private int <gameId>5__3; //Field offset: 0x38
		private float <totalCashEarned>5__4; //Field offset: 0x3C
		private float <totalCashSpent>5__5; //Field offset: 0x40
		private int <>7__wrap5; //Field offset: 0x44
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48
		private TaskAwaiter<BossRushScoreResponse> <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button playAgainBtn; //Field offset: 0x110
	[SerializeField]
	private Button nextBtn; //Field offset: 0x118
	[SerializeField]
	private GameObject submittedBanner; //Field offset: 0x120
	[SerializeField]
	private GameObject notSubmittedBanner; //Field offset: 0x128
	[SerializeField]
	private GameObject killingBlowBanner; //Field offset: 0x130
	[SerializeField]
	private GameObject tierDefeatedBanner; //Field offset: 0x138
	[SerializeField]
	private GameObject eventEndedBanner; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI scoreTxt; //Field offset: 0x148
	[SerializeField]
	private TextMeshProUGUI scoreTxtReplay; //Field offset: 0x150
	[SerializeField]
	private TextMeshProUGUI notSubmittedTxt; //Field offset: 0x158
	[SerializeField]
	private TextMeshProUGUI scoreSubmittedTxt; //Field offset: 0x160
	[SerializeField]
	private Image bossImage; //Field offset: 0x168
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x170
	[SerializeField]
	private TextMeshProUGUI titleTxt; //Field offset: 0x178
	[SerializeField]
	private BossRushScoreDisplay scoreDisplayTemplate; //Field offset: 0x180
	[SerializeField]
	private Transform scoreDisplaysContainer; //Field offset: 0x188
	private readonly List<BossRushScoreDisplay> activeScoreDisplays; //Field offset: 0x190
	[SerializeField]
	private GameObject scoresDisabledObj; //Field offset: 0x198
	[SerializeField]
	private SinglePlayerStatsPanel singlePlayerStatsPanel; //Field offset: 0x1A0
	private CalloutManager calloutManager; //Field offset: 0x1A8
	private readonly List<CalloutUiData> coopCalloutUiData; //Field offset: 0x1B0
	private int availableTickets; //Field offset: 0x1B8
	[SerializeField]
	private Button buyAndPlayBtn; //Field offset: 0x1C0
	[SerializeField]
	private NK_TextMeshProUGUI buyBtnCostTxt; //Field offset: 0x1C8
	[SerializeField]
	private GameObject ticketsObj; //Field offset: 0x1D0
	[SerializeField]
	private NK_TextMeshProUGUI ticketsAvailableTxt; //Field offset: 0x1D8
	[SerializeField]
	private GameObject hpBarContainer; //Field offset: 0x1E0
	[SerializeField]
	private NK_TextMeshProUGUI hpBarTxt; //Field offset: 0x1E8
	[SerializeField]
	private Image hpBarImg; //Field offset: 0x1F0
	private BossRushEvent bossRushEvent; //Field offset: 0x1F8
	private BossRushSettings bossRushSettings; //Field offset: 0x200
	private int currentTileIndex; //Field offset: 0x208
	private BossType bossType; //Field offset: 0x20C

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public BossRushVictoryScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object menuData) { }

	protected virtual void Awake() { }

	private void ButtonsInteractable(bool interactable) { }

	private void BuyTicketAndStartGame() { }

	private void EventEndedDisplay() { }

	protected virtual bool get_IsVictoryScreen() { }

	public void InitialisePlayerStatsPanel() { }

	[AsyncStateMachine(typeof(<Open>d__36))]
	public virtual void Open(object menuData) { }

	private void PlayAgainClicked() { }

	private void ReplayDisplay(int score) { }

	private void SetupPlayButton() { }

	private void SetupUI(int score, bool isKillingBlow, bool isScoreSubmitted, bool isTierCompleted, bool isOldScoreImproved, List<Int32> sortedActiveScores, int scoreIncrement) { }

	[AsyncStateMachine(typeof(<TrySubmitScore>d__40))]
	private Task<BossRushScoreResponse> TrySubmitScore(int score) { }

}

