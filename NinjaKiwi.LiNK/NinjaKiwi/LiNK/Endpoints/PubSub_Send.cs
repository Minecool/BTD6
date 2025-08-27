namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Send : Endpoint<PubSubMessageModel>
{

	internal PubSub_Send(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubMessageModel> Call(string channelID, string payload, string recipientLiNKID = null, Dictionary<String, Object> otherMessageData = null, Nullable<TimeSpan> expiresIn = null, int type = 1000) { }

	public Task<PubSubMessageModel> Call(IEnumerable<String> channelIDs, string payload, string recipientLiNKID = null, Dictionary<String, Object> otherMessageData = null, Nullable<TimeSpan> expiresIn = null, int type = 1000) { }

	protected virtual PubSubMessageModel Receive(string json) { }

}

