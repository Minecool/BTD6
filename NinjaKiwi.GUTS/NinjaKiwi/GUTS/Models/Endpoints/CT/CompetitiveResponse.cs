namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class CompetitiveResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private GuildCompetitiveStatus <GuildCompetitiveStatus>k__BackingField; //Field offset: 0x18

	public GuildCompetitiveStatus GuildCompetitiveStatus
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public CompetitiveResponse() { }

	[CompilerGenerated]
	public GuildCompetitiveStatus get_GuildCompetitiveStatus() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_GuildCompetitiveStatus(GuildCompetitiveStatus value) { }

}

