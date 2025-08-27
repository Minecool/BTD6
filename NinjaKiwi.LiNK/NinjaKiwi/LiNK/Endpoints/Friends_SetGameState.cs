namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_SetGameState : Endpoint<Boolean>
{

	internal Friends_SetGameState(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(Dictionary<String, Object> ownGameState, Nullable<TimeSpan> expiresIn) { }

	protected virtual bool Receive(string json) { }

}

