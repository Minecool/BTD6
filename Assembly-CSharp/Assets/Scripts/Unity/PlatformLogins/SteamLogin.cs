namespace Assets.Scripts.Unity.PlatformLogins;

public class SteamLogin : IAuthenticationProvider<SteamToken>
{
	private readonly MultiLevelLogger Logger; //Field offset: 0x10

	public SteamLogin(MultiLevelLogger logger) { }

	public override Task<SteamToken> AskForAuthToken() { }

	public static uint GetAccountID(ulong steamID) { }

	public static string GetIdIfAuthenticated() { }

	public override string GetIdWithProviderPrefixIfAuthenticated() { }

}

