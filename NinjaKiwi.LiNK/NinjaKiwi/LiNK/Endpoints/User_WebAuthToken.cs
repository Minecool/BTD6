namespace NinjaKiwi.LiNK.Endpoints;

public class User_WebAuthToken : Endpoint<String>
{

	internal User_WebAuthToken(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call(string destination, string additional) { }

	protected virtual string Receive(string json) { }

}

