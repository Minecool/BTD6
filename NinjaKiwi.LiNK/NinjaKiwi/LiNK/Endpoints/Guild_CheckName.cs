namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_CheckName : Endpoint<GuildNameAvailability>
{

	internal Guild_CheckName(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildNameAvailability> Call(string guildName) { }

	protected virtual GuildNameAvailability Receive(string json) { }

}

