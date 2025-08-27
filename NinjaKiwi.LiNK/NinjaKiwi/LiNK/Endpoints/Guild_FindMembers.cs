namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_FindMembers : Endpoint<List`1<GuildMemberModel>>
{

	internal Guild_FindMembers(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<GuildMemberModel>> Call(string guildID, IEnumerable<String> liNKIDs) { }

	protected virtual List<GuildMemberModel> Receive(string json) { }

}

