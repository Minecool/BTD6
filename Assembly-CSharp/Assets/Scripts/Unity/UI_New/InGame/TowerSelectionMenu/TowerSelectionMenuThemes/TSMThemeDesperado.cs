namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeDesperado : TSMThemeDefault
{
	public GameObject camoTickbox; //Field offset: 0xD8
	public TSMButton camoButton; //Field offset: 0xE0
	public GameObject bountyHunterTickbox; //Field offset: 0xE8
	public TSMButton bountyHunterButton; //Field offset: 0xF0

	public TSMThemeDesperado() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

