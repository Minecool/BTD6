namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeMonkeyAce : TSMThemeWithActionButton
{
	private const int minFramesSinceReverse = 300; //Field offset: 0x0
	public Button reverseButton; //Field offset: 0xE0
	public Button paragonCarpetBomb; //Field offset: 0xE8
	public Image cooldownFade; //Field offset: 0xF0
	public Image buttonImage; //Field offset: 0xF8
	public AudioClip targetBtnSound; //Field offset: 0x100
	public int timeOfLastReverse; //Field offset: 0x108
	private TowerToSimulation selectedTower; //Field offset: 0x110

	public TSMThemeMonkeyAce() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

