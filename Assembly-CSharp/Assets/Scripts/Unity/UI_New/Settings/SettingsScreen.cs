namespace Assets.Scripts.Unity.UI_New.Settings;

public class SettingsScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__47_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Open>b__47_0() { }

	}

	[CompilerGenerated]
	private struct <BackUpData>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnReviewDataConsent>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float delay = 5; //Field offset: 0x0
	public NK_TextMeshProUGUI copyrightText; //Field offset: 0x48
	public NK_TextMeshProUGUI jukeBoxText; //Field offset: 0x50
	public NK_TextMeshProUGUI jukeBoxEnabledText; //Field offset: 0x58
	public Image flagImage; //Field offset: 0x60
	public GameObject backupStatus; //Field offset: 0x68
	public GameObject backupInProgress; //Field offset: 0x70
	public GameObject backupSucceeded; //Field offset: 0x78
	public GameObject backupFailed; //Field offset: 0x80
	public Button backupBtn; //Field offset: 0x88
	public Button profileBtn; //Field offset: 0x90
	public Button langBtn; //Field offset: 0x98
	public Button hotkeysBtn; //Field offset: 0xA0
	public Button accessibilityBtn; //Field offset: 0xA8
	public Button extraSettingsBtn; //Field offset: 0xB0
	public Button jukeBoxBtn; //Field offset: 0xB8
	public Button jukeBoxCheckBtn; //Field offset: 0xC0
	public Button updateBtn; //Field offset: 0xC8
	public Button nexusBtn; //Field offset: 0xD0
	public Button twitchBtn; //Field offset: 0xD8
	public Button logoutBtn; //Field offset: 0xE0
	public Image jukeBoxTickImg; //Field offset: 0xE8
	public GameObject extraSettingsBtnNotify; //Field offset: 0xF0
	public GameObject doubleCashPopup; //Field offset: 0xF8
	private float doubleCashHideTime; //Field offset: 0x100
	public Button toggleDebug; //Field offset: 0x108
	public GameObject debugPanel; //Field offset: 0x110
	public Button giftDC; //Field offset: 0x118
	public Button giftBB; //Field offset: 0x120
	public Button giftSB; //Field offset: 0x128
	public Button giftBT; //Field offset: 0x130
	public Button giftST; //Field offset: 0x138
	public ScreenSizeDropDown screenSizeDropDown; //Field offset: 0x140
	public GameObject updateNotes; //Field offset: 0x148
	public GameObject dataConsentContainer; //Field offset: 0x150
	public Button dataConsentReviewBtn; //Field offset: 0x158
	public NK_TextMeshProUGUI dataConsentText; //Field offset: 0x160
	public GameObject dataConsentTick; //Field offset: 0x168
	public Slider voiceSlider; //Field offset: 0x170
	[SerializeField]
	private Button rogueResetBtn; //Field offset: 0x178
	private bool autoHide; //Field offset: 0x180
	private float hideTime; //Field offset: 0x184

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 211
	}

	public SettingsScreen() { }

	[CompilerGenerated]
	private void <GamepadInit>b__50_0(InputSystemMode x) { }

	[CompilerGenerated]
	private GameObject <Open>b__47_1() { }

	private void AccessibilityClicked() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<BackUpData>d__52))]
	private void BackUpData() { }

	private void CheckExtraSettingBtn() { }

	private void ExtraSettingsClicked() { }

	private void GamepadInit() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private void HotkeysClicked() { }

	private void JukeBoxCheckClicked() { }

	private void JukeBoxClicked() { }

	private void LanguageClicked() { }

	public static void Logout() { }

	public void OnDestroy() { }

	[AsyncStateMachine(typeof(<OnReviewDataConsent>d__68))]
	private void OnReviewDataConsent() { }

	public virtual void Open(object menuData) { }

	private void RogueResetClicked() { }

	public void SendRestartAnalyticsAndDelete() { }

	private void ShowBackupStatus(GameObject toShow, bool autoHide = true) { }

	private void ShowDoubleCashMessage() { }

	private void ShowJukeBoxTick(bool show) { }

	public void ShowUpdateNotes() { }

	private void ToggleButtonsInteractive(bool setIneractive) { }

	private void Update() { }

	private void UpdateDataConsentState(bool hasGivenConsent) { }

	private void UpdateNav() { }

}

