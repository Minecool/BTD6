namespace UnityEngine.Purchasing;

public class FakeGooglePlayStoreExtensions : IGooglePlayStoreExtensions, IStoreExtension
{

	public FakeGooglePlayStoreExtensions() { }

	public override bool IsPurchasedProductDeferred(Product product) { }

}

