namespace Assets.Scripts.Unity.PlatformLogins;

public class GooglePlayLogin : IAuthenticationProvider<GooglePlayToken>
{
	private readonly MultiLevelLogger Logger; //Field offset: 0x10

	public static bool Available
	{
		 get { } //Length: 3
	}

	public static bool IsAuthenticating
	{
		 get { } //Length: 3
	}

	public GooglePlayLogin(MultiLevelLogger logger) { }

	public override Task<GooglePlayToken> AskForAuthToken() { }

	public static Task Authenticate() { }

	public static bool get_Available() { }

	public static bool get_IsAuthenticating() { }

	public static string GetIdIfAuthenticated() { }

	public override string GetIdWithProviderPrefixIfAuthenticated() { }

}

