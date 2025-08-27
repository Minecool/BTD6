namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_Block : Endpoint<Boolean>
{

	internal Friends_Block(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string liNKID) { }

	protected virtual bool Receive(string json) { }

}

