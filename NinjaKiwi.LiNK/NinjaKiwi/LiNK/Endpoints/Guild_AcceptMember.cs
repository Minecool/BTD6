namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_AcceptMember : Endpoint<Boolean>
{

	internal Guild_AcceptMember(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string guildID, string memberLiNKID, bool accept) { }

	protected virtual bool Receive(string json) { }

}

