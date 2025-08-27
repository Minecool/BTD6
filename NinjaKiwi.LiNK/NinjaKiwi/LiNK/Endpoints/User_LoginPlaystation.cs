namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginPlaystation : Endpoint<LoginResponseModel>
{

	internal User_LoginPlaystation(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LoginResponseModel> Call(string playstationID, string confirmation) { }

}

