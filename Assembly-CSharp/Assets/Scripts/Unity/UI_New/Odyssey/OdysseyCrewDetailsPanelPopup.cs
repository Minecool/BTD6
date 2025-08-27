namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyCrewDetailsPanelPopup : OdysseyPopup
{
	public NK_TextMeshProUGUI heroSeats; //Field offset: 0x48
	public NK_TextMeshProUGUI monkeySeats; //Field offset: 0x50
	public NK_TextMeshProUGUI monkeyMax; //Field offset: 0x58
	public NK_TextMeshProUGUI powerSpace; //Field offset: 0x60
	public NK_TextMeshProUGUI powerMax; //Field offset: 0x68
	public GameObject allHerosBanner; //Field offset: 0x70
	public GameObject herosContentPanel; //Field offset: 0x78
	public GameObject towersContentPanel; //Field offset: 0x80
	public GameObject powersContentPanel; //Field offset: 0x88
	public OdysseyTowerDisplay towerPrefab; //Field offset: 0x90
	public OdysseyPowerDisplay powerPrefab; //Field offset: 0x98
	public GameObject extremeOverlay; //Field offset: 0xA0
	private List<GameObject> herosDisplayList; //Field offset: 0xA8
	private List<GameObject> towerDisplayList; //Field offset: 0xB0
	private List<GameObject> powerDisplayList; //Field offset: 0xB8

	public OdysseyCrewDetailsPanelPopup() { }

	public virtual void Initialize(OdysseyEventScreen parentScreen, object metaData) { }

	public virtual void OnDifficultyChanged() { }

	private void SetupUi() { }

}

