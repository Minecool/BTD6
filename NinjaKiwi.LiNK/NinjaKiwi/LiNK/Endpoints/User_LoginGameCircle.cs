namespace NinjaKiwi.LiNK.Endpoints;

[Obsolete]
public class User_LoginGameCircle : Endpoint<LoginResponseModel>
{

	internal User_LoginGameCircle(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

