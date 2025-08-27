namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeSuperMonkeyBeacon : TSMThemeDefault
{
	public TSMButton rechargeButton; //Field offset: 0xD8
	public NK_TextMeshProUGUI rechargeCostText; //Field offset: 0xE0
	private readonly TSMInfoModel info; //Field offset: 0xE8

	public TSMThemeSuperMonkeyBeacon() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void TowerInfoChanged(TowerToSimulation tower) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

