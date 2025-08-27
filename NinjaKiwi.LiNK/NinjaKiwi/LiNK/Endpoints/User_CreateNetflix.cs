namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateNetflix : Endpoint<UserModel>
{

	internal User_CreateNetflix(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string identifier, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

