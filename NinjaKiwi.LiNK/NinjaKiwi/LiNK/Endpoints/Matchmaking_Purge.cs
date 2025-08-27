namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Purge : Endpoint<String[]>
{

	internal Matchmaking_Purge(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String[]> Call(string lobbyID) { }

	protected virtual String[] Receive(string json) { }

}

