namespace Assets.Scripts.Unity.UI_New.Main.PowersSelect;

public class PowersSelectScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__17_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Open>b__17_0() { }

	}

	public Transform powerButtonsContainer; //Field offset: 0x48
	public PowerSelectButton powerButtonPrefab; //Field offset: 0x50
	private List<PowerSelectButton> powerButtons; //Field offset: 0x58
	private PowerModel selectedPowerModel; //Field offset: 0x60
	public Image selectedPowerIcon; //Field offset: 0x68
	public NK_TextMeshProUGUI selectedPowerTitleText; //Field offset: 0x70
	public NK_TextMeshProUGUI selectedPowerDescriptionText; //Field offset: 0x78
	public NK_TextMeshProUGUI selectedPowerCostText; //Field offset: 0x80
	public Button purchaseButton; //Field offset: 0x88
	public ToggleGroup toggleGroup; //Field offset: 0x90
	public NK_TextMeshProUGUI menuTitleTxt; //Field offset: 0x98
	public Button instaTowerMenuBtn; //Field offset: 0xA0
	public GameObject instaTowerMenuBtnNotify; //Field offset: 0xA8
	public GameObject costContainer; //Field offset: 0xB0
	public AudioClip click3Sound; //Field offset: 0xB8
	public AudioClip unlockSound; //Field offset: 0xC0
	public Button storeButton; //Field offset: 0xC8

	public PowersSelectScreen() { }

	[CompilerGenerated]
	private GameObject <Open>b__17_1() { }

	public void DisplayPower(PowerModel power) { }

	private PowerSelectButton GetFirstButton() { }

	private PowerSelectButton GetSelectedPowerButton() { }

	public void OnStoreButton() { }

	public virtual void Open(object data) { }

	private void PowerButton_OnSelect(PowerSelectButton powerButton) { }

	public void PurchaseSelectedPower() { }

	private void SetupPowerButtons() { }

	private void ShowScreen(PowerModel powerModel) { }

}

