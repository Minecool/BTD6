namespace Assets.Scripts.Models;

public class IapStoreSettings
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <.ctor>b__0(StoreItem x) { }

	}

	[CompilerGenerated]
	private readonly bool <IsEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly IReadOnlyDictionary<StoreCategoryFilter, IReadOnlyCollection`1<StoreItemSettings>> <CategorySettings>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly StoreCategoryFilter <DefaultCategory>k__BackingField; //Field offset: 0x20

	public IReadOnlyDictionary<StoreCategoryFilter, IReadOnlyCollection`1<StoreItemSettings>> CategorySettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal StoreCategoryFilter DefaultCategory
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonConstructor]
	public IapStoreSettings(bool isEnabled, Dictionary<String, Dictionary`2<String, JsonIapItemSettings>> categorySettings, string defaultCategory) { }

	[CompilerGenerated]
	public IReadOnlyDictionary<StoreCategoryFilter, IReadOnlyCollection`1<StoreItemSettings>> get_CategorySettings() { }

	[CompilerGenerated]
	internal StoreCategoryFilter get_DefaultCategory() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	private static bool TryGetStoreCategoryFilter(string storeCategoryFilterName, out StoreCategoryFilter storeCategoryFilter) { }

}

