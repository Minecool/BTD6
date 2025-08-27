namespace NinjaKiwi.LiNK.Endpoints;

public class Matchmaking_SendInvites : Endpoint<List`1<LobbyInviteModel>>
{

	internal Matchmaking_SendInvites(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<LobbyInviteModel>> Call(string lobbyID, string inviteMetadata, string recipient, InviteType lobbyType, Nullable<TimeSpan> expiry = null) { }

	public Task<List`1<LobbyInviteModel>> Call(string lobbyID, string inviteMetadata, IEnumerable<String> recipients, InviteType lobbyType, Nullable<TimeSpan> expiry = null) { }

	protected virtual List<LobbyInviteModel> Receive(string json) { }

}

