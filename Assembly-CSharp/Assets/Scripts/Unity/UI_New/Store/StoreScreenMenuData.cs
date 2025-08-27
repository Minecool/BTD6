namespace Assets.Scripts.Unity.UI_New.Store;

public class StoreScreenMenuData
{
	[CompilerGenerated]
	private readonly StoreCategoryFilter <StoreCategoryFilter>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <SelectedProductId>k__BackingField; //Field offset: 0x18
	public bool ForceRefresh; //Field offset: 0x20

	public string SelectedProductId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StoreCategoryFilter StoreCategoryFilter
	{
		[CompilerGenerated]
		 get { } //Length: 94
	}

	public StoreScreenMenuData(StoreCategoryFilter storeCategoryFilter, string selectedProductId, bool forceRefresh = false) { }

	[CompilerGenerated]
	public string get_SelectedProductId() { }

	[CompilerGenerated]
	public StoreCategoryFilter get_StoreCategoryFilter() { }

}

