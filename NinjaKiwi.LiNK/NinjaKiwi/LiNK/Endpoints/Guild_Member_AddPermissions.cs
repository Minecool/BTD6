namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_Member_AddPermissions : Endpoint<GuildMembershipState>
{

	internal Guild_Member_AddPermissions(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildMembershipState> Call(string guildID, string memberLiNKID, GuildMembershipState permissionsToAdd) { }

	protected virtual GuildMembershipState Receive(string json) { }

}

