namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_GetInvitationCode : Endpoint<String>
{

	internal Guild_GetInvitationCode(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<String> Call(int uses = 1) { }

	protected virtual string Receive(string json) { }

}

