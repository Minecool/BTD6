namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Region : Endpoint<String>
{

	internal Matchmaking_Region(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call() { }

	protected virtual string Receive(string json) { }

}

