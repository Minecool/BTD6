namespace NinjaKiwi.GUTS.Models.Endpoints.ContentBrowser;

public class AccoladePurchaseRequestResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private Accolade[] <Accolades>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <QuantityPurchased>k__BackingField; //Field offset: 0x20

	public Accolade[] Accolades
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int QuantityPurchased
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public AccoladePurchaseRequestResponse() { }

	[CompilerGenerated]
	public Accolade[] get_Accolades() { }

	[CompilerGenerated]
	public int get_QuantityPurchased() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_Accolades(Accolade[] value) { }

	[CompilerGenerated]
	public void set_QuantityPurchased(int value) { }

}

