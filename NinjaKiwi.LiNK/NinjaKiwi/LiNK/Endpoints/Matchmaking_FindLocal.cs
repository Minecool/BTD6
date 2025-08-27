namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_FindLocal : Endpoint<LocalNetworkLobby[]>
{

	internal Matchmaking_FindLocal(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LocalNetworkLobby[]> Call() { }

	protected virtual LocalNetworkLobby[] Receive(string json) { }

}

