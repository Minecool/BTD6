namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Cancel : Endpoint<Boolean>
{

	internal Matchmaking_Cancel(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string bucket, string playerID, IEnumerable<String> matchRestrictions = null, int maxPlayers = -1, string faction = null) { }

	protected virtual bool Receive(string json) { }

}

