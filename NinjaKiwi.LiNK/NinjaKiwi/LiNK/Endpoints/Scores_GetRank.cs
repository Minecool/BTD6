namespace NinjaKiwi.LiNK.Endpoints;

public class Scores_GetRank : Endpoint<RankModel>
{

	internal Scores_GetRank(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<RankModel> Call(string leaderboardID, string userID = null) { }

	protected virtual RankModel Receive(string json) { }

}

