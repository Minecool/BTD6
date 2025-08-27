namespace Assets.Scripts.Unity.UI_New.GameOver;

public class VictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TopContributor, String> <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ShowAccolades>b__26_0(TopContributor x) { }

	}

	[CompilerGenerated]
	private struct <ShowAccolades>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VictoryScreen <>4__this; //Field offset: 0x20
		private PlayerContentInfo <contentInfo>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI difficulty; //Field offset: 0x110
	public Button freePlayBtn; //Field offset: 0x118
	public GameObject completeObject; //Field offset: 0x120
	public GameObject rewardsObject; //Field offset: 0x128
	public GameObject userChalObject; //Field offset: 0x130
	public Toggle likeTgl; //Field offset: 0x138
	public GameObject likeTglEnabledBg; //Field offset: 0x140
	public TMP_Text ratingCountTxt; //Field offset: 0x148
	public Toggle favouriteTgl; //Field offset: 0x150
	public LootPanel lootPanel; //Field offset: 0x158
	public AudioClip victorySound; //Field offset: 0x160
	public SinglePlayerStatsPanel playerStats; //Field offset: 0x168
	public GameObject goldenBloonObj; //Field offset: 0x170
	public NK_TextMeshProUGUI goldenBloonPopCountTxt; //Field offset: 0x178
	public NK_TextMeshProUGUI goldenBloonMMEarntTxt; //Field offset: 0x180
	public GameObject monkeyTeamsObj; //Field offset: 0x188
	public MonkeyTeamsIcon monkeyTeamsIcon; //Field offset: 0x190
	public NK_TextMeshProUGUI monkeyTeamsMMEarntTxt; //Field offset: 0x198
	[SerializeField]
	private AccoladesDisplayButton accoladesButton; //Field offset: 0x1A0
	[SerializeField]
	private AccoladeSummaryScreenDisplay accoladesFloatDisplay; //Field offset: 0x1A8
	private readonly List<CalloutUiData> calloutUiData; //Field offset: 0x1B0
	private CalloutManager calloutManager; //Field offset: 0x1B8

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public VictoryScreen() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void FavouriteToggled(bool value) { }

	private void FreeplayClick() { }

	private void GamepadUpdateNav() { }

	protected virtual bool get_IsVictoryScreen() { }

	private string GetSpecialConditionsDisplayText(InGame ingame, LocalizationManager loc) { }

	public void InitialisePlayerStatsPanel() { }

	private void LikeToggled(bool value) { }

	public virtual void Open(object menuData) { }

	[AsyncStateMachine(typeof(<ShowAccolades>d__26))]
	private Task ShowAccolades() { }

}

