namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateXbox : Endpoint<UserModel>
{

	internal User_CreateXbox(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string xboxID, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

