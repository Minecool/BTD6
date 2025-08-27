namespace UnityEngine.Purchasing.Extension;

public interface IStoreCallback
{

	public ProductCollection products
	{
		 get { } //Length: 0
	}

	public ProductCollection get_products() { }

	public void OnAllPurchasesRetrieved(List<Product> purchasedProducts) { }

	public void OnProductsRetrieved(List<ProductDescription> products) { }

	public void OnPurchaseFailed(PurchaseFailureDescription desc) { }

	public void OnPurchaseSucceeded(string storeSpecificId, string receipt, string transactionIdentifier) { }

	public void OnSetupFailed(InitializationFailureReason reason, string message) { }

}

