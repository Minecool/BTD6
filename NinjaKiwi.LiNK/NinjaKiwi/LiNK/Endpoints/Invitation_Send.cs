namespace NinjaKiwi.LiNK.Endpoints;

public class Invitation_Send : Endpoint<List`1<Invitation>>
{

	internal Invitation_Send(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<List`1<Invitation>> Call(string recipientLiNKID, string invitationType, string metadata, Nullable<TimeSpan> expiresIn = null) { }

	protected virtual List<Invitation> Receive(string json) { }

}

