namespace Assets.Scripts.Unity.UI_New.GameOver;

public class QuestVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public QuestVictoryScreen <>4__this; //Field offset: 0x10
		public DialogueData dialogueData; //Field offset: 0x18
		public int taskIndex; //Field offset: 0x20

		public <>c__DisplayClass38_0() { }

		internal void <CheckForQuestDialogue>b__0() { }

		internal void <CheckForQuestDialogue>b__1() { }

	}

	[CompilerGenerated]
	private struct <CheckForQuestDialogue>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestVictoryScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button playAgainBtn; //Field offset: 0x110
	public GameObject victoryPanelObj; //Field offset: 0x118
	public GameObject scoreMissedPanelObj; //Field offset: 0x120
	public GameObject completedPanelObj; //Field offset: 0x128
	public NK_TextMeshProUGUI victoryDescriptionLoc; //Field offset: 0x130
	public GameObject completeObject; //Field offset: 0x138
	public GameObject rewardsObject; //Field offset: 0x140
	public LootPanel lootPanel; //Field offset: 0x148
	public AudioClip victorySound; //Field offset: 0x150
	public AudioClip defeatSound; //Field offset: 0x158
	public SinglePlayerStatsPanel playerStats; //Field offset: 0x160
	public Image victoryMonkey; //Field offset: 0x168
	public Color greenColour; //Field offset: 0x170
	public Color redColour; //Field offset: 0x180
	public Color darkRedolour; //Field offset: 0x190
	private readonly List<CalloutUiData> calloutUiData; //Field offset: 0x1A0
	private CalloutManager calloutManager; //Field offset: 0x1A8
	private QuestDetails questDetails; //Field offset: 0x1B0
	private TaskData taskData; //Field offset: 0x1B8
	private AudioClip screenSound; //Field offset: 0x1C0

	private bool HasClaimedRewards
	{
		private get { } //Length: 102
	}

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	private int PartIndex
	{
		private get { } //Length: 77
	}

	private QuestGameData QuestGameData
	{
		private get { } //Length: 69
	}

	private string QuestId
	{
		private get { } //Length: 78
	}

	private QuestTrackerManager QuestTrackerManager
	{
		private get { } //Length: 68
	}

	private int TaskIndex
	{
		private get { } //Length: 77
	}

	public QuestVictoryScreen() { }

	private void AnimatedDialogueCompleted(DialogueData dialogueData, int index) { }

	protected virtual void Awake() { }

	private void BindChallengeData(ChallengeGoalData data) { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	[AsyncStateMachine(typeof(<CheckForQuestDialogue>d__38))]
	private void CheckForQuestDialogue() { }

	private void CheckQuestGoal() { }

	private void CheckSetChallengeScore() { }

	private bool CompareScoreBasedOnGameModeType(long newScore, long otherScore) { }

	private void DefaultUI() { }

	private void GamepadUpdateNav() { }

	private bool get_HasClaimedRewards() { }

	protected virtual bool get_IsVictoryScreen() { }

	private int get_PartIndex() { }

	private QuestGameData get_QuestGameData() { }

	private string get_QuestId() { }

	private QuestTrackerManager get_QuestTrackerManager() { }

	private int get_TaskIndex() { }

	public void InitialisePlayerStatsPanel() { }

	public virtual void OnNextClicked() { }

	public virtual void Open(object menuData) { }

	private void PlayAgainClicked() { }

	private void SaveDataAndSendAnalytics(long score, bool questBeaten) { }

	private bool TryGetUnseenTaskDialogueData(out DialogueData dialogueData, out int index) { }

	private void UpdateContextSpecificUI() { }

}

