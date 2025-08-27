namespace NinjaKiwi.LiNK.Endpoints;

public class GenericEndpoint : EndpointBase
{

	internal GenericEndpoint(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call(string endpoint, object data = null) { }

}

