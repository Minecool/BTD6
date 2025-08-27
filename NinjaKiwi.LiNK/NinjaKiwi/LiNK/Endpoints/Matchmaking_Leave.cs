namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Leave : Endpoint<Boolean>
{

	internal Matchmaking_Leave(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call(string lobbyID, string playerGlobalID = null) { }

	protected virtual bool Receive(string json) { }

}

