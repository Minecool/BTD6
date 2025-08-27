namespace NinjaKiwi.LiNK.Endpoints;

public class User_DisplayNameCheck : Endpoint<Boolean>
{

	internal User_DisplayNameCheck(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call(string displayName) { }

	protected virtual bool Receive(string json) { }

}

