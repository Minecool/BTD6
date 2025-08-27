namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeSmallUpgradeable : TSMThemeDefault
{
	public NK_TextMeshProUGUI nextLevelText; //Field offset: 0xD8
	public NK_TextMeshProUGUI currentLevelText; //Field offset: 0xE0
	public TSMButton upgradeButton; //Field offset: 0xE8

	public TSMThemeSmallUpgradeable() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

