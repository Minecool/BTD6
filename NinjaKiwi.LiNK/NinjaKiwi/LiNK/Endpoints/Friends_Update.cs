namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_Update : Endpoint<Boolean>
{

	internal Friends_Update(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string friendLiNKID, FriendStatus newStatus) { }

	protected virtual bool Receive(string json) { }

}

