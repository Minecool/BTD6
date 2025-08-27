namespace Assets.Scripts.Data.Store;

public class StoreItems : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StoreItem, Boolean> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <IsEditorItemInStorePremiumPack>b__8_0(StoreItem x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetProduct>b__0(StoreItem element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public StoreItem sl; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <GetProducts>b__0(StoreItem o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public PropPackUnlockLoot loot; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <IsEditorItemInStorePremiumPack>b__1(string collection) { }

	}

	[SerializeField]
	private List<StoreItem> storeItems; //Field offset: 0x18

	public IList<StoreItem> Items
	{
		 get { } //Length: 5
	}

	public StoreItems() { }

	public void CopyBaseProductDataIntoSaleProduct(StoreItem baseProduct, StoreItem saleProduct) { }

	public IList<StoreItem> get_Items() { }

	public List<StoreItem> GetHeroBundleProducts(string heroId) { }

	public StoreItem GetProduct(string id) { }

	public List<StoreItem> GetProducts(bool inGame, int rank) { }

	public bool IsEditorItemInStorePremiumPack(String[] packCollections) { }

	private bool StoreItemCheck(StoreItem si, bool inGame, int rank) { }

}

