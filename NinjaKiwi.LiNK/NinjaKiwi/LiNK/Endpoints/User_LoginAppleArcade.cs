namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginAppleArcade : Endpoint<LiNKAccountModel>
{

	internal User_LoginAppleArcade(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

