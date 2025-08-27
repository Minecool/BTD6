namespace NinjaKiwi.GUTS.Models.Endpoints;

public class ClaimedAchievementsResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private String[] <ClaimedIds>k__BackingField; //Field offset: 0x18

	public String[] ClaimedIds
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

	public ClaimedAchievementsResponse() { }

	[CompilerGenerated]
	public String[] get_ClaimedIds() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_ClaimedIds(String[] value) { }

}

