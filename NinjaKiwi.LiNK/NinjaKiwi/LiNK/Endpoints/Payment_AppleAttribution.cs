namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_AppleAttribution : Endpoint<Boolean>
{

	internal Payment_AppleAttribution(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string appleAdToken, string sessionID) { }

	protected virtual bool Receive(string json) { }

}

