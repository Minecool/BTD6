namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_RemoveInvites : Endpoint<List`1<LobbyInviteModel>>
{

	internal Matchmaking_RemoveInvites(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<LobbyInviteModel>> Call(string lobbyID, string recipientID, InviteType lobbyType) { }

	protected virtual List<LobbyInviteModel> Receive(string json) { }

}

