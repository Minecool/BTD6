namespace NinjaKiwi.LiNK.Endpoints;

public class Squad_Matchmaking : Endpoint<Boolean>
{

	internal Squad_Matchmaking(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call(IEnumerable<String> matchmakingVersion, string gameMode, IEnumerable<String> preferredSwarms = null) { }

	public Task<Boolean> Call(string matchmakingVersion, string gameMode, IEnumerable<String> preferredSwarms = null) { }

	protected virtual bool Receive(string json) { }

}

