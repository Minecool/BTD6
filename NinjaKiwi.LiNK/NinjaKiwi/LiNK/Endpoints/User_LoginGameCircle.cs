namespace NinjaKiwi.LiNK.Endpoints;

[Obsolete]
public class User_LoginGameCircle : Endpoint<LiNKAccountModel>
{

	internal User_LoginGameCircle(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string identifier, string confirmation) { }

}

