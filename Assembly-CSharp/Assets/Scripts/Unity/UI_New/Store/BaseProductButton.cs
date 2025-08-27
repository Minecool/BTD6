namespace Assets.Scripts.Unity.UI_New.Store;

public abstract class BaseProductButton : MonoBehaviour
{
	public TMP_Text heading; //Field offset: 0x20
	public TMP_Text price; //Field offset: 0x28
	public TMP_Text timeRemaining; //Field offset: 0x30
	public Button button; //Field offset: 0x38
	public Button buyButtonArea; //Field offset: 0x40
	public GameObject purchasedObj; //Field offset: 0x48
	protected StoreItem productModel; //Field offset: 0x50
	private string localizedPriceString; //Field offset: 0x58
	public Image icon; //Field offset: 0x60
	protected string limitedTimePrefix; //Field offset: 0x68

	protected BaseProductButton() { }

	public void Bind(StoreItem productModel) { }

	private static string FormatTimeCountdown(TimeSpan timeRemaining, ILocProvider locManager) { }

	protected override void OnBind(StoreItem productModel) { }

	public abstract void OnPurchaseComplete() { }

	protected override void OnTemporarySaleFinished() { }

	private void SetBuyButtonInteractable(bool interactable, bool hidePurchasedObj = true) { }

	protected void SetPriceText(string text) { }

	public override void StartPurchase() { }

	protected override void Update() { }

}

