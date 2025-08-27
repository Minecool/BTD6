namespace NinjaKiwi.GUTS.Models.Endpoints;

public class GetQuestsResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private ActiveQuests <PlayerQuests>k__BackingField; //Field offset: 0x18

	public ActiveQuests PlayerQuests
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

	public GetQuestsResponse() { }

	[CompilerGenerated]
	public ActiveQuests get_PlayerQuests() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_PlayerQuests(ActiveQuests value) { }

}

