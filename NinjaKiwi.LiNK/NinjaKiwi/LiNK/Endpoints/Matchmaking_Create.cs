namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Create : Endpoint<LobbyModel>
{

	internal Matchmaking_Create(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LobbyModel> Call(string bucket, int maxPlayers, TimeSpan expiresIn) { }

	public Task<LobbyModel> Call(MatchMakingParameters parameters) { }

}

