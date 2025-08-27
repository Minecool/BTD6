namespace Assets.Scripts.Unity.UI_New.Main.PowersSelect;

public class InstaTowerDisplay : MonoBehaviour
{
	public NK_TextMeshProUGUI pathsTxt; //Field offset: 0x20
	public Image icon; //Field offset: 0x28
	public GameObject countCont; //Field offset: 0x30
	public NK_TextMeshProUGUI countTxt; //Field offset: 0x38
	public GameObject newNotify; //Field offset: 0x40
	public Material grayscaleMat; //Field offset: 0x48
	[SerializeField]
	private Button button; //Field offset: 0x50
	private OnInstaButtonSelected onInstaButtonSelected; //Field offset: 0x58
	public GameObject selectionFx; //Field offset: 0x60
	[HideInInspector]
	public string towerBaseId; //Field offset: 0x68
	[HideInInspector]
	public int towerUniqueId; //Field offset: 0x70
	[HideInInspector]
	public Int32[] tiers; //Field offset: 0x78

	public InstaTowerDisplay() { }

	private void Awake() { }

	public void DisplayRogueInsta(string towerBaseId, Int32[] tiers, OnInstaButtonSelected onInstaButtonSelected = null) { }

	private SpriteReference GetPowerIcon(string baseId) { }

	public void Init(string towerBaseId, InstaTowerModel itm) { }

	private void InstaClicked() { }

	public void SetInteractable(bool interactable) { }

	public void SetSelected(bool isOn) { }

}

