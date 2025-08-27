namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateMyNK : Endpoint<UserModel>
{

	internal User_CreateMyNK(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string userID, string token, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

