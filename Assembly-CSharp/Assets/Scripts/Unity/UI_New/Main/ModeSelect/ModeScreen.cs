namespace Assets.Scripts.Unity.UI_New.Main.ModeSelect;

public class ModeScreen : GameMenu
{
	public GameObject easyModes; //Field offset: 0x48
	public GameObject mediumModes; //Field offset: 0x50
	public GameObject hardModes; //Field offset: 0x58
	public Image medal; //Field offset: 0x60
	public SpriteReference easyMedal; //Field offset: 0x68
	public SpriteReference mediumMedal; //Field offset: 0x70
	public SpriteReference hardMedal; //Field offset: 0x78
	public NK_TextMeshProUGUI headerTxt; //Field offset: 0x80
	public NK_TextMeshProUGUI subTxt; //Field offset: 0x88

	public ModeScreen() { }

	[CompilerGenerated]
	private GameObject <Open>b__9_0() { }

	public override void OnModeSelected(string modeType, bool wasSaveOverwritten) { }

	public virtual void Open(object data) { }

}

