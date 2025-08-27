namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginLiNKCode : Endpoint<LiNKAccountModel>
{

	internal User_LoginLiNKCode(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string linkCode) { }

}

