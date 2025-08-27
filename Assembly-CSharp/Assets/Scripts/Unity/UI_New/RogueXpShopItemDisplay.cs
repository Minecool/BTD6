namespace Assets.Scripts.Unity.UI_New;

public class RogueXpShopItemDisplay : MonoBehaviour
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
	private Color unpurchasedTxtColor; //Field offset: 0x40
	[SerializeField]
	private Color purchasedTxtColor; //Field offset: 0x50
	[SerializeField]
	private Color canAffordTxtColor; //Field offset: 0x60
	[SerializeField]
	private Color canNotAffordTxtColor; //Field offset: 0x70
	[SerializeField]
	private GameObject activePanelObj; //Field offset: 0x80
	[SerializeField]
	private GameObject inActivePanelObj; //Field offset: 0x88
	[SerializeField]
	private GameObject checkmark; //Field offset: 0x90
	[SerializeField]
	private GameObject highlightFx; //Field offset: 0x98
	[SerializeField]
	private GameObject costObj; //Field offset: 0xA0
	[SerializeField]
	private GameObject totalEffectObj; //Field offset: 0xA8
	[SerializeField]
	private GameObject maxLevelObj; //Field offset: 0xB0
	[SerializeField]
	private NK_TextMeshProUGUI totalEffectAmount; //Field offset: 0xB8
	[SerializeField]
	private NK_TextMeshProUGUI levelTxt; //Field offset: 0xC0
	[HideInInspector]
	public RogueXpShopItem rogueXpShopItem; //Field offset: 0xC8
	private OnXpShopIconSelected selectedCallback; //Field offset: 0xD0

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	public RogueXpShopItemDisplay() { }

	private void Awake() { }

	public void Bind(RogueXpShopItem rogueXpShopItem, OnXpShopIconSelected selectedCallback) { }

	private LegendsDataModel get_LegendsData() { }

	public void RefreshUIs(int level) { }

	private void SelectClicked() { }

	public void SetSelectionFx(bool selected) { }

}

