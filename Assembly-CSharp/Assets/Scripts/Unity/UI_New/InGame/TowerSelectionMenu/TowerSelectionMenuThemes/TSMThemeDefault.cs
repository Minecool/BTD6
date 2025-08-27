namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeDefault : BaseTSMTheme
{
	public NK_TextMeshProUGUI towerName; //Field offset: 0x30
	public NK_TextMeshProUGUI popCountText; //Field offset: 0x38
	public NK_TextMeshProUGUI cashCountText; //Field offset: 0x40
	public NK_TextMeshProUGUI targetTypeText; //Field offset: 0x48
	public Image towerMonkeyImage; //Field offset: 0x50
	public Image towerBackgroundImage; //Field offset: 0x58
	public SpriteReference primarySprite; //Field offset: 0x60
	public SpriteReference militarySprite; //Field offset: 0x68
	public SpriteReference magicSprite; //Field offset: 0x70
	public SpriteReference supportSprite; //Field offset: 0x78
	public SpriteReference heroSprite; //Field offset: 0x80
	public SpriteReference paragonSprite; //Field offset: 0x88
	public TSMButton targetTypeBackwardsButton; //Field offset: 0x90
	public TSMButton targetTypeForwardsButton; //Field offset: 0x98
	public GameObject namedMonkeyInput; //Field offset: 0xA0
	public TSMButton namedMonkeyButton; //Field offset: 0xA8
	public Image[] coopPlayerIcons; //Field offset: 0xB0
	private SpriteReference currentTowerMonkeyImage; //Field offset: 0xB8
	public GameObject xpBarObject; //Field offset: 0xC0
	public Image xpBarImage; //Field offset: 0xC8
	public NK_TextMeshProUGUI xpText; //Field offset: 0xD0

	public TSMThemeDefault() { }

	protected void CheckCustomInput(TowerToSimulation tower, TSMButton button) { }

	private string ConvertTouchTextToMouse(string text) { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void OnSpecialUiEvent(TowerToSimulation selectedTower, string eventId) { }

	public virtual void OnTargetTypeChanged(TowerToSimulation tower) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void TowerInfoChanged(TowerToSimulation tower) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

	public virtual void UpdateName(string nameOverride, bool canEdit) { }

	protected void UpdatePowerProInfo(TowerToSimulation tower) { }

	public void UpdateTargetType(TowerToSimulation tower) { }

}

