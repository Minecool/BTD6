namespace NinjaKiwi.LiNK.Endpoints;

public class User_LinkEpic : Endpoint<UserModel>
{

	internal User_LinkEpic(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string epicID) { }

	protected virtual UserModel Receive(string json) { }

}

