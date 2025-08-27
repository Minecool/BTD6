namespace NinjaKiwi.LiNK.Endpoints;

public class User_CheckAndSetPlaySession : Endpoint<SetPlaySessionResponse>
{

	internal User_CheckAndSetPlaySession(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SetPlaySessionResponse> Call(TimeSpan duration, string gameState, bool forceSession) { }

	protected virtual SetPlaySessionResponse Receive(string json) { }

}

