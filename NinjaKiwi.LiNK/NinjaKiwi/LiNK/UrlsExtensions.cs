namespace NinjaKiwi.LiNK;

[Extension]
public static class UrlsExtensions
{

	[Extension]
	public static UriBuilder GetUriForCdn(Environments enumValue, string path = null) { }

	[Extension]
	public static UriBuilder GetUriForLiNK(Environments enumValue, string path = null) { }

	[Extension]
	public static UriBuilder GetUriForPriorityCdn(Environments enumValue, string path = null) { }

	[Extension]
	public static UriBuilder GetUriForWebview(Environments enumValue, string path = null) { }

	private static UrlsDefinitionAttribute GetUrlsForEnum(Environments enumValue) { }

}

