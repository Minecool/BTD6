namespace NinjaKiwi.LiNK.Endpoints;

public class Social_GetLeaderboard : Endpoint<List`1<ScoreModel>>
{

	internal Social_GetLeaderboard(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<ScoreModel>> Call(string type, string name) { }

	protected virtual List<ScoreModel> Receive(string json) { }

}

