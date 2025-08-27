namespace Assets.Scripts.Unity.UI_New;

public class RogueCurseItemDisplay : MonoBehaviour
{
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI costTxt; //Field offset: 0x28
	[SerializeField]
	private Image icon; //Field offset: 0x30
	[SerializeField]
	private Button selectBtn; //Field offset: 0x38
	[SerializeField]
	private Button toggleBtn; //Field offset: 0x40
	[SerializeField]
	private GameObject activePanelObj; //Field offset: 0x48
	[SerializeField]
	private GameObject inActivePanelObj; //Field offset: 0x50
	[SerializeField]
	private GameObject checkmark; //Field offset: 0x58
	[SerializeField]
	private GameObject highlightFx; //Field offset: 0x60
	[HideInInspector]
	public RogueXpShopItem rogueXpShopItem; //Field offset: 0x68
	private OnCurseItemSelected selectedCallback; //Field offset: 0x70
	private OnCurseItemSelected toggledCallback; //Field offset: 0x78

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	public RogueCurseItemDisplay() { }

	private void Awake() { }

	public void Bind(RogueXpShopItem rogueXpShopItem, OnCurseItemSelected selectedCallback, OnCurseItemSelected toggledCallback) { }

	private LegendsDataModel get_LegendsData() { }

	public void RefreshUIs(int level) { }

	private void SelectClicked() { }

	public void SetSelectionFx(bool selected) { }

	private void ToggleClicked() { }

}

