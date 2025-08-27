namespace Firebase.Crashlytics;

internal class ExceptionHandler
{
	private bool isRegistered; //Field offset: 0x10

	public ExceptionHandler() { }

	private String[] getMessageParts(string message) { }

	internal void HandleException(object sender, UnhandledExceptionEventArgs eArgs) { }

	internal void HandleLog(string message, string stackTraceString, LogType type) { }

	internal override void LogException(LoggedException e) { }

	internal void Register() { }

}

