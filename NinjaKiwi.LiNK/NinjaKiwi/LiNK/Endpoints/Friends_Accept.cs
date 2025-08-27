namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_Accept : Endpoint<Boolean>
{

	internal Friends_Accept(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string liNKID) { }

	protected virtual bool Receive(string json) { }

}

