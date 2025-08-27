namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Read : Endpoint<PubSubChannelModel>
{

	internal PubSub_Read(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubChannelModel> Call(string channelID, int limit, long lastUpdated = 0) { }

	protected virtual PubSubChannelModel Receive(string json) { }

}

