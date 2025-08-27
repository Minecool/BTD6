namespace NinjaKiwi.GUTS.Models.Endpoints;

public class ContributionResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private int <PlayerBalance>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <ItemBalance>k__BackingField; //Field offset: 0x1C

	public int ItemBalance
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int PlayerBalance
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

	public ContributionResponse() { }

	[CompilerGenerated]
	public int get_ItemBalance() { }

	[CompilerGenerated]
	public int get_PlayerBalance() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_ItemBalance(int value) { }

	[CompilerGenerated]
	public void set_PlayerBalance(int value) { }

}

