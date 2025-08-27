namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Remove : Endpoint<PubSubMessageModel>
{

	internal PubSub_Remove(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubMessageModel> Call(string messageID) { }

	protected virtual PubSubMessageModel Receive(string json) { }

}

