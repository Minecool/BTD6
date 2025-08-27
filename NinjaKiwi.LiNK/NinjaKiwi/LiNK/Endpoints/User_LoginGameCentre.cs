namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginGameCentre : Endpoint<LiNKAccountModel>
{

	internal User_LoginGameCentre(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

