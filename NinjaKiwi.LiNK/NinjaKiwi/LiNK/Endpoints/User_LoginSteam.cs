namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginSteam : Endpoint<LiNKAccountModel>
{

	internal User_LoginSteam(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string steamID, string confirmation, string sessionTicket) { }

}

