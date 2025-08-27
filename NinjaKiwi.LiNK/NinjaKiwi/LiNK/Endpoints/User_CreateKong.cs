namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateKong : Endpoint<UserModel>
{

	internal User_CreateKong(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string userID, string gameAuthToken, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

