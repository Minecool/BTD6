namespace NinjaKiwi.LiNK.Endpoints;

public class Scores_GetScores : Endpoint<ScoreModel[]>
{

	internal Scores_GetScores(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<ScoreModel[]> Call(string leaderboardID, IEnumerable<String> userIDs, string ownUserID = null) { }

	protected virtual ScoreModel[] Receive(string json) { }

}

