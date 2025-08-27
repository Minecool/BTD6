namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_List : Endpoint<FriendsListResponse>
{

	internal Friends_List(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<FriendsListResponse> Call() { }

	protected virtual FriendsListResponse Receive(string json) { }

}

