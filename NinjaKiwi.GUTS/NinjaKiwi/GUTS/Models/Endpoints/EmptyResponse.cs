namespace NinjaKiwi.GUTS.Models.Endpoints;

public class EmptyResponse : EndpointResponseBase, IEndpointResponse
{

	[JsonIgnore]
	public override bool Success
	{
		 get { } //Length: 9
	}

	public EmptyResponse() { }

	public override bool get_Success() { }

}

