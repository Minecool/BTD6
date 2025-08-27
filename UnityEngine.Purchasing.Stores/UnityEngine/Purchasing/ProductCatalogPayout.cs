namespace UnityEngine.Purchasing;

public class ProductCatalogPayout
{
	internal enum ProductCatalogPayoutType
	{
		Other = 0,
		Currency = 1,
		Item = 2,
		Resource = 3,
	}

	public const int MaxSubtypeLength = 64; //Field offset: 0x0
	public const int MaxDataLength = 1024; //Field offset: 0x0
	[SerializeField]
	private string t; //Field offset: 0x10
	[SerializeField]
	private string st; //Field offset: 0x18
	[SerializeField]
	private double q; //Field offset: 0x20
	[SerializeField]
	private string d; //Field offset: 0x28

	public ProductCatalogPayout() { }

}

