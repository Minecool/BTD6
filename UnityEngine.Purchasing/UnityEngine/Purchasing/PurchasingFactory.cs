namespace UnityEngine.Purchasing;

internal class PurchasingFactory : IPurchasingBinder, IExtensionProvider
{
	private readonly Dictionary<Type, IStoreConfiguration> m_ConfigMap; //Field offset: 0x10
	private readonly Dictionary<Type, IStoreExtension> m_ExtensionMap; //Field offset: 0x18
	private IStore m_Store; //Field offset: 0x20
	private ICatalogProvider m_CatalogProvider; //Field offset: 0x28
	[CompilerGenerated]
	private string <storeName>k__BackingField; //Field offset: 0x30

	public IStore service
	{
		 get { } //Length: 100
		 set { } //Length: 5
	}

	public private string storeName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public PurchasingFactory(IPurchasingModule first, IPurchasingModule[] remainingModules) { }

	public IStore get_service() { }

	[CompilerGenerated]
	public string get_storeName() { }

	internal ICatalogProvider GetCatalogProvider() { }

	public override T GetExtension() { }

	public override void RegisterConfiguration(T instance) { }

	public override void RegisterExtension(T instance) { }

	public override void RegisterStore(string name, IStore s) { }

	public void set_service(IStore value) { }

	[CompilerGenerated]
	private void set_storeName(string value) { }

}

