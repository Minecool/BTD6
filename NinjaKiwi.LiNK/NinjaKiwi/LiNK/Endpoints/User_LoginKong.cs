namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginKong : Endpoint<LoginResponseModel>
{

	internal User_LoginKong(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string userID, string gameAuthToken) { }

}

