namespace Assets.Scripts.Models;

public class StoreItemSettings
{
	[CompilerGenerated]
	private readonly string <ProductId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly ProductPanelType <PanelType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly int <SortingPriority>k__BackingField; //Field offset: 0x1C

	public ProductPanelType PanelType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string ProductId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int SortingPriority
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public StoreItemSettings(string productId, ProductPanelType panelType, int sortingPriority) { }

	[CompilerGenerated]
	public ProductPanelType get_PanelType() { }

	[CompilerGenerated]
	public string get_ProductId() { }

	[CompilerGenerated]
	public int get_SortingPriority() { }

}

