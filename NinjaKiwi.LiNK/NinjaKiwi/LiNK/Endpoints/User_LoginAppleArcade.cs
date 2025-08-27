namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginAppleArcade : Endpoint<LoginResponseModel>
{

	internal User_LoginAppleArcade(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

