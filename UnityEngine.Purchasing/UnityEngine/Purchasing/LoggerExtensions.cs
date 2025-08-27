namespace UnityEngine.Purchasing;

[Extension]
internal static class LoggerExtensions
{

	[Extension]
	public static void LogIAPError(ILogger logger, string message) { }

	[Extension]
	public static void LogIAPWarning(ILogger logger, string message) { }

}

