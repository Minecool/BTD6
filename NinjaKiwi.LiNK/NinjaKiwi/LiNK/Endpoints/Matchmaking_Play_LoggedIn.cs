namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Play_LoggedIn : Endpoint<LobbyModel>
{

	internal Matchmaking_Play_LoggedIn(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LobbyModel> Call(string bucket, int score, IEnumerable<String> matchRestrictions = null, Dictionary<String, String[]> filter = null, int maxPlayers = -1, string faction = null) { }

}

