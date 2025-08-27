namespace NinjaKiwi.LiNK.Endpoints;

public class User_CreateChild : Endpoint<ChildLiNKAccountModel>
{

	internal User_CreateChild(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<ChildLiNKAccountModel> Call() { }

	protected virtual ChildLiNKAccountModel Receive(string json) { }

}

