namespace NinjaKiwi.LiNK.Endpoints;

public class Social_Reconnect : Endpoint<Boolean>
{

	internal Social_Reconnect(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task Call(SocialLeaderboardProvider provider, string token) { }

}

