namespace NinjaKiwi.Common;

[Extension]
public static class ErrorHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<FileInfo, Boolean> <>9__25_0; //Field offset: 0x8
		public static Func<FileInfo, DateTime> <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <UploadCrashLogs>b__25_0(FileInfo f) { }

		internal DateTime <UploadCrashLogs>b__25_1(FileInfo f) { }

	}

	[CompilerGenerated]
	private struct <UploadCrashLogs>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Encoder encoder; //Field offset: 0x20
		public UploadFileFn uploadFileFn; //Field offset: 0x28
		private FileInfo <crashLogFile>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CopyToClipboard : MulticastDelegate
	{

		public CopyToClipboard(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string cliboardString, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string cliboardString) { }

	}

	internal sealed class Encoder : MulticastDelegate
	{

		public Encoder(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Byte[] orig, AsyncCallback callback, object object) { }

		public override Byte[] EndInvoke(IAsyncResult result) { }

		public override Byte[] Invoke(Byte[] orig) { }

	}

	internal sealed class HandleException : MulticastDelegate
	{

		public HandleException(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string logString, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string logString) { }

	}

	internal sealed class SystemDetailValue : MulticastDelegate
	{

		public SystemDetailValue(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override string EndInvoke(IAsyncResult result) { }

		public override string Invoke() { }

	}

	internal sealed class UploadFileFn : MulticastDelegate
	{

		public UploadFileFn(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string filename, string data, Nullable<TimeSpan> expiresIn, AsyncCallback callback, object object) { }

		public override Task EndInvoke(IAsyncResult result) { }

		public override Task Invoke(string filename, string data, Nullable<TimeSpan> expiresIn = null) { }

	}

	private const string kCrashLogFilePrefix = "Crash_"; //Field offset: 0x0
	private const string kCrashLogFileExtension = ".log"; //Field offset: 0x0
	private static TimeSpan UploadCrashLogTimeout; //Field offset: 0x0
	private static Dictionary<String, SystemDetailValue> extraSystemDetails; //Field offset: 0x8
	private static HandleException handleException; //Field offset: 0x10
	private static CopyToClipboard copyToClipboard; //Field offset: 0x18
	private static readonly string RegexMatchPattern; //Field offset: 0x20

	private static string CrashLogRoot
	{
		private get { } //Length: 64
	}

	private static ErrorHandler() { }

	public static void AddSystemDetail(string key, SystemDetailValue valueGetter) { }

	private static string CleanupExceptionStrings(string exceptionString) { }

	private static void CopyAndWriteCrashLog(string dumpStr) { }

	public static void DumpCrashLog(Exception exception) { }

	public static void DumpCrashLog(string exceptionStr) { }

	private static string get_CrashLogRoot() { }

	private static string GetSystemDetails() { }

	public static void Initialise(HandleException handleException, CopyToClipboard copyToClipboard) { }

	private static void ReadExceptionsAndForceQuit(string logString, string stackTrace, LogType type) { }

	public static void StartListeningForExceptions() { }

	public static void StopListeningForExceptions() { }

	[Extension]
	private static string ToCustomString(Exception exception) { }

	[AsyncStateMachine(typeof(<UploadCrashLogs>d__25))]
	public static Task UploadCrashLogs(UploadFileFn uploadFileFn, Encoder encoder) { }

}

