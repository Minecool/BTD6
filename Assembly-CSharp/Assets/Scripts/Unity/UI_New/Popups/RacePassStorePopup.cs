namespace Assets.Scripts.Unity.UI_New.Popups;

public class RacePassStorePopup : Popup
{
	public NK_TextMeshProUGUI priceTxt; //Field offset: 0x128
	public Button purchaseBtn; //Field offset: 0x130
	public NK_TextMeshProUGUI priceTxt2; //Field offset: 0x138
	public Button purchaseBtn2; //Field offset: 0x140
	public Button closeBtn; //Field offset: 0x148
	private StoreItem storeItem; //Field offset: 0x150
	private StoreItem storeItem2; //Field offset: 0x158
	private ReturnCallback purchaseCompleteCallback; //Field offset: 0x160

	public RacePassStorePopup() { }

	private void CloseClicked() { }

	public void Init(ReturnCallback purchaseCompleteCallback, BackGround background, TransitionAnim transition) { }

	private void Purchase2Clicked() { }

	private void PurchaseClicked() { }

	private void PurchaseComplete() { }

	public void Start() { }

	public void Update() { }

}

