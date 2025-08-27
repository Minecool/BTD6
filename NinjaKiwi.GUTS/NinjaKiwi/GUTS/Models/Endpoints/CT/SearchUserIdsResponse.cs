namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class SearchUserIdsResponse : EndpointResponseBase, IUserServerIdsResponse, IEndpointResponse
{
	[CompilerGenerated]
	private UserServerIds <UserServerIds>k__BackingField; //Field offset: 0x18

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 74
	}

	public override UserServerIds UserServerIds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public SearchUserIdsResponse() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public override UserServerIds get_UserServerIds() { }

	[CompilerGenerated]
	public override void set_UserServerIds(UserServerIds value) { }

}

