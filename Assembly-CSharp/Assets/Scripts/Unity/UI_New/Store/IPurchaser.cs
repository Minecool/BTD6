namespace Assets.Scripts.Unity.UI_New.Store;

public interface IPurchaser
{

	public bool CanThrowValidationExceptions
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public PurchaseValidator CurrentPurchaseValidator
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void BuyProduct(string productID) { }

	public void BuyTowerProduct(string productID, string towerID) { }

	public bool get_CanThrowValidationExceptions() { }

	public PurchaseValidator get_CurrentPurchaseValidator() { }

	public string GetLocalizedPriceString(string productId) { }

	public bool HasUnviewedLoot() { }

	public void InitializePurchasing() { }

	public bool IsInitialized() { }

	public bool IsNonConsumablePurchased(string productID) { }

	public bool IsOneTimeConsumablePurchased(string productID) { }

	public bool IsProcessing() { }

	public bool IsProcessing(string productID) { }

	public LootSet PopUnviewedLoot() { }

	public void RestorePurchases() { }

	public void set_CanThrowValidationExceptions(bool value) { }

	public void set_CurrentPurchaseValidator(PurchaseValidator value) { }

}

