namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Migrate : Endpoint<Boolean>
{

	internal Matchmaking_Migrate(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string lobbyID, string currentBucket, string newBucket) { }

	protected virtual bool Receive(string json) { }

}

