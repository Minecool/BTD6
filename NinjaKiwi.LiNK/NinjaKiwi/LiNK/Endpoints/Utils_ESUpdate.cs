namespace NinjaKiwi.LiNK.Endpoints;

public class Utils_ESUpdate : Endpoint<Boolean>
{

	internal Utils_ESUpdate(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string index, string id, Dictionary<String, String> modify, bool skipQueue = false) { }

	protected virtual bool Receive(string json) { }

}

