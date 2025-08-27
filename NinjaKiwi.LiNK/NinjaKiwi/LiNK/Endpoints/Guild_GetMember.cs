namespace NinjaKiwi.LiNK.Endpoints;

public class Guild_GetMember : Endpoint<Guild_GetMemberResponse>
{

	internal Guild_GetMember(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Guild_GetMemberResponse> Call(string liNKID) { }

	protected virtual Guild_GetMemberResponse Receive(string json) { }

}

