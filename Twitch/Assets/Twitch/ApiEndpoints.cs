namespace Assets.Twitch;

internal static class ApiEndpoints
{
	public static class Authentication
	{
		private const string AuthBase = "https://id.twitch.tv/oauth2/"; //Field offset: 0x0
		internal const string Authorise = "https://id.twitch.tv/oauth2/authorize"; //Field offset: 0x0
		internal const string Validate = "https://id.twitch.tv/oauth2/validate"; //Field offset: 0x0
		internal const string Revoke = "https://id.twitch.tv/oauth2/revoke"; //Field offset: 0x0
		internal const string Refresh = "https://id.twitch.tv/oauth2/token"; //Field offset: 0x0

	}

	internal const string ApiBase = "https://api.twitch.tv/helix/"; //Field offset: 0x0
	internal const string Polls = "https://api.twitch.tv/helix/polls"; //Field offset: 0x0
	internal const string Users = "https://api.twitch.tv/helix/users"; //Field offset: 0x0

}

