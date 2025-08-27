namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeSelectInputOrDefault : TSMThemeDefault
{
	public const string selectInputKey = "SelectInput"; //Field offset: 0x0
	public const string selectDefaultKey = "SelectDefault"; //Field offset: 0x0
	private const int minButtonDelay = 360; //Field offset: 0x0
	public TSMButton selectInputButton; //Field offset: 0xD8
	public TSMButton selectDefaultButton; //Field offset: 0xE0
	public Image targetButtonCooldownFade; //Field offset: 0xE8
	protected readonly TSMInfoModel info; //Field offset: 0xF0

	public TSMThemeSelectInputOrDefault() { }

	public virtual string GetButtonIDTowerSpecial() { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

