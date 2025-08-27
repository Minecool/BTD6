namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_GenerateName : Endpoint<String>
{

	internal Guild_GenerateName(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call() { }

	protected virtual string Receive(string json) { }

}

