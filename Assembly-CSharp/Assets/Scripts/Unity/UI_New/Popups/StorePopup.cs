namespace Assets.Scripts.Unity.UI_New.Popups;

public class StorePopup : Popup
{
	public Image itemImg; //Field offset: 0x128
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x130
	public NK_TextMeshProUGUI descTxt; //Field offset: 0x138
	public NK_TextMeshProUGUI priceTxt; //Field offset: 0x140
	public NK_TextMeshProUGUI salePriceTxt; //Field offset: 0x148
	public NK_TextMeshProUGUI limitedTimerTxt; //Field offset: 0x150
	public GameObject saleObject; //Field offset: 0x158
	public Button purchaseBtn; //Field offset: 0x160
	public Button closeBtn; //Field offset: 0x168
	public LootPanel lootPanel; //Field offset: 0x170
	public Animator storeAnimator; //Field offset: 0x178
	private StoreItem storeItem; //Field offset: 0x180
	private StorePopupState animationState; //Field offset: 0x188
	protected string limitedTimePrefix; //Field offset: 0x190
	private LocalizationManager locManager; //Field offset: 0x198
	private ReturnCallback purchaseCompleteCallback; //Field offset: 0x1A0
	private string boughtStoreItem; //Field offset: 0x1A8

	public StorePopup() { }

	private void CloseClicked() { }

	private static string FormatTimeCountdown(TimeSpan timeRemaining, ILocProvider locManager) { }

	public void Init(StoreItem storeItem, ReturnCallback purchaseCompleteCallback, BackGround background, TransitionAnim transition) { }

	private void InitLootPanel() { }

	private void PurchaseClicked() { }

	private void PurchaseComplete() { }

	private void SetPopupState() { }

	public void Start() { }

	public void Update() { }

	private void UpdateTimeRemaining() { }

}

