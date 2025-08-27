namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginPlaystation : Endpoint<LiNKAccountModel>
{

	internal User_LoginPlaystation(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<LiNKAccountModel> Call(string playstationID, string confirmation) { }

}

