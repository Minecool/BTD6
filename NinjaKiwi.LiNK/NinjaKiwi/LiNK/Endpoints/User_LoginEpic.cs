namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginEpic : Endpoint<LiNKAccountModel>
{

	internal User_LoginEpic(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string accessToken) { }

}

