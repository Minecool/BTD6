namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginKong : Endpoint<LiNKAccountModel>
{

	internal User_LoginKong(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string userID, string gameAuthToken) { }

}

