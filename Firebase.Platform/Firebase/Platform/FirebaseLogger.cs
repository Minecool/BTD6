namespace Firebase.Platform;

internal class FirebaseLogger
{
	private static MainThreadProperty<Boolean> incompatibleStackUnwindingEnabled; //Field offset: 0x0

	internal static bool CanRedirectNativeLogs
	{
		internal get { } //Length: 387
	}

	private static FirebaseLogger() { }

	private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs() { }

	internal static bool get_CanRedirectNativeLogs() { }

	private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType) { }

	internal static void LogMessage(PlatformLogLevel logLevel, string message) { }

}

