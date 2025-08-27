namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_ListMembers : Endpoint<PagedCollection`1<GuildMemberModel>>
{

	internal Guild_ListMembers(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<PagedCollection`1<GuildMemberModel>> Call(string guildID, int limit, int offset) { }

	public Task<PagedCollection`1<GuildMemberModel>> Call(string guildID, int limit, int offset, GuildMembershipState minimumPermissions, GuildMembershipState maximumPermissions) { }

	protected virtual PagedCollection<GuildMemberModel> Receive(string json) { }

}

