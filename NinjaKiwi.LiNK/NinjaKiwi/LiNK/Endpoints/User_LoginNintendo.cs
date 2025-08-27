namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginNintendo : Endpoint<LoginResponseModel>
{

	internal User_LoginNintendo(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

