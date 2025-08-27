namespace NinjaKiwi.LiNK.Endpoints;

public class User_GetLiNKCode : Endpoint<String>
{

	internal User_GetLiNKCode(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call() { }

	protected virtual string Receive(string json) { }

}

