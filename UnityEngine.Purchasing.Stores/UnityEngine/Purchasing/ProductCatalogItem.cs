namespace UnityEngine.Purchasing;

public class ProductCatalogItem
{
	public string id; //Field offset: 0x10
	public ProductType type; //Field offset: 0x18
	[SerializeField]
	private List<StoreID> storeIDs; //Field offset: 0x20
	public LocalizedProductDescription defaultDescription; //Field offset: 0x28
	public string screenshotPath; //Field offset: 0x30
	public int applePriceTier; //Field offset: 0x38
	public Price googlePrice; //Field offset: 0x40
	public string pricingTemplateID; //Field offset: 0x48
	[SerializeField]
	private List<LocalizedProductDescription> descriptions; //Field offset: 0x50
	public Price udpPrice; //Field offset: 0x58
	[SerializeField]
	private List<ProductCatalogPayout> payouts; //Field offset: 0x60

	public ICollection<StoreID> allStoreIDs
	{
		 get { } //Length: 5
	}

	public ProductCatalogItem() { }

	public ICollection<StoreID> get_allStoreIDs() { }

}

