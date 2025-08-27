namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(1)]
internal interface IGooglePurchase
{

	public int purchaseState
	{
		 get { } //Length: 0
	}

	public string purchaseToken
	{
		 get { } //Length: 0
	}

	public string receipt
	{
		 get { } //Length: 0
	}

	[Nullable(2)]
	public string sku
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public List<String> skus
	{
		 get { } //Length: 0
	}

	public int get_purchaseState() { }

	public string get_purchaseToken() { }

	public string get_receipt() { }

	[NullableContext(2)]
	public string get_sku() { }

	public List<String> get_skus() { }

	public bool IsAcknowledged() { }

	public bool IsPending() { }

	public bool IsPurchased() { }

}

