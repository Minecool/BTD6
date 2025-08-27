namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Global_Send : Endpoint<PubSubMessageModel>
{

	internal PubSub_Global_Send(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubMessageModel> Call(string channelID, string payload, Dictionary<String, Object> otherMessageData = null, Nullable<TimeSpan> expiresIn = null, int type = 1000) { }

	public Task<PubSubMessageModel> Call(IEnumerable<String> channelIDs, string payload, Dictionary<String, Object> otherMessageData = null, Nullable<TimeSpan> expiresIn = null, int type = 1000) { }

	protected virtual PubSubMessageModel Receive(string json) { }

}

