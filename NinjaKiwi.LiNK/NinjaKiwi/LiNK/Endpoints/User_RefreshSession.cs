namespace NinjaKiwi.LiNK.Endpoints;

public class User_RefreshSession : Endpoint<SessionModel>
{

	internal User_RefreshSession(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<SessionModel> Call(string currentSessionId, string sessionTicket) { }

	protected virtual SessionModel Receive(string json) { }

}

