namespace Firebase;

internal sealed class LogUtil : IDisposable
{
	public sealed class LogMessageDelegate : MulticastDelegate
	{

		public LogMessageDelegate(object object, IntPtr method) { }

		public override void Invoke(LogLevel log_level, string message) { }

	}

	private static LogUtil _instance; //Field offset: 0x0
	private static object InitializeLoggingLock; //Field offset: 0x8
	private bool _disposed; //Field offset: 0x10

	private static LogUtil() { }

	public LogUtil() { }

	[CompilerGenerated]
	private void <.ctor>b__9_0(object sender, EventArgs e) { }

	internal static PlatformLogLevel ConvertLogLevel(LogLevel logLevel) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public static void InitializeLogging() { }

	internal static void LogMessage(LogLevel logLevel, string message) { }

	[MonoPInvokeCallback(typeof(LogMessageDelegate))]
	internal static void LogMessageFromCallback(LogLevel logLevel, string message) { }

}

