namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_Remove : Endpoint<Boolean>
{

	internal Friends_Remove(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string liNKID) { }

	protected virtual bool Receive(string json) { }

}

