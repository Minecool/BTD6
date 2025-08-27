namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Global_Remove : Endpoint<PubSubMessageModel[]>
{

	internal PubSub_Global_Remove(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubMessageModel[]> Call(string messageID) { }

	public Task<PubSubMessageModel[]> Call(IEnumerable<String> messageIDs) { }

	protected virtual PubSubMessageModel[] Receive(string json) { }

}

