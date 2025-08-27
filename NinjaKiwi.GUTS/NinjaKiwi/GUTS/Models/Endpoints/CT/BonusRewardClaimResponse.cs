namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class BonusRewardClaimResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private int <TeamTrophies>k__BackingField; //Field offset: 0x18

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public int TeamTrophies
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public BonusRewardClaimResponse() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public int get_TeamTrophies() { }

	[CompilerGenerated]
	public void set_TeamTrophies(int value) { }

}

