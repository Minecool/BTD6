namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Play : Endpoint<LobbyModel>
{

	internal Matchmaking_Play(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LobbyModel> Call(string bucket, int score, string playerID, IEnumerable<String> matchRestrictions = null, Dictionary<String, String[]> filter = null, int maxPlayers = -1, string faction = null, string matchmakingVersion = null, IEnumerable<String> matchmakingVersions = null, Nullable<TimeSpan> timeWaited = null) { }

}

