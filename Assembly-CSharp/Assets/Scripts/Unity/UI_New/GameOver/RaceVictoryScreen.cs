namespace Assets.Scripts.Unity.UI_New.GameOver;

public class RaceVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public RaceVictoryScreen <>4__this; //Field offset: 0x10
		public string leaderboardId; //Field offset: 0x18
		public LeaderboardScoreData score; //Field offset: 0x20
		public string metadata; //Field offset: 0x30
		public KonFuze sha; //Field offset: 0x38

		public <>c__DisplayClass17_0() { }

		internal void <TrySubmitScores>b__0() { }

		internal void <TrySubmitScores>b__1() { }

	}

	[CompilerGenerated]
	private struct <CheckOnlineThenStartNewGame>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceVictoryScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LeaderboardClickedAsync>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceVictoryScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<LeaderboardReward[][]> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceVictoryScreen <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySubmitScores>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RaceVictoryScreen <>4__this; //Field offset: 0x20
		public string leaderboardId; //Field offset: 0x28
		public LeaderboardScoreData score; //Field offset: 0x30
		public string metadata; //Field offset: 0x40
		public KonFuze sha; //Field offset: 0x48
		private <>c__DisplayClass17_0 <>8__1; //Field offset: 0x50
		private InGame <ingame>5__2; //Field offset: 0x58
		private UnityToSimulation <bridge>5__3; //Field offset: 0x60
		private TaskAwaiter<ScoreModel> <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject greatFinishMessageObj; //Field offset: 0x110
	public NK_TextMeshProUGUI retryMMCostTxt; //Field offset: 0x118
	public AudioClip victorySound; //Field offset: 0x120
	private KonFuze retryMMCost; //Field offset: 0x128
	private RaceEvent raceEvent; //Field offset: 0x130
	private Scores scores; //Field offset: 0x138
	private RaceStartMethod startMethod; //Field offset: 0x140
	private LeaderboardVictoryScreen leaderboardScreen; //Field offset: 0x148

	private bool CanPlayAgain
	{
		private get { } //Length: 138
	}

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public RaceVictoryScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object menuData) { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void CancelStartNewGame() { }

	[AsyncStateMachine(typeof(<CheckOnlineThenStartNewGame>d__20))]
	private void CheckOnlineThenStartNewGame() { }

	private bool get_CanPlayAgain() { }

	protected virtual bool get_IsVictoryScreen() { }

	private string GetMetadata() { }

	private Scores GetScores() { }

	private Int32[] GetSkuSettings() { }

	private void LeaderboardClicked() { }

	[AsyncStateMachine(typeof(<LeaderboardClickedAsync>d__23))]
	private Task LeaderboardClickedAsync() { }

	[AsyncStateMachine(typeof(<Open>d__13))]
	public virtual void Open(object menuData) { }

	private void PlayAgainClicked() { }

	private void PopulateScreen(LootSet loot) { }

	[AsyncStateMachine(typeof(<TrySubmitScores>d__17))]
	private Task TrySubmitScores(string leaderboardId, LeaderboardScoreData score, string metadata, KonFuze sha) { }

	public void Update() { }

}

