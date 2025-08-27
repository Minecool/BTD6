namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_GetSubscriptions : Endpoint<List`1<SubscriptionModel>>
{

	internal Payment_GetSubscriptions(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<SubscriptionModel>> Call(string identifier, string receipt = null) { }

	protected virtual List<SubscriptionModel> Receive(string json) { }

}

