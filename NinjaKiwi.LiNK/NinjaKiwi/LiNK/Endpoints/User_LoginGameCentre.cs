namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginGameCentre : Endpoint<LoginResponseModel>
{

	internal User_LoginGameCentre(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

