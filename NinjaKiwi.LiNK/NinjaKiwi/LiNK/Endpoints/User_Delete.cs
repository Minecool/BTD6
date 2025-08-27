namespace NinjaKiwi.LiNK.Endpoints;

public class User_Delete : Endpoint<TimeSpan>
{
	internal enum ConfirmationType
	{
		EMAIL_PASSWORD = 0,
		SHORTCODE_CRC = 1,
		ADMIN = 2,
		SUPPORT_CONTACT = 3,
		LAPSED_USER = 4,
	}


	internal User_Delete(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<TimeSpan> Call(string confirmation, ConfirmationType confirmationType) { }

	protected virtual TimeSpan Receive(string json) { }

}

