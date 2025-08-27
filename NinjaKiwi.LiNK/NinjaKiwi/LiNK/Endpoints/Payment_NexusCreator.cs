namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_NexusCreator : Endpoint<Boolean>
{

	internal Payment_NexusCreator(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call(string nexusCreatorIdOrSlug) { }

	protected virtual bool Receive(string json) { }

}

