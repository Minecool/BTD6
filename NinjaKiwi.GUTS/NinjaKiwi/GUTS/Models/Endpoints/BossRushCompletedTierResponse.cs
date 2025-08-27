namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushCompletedTierResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private int <CompletedTier>k__BackingField; //Field offset: 0x18

	public int CompletedTier
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

	public BossRushCompletedTierResponse() { }

	[CompilerGenerated]
	public int get_CompletedTier() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_CompletedTier(int value) { }

}

