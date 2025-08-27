namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_Update : Endpoint<GuildModel>
{

	internal Guild_Update(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildModel> Call(GuildModel guild) { }

	public Task<GuildModel> Call(string guildID, string newName, GuildStatus newStatus, int newMaxMembers, string newTagLine) { }

	protected virtual GuildModel Receive(string json) { }

}

