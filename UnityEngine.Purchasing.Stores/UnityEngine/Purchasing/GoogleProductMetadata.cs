namespace UnityEngine.Purchasing;

public class GoogleProductMetadata : ProductMetadata
{
	[CompilerGenerated]
	private string <originalJson>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private string <subscriptionPeriod>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private string <freeTrialPeriod>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private string <introductoryPrice>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private string <introductoryPricePeriod>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <introductoryPriceCycles>k__BackingField; //Field offset: 0x68

	internal string freeTrialPeriod
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string introductoryPrice
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal int introductoryPriceCycles
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal string introductoryPricePeriod
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal string originalJson
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal string subscriptionPeriod
	{
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	internal GoogleProductMetadata(string priceString, string title, string description, string currencyCode, decimal localizedPrice) { }

	[CompilerGenerated]
	public string get_originalJson() { }

	[CompilerGenerated]
	internal void set_freeTrialPeriod(string value) { }

	[CompilerGenerated]
	internal void set_introductoryPrice(string value) { }

	[CompilerGenerated]
	internal void set_introductoryPriceCycles(int value) { }

	[CompilerGenerated]
	internal void set_introductoryPricePeriod(string value) { }

	[CompilerGenerated]
	internal void set_originalJson(string value) { }

	[CompilerGenerated]
	internal void set_subscriptionPeriod(string value) { }

}

