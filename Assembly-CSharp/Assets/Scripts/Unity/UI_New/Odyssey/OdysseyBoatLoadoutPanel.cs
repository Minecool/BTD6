namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyBoatLoadoutPanel : OdysseyPopup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public OdysseyBoatLoadoutPanel <>4__this; //Field offset: 0x10
		public Toggle[] tabs; //Field offset: 0x18

		public <>c__DisplayClass50_0() { }

		internal void <GamepadSetup>b__0() { }

		internal void <GamepadSetup>b__1() { }

		internal void <GamepadSetup>b__2() { }

	}

	internal enum GamepadMode
	{
		Add = 0,
		Remove = 1,
	}

	public NK_TextMeshProUGUI monkeySeats; //Field offset: 0x48
	public NK_TextMeshProUGUI monkeyMax; //Field offset: 0x50
	public NK_TextMeshProUGUI powerSpace; //Field offset: 0x58
	public NK_TextMeshProUGUI powerMax; //Field offset: 0x60
	public OdysseyTowerDisplay prefabTower; //Field offset: 0x68
	public OdysseyPowerDisplay prefabPower; //Field offset: 0x70
	public OdysseyTowerDisplay prefabHero; //Field offset: 0x78
	public GameObject prefabTowerBackground; //Field offset: 0x80
	public GameObject prefabPowerBackgorund; //Field offset: 0x88
	public GameObject prefabHeroBackgorund; //Field offset: 0x90
	public GameObject objTopPanelNormal; //Field offset: 0x98
	public NK_TextMeshProUGUI titleText; //Field offset: 0xA0
	public GameObject objTopPanelExtreme; //Field offset: 0xA8
	public NK_TextMeshProUGUI titleTextExtreme; //Field offset: 0xB0
	public GameObject objTopPanelActiveOdysseyExtreme; //Field offset: 0xB8
	public NK_TextMeshProUGUI topPanelActiveOdysseyExtreme; //Field offset: 0xC0
	public GameObject objTowerContent; //Field offset: 0xC8
	public GameObject objTowerSeatsContent; //Field offset: 0xD0
	public GameObject objPowerContent; //Field offset: 0xD8
	public GameObject objPowerSlotsContent; //Field offset: 0xE0
	public GameObject objRightTowerPowerContent; //Field offset: 0xE8
	public GameObject objResetCrew; //Field offset: 0xF0
	public GameObject objResetButtonContainer; //Field offset: 0xF8
	protected List<GameObject> towerDisplayList; //Field offset: 0x100
	protected List<GameObject> powerDisplayList; //Field offset: 0x108
	protected List<GameObject> towerBackgroundList; //Field offset: 0x110
	protected List<GameObject> powerBackgroundList; //Field offset: 0x118
	protected List<GameObject> rightPanelList; //Field offset: 0x120
	public Toggle btnMonkeys; //Field offset: 0x128
	public Toggle btnPowers; //Field offset: 0x130
	public Toggle btnHeros; //Field offset: 0x138
	public Button btnResetDefaultLoadout; //Field offset: 0x140
	public Button btnClearMonkeys; //Field offset: 0x148
	public Button btnClearPowers; //Field offset: 0x150
	public Button btnGamepadGroupLeft; //Field offset: 0x158
	public Button btnGamepadGroupRight; //Field offset: 0x160
	public Button btnGamepadToggleMode; //Field offset: 0x168
	public NK_TextMeshProUGUI gamepadToggleModeLabel; //Field offset: 0x170
	private bool canMoProblems; //Field offset: 0x178
	private GamepadMode gamepadMode; //Field offset: 0x17C

	private int CurrentPowerCount
	{
		private get { } //Length: 327
	}

	private int CurrentTowerCount
	{
		private get { } //Length: 473
	}

	public ILocProvider locs
	{
		 get { } //Length: 48
	}

	public OdysseyBoatLoadoutPanel() { }

	public bool CanMoProblems() { }

	protected override void ClearUi() { }

	public void GamepadSelectFirst() { }

	private void GamepadSetMode(GamepadMode mode) { }

	protected void GamepadSetup() { }

	private int get_CurrentPowerCount() { }

	private int get_CurrentTowerCount() { }

	public ILocProvider get_locs() { }

	private int GetTabIndex(Toggle[] tabs) { }

	public override void HeroMinusClicked(TowerData towerData) { }

	public override void HeroPlusClicked(TowerData towerData) { }

	public virtual void Initialize(OdysseyEventScreen odysseyEventScreen, object metaData) { }

	public void OnClickClearMonkeys() { }

	public void OnClickClearPowers() { }

	public override void OnClickResetDefaultLoadout() { }

	public virtual void OnCloseClick() { }

	public override void OnConfirmResetDefaultLoadout() { }

	public virtual void OnDifficultyChanged() { }

	private void OnDisable() { }

	public void OnEmptyBoatSlotClicked() { }

	public void OnEmptyHeroSlotClicked() { }

	public void OnEmptyPowersSlotClicked() { }

	public void OnToggleHerosButton(bool isOn) { }

	public void OnToggleMonkeysButton(bool isOn) { }

	public void OnTogglePowersButton(bool isOn) { }

	public override void PowerMinusClicked(PowerData powerData) { }

	public override void PowerPlusClicked(PowerData powerData) { }

	private bool SelectFirst(Transform container) { }

	public override void SetupUi() { }

	public override void TowerMinusClicked(TowerData towerData) { }

	public override void TowerPlusClicked(TowerData towerData) { }

	private void UpdateGamepadSetMode() { }

	public void UpdateNav() { }

	public override void UpdateUI() { }

}

