namespace NinjaKiwi.LiNK.Endpoints;

public class User_LinkPlatform : Endpoint<UserModel>
{

	internal User_LinkPlatform(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(AuthProviderType authProvider, string identifier, string confirmation, string steamSessionTicket = null) { }

	protected virtual UserModel Receive(string json) { }

}

