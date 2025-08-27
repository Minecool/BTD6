namespace Assets.Scripts.Unity.UI_New.GameOver;

public class LeaderboardVictoryScreen : MonoBehaviour
{
	[CompilerGenerated]
	private struct <SubmitScore>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ScoreModel> <>t__builder; //Field offset: 0x8
		public Byte[] submissionData; //Field offset: 0x20
		public BaseServerEvent serverEvent; //Field offset: 0x28
		private Submission <data>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter<DateTime> <>u__2; //Field offset: 0x40
		private TaskAwaiter<ScoreModel> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string kNoDecrease = "NO_DECREASE"; //Field offset: 0x0
	private const string kNoIncrease = "NO_INCREASE"; //Field offset: 0x0
	private static readonly TimeSpan kScoreExpiration; //Field offset: 0x0
	public NK_TextMeshProUGUI bestTimeTxt; //Field offset: 0x20
	public GameObject bestTimeObj; //Field offset: 0x28
	public GameObject worseTimeObj; //Field offset: 0x30
	public Color bestTimeColor; //Field offset: 0x38
	public Color worseTimeColor; //Field offset: 0x48
	public GameObject claimedRewardsObj; //Field offset: 0x58
	public GameObject currTimeObj; //Field offset: 0x60
	public NK_TextMeshProUGUI currTimeTxt; //Field offset: 0x68
	public LootPanel lootPanel; //Field offset: 0x70
	public Button leaderboardBtn; //Field offset: 0x78
	public Button playAgainBtn; //Field offset: 0x80
	public GameObject buttonsContainer; //Field offset: 0x88
	public Image loadingSpinner; //Field offset: 0x90

	private static LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private static LeaderboardVictoryScreen() { }

	public LeaderboardVictoryScreen() { }

	[CompilerGenerated]
	private void <Awake>b__18_0() { }

	[CompilerGenerated]
	private void <Awake>b__18_1() { }

	public void Awake() { }

	public void ButtonsInteractive(bool canInteract) { }

	public void CancelSubmitScores() { }

	private void GamepadUpdateNav() { }

	private static LocalizationManager get_Locs() { }

	public static bool IsValidEndTime(DateTime eventEndTime) { }

	public void SetLoot(LootSet loot) { }

	public void SetTimers(Scores scores) { }

	public void ShowSubmissionFailedPopup(string titleLoc, IList<Double> messageValues, ReturnCallback okCallback) { }

	[AsyncStateMachine(typeof(<SubmitScore>d__23))]
	public static Task<ScoreModel> SubmitScore(Byte[] submissionData, BaseServerEvent serverEvent) { }

}

