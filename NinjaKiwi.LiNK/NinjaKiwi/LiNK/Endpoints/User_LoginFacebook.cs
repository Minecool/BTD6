namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginFacebook : Endpoint<LoginResponseModel>
{

	internal User_LoginFacebook(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string accessToken) { }

}

