namespace NinjaKiwi.LiNK.Endpoints;

public class Scores_GetRanks : Endpoint<RankModel[]>
{

	internal Scores_GetRanks(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<RankModel[]> Call(string leaderboardID, IEnumerable<String> userIDs) { }

	protected virtual RankModel[] Receive(string json) { }

}

