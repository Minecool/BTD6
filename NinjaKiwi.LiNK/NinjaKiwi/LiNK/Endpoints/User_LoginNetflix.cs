namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginNetflix : Endpoint<LiNKAccountModel>
{

	internal User_LoginNetflix(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

