namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_GetInvites : Endpoint<List`1<LobbyInviteModel>>
{

	internal Matchmaking_GetInvites(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<LobbyInviteModel>> Call(string recipientID, InviteType lobbyType) { }

	public Task<List`1<LobbyInviteModel>> Call(IEnumerable<String> recipientIDs, InviteType lobbyType) { }

	protected virtual List<LobbyInviteModel> Receive(string json) { }

}

