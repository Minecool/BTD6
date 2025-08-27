namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Cancel_LoggedIn : Endpoint<Boolean>
{

	internal Matchmaking_Cancel_LoggedIn(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string bucket, IEnumerable<String> matchRestrictions = null, int maxPlayers = -1, string faction = null) { }

	protected virtual bool Receive(string json) { }

}

