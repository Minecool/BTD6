namespace UnityEngine.Purchasing;

public interface IStoreController
{

	public ProductCollection products
	{
		 get { } //Length: 0
	}

	public void ConfirmPendingPurchase(Product product) { }

	public ProductCollection get_products() { }

	public void InitiatePurchase(Product product) { }

}

