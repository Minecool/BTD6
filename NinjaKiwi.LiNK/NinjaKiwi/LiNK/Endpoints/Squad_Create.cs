namespace NinjaKiwi.LiNK.Endpoints;

public class Squad_Create : Endpoint<SquadModel>
{

	internal Squad_Create(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SquadModel> Call(SquadMatchmakingParameters matchmakingParameters) { }

	public Task<SquadModel> Call(string matchmakingVersion) { }

	protected virtual SquadModel Receive(string json) { }

}

