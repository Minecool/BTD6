namespace Assets.Scripts.Unity.UI_New.GameOver;

public class BossVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <InitialisePlayerStatsPanel>b__0(CoopPlayerInfo p) { }

	}

	[CompilerGenerated]
	private struct <InitEventUI>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossVictoryScreen <>4__this; //Field offset: 0x20
		public bool isRanked; //Field offset: 0x28
		private TaskAwaiter<Double[]> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossVictoryScreen <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image bossIcon; //Field offset: 0x110
	[SerializeField]
	private TMP_Text defeatedBossTxt; //Field offset: 0x118
	[SerializeField]
	private AudioClip victorySound; //Field offset: 0x120
	[SerializeField]
	private Button nextBtn; //Field offset: 0x128
	[SerializeField]
	private SinglePlayerStatsPanel singlePlayerStatsPanel; //Field offset: 0x130
	[SerializeField]
	private CoopPlayerStatsPanel[] playersStats; //Field offset: 0x138
	[SerializeField]
	private CoopPlayerPanelFreeplay[] playersFreeplayLoadings; //Field offset: 0x140
	[SerializeField]
	private BossLeaderboardScoresGroup leaderboardScoresGroup; //Field offset: 0x148
	[SerializeField]
	private NK_TextMeshProUGUI defeatedBossChallengeTxt; //Field offset: 0x150
	[SerializeField]
	private GameObject defeatedBossChallengeObj; //Field offset: 0x158
	private BossEvent bossEvent; //Field offset: 0x160
	private BossType bossBloon; //Field offset: 0x168
	private bool isElite; //Field offset: 0x16C
	private LeaderboardType leaderboardType; //Field offset: 0x170
	[SerializeField]
	private GameObject[] lootObjects; //Field offset: 0x178
	private readonly List<CalloutUiData> coopCalloutUiData; //Field offset: 0x180
	private CalloutManager calloutManager; //Field offset: 0x188
	private LeaderboardVictoryScreen leaderboardScreen; //Field offset: 0x190
	private bool isEventMode; //Field offset: 0x198

	private bool CanPlayAgain
	{
		private get { } //Length: 262
	}

	private bool IsCoop
	{
		private get { } //Length: 70
	}

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	private int PlayerCount
	{
		private get { } //Length: 176
	}

	public BossVictoryScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object menuData) { }

	[CompilerGenerated]
	private void <InitEventUI>b__30_0() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void GamepadSelectFirst() { }

	private void GamepadUpdateNav() { }

	private bool get_CanPlayAgain() { }

	private bool get_IsCoop() { }

	protected virtual bool get_IsVictoryScreen() { }

	private int get_PlayerCount() { }

	private LeaderboardScoreData GetLeaderboardScoreData(LeaderboardScoringType scoringType, long rawScore) { }

	private void InitChallengeScores(bool isRanked) { }

	[AsyncStateMachine(typeof(<InitEventUI>d__30))]
	private Task InitEventUI(bool isRanked) { }

	public void InitialiseFreeplayPanel() { }

	public void InitialisePlayerStatsPanel() { }

	private void LeaderboardClicked() { }

	public virtual void OnNextClicked() { }

	[AsyncStateMachine(typeof(<Open>d__28))]
	public virtual void Open(object menuData) { }

	private void PlayAgainClicked() { }

	private void ShowScores(LeaderboardScoringType scoringType, BossLeaderboardType bossLeaderboardType, LeaderboardScoreData currentScore) { }

	public void Update() { }

}

