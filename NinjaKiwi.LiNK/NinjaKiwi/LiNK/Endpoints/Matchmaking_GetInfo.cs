namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_GetInfo : Endpoint<LobbyModel>
{

	internal Matchmaking_GetInfo(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LobbyModel> Call(string lobbyID) { }

	protected virtual LobbyModel Receive(string json) { }

}

