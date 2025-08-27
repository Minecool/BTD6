namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_UpdatePermissions : Endpoint<GuildMembershipState>
{

	internal Guild_UpdatePermissions(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildMembershipState> Call(string guildID, string memberLiNKID, GuildMembershipState permissionsToAdd) { }

	protected virtual GuildMembershipState Receive(string json) { }

}

