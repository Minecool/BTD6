namespace Assets.Scripts.Unity.PlatformLogins;

public class SteamLogin : IAuthenticationProvider<SteamToken>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Byte, String> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <AskForAuthToken>b__2_0(byte b) { }

	}

	private readonly MultiLevelLogger Logger; //Field offset: 0x10

	public SteamLogin(MultiLevelLogger logger) { }

	public override Task<SteamToken> AskForAuthToken() { }

	public static uint GetAccountID(ulong steamID) { }

	public static string GetIdIfAuthenticated() { }

	public override string GetIdWithProviderPrefixIfAuthenticated() { }

}

