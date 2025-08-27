namespace Assets.Scripts.Unity.UI_New;

public class RogueXpShopPanel : MonoBehaviour
{
	internal sealed class OnXpShopIconSelected : MulticastDelegate
	{

		public OnXpShopIconSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueXpShopItemDisplay item, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueXpShopItemDisplay item) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI selectedTitleTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI selectedDescriptionTxt; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI xpAmountTxt; //Field offset: 0x30
	[SerializeField]
	private Transform itemsContainer; //Field offset: 0x38
	[SerializeField]
	private RogueXpShopItemDisplay itemPrefab; //Field offset: 0x40
	[SerializeField]
	private Button purchaseItemBtn; //Field offset: 0x48
	[SerializeField]
	private Button respecBtn; //Field offset: 0x50
	[SerializeField]
	private Lightbox backBg; //Field offset: 0x58
	[SerializeField]
	private GameObject maxLevelObj; //Field offset: 0x60
	[SerializeField]
	private GameObject nextArrow; //Field offset: 0x68
	[SerializeField]
	private GameObject nextBuffLevelObj; //Field offset: 0x70
	[SerializeField]
	private NK_TextMeshProUGUI currentBuffTxt; //Field offset: 0x78
	[SerializeField]
	private NK_TextMeshProUGUI nextBuffTxt; //Field offset: 0x80
	[SerializeField]
	private NK_TextMeshProUGUI selectedItemXpCostTxt; //Field offset: 0x88
	[SerializeField]
	private Color canAffordTxtColor; //Field offset: 0x90
	[SerializeField]
	private Color canNotAffordTxtColor; //Field offset: 0xA0
	private RogueXpShopItemDisplay selectedIcon; //Field offset: 0xB0
	private List<RogueXpShopItemDisplay> activeItemDisplays; //Field offset: 0xB8

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueXpShopPanel() { }

	private void Awake() { }

	public void Close() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private void ItemClicked(RogueXpShopItemDisplay item) { }

	public void Open() { }

	private void PopulateShopItems() { }

	private void PurchaseClicked() { }

	private void RefundAllXp() { }

	private void RespecClicked() { }

	private void SetSelectionFx() { }

	private void UpdateUIs() { }

}

