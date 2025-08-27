namespace NinjaKiwi.LiNK.Endpoints;

public class User_SteamTicket : Endpoint<Boolean>
{

	internal User_SteamTicket(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call(string sessionTicket) { }

	public Task<Boolean> Call(Byte[] sessionTicketData) { }

	protected virtual bool Receive(string json) { }

}

