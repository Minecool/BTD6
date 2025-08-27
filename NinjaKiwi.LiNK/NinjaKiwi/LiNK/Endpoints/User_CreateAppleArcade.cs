namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateAppleArcade : Endpoint<UserModel>
{

	internal User_CreateAppleArcade(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string identifier, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

