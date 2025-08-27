namespace NinjaKiwi.Common;

public static class NetworkUtilities
{
	public const string kHeader_UserAgent = "user-agent"; //Field offset: 0x0
	public const string kHeader_ContentType = "Content-Type"; //Field offset: 0x0
	public const string kContentTypeJson = "application/json"; //Field offset: 0x0

	public static bool IsHTTPFailure(long code) { }

	public static bool IsHTTPSuccess(long code) { }

	public static string MakeLinkUserAgentName(string gameName, string platform, string appVersion) { }

	private static string md5(Byte[] buffer) { }

	public static string md5(string str) { }

	public static string Signature(string salt, Byte[] body) { }

	public static string Signature(string salt, string body) { }

}

