namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeDesperado : TSMThemeDefault
{
	public GameObject camoTickbox; //Field offset: 0xC0
	public TSMButton camoButton; //Field offset: 0xC8
	public GameObject bountyHunterTickbox; //Field offset: 0xD0
	public TSMButton bountyHunterButton; //Field offset: 0xD8

	public TSMThemeDesperado() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

