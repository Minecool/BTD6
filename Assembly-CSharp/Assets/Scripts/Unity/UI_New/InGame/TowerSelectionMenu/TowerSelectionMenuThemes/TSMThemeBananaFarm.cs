namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMThemeBananaFarm : TSMThemeDefault
{
	public TSMButton collectButton; //Field offset: 0xC0
	public TSMButton collectAllButton; //Field offset: 0xC8
	public TSMButton depositButton; //Field offset: 0xD0
	public GameObject collectObject; //Field offset: 0xD8
	public GameObject collectAllObject; //Field offset: 0xE0
	public GameObject depositObject; //Field offset: 0xE8
	public NK_TextMeshProUGUI collectAmount; //Field offset: 0xF0
	public NK_TextMeshProUGUI collectAllAmount; //Field offset: 0xF8
	public NK_TextMeshProUGUI depositAmount; //Field offset: 0x100
	public GameObject debtObject; //Field offset: 0x108
	public NK_TextMeshProUGUI debtText; //Field offset: 0x110
	private readonly TSMInfoModel info; //Field offset: 0x118

	public TSMThemeBananaFarm() { }

	public virtual TSMInfoModel OnButtonPress(TowerToSimulation tower, TSMButton button) { }

	public virtual void UpdateFromSimInfo(TowerToSimulation tower, Dictionary<String, TSMInfoModel> objects) { }

}

