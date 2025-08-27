namespace NinjaKiwi.LiNK.Endpoints;

public class User_Find : Endpoint<Dictionary`2<String, UserModel>>
{
	internal enum Method
	{
		EMAIL = 0,
		LiNK_ID = 1,
		PROVIDER_ID = 2,
		DISPLAY_NAME = 3,
		SHORTCODE = 4,
	}


	internal User_Find(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<Dictionary`2<String, UserModel>> Call(IEnumerable<String> keys, Method method, bool includeOnlineStatus = false) { }

	protected virtual Dictionary<String, UserModel> Receive(string json) { }

}

