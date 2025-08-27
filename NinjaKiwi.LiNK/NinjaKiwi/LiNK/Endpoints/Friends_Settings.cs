namespace NinjaKiwi.LiNK.Endpoints;

public class Friends_Settings : Endpoint<Boolean>
{

	internal Friends_Settings(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(string settingName, FriendSetting value) { }

	protected virtual bool Receive(string json) { }

}

