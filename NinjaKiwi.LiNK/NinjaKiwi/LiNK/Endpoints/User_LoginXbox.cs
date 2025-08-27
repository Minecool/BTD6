namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginXbox : Endpoint<LoginResponseModel>
{

	internal User_LoginXbox(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string xboxID, string confirmation) { }

}

