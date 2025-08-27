namespace NinjaKiwi.GUTS.Models.Endpoints.CT;

public class TicketResponse : EndpointResponseBase, IEndpointResponse
{
	[CompilerGenerated]
	private TicketStatus <Tickets>k__BackingField; //Field offset: 0x18

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public TicketStatus Tickets
	{
		[CompilerGenerated]
		 get { } //Length: 53
		[CompilerGenerated]
		 set { } //Length: 50
	}

	public TicketResponse() { }

	public override bool get_Success() { }

	[CompilerGenerated]
	public TicketStatus get_Tickets() { }

	[CompilerGenerated]
	public void set_Tickets(TicketStatus value) { }

}

