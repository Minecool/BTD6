namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeMonkeySub : TSMThemeDefault
{
	private const float submergeCooldownSeconds = 0.5; //Field offset: 0x0
	private int lastFrameSubmergeButtonWasClicked; //Field offset: 0xD8
	public Button submergeButton; //Field offset: 0xE0
	public GameObject submergeIcon; //Field offset: 0xE8
	public GameObject unsubmergeIcon; //Field offset: 0xF0
	public Image cooldownFade; //Field offset: 0xF8
	private int submergeCooldownFrames; //Field offset: 0x100

	public TSMThemeMonkeySub() { }

	public virtual string GetButtonIDTowerSpecial() { }

	private bool IsSubmergeButtonOnCooldown() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

