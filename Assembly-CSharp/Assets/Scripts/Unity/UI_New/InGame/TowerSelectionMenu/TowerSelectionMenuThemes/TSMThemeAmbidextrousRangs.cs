namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeAmbidextrousRangs : TSMThemeDefault
{
	public TSMButton leftHandButton; //Field offset: 0xC0
	public TSMButton rightHandButton; //Field offset: 0xC8
	private bool isMonkeyPortraitFlipped; //Field offset: 0xD0

	public TSMThemeAmbidextrousRangs() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

