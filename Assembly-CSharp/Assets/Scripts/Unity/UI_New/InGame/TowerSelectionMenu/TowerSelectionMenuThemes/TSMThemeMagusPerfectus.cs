namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeMagusPerfectus : TSMThemeUnpoppedArmy
{
	public TSMButton drainingBeamToggleButton; //Field offset: 0xE8
	public NK_TextMeshProUGUI toggleGraveyardStateText; //Field offset: 0xF0
	public Image drainingBeamCooldownFade; //Field offset: 0xF8
	public int drainingBeamCooldownFrames; //Field offset: 0x100
	private int drainingBeamCooldownFrom; //Field offset: 0x104
	public GameObject drainingBeamSetOn; //Field offset: 0x108
	public GameObject drainingBeamSetOff; //Field offset: 0x110
	public GameObject graveyardUseObject; //Field offset: 0x118
	public GameObject graveyardDrainObject; //Field offset: 0x120
	public Image graveyardUseFill; //Field offset: 0x128
	public Image graveyardDrainFill; //Field offset: 0x130

	public TSMThemeMagusPerfectus() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void Selected(TowerToSimulation tower, bool openedFromRight) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

