namespace NinjaKiwi.LiNK.Endpoints;

public class PubSub_Global_Wipe : Endpoint<Boolean>
{

	internal PubSub_Global_Wipe(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string channelID) { }

	protected virtual bool Receive(string json) { }

}

