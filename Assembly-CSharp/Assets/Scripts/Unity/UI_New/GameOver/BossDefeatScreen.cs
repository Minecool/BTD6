namespace Assets.Scripts.Unity.UI_New.GameOver;

public class BossDefeatScreen : CheckpointDefeatScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Nullable`1<LeaderboardScoreData>, Boolean> <>9__29_0; //Field offset: 0x8
		public static Func<Nullable`1<LeaderboardScoreData>, Boolean> <>9__35_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <get_HasSubmittedScore>b__29_0(Nullable<LeaderboardScoreData> x) { }

		internal bool <Open>b__35_0(Nullable<LeaderboardScoreData> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public KonFuze continueMmCost; //Field offset: 0x10
		public BossDefeatScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass35_0() { }

		internal void <Open>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_1
	{
		public KonFuze retryMmCost; //Field offset: 0x10
		public BossDefeatScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass35_1() { }

		internal void <Open>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <InitialisePlayerStatsPanel>b__0(CoopPlayerInfo p) { }

	}

	public Image bossIcon; //Field offset: 0x158
	public TMP_Text title; //Field offset: 0x160
	public TMP_Text finalRoundTxt; //Field offset: 0x168
	public TMP_Text bestRoundTxt; //Field offset: 0x170
	public TMP_Text bestRoundTxt2; //Field offset: 0x178
	public GameObject bestRoundObj; //Field offset: 0x180
	public GameObject newBestRoundObj; //Field offset: 0x188
	public Button restartButton; //Field offset: 0x190
	public GameObject lostToBossObj; //Field offset: 0x198
	public TMP_Text lostToBossTxt; //Field offset: 0x1A0
	public GameObject ranOutOfTimeObj; //Field offset: 0x1A8
	public TMP_Text ranOutOfTimeTxt; //Field offset: 0x1B0
	public TMP_Text ranOutOfTimeSubTxt; //Field offset: 0x1B8
	public AudioClip defeatSound; //Field offset: 0x1C0
	public SinglePlayerStatsPanel singlePlayerStatsPanel; //Field offset: 0x1C8
	public CoopPlayerStatsPanel[] playersStats; //Field offset: 0x1D0
	public GameObject unrankedRoundsObj; //Field offset: 0x1D8
	[SerializeField]
	private BossLeaderboardScoresGroup leaderboardScoresGroup; //Field offset: 0x1E0
	[SerializeField]
	private Button leaderboardBtn; //Field offset: 0x1E8
	private readonly List<CalloutUiData> coopCalloutUiData; //Field offset: 0x1F0
	private CalloutManager calloutManager; //Field offset: 0x1F8
	private BossEvent bossEvent; //Field offset: 0x200
	private bool isEventMode; //Field offset: 0x208
	private LeaderboardType leaderboardType; //Field offset: 0x20C
	private Dictionary<String, MapSaveDataModel> previousSaves; //Field offset: 0x210

	protected virtual bool CanPlayAgain
	{
		 get { } //Length: 262
	}

	private bool HasSubmittedScore
	{
		private get { } //Length: 319
	}

	private bool IsElite
	{
		private get { } //Length: 78
	}

	private bool IsRanked
	{
		private get { } //Length: 78
	}

	public BossDefeatScreen() { }

	[CompilerGenerated]
	private void <RestartClick>b__37_0() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void GamepadUpdateNav() { }

	protected virtual bool get_CanPlayAgain() { }

	private bool get_HasSubmittedScore() { }

	private bool get_IsElite() { }

	private bool get_IsRanked() { }

	private KonFuze GetRetryMmCost() { }

	public void InitialisePlayerStatsPanel() { }

	public virtual void Open(object menuData) { }

	private void OpenLeaderboard() { }

	private void RestartClick() { }

	private void RestoreMapSaves() { }

	public void RunRestart() { }

}

