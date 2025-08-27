namespace Assets.Scripts.Unity.UI_New.Main.PowersSelect;

public class InstaTowerTypeDisplay : MonoBehaviour
{
	public Button objBtn; //Field offset: 0x20
	public NK_TextMeshProUGUI nameTxt; //Field offset: 0x28
	public GameObject blueBorder; //Field offset: 0x30
	public GameObject goldBorder; //Field offset: 0x38
	public GameObject blackBorder; //Field offset: 0x40
	public Image icon; //Field offset: 0x48
	public GameObject countCont; //Field offset: 0x50
	public NK_TextMeshProUGUI countTxt; //Field offset: 0x58
	public GameObject newNotify; //Field offset: 0x60
	public Color textColorDisabled; //Field offset: 0x68
	public Material disabledMaterial; //Field offset: 0x78
	public Button DEBUGAddAllInstasBtn; //Field offset: 0x80
	public Button DEBUGRemoveAllInstasBtn; //Field offset: 0x88
	public Button DEBUGAddAllButTier5InstasBtn; //Field offset: 0x90
	public Button DEBUGAddRandomInstasBtn; //Field offset: 0x98
	[HideInInspector]
	public string baseTowerID; //Field offset: 0xA0
	[HideInInspector]
	public bool hasCollectionOrInventory; //Field offset: 0xA8

	public InstaTowerTypeDisplay() { }

	public void Init(TowerModel tm) { }

	public void UpdateDisplay(List<InstaTowerModel> mitt) { }

}

