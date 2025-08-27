namespace NinjaKiwi.LiNK.Endpoints;

public class Storage_SaveTemp : Endpoint<Boolean>
{

	internal Storage_SaveTemp(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string id, string filename, string data, Nullable<TimeSpan> expiresIn = null) { }

	protected virtual bool Receive(string json) { }

}

