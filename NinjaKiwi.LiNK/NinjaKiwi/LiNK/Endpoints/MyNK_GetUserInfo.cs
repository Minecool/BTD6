namespace NinjaKiwi.LiNK.Endpoints;

public class MyNK_GetUserInfo : Endpoint<MyNK_UserInfoModel>
{

	internal MyNK_GetUserInfo(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<MyNK_UserInfoModel> Call(string userID) { }

	protected virtual MyNK_UserInfoModel Receive(string json) { }

}

