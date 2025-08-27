namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushPlayerScoresResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private BossRushPlayerStatus <PlayerStatus>k__BackingField; //Field offset: 0x18

	public BossRushPlayerStatus PlayerStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 37
	}

	public BossRushPlayerScoresResponse() { }

	[CompilerGenerated]
	public BossRushPlayerStatus get_PlayerStatus() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_PlayerStatus(BossRushPlayerStatus value) { }

}

