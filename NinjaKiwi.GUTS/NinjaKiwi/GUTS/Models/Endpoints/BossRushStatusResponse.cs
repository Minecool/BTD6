namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushStatusResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private BossRushGuildStatus <BossRushGuildStatus>k__BackingField; //Field offset: 0x18

	public BossRushGuildStatus BossRushGuildStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 19
	}

	public BossRushStatusResponse() { }

	[CompilerGenerated]
	public BossRushGuildStatus get_BossRushGuildStatus() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_BossRushGuildStatus(BossRushGuildStatus value) { }

}

