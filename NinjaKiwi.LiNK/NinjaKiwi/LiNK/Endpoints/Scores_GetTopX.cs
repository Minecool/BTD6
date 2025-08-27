namespace NinjaKiwi.LiNK.Endpoints;

public class Scores_GetTopX : Endpoint<ScoreModel[]>
{

	internal Scores_GetTopX(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<ScoreModel[]> Call(string leaderboardID, int limit) { }

	protected virtual ScoreModel[] Receive(string json) { }

}

