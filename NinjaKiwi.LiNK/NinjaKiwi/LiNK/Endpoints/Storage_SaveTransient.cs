namespace NinjaKiwi.LiNK.Endpoints;

public class Storage_SaveTransient : Endpoint<Boolean>
{

	internal Storage_SaveTransient(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string filename, string data, Nullable<TimeSpan> expiresIn = null) { }

	protected virtual bool Receive(string json) { }

}

