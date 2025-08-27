namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_RemoveMember : Endpoint<Boolean>
{

	internal Guild_RemoveMember(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string guildID, string memberLiNKID, bool allowDisband = false) { }

	protected virtual bool Receive(string json) { }

}

