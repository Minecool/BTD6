namespace UnityEngine.Purchasing.Interfaces;

internal interface IGooglePurchaseService
{

	public void Purchase(ProductDefinition product, Product oldProduct, Nullable<GooglePlayProrationMode> desiredProrationMode) { }

}

