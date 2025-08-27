namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginGooglePlay : Endpoint<LoginResponseModel>
{

	internal User_LoginGooglePlay(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string identifier, string confirmation) { }

}

