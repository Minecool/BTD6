namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreatePlaystation : Endpoint<UserModel>
{

	internal User_CreatePlaystation(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string playstationID, string confirmation, string displayName) { }

	protected virtual UserModel Receive(string json) { }

}

