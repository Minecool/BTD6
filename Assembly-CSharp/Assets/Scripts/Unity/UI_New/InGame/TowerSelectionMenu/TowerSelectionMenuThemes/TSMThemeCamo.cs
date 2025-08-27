namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeCamo : TSMThemeDefault
{
	public Button prioCamoButton; //Field offset: 0xD8
	public GameObject toggleTickbox; //Field offset: 0xE0

	public TSMThemeCamo() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

