namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginApple : Endpoint<LiNKAccountModel>
{

	internal User_LoginApple(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

