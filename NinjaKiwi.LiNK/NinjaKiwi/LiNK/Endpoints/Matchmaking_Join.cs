namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Join : Endpoint<LobbyModel>
{

	internal Matchmaking_Join(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LobbyModel> Call(string lobbyID, int maxPlayers) { }

	public Task<LobbyModel> Call(string lobbyID, MatchMakingParameters parameters) { }

}

