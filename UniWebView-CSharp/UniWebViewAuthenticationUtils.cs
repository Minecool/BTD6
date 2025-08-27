//Type is in global namespace

public class UniWebViewAuthenticationUtils
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Random random; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal char <GenerateCodeVerifier>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string scheme; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <ConvertIntentUri>b__0(string fragment) { }

	}

	private static readonly Char[] padding; //Field offset: 0x0

	private static UniWebViewAuthenticationUtils() { }

	public UniWebViewAuthenticationUtils() { }

	public static string CalculateCodeChallenge(string codeVerifier, UniWebViewAuthenticationPKCE method) { }

	public static string ConvertIntentUri(string input) { }

	public static string ConvertPKCEToString(UniWebViewAuthenticationPKCE method) { }

	public static string ConvertToBase64String(string input) { }

	public static string ConvertToBase64URLString(string input) { }

	public static string CreateQueryString(Dictionary<String, String> collection) { }

	public static string GenerateCodeVerifier(int length = 64) { }

	public static string GenerateRandomBase64String() { }

	public static string GenerateRandomBase64URLString() { }

	internal static Dictionary<String, String> ParseFormUrlEncodedString(string input) { }

}

