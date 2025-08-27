namespace NinjaKiwi.LiNK.Endpoints;

public class User_LinkEmail : Endpoint<UserModel>
{

	internal User_LinkEmail(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string email, string password) { }

	protected virtual UserModel Receive(string json) { }

}

