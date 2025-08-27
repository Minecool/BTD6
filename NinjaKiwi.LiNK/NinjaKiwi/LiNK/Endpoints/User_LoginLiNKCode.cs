namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginLiNKCode : Endpoint<LoginResponseModel>
{

	internal User_LoginLiNKCode(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string linkCode) { }

}

