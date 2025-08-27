namespace Assets.Scripts.Unity.UI_New.GameOver;

public class CoopDefeatScreen : SummaryScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <InitialisePlayerStatsPanel>b__0(CoopPlayerInfo p) { }

	}

	public NK_TextMeshProUGUI continueCost; //Field offset: 0x110
	public NK_TextMeshProUGUI finalRound; //Field offset: 0x118
	public Button restartButton; //Field offset: 0x120
	public Image restartCountdownTimer; //Field offset: 0x128
	public Button continueButton; //Field offset: 0x130
	public Image continueCountdownTimer; //Field offset: 0x138
	public AudioClip defeatSound; //Field offset: 0x140
	public CoopPlayerStatsPanel[] playersStats; //Field offset: 0x148
	private List<CalloutUiData> coopCalloutUiData; //Field offset: 0x150
	private CalloutManager calloutManager; //Field offset: 0x158
	public NK_TextMeshProUGUI title; //Field offset: 0x160
	public BloonCauseDeathDisplay bloonCauseDeathDisplayPrefab; //Field offset: 0x168
	public GameObject bloonCoDContainer; //Field offset: 0x170
	private List<BloonCauseDeathDisplay> bloonCauseDeathDisplayList; //Field offset: 0x178
	private bool disableButtons; //Field offset: 0x180
	private bool canUseContinue; //Field offset: 0x181
	private bool finishedButtonAnimations; //Field offset: 0x182
	private float animTimerCount; //Field offset: 0x184

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	private TimeSpan RestartButtonDelay
	{
		private get { } //Length: 165
	}

	public CoopDefeatScreen() { }

	[CompilerGenerated]
	private void <ShowContinuePopup>b__27_0() { }

	[CompilerGenerated]
	private void <ShowContinuePopup>b__27_1() { }

	[CompilerGenerated]
	private void <ShowContinuePopup>b__27_2() { }

	[CompilerGenerated]
	private void <ShowContinuePopup>b__27_3() { }

	[CompilerGenerated]
	private void <ShowRestartPopup>b__29_0() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	public void EnableContinueRestart() { }

	private void GamepadUpdateNav() { }

	protected virtual bool get_IsVictoryScreen() { }

	private TimeSpan get_RestartButtonDelay() { }

	public void InitialisePlayerStatsPanel() { }

	private void OnContinueClicked() { }

	private void OnRestartClicked() { }

	public virtual void Open(object menuData) { }

	public virtual void ReOpen(object data) { }

	public void ShowContinuePopup() { }

	public void ShowRestartPopup() { }

	public void Update() { }

}

