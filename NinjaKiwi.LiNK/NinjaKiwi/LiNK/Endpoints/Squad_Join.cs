namespace NinjaKiwi.LiNK.Endpoints;

public class Squad_Join : Endpoint<SquadModel>
{

	internal Squad_Join(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SquadModel> Call(string squadID) { }

	protected virtual SquadModel Receive(string json) { }

}

