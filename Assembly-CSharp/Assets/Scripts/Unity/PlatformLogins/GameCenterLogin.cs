namespace Assets.Scripts.Unity.PlatformLogins;

public class GameCenterLogin : IAuthenticationProvider<GameCenterToken>
{
	private MultiLevelLogger Logger; //Field offset: 0x10

	public static bool Available
	{
		 get { } //Length: 3
	}

	public static bool IsAuthenticating
	{
		 get { } //Length: 3
	}

	public GameCenterLogin(MultiLevelLogger logger) { }

	public override Task<GameCenterToken> AskForAuthToken() { }

	public static Task Authenticate() { }

	public static bool get_Available() { }

	public static bool get_IsAuthenticating() { }

	public static string GetIdIfAuthenticated() { }

	public override string GetIdWithProviderPrefixIfAuthenticated() { }

}

