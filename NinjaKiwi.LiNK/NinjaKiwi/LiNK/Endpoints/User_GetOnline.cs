namespace NinjaKiwi.LiNK.Endpoints;

public class User_GetOnline : Endpoint<OnlineModel>
{

	internal User_GetOnline(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<OnlineModel> Call(string liNKID) { }

	protected virtual OnlineModel Receive(string json) { }

}

