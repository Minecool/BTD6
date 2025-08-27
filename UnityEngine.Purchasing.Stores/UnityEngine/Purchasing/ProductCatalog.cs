namespace UnityEngine.Purchasing;

public class ProductCatalog
{
	private static IProductCatalogImpl instance; //Field offset: 0x0
	public const string kCatalogPath = "Assets/Resources/IAPProductCatalog.json"; //Field offset: 0x0
	public const string kPrevCatalogPath = "Assets/Plugins/UnityPurchasing/Resources/IAPProductCatalog.json"; //Field offset: 0x0
	public string appleSKU; //Field offset: 0x10
	public string appleTeamID; //Field offset: 0x18
	public bool enableCodelessAutoInitialization; //Field offset: 0x20
	public bool enableUnityGamingServicesAutoInitialization; //Field offset: 0x21
	[SerializeField]
	private List<ProductCatalogItem> products; //Field offset: 0x28

	public ICollection<ProductCatalogItem> allProducts
	{
		 get { } //Length: 5
	}

	public ProductCatalog() { }

	public static ProductCatalog Deserialize(string catalogJSON) { }

	public static ProductCatalog FromTextAsset(TextAsset asset) { }

	public ICollection<ProductCatalogItem> get_allProducts() { }

	internal static void Initialize() { }

	public static void Initialize(IProductCatalogImpl productCatalogImpl) { }

	public static ProductCatalog LoadDefaultCatalog() { }

}

