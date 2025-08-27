namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginMyNK : Endpoint<LiNKAccountModel>
{

	internal User_LoginMyNK(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string userID, string token) { }

}

