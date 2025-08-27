namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_Request : Endpoint<Boolean>
{

	internal Friends_Request(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string liNKID) { }

	protected virtual bool Receive(string json) { }

}

