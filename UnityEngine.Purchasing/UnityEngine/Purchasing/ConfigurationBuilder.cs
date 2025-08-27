namespace UnityEngine.Purchasing;

public class ConfigurationBuilder
{
	[CompilerGenerated]
	private bool <useCatalogProvider>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <logUnavailableProducts>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private readonly HashSet<ProductDefinition> <products>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly PurchasingFactory <factory>k__BackingField; //Field offset: 0x20

	internal PurchasingFactory factory
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public bool logUnavailableProducts
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public HashSet<ProductDefinition> products
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool useCatalogProvider
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ConfigurationBuilder(PurchasingFactory factory) { }

	public ConfigurationBuilder AddProduct(string id, ProductType type) { }

	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs) { }

	public ConfigurationBuilder AddProduct(string id, ProductType type, IDs storeIDs, IEnumerable<PayoutDefinition> payouts) { }

	[CompilerGenerated]
	internal PurchasingFactory get_factory() { }

	[CompilerGenerated]
	public bool get_logUnavailableProducts() { }

	[CompilerGenerated]
	public HashSet<ProductDefinition> get_products() { }

	[CompilerGenerated]
	public bool get_useCatalogProvider() { }

	public static ConfigurationBuilder Instance(IPurchasingModule first, IPurchasingModule[] rest) { }

}

