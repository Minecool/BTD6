namespace NinjaKiwi.LiNK.Endpoints;

public class Utils_ESCreate : Endpoint<ESDocument>
{

	internal Utils_ESCreate(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<ESDocument> Call(string index, object payload, string data = null) { }

	protected virtual ESDocument Receive(string json) { }

}

