namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Global_Read : Endpoint<PubSubChannelModel>
{

	internal PubSub_Global_Read(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubChannelModel> Call(string channelID, int limit, long lastUpdated = 0) { }

	protected virtual PubSubChannelModel Receive(string json) { }

}

