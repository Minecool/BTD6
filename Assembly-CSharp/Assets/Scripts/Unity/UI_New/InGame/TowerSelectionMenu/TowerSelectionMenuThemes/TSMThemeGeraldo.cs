namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeGeraldo : TSMThemeWithActionButton
{

	public TSMThemeGeraldo() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

}

