namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_GetInfoByName : Endpoint<GuildModel>
{

	internal Guild_GetInfoByName(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildModel> Call(string guildName) { }

	protected virtual GuildModel Receive(string json) { }

}

