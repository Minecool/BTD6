namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateGooglePlay : Endpoint<UserModel>
{

	internal User_CreateGooglePlay(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string identifier, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

