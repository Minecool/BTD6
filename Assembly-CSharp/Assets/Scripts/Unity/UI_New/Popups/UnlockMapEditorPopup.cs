namespace Assets.Scripts.Unity.UI_New.Popups;

public class UnlockMapEditorPopup : Popup
{
	public GameObject storePanel; //Field offset: 0x128
	public NK_TextMeshProUGUI iapCostText; //Field offset: 0x130
	public Button purchaseBtnIAP; //Field offset: 0x138
	public Button purchaseWithMmBtn; //Field offset: 0x140
	public HoverableInfoPopup purchaseWithMmLockedInfo; //Field offset: 0x148
	public GameObject purchaseWithMmLockedVisuals; //Field offset: 0x150
	public Button closeBtn; //Field offset: 0x158
	private StoreItem storeItem; //Field offset: 0x160
	private ReturnCallback purchaseCompleteCallback; //Field offset: 0x168

	public UnlockMapEditorPopup() { }

	private void CloseClicked() { }

	public void Init(ReturnCallback purchaseCompleteCallback, BackGround background, TransitionAnim transition) { }

	private void PurchaseComplete() { }

	private void PurchaseFailed() { }

	private void PurchaseIapClicked() { }

	public void Start() { }

	private void UnlockWithMonkeyMoneyClicked() { }

	public void Update() { }

}

