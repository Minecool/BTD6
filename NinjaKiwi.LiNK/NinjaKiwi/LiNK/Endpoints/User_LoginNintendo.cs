namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginNintendo : Endpoint<LiNKAccountModel>
{

	internal User_LoginNintendo(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

