namespace NinjaKiwi.LiNK.Endpoints;

public class User_LoginSession : Endpoint<String>
{

	internal User_LoginSession(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call(string encryptedSessionID, string sessionTicket) { }

	protected virtual string Receive(string json) { }

}

