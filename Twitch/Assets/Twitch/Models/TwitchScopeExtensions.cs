namespace Assets.Twitch.Models;

[Extension]
public static class TwitchScopeExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Scope, IEnumerable`1<String>> <>9__0_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<String> <GetScopesString>b__0_0(Scope x) { }

	}


	[Extension]
	public static bool ExistAll(Scope[] scopes, String[] scopesStr) { }

	[Extension]
	public static string GetScopesString(Scope[] scopes) { }

	[Extension]
	public static String[] GetScopeStrings(Scope scope) { }

}

