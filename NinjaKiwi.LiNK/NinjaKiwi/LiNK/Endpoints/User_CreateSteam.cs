namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateSteam : Endpoint<UserModel>
{

	internal User_CreateSteam(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<UserModel> Call(string steamID, string confirmation, string displayName, string sessionTicket) { }

	protected virtual UserModel Receive(string json) { }

}

