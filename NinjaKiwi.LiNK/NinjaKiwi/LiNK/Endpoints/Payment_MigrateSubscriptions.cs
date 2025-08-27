namespace NinjaKiwi.LiNK.Endpoints;

public class Payment_MigrateSubscriptions : Endpoint<Int32>
{

	internal Payment_MigrateSubscriptions(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Int32> Call(string from, string to) { }

	protected virtual int Receive(string json) { }

}

