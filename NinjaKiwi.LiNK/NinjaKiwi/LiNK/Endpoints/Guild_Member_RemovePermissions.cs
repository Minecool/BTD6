namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_Member_RemovePermissions : Endpoint<GuildMembershipState>
{

	internal Guild_Member_RemovePermissions(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildMembershipState> Call(string guildID, string memberLiNKID, GuildMembershipState permissionsToRemove) { }

	protected virtual GuildMembershipState Receive(string json) { }

}

