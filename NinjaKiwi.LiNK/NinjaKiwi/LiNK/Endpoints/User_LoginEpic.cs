namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginEpic : Endpoint<LoginResponseModel>
{

	internal User_LoginEpic(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string accessToken) { }

}

