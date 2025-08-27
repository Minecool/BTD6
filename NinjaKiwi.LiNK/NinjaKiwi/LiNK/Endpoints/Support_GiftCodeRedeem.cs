namespace NinjaKiwi.LiNK.Endpoints;

public class Support_GiftCodeRedeem : Endpoint<PubSubMessageModel>
{

	internal Support_GiftCodeRedeem(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PubSubMessageModel> Call(string giftCode, bool alsoRespondToPubSubChannel) { }

	protected virtual PubSubMessageModel Receive(string json) { }

}

