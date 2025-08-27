namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateNintendo : Endpoint<UserModel>
{

	internal User_CreateNintendo(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string identifier, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

