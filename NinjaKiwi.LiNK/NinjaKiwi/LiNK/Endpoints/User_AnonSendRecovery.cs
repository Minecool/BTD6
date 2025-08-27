namespace NinjaKiwi.LiNK.Endpoints;

public class User_AnonSendRecovery : Endpoint<Boolean>
{

	internal User_AnonSendRecovery(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call(string emailAddress) { }

	protected virtual bool Receive(string json) { }

}

