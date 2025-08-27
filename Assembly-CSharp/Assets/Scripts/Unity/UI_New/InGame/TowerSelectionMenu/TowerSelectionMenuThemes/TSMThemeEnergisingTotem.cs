namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeEnergisingTotem : TSMThemeDefault
{
	public TSMButton rechargeButton; //Field offset: 0xC0
	public NK_TextMeshProUGUI rechargeCostText; //Field offset: 0xC8
	private readonly TSMInfoModel info; //Field offset: 0xD0

	public TSMThemeEnergisingTotem() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

