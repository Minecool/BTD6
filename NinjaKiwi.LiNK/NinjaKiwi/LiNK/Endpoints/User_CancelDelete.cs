namespace NinjaKiwi.LiNK.Endpoints;

public class User_CancelDelete : Endpoint<Boolean>
{
	internal enum ConfirmationType
	{
		EMAIL_PASSWORD = 0,
		SHORTCODE_CRC = 1,
		ADMIN = 2,
		SUPPORT_CONTACT = 3,
		LAPSED_USER = 4,
	}


	internal User_CancelDelete(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Boolean> Call() { }

	protected virtual bool Receive(string json) { }

}

