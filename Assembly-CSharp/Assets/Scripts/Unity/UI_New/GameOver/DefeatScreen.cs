namespace Assets.Scripts.Unity.UI_New.GameOver;

public class DefeatScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TopContributor, String> <>9__50_0; //Field offset: 0x8
		public static Func<TalkingHeadHint, Boolean> <>9__57_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CheckForQuestDialogue>b__57_2(TalkingHeadHint x) { }

		internal string <ShowAccolades>b__50_0(TopContributor x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public DialogueData dialogueData; //Field offset: 0x10
		public int taskIndex; //Field offset: 0x18
		public DefeatScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass57_0() { }

		internal void <CheckForQuestDialogue>b__0() { }

	}

	[CompilerGenerated]
	private struct <CheckForQuestDialogue>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DefeatScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckOnlineThenStartNewGame>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DefeatScreen <>4__this; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DefeatScreen <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30
		private ContentType <contentType>5__2; //Field offset: 0x38
		private string <contentId>5__3; //Field offset: 0x40
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshRaceUI>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public DefeatScreen <>4__this; //Field offset: 0x28
		private Race <race>5__2; //Field offset: 0x30
		private TaskAwaiter<Race> <>u__1; //Field offset: 0x38
		private TaskAwaiter<OnlineProfileModel> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowAccolades>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DefeatScreen <>4__this; //Field offset: 0x20
		private PlayerContentInfo <contentInfo>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text continueCostTxt; //Field offset: 0x110
	public TMP_Text finalRoundTxt; //Field offset: 0x118
	private KonFuze retryMMCost; //Field offset: 0x120
	private KonFuze continuePrice; //Field offset: 0x128
	public Button restartButton; //Field offset: 0x130
	public Button retryForMMButton; //Field offset: 0x138
	public Button continueButton; //Field offset: 0x140
	public Button retryLastRoundButton; //Field offset: 0x148
	public Button buyRacePassesButton; //Field offset: 0x150
	public NK_TextMeshProUGUI retryMMCostTxt; //Field offset: 0x158
	public NK_TextMeshProUGUI retryLastRoundMMCostTxt; //Field offset: 0x160
	public NK_TextMeshProUGUI retryLastRoundMMTxt; //Field offset: 0x168
	public GameObject retryLastRoundMMCostPanel; //Field offset: 0x170
	public GameObject regularObject; //Field offset: 0x178
	public GameObject userChalObject; //Field offset: 0x180
	public Toggle likeTgl; //Field offset: 0x188
	public GameObject likeTglEnabledBg; //Field offset: 0x190
	public TMP_Text ratingCountTxt; //Field offset: 0x198
	public Toggle favouriteTgl; //Field offset: 0x1A0
	public TMP_Text userChalFinalRoundTxt; //Field offset: 0x1A8
	public AudioClip defeatSound; //Field offset: 0x1B0
	public BloonCauseDeathDisplay bloonCauseDeathDisplayPrefab; //Field offset: 0x1B8
	public GameObject bloonCoDContainer; //Field offset: 0x1C0
	public NK_TextMeshProUGUI title; //Field offset: 0x1C8
	[SerializeField]
	private AccoladeSummaryScreenDisplay accoladesFloatDisplay; //Field offset: 0x1D0
	private readonly List<BloonCauseDeathDisplay> bloonCauseDeathDisplayList; //Field offset: 0x1D8
	private RaceEvent raceEvent; //Field offset: 0x1E0
	private readonly List<CalloutUiData> calloutUiData; //Field offset: 0x1E8
	private CalloutManager calloutManager; //Field offset: 0x1F0
	public SinglePlayerStatsPanel playerStats; //Field offset: 0x1F8
	private QuestDetails questDetails; //Field offset: 0x200
	private TaskData taskData; //Field offset: 0x208
	[SerializeField]
	private AccoladesDisplayButton accoladesButton; //Field offset: 0x210
	[SerializeField]
	private GameObject alternateGameOverObj; //Field offset: 0x218
	[SerializeField]
	private TextMeshProUGUI alternateGameOverTxt; //Field offset: 0x220
	[SerializeField]
	private Image alternateGameOverImage; //Field offset: 0x228
	private Nullable<Boolean> IsRaceValueSet; //Field offset: 0x230
	private RaceStartMethod startMethod; //Field offset: 0x234

	private bool CanRaceAgain
	{
		private get { } //Length: 171
	}

	private bool IsRace
	{
		private get { } //Length: 152
	}

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	private QuestGameData QuestGameData
	{
		private get { } //Length: 69
	}

	private int TaskIndex
	{
		private get { } //Length: 77
	}

	public DefeatScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object menuData) { }

	[CompilerGenerated]
	private void <Awake>b__47_0() { }

	[CompilerGenerated]
	private void <CheckForQuestDialogue>b__57_1() { }

	[CompilerGenerated]
	private void <CheckForQuestDialogue>b__57_3() { }

	private void AnimatedDialogueCompleted(DialogueData dialogueData, int index) { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool yes) { }

	private void BuyRacePassClicked() { }

	private void CancelStartNewGame() { }

	[AsyncStateMachine(typeof(<CheckForQuestDialogue>d__57))]
	private void CheckForQuestDialogue() { }

	[AsyncStateMachine(typeof(<CheckOnlineThenStartNewGame>d__62))]
	private void CheckOnlineThenStartNewGame() { }

	public void ContinueClick() { }

	private void FavouriteToggled(bool value) { }

	private void GamepadUpdateNav() { }

	private bool get_CanRaceAgain() { }

	private bool get_IsRace() { }

	protected virtual bool get_IsVictoryScreen() { }

	private QuestGameData get_QuestGameData() { }

	private int get_TaskIndex() { }

	public void InitialisePlayerStatsPanel() { }

	private void LikeToggled(bool value) { }

	[AsyncStateMachine(typeof(<Open>d__48))]
	public virtual void Open(object menuData) { }

	private void PurchaseComplete() { }

	[AsyncStateMachine(typeof(<RefreshRaceUI>d__52))]
	private void RefreshRaceUI() { }

	private void RestartClick() { }

	private void RetryForMMClicked() { }

	public void RunContinue() { }

	public void RunRestart() { }

	[AsyncStateMachine(typeof(<ShowAccolades>d__50))]
	private Task ShowAccolades() { }

	private bool TryGetUnseenTaskDialogueData(out DialogueData dialogueData, out int index) { }

	public void Update() { }

}

