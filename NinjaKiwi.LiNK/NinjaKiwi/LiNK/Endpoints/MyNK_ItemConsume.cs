namespace NinjaKiwi.LiNK.Endpoints;

public class MyNK_ItemConsume : Endpoint<Boolean>
{

	internal MyNK_ItemConsume(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string userID, string itemUuid) { }

	protected virtual bool Receive(string json) { }

}

