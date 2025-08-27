namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeRosalia : TSMThemeDefault
{
	private const int minFramesSinceJump = 120; //Field offset: 0x0
	private const int minFramesSinceWeaponSwitch = 120; //Field offset: 0x0
	public TSMButton leftHandButton; //Field offset: 0xC0
	public TSMButton rightHandButton; //Field offset: 0xC8
	public TSMButton jumpButton; //Field offset: 0xD0
	public Image jumpButtonCooldownFade; //Field offset: 0xD8
	public Image handButtonCooldownFade; //Field offset: 0xE0

	public TSMThemeRosalia() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual string GetButtonIDTowerSpecial2() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

