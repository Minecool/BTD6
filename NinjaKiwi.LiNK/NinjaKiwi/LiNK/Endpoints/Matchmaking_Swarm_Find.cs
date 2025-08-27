namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Swarm_Find : Endpoint<MatchmakingSwarmFindResponse>
{

	internal Matchmaking_Swarm_Find(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<MatchmakingSwarmFindResponse> Call(MatchmakingSwarmFindParameters parameters) { }

}

