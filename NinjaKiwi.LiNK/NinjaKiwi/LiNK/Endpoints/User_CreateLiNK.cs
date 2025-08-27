namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateLiNK : Endpoint<UserModel>
{

	internal User_CreateLiNK(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string email, string password, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

