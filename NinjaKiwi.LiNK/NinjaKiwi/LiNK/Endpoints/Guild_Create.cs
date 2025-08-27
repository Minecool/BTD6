namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_Create : Endpoint<GuildModel>
{

	internal Guild_Create(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<GuildModel> Call(string name, GuildStatus status, int maxMembers, string tagLine) { }

	protected virtual GuildModel Receive(string json) { }

}

