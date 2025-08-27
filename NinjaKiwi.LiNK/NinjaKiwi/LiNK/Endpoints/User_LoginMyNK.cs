namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginMyNK : Endpoint<LoginResponseModel>
{

	internal User_LoginMyNK(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string userID, string token) { }

}

