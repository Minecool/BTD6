namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_Join : Endpoint<GuildMembershipState>
{

	internal Guild_Join(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildMembershipState> Call(string guildID) { }

	protected virtual GuildMembershipState Receive(string json) { }

}

