namespace NinjaKiwi.LiNK.Endpoints;

public class User_LinkFacebook : Endpoint<UserModel>
{

	internal User_LinkFacebook(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string accessToken) { }

	protected virtual UserModel Receive(string json) { }

}

