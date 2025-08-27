namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <InitialisePlayerStatsPanel>b__0(CoopPlayerInfo p) { }

	}

	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x110
	public GameObject statsObj; //Field offset: 0x118
	public GameObject freeplayObj; //Field offset: 0x120
	public Image rewardsMmImg; //Field offset: 0x128
	public LootPanel lootPanel; //Field offset: 0x130
	public Button nextButton; //Field offset: 0x138
	public Button freeplayButton; //Field offset: 0x140
	public Image freeplayCountdownTimer; //Field offset: 0x148
	public CoopPlayerStatsPanel[] playersStats; //Field offset: 0x150
	public CoopPlayerPanelFreeplay[] playersFreeplayLoadings; //Field offset: 0x158
	public AudioClip victorySound; //Field offset: 0x160
	public GameObject goldenBloonObj; //Field offset: 0x168
	public NK_TextMeshProUGUI goldenBloonPopCountTxt; //Field offset: 0x170
	public NK_TextMeshProUGUI goldenBloonMMEarntTxt; //Field offset: 0x178
	public GameObject monkeyTeamsObj; //Field offset: 0x180
	public MonkeyTeamsIcon monkeyTeamsIcon; //Field offset: 0x188
	public NK_TextMeshProUGUI monkeyTeamsMMEarntTxt; //Field offset: 0x190
	private readonly List<CalloutUiData> coopCalloutUiData; //Field offset: 0x198
	private CalloutManager calloutManager; //Field offset: 0x1A0
	private bool finishedButtonAnimations; //Field offset: 0x1A8
	private float animTimerCount; //Field offset: 0x1AC
	private bool disableFreeplayButton; //Field offset: 0x1B0

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public CoopVictoryScreen() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	public void EnableFreeplay() { }

	public void FreeplayClick() { }

	private void GamepadUpdateNav() { }

	protected virtual bool get_IsVictoryScreen() { }

	public void InitialiseFreeplayPanel() { }

	public void InitialisePlayerStatsPanel() { }

	public virtual void OnNextClicked() { }

	public virtual void Open(object menuData) { }

	public void Update() { }

}

