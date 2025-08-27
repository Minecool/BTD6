namespace NinjaKiwi.LiNK.Endpoints;

public class Utils_GetTime : Endpoint<DateTime>
{

	internal Utils_GetTime(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<DateTime> Call() { }

	protected virtual DateTime Receive(string json) { }

}

