namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeCamo : TSMThemeDefault
{
	public Button prioCamoButton; //Field offset: 0xC0
	public GameObject toggleTickbox; //Field offset: 0xC8

	public TSMThemeCamo() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

