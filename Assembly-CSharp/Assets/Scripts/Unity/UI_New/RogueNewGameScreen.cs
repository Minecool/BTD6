namespace Assets.Scripts.Unity.UI_New;

public class RogueNewGameScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RogueModeGenericRules, Boolean> <>9__52_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <TrainingModeDCM>b__52_0(RogueModeGenericRules x) { }

	}

	[CompilerGenerated]
	private sealed class <GoToRogueMap>d__48 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GoToRogueMap>d__48(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class NewGamePanelRefresh : MulticastDelegate
	{

		public NewGamePanelRefresh(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[SerializeField]
	private SelectArtifactsPanel selectArtifactsPanel; //Field offset: 0x48
	[SerializeField]
	private RogueCurseSelectPanel rogueCurseSelectPanel; //Field offset: 0x50
	[SerializeField]
	private RogueArtifactDisplayIcon[] startingArtifacts; //Field offset: 0x58
	[SerializeField]
	private RogueArtifactDisplayIcon heroArtifact; //Field offset: 0x60
	[SerializeField]
	private Toggle chimpsToggle; //Field offset: 0x68
	[SerializeField]
	private Lightbox closeNewGamePanelBg; //Field offset: 0x70
	[SerializeField]
	private Button partyBtn; //Field offset: 0x78
	[SerializeField]
	private Button startCampaignBtn; //Field offset: 0x80
	[SerializeField]
	private Button selectArtifactsBtn; //Field offset: 0x88
	[SerializeField]
	private Button continueTrainingBtn; //Field offset: 0x90
	[SerializeField]
	private Button selectCursesBtn; //Field offset: 0x98
	[SerializeField]
	private Button trainingModePlayBtn; //Field offset: 0xA0
	[SerializeField]
	private GameObject instasContainer; //Field offset: 0xA8
	[SerializeField]
	private GameObject instaPrefab; //Field offset: 0xB0
	[SerializeField]
	private GameObject chimpsToggleLock; //Field offset: 0xB8
	[SerializeField]
	private GameObject chimpsToggleIcon; //Field offset: 0xC0
	[SerializeField]
	private Image heroPortrait; //Field offset: 0xC8
	[SerializeField]
	private NK_TextMeshProUGUI powerCountTxt; //Field offset: 0xD0
	[SerializeField]
	private NK_TextMeshProUGUI curseCountBtnTxt; //Field offset: 0xD8
	[SerializeField]
	private NK_TextMeshProUGUI trainingMapTxt; //Field offset: 0xE0
	[SerializeField]
	private NK_TextMeshProUGUI trainingRoundTxt; //Field offset: 0xE8
	[SerializeField]
	private NK_TextMeshProUGUI previewPowerCountTxt; //Field offset: 0xF0
	[SerializeField]
	private MapSelectPanel trainingMapSelect; //Field offset: 0xF8
	private bool isTrainingMode; //Field offset: 0x100
	private readonly List<GameObject> activeInstaIcons; //Field offset: 0x108
	private string selectedMap; //Field offset: 0x110

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueNewGameScreen() { }

	protected virtual void Awake() { }

	private void ContinueTrainingMode() { }

	private void DisplayHero() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private int GetCurseAmount() { }

	private int GetTotalPower() { }

	[IteratorStateMachine(typeof(<GoToRogueMap>d__48))]
	private IEnumerator GoToRogueMap() { }

	private void OnChimpsToggleChanged(bool isOn) { }

	private void OnMapSelected(string map) { }

	public virtual void Open(object data) { }

	private void OpenCursePanel() { }

	public void OpenHeroSelect() { }

	public void OpenSelectArtifactPanel() { }

	public virtual bool OverrideClose() { }

	private void PlayTrainingModeClicked() { }

	private void RefreshUIs() { }

	public virtual void ReOpen(object data) { }

	private void SetupButtons(object data) { }

	private void ShowInstas(IEnumerable<RogueInstaMonkey> instas) { }

	private void ShowStartingArtifacts() { }

	private void StartClicked() { }

	private void StartNewCampaign() { }

	private DailyChallengeModel TrainingModeDCM(string mapName) { }

}

