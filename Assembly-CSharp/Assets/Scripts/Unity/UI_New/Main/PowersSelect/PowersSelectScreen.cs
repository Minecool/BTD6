namespace Assets.Scripts.Unity.UI_New.Main.PowersSelect;

public class PowersSelectScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__89_0; //Field offset: 0x8
		public static Func<PowerModel, Boolean> <>9__94_0; //Field offset: 0x10
		public static Func<PowerModel, Boolean> <>9__94_1; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal void <Open>b__89_0() { }

		internal bool <SetupPowerButtons>b__94_0(PowerModel p) { }

		internal bool <SetupPowerButtons>b__94_1(PowerModel p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_0
	{
		public int path; //Field offset: 0x10
		public PowersSelectScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass89_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass89_1
	{
		public int tier; //Field offset: 0x10
		public <>c__DisplayClass89_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass89_1() { }

		internal void <Open>b__7(BaseEventData data) { }

	}

	[CompilerGenerated]
	private struct <StartBackgroundColourSwap>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Color colour; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal class PowersSelectScreenOpenData
	{
		public PowerModel powerModel; //Field offset: 0x10
		public bool showUpgrades; //Field offset: 0x18

		public PowersSelectScreenOpenData() { }

	}

	internal struct PowerThemeData
	{
		public Color commonBgColour; //Field offset: 0x0
		public Color descriptionTextColour; //Field offset: 0x10
		public GameObject[] objects; //Field offset: 0x20

	}

	public Transform powerButtonsContainer; //Field offset: 0x48
	public PowerSelectButton powerButtonPrefab; //Field offset: 0x50
	private List<PowerSelectButton> powerButtons; //Field offset: 0x58
	private PowerSelectButton selectedPowerButton; //Field offset: 0x60
	public Image selectedPowerIcon; //Field offset: 0x68
	public ToggleGroup toggleGroup; //Field offset: 0x70
	public NK_TextMeshProUGUI menuTitleTxt; //Field offset: 0x78
	public Button instaTowerMenuBtn; //Field offset: 0x80
	public GameObject instaTowerMenuBtnNotify; //Field offset: 0x88
	public AudioClip click1Sound; //Field offset: 0x90
	public AudioClip unlockSound; //Field offset: 0x98
	public AudioClip tabSound; //Field offset: 0xA0
	public AudioClip tickSound; //Field offset: 0xA8
	public AudioClip returnSound; //Field offset: 0xB0
	private List<PowerModel> powers; //Field offset: 0xB8
	[Header("Right panel")]
	public NK_TextMeshProUGUI selectedPowerTitleText; //Field offset: 0xC0
	public NK_TextMeshProUGUI selectedPowerDescriptionText; //Field offset: 0xC8
	public NK_TextMeshProUGUI selectedPowerCostText; //Field offset: 0xD0
	public Image selectedPowerDescriptionPanel; //Field offset: 0xD8
	public Button purchaseButton; //Field offset: 0xE0
	public GameObject costContainer; //Field offset: 0xE8
	public Button storeButton; //Field offset: 0xF0
	public bool goToStoreOnStoreButton; //Field offset: 0xF8
	public Transform countContainer; //Field offset: 0x100
	public NK_TextMeshProUGUI countText; //Field offset: 0x108
	public Transform animatedIconContainer; //Field offset: 0x110
	public GameObject nextTierParent; //Field offset: 0x118
	public NK_TextMeshProUGUI nextTierXpText; //Field offset: 0x120
	public NK_TextMeshProUGUI nextTierDescriptionText; //Field offset: 0x128
	public Image nextTierBar; //Field offset: 0x130
	public Animator nextTierBarFlashAnimator; //Field offset: 0x138
	[Header("Power pro lock box")]
	public GameObject proLockContainer; //Field offset: 0x140
	public Image proLockXpSlider; //Field offset: 0x148
	public Image proLockIcon; //Field offset: 0x150
	public NK_TextMeshProUGUI proLockText; //Field offset: 0x158
	public NK_TextMeshProUGUI xpUnlockText; //Field offset: 0x160
	[Header("Power pro short lock info")]
	public GameObject shortLockContainer; //Field offset: 0x168
	public Image shortLockXpSlider; //Field offset: 0x170
	public Animator barFlashAnimator; //Field offset: 0x178
	[Header("Info popup")]
	public Button infoButton; //Field offset: 0x180
	public GameObject infoPopup; //Field offset: 0x188
	public Button closeInfoPopupButton; //Field offset: 0x190
	[Header("Upgrades popup")]
	public Button proUpgradesButton; //Field offset: 0x198
	public GameObject proUpgradesPopup; //Field offset: 0x1A0
	public GameObject newUpgradePip; //Field offset: 0x1A8
	public Toggle baseUpgrade; //Field offset: 0x1B0
	public Toggle[] path1UpgradeButtons; //Field offset: 0x1B8
	public Toggle[] path2UpgradeButtons; //Field offset: 0x1C0
	public Toggle[] path3UpgradeButtons; //Field offset: 0x1C8
	private Toggle[][] allPaths; //Field offset: 0x1D0
	public NK_TextMeshProUGUI proUpgradeHeader; //Field offset: 0x1D8
	public NK_TextMeshProUGUI proUpgradeSubHeader; //Field offset: 0x1E0
	public NK_TextMeshProUGUI proUpgradeDescription; //Field offset: 0x1E8
	public GameObject proUpgradeCostContainer; //Field offset: 0x1F0
	public NK_TextMeshProUGUI proUpgradeCost; //Field offset: 0x1F8
	public GameObject tier1Lock; //Field offset: 0x200
	public GameObject tier2Lock; //Field offset: 0x208
	public GameObject tier3Lock; //Field offset: 0x210
	public Image tier1LockBar; //Field offset: 0x218
	public Image otherTierLockBar; //Field offset: 0x220
	public GameObject tier1LockParent; //Field offset: 0x228
	public GameObject otherTiersLockParent; //Field offset: 0x230
	public NK_TextMeshProUGUI tier1UnlockText; //Field offset: 0x238
	public NK_TextMeshProUGUI otherTierUnlockText; //Field offset: 0x240
	public NK_TextMeshProUGUI tier1LockXpText; //Field offset: 0x248
	public NK_TextMeshProUGUI otherTierLockXpText; //Field offset: 0x250
	[Header("Filters")]
	public Toggle allFilterToggle; //Field offset: 0x258
	public Toggle powerFilterToggle; //Field offset: 0x260
	public Toggle powerProFilterToggle; //Field offset: 0x268
	[Header("Theme data")]
	public PowerThemeData powerTheme; //Field offset: 0x270
	public PowerThemeData powerProTheme; //Field offset: 0x298
	public PowerThemeData IAPTheme; //Field offset: 0x2C0
	private PowerThemeData currentTheme; //Field offset: 0x2E8
	private bool firstThemeUpdate; //Field offset: 0x310

	private PowersProSaveData SaveData
	{
		private get { } //Length: 81
	}

	public PowerModel SelectedPowerModel
	{
		 get { } //Length: 125
	}

	public PowersSelectScreen() { }

	[CompilerGenerated]
	private void <Open>b__89_1() { }

	[CompilerGenerated]
	private void <Open>b__89_2() { }

	[CompilerGenerated]
	private void <Open>b__89_3() { }

	[CompilerGenerated]
	private GameObject <Open>b__89_4() { }

	[CompilerGenerated]
	private void <Open>b__89_5(BaseEventData data) { }

	[CompilerGenerated]
	private void <Open>b__89_6() { }

	[CompilerGenerated]
	private void <OpenStorePopup>b__106_0() { }

	[CompilerGenerated]
	private void <ShowInfoPopup>b__90_0() { }

	public virtual void Close() { }

	public void DebugAddProXp() { }

	private bool DebugGetProId(out string id) { }

	public void DebugRemoveProXp() { }

	private void DebugUpdate() { }

	public void DisplayPower(PowerSelectButton powerButton, bool fromPurchase = false) { }

	public void ForceLock() { }

	public void ForceUnlock() { }

	private PowersProSaveData get_SaveData() { }

	public PowerModel get_SelectedPowerModel() { }

	private PowerSelectButton GetFirstButton() { }

	public string GetProOrBasePowerId(string id) { }

	private PowerSelectButton GetSelectedPowerButton() { }

	private void OnFilterAll(bool newValue) { }

	private void OnFilterPower(bool newValue) { }

	private void OnFilterPowerPro(bool newValue) { }

	public void OnStoreButton() { }

	public virtual void Open(object data) { }

	public void OpenStorePopup(string iapId) { }

	private void PopulateProUpgrades() { }

	private void PowerButton_OnSelect(PowerSelectButton powerButton) { }

	public void PurchaseSelectedPower() { }

	public void ResetUnlockAnims() { }

	private void SelectUpgrade(int path, int tier) { }

	private void SetupPowerButtons() { }

	private void ShowInfoPopup() { }

	private void ShowScreen(PowerModel powerModel) { }

	[AsyncStateMachine(typeof(<StartBackgroundColourSwap>d__100))]
	private void StartBackgroundColourSwap(Color colour) { }

	private void UpdateProXpDisplays(PowerModel power, bool fromPurchase = false) { }

	private void UpdateShortProXpDisplay(bool fromPurchase = false) { }

	private void UpdateTheme(PowerModel power) { }

}

