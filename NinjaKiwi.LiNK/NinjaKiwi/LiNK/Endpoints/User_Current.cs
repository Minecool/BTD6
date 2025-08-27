namespace NinjaKiwi.LiNK.Endpoints;

public class User_Current : Endpoint<UserModel>
{

	internal User_Current(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call() { }

	protected virtual UserModel Receive(string json) { }

}

