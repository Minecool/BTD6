namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateEpic : Endpoint<UserModel>
{

	internal User_CreateEpic(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string accessToken, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

