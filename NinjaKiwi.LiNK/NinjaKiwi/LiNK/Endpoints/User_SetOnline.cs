namespace NinjaKiwi.LiNK.Endpoints;

public class User_SetOnline : Endpoint<OnlineModel>
{

	internal User_SetOnline(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<OnlineModel> Call(TimeSpan duration, string playSession, string gameState = null) { }

	protected virtual OnlineModel Receive(string json) { }

}

