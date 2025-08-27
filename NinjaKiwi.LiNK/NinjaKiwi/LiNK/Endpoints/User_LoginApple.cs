namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginApple : Endpoint<LoginResponseModel>
{

	internal User_LoginApple(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

