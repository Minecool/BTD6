namespace NinjaKiwi.LiNK.Endpoints;

public class Scores_Set : Endpoint<ScoreModel>
{

	internal Scores_Set(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<ScoreModel> Call(string leaderboardID, long score, string metadata, string setModifier, TimeSpan expiresIn, string userID = null, string eventID = null) { }

	protected virtual ScoreModel Receive(string json) { }

}

