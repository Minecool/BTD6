namespace NinjaKiwi.LiNK.Endpoints;

public class Invitation_Get : Endpoint<List`1<Invitation>>
{

	internal Invitation_Get(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<Invitation>> Call(string invitationType) { }

	public Task<List`1<Invitation>> Call(IEnumerable<String> invitationTypes) { }

	protected virtual List<Invitation> Receive(string json) { }

}

