namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginNetflix : Endpoint<LoginResponseModel>
{

	internal User_LoginNetflix(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

