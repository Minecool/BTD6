namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginXbox : Endpoint<LiNKAccountModel>
{

	internal User_LoginXbox(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string xboxID, string confirmation) { }

}

