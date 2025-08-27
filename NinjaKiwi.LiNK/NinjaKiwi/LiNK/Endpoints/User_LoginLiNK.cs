namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginLiNK : Endpoint<LoginResponseModel>
{

	internal User_LoginLiNK(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string email, string password) { }

}

