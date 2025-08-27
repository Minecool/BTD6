namespace NinjaKiwi.LiNK.Endpoints;

public class Scores_GetNeighbours : Endpoint<LeaderboardModel>
{

	internal Scores_GetNeighbours(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LeaderboardModel> Call(string leaderboardID, int limit, string userID = null) { }

}

