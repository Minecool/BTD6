namespace NinjaKiwi.LiNK.Endpoints;

public class Invitation_Remove : Endpoint<List`1<Invitation>>
{

	internal Invitation_Remove(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<Invitation>> Call(string invitationType, string invitationID) { }

	protected virtual List<Invitation> Receive(string json) { }

}

