namespace Assets.Scripts.Unity.UI_New.EndGame;

public class OdysseyVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TopContributor, String> <>9__20_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ShowAccolades>b__20_0(TopContributor x) { }

	}

	[CompilerGenerated]
	private struct <ShowAccolades>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public OdysseyVictoryScreen <>4__this; //Field offset: 0x20
		private PlayerContentInfo <contentInfo>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public LootPanel lootPanel; //Field offset: 0x110
	public GameObject odysseyCompleteBanner; //Field offset: 0x118
	public GameObject odysseyStageCompleteBanner; //Field offset: 0x120
	public Button continueBtn; //Field offset: 0x128
	public AudioClip victorySound; //Field offset: 0x130
	public GameObject specialConditionsResult; //Field offset: 0x138
	public GameObject rewardsCollectedObj; //Field offset: 0x140
	public GameObject rewardsPanel; //Field offset: 0x148
	[SerializeField]
	private GameObject userChallengeObj; //Field offset: 0x150
	[SerializeField]
	private AccoladesDisplayButton accoladesButton; //Field offset: 0x158
	[SerializeField]
	private AccoladeSummaryScreenDisplay accoladesFloatDisplay; //Field offset: 0x160
	public OdysseyMapPanel[] odysseyMapPanels; //Field offset: 0x168
	public NK_TextMeshProUGUI titleTextMapComplete; //Field offset: 0x170

	public OdysseyDifficultySaveData DifficultyData
	{
		 get { } //Length: 135
	}

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public OdysseySaveData SaveData
	{
		 get { } //Length: 33
	}

	public OdysseyVictoryScreen() { }

	[CompilerGenerated]
	private void <Open>b__19_0() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void GamepadUpdateNav() { }

	public OdysseyDifficultySaveData get_DifficultyData() { }

	protected virtual bool get_IsVictoryScreen() { }

	public OdysseySaveData get_SaveData() { }

	public virtual void Open(object menuData) { }

	private void SaveDataAndSendAnalytics() { }

	private void SetSpecialConditionsText() { }

	[AsyncStateMachine(typeof(<ShowAccolades>d__20))]
	private Task ShowAccolades() { }

}

