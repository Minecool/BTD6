namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginLiNK : Endpoint<LiNKAccountModel>
{

	internal User_LoginLiNK(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string email, string password) { }

}

