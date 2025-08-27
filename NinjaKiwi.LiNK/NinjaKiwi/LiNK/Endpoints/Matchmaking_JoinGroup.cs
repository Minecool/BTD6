namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_JoinGroup : Endpoint<String>
{

	internal Matchmaking_JoinGroup(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call(IEnumerable<String> groupIDs, int maxPlayers, string eventID = null) { }

	protected virtual string Receive(string json) { }

}

