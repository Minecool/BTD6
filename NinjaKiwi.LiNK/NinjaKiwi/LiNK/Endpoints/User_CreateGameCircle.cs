namespace NinjaKiwi.LiNK.Endpoints;

[Obsolete]
public class User_CreateGameCircle : Endpoint<UserModel>
{

	internal User_CreateGameCircle(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string identifier, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

