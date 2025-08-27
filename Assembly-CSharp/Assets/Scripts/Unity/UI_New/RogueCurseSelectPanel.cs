namespace Assets.Scripts.Unity.UI_New;

public class RogueCurseSelectPanel : MonoBehaviour
{
	internal sealed class OnCurseItemSelected : MulticastDelegate
	{

		public OnCurseItemSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueCurseItemDisplay item, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueCurseItemDisplay item) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI selectedTitleTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI selectedDescriptionTxt; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI curseAmountTxt; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI curseXpMultiplierTxt; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI purchaseBtnTxt; //Field offset: 0x40
	[SerializeField]
	private Transform itemsContainer; //Field offset: 0x48
	[SerializeField]
	private RogueCurseItemDisplay itemPrefab; //Field offset: 0x50
	[SerializeField]
	private Button applyItemBtn; //Field offset: 0x58
	[SerializeField]
	private Button clearBtn; //Field offset: 0x60
	[SerializeField]
	private Lightbox backBg; //Field offset: 0x68
	private RogueCurseItemDisplay selectedIcon; //Field offset: 0x70
	private List<RogueCurseItemDisplay> activeItemDisplays; //Field offset: 0x78

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

	public RogueCurseSelectPanel() { }

	private void ApplyCurseClicked() { }

	private void Awake() { }

	private void Clear() { }

	public void Close() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueData get_RogueData() { }

	private void ItemSelected(RogueCurseItemDisplay item) { }

	private void ItemToggled(RogueCurseItemDisplay item) { }

	public void Open() { }

	private void PopulateShopItems() { }

	private void SetSelectionFx() { }

	private void UpdateUIs() { }

}

