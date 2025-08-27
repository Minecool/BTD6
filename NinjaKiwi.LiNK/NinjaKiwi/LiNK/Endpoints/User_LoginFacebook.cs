namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginFacebook : Endpoint<LiNKAccountModel>
{

	internal User_LoginFacebook(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string accessToken) { }

}

