namespace UnityEngine.Purchasing.Security;

public class AppleInAppPurchaseReceipt
{
	[CompilerGenerated]
	private string <productID>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <transactionID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <originalTransactionIdentifier>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DateTime <purchaseDate>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DateTime <subscriptionExpirationDate>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private DateTime <cancellationDate>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <isFreeTrial>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <productType>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private int <isIntroductoryPricePeriod>k__BackingField; //Field offset: 0x48

	public DateTime cancellationDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int isFreeTrial
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public int isIntroductoryPricePeriod
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string originalTransactionIdentifier
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string productID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int productType
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public override DateTime purchaseDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DateTime subscriptionExpirationDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override string transactionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public DateTime get_cancellationDate() { }

	[CompilerGenerated]
	public int get_isFreeTrial() { }

	[CompilerGenerated]
	public int get_isIntroductoryPricePeriod() { }

	[CompilerGenerated]
	public string get_originalTransactionIdentifier() { }

	[CompilerGenerated]
	public override string get_productID() { }

	[CompilerGenerated]
	public int get_productType() { }

	[CompilerGenerated]
	public override DateTime get_purchaseDate() { }

	[CompilerGenerated]
	public DateTime get_subscriptionExpirationDate() { }

	[CompilerGenerated]
	public override string get_transactionID() { }

}

