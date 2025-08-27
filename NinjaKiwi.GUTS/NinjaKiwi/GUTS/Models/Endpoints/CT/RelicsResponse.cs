namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class RelicsResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private List<ContestedTerritoryRelicType> <GuildRelics>k__BackingField; //Field offset: 0x18

	public List<ContestedTerritoryRelicType> GuildRelics
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

	public RelicsResponse() { }

	[CompilerGenerated]
	public List<ContestedTerritoryRelicType> get_GuildRelics() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public void set_GuildRelics(List<ContestedTerritoryRelicType> value) { }

}

