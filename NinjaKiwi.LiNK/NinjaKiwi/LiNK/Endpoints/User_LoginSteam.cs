namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginSteam : Endpoint<LoginResponseModel>
{

	internal User_LoginSteam(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string steamID, string confirmation, string sessionTicket) { }

}

