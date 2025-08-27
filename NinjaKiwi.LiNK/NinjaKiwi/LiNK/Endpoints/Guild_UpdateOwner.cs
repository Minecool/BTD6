namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_UpdateOwner : Endpoint<GuildModel>
{

	internal Guild_UpdateOwner(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildModel> Call(string guildID, string newOwnerID) { }

}

