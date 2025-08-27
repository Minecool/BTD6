namespace NinjaKiwi.LiNK.Endpoints;

public class Social_Status : Endpoint<OauthTokensModel>
{

	internal Social_Status(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<OauthTokensModel> Call() { }

}

