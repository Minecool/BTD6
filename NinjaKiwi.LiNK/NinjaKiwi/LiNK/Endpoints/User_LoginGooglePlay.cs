namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginGooglePlay : Endpoint<LiNKAccountModel>
{

	internal User_LoginGooglePlay(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

