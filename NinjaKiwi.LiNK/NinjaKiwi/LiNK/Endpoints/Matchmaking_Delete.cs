namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_Delete : Endpoint<Boolean>
{

	internal Matchmaking_Delete(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string lobbyID) { }

	protected virtual bool Receive(string json) { }

}

