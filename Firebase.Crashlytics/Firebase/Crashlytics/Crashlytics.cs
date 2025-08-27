namespace Firebase.Crashlytics;

[Preserve]
public static class Crashlytics
{
	[Preserve]
	public static class PlatformAccessor
	{
		private static ExceptionHandler _exceptionHandler; //Field offset: 0x0
		private static Impl _impl; //Field offset: 0x8
		private static FirebaseApp _app; //Field offset: 0x10

		[Preserve]
		internal static FirebaseApp App
		{
			internal get { } //Length: 79
		}

		[Preserve]
		internal static ExceptionHandler ExceptionHandler
		{
			internal get { } //Length: 78
		}

		internal static Impl Impl
		{
			internal get { } //Length: 79
		}

		private static PlatformAccessor() { }

		internal static FirebaseApp get_App() { }

		internal static ExceptionHandler get_ExceptionHandler() { }

		internal static Impl get_Impl() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static bool <ReportUncaughtExceptionsAsFatal>k__BackingField; //Field offset: 0x0

	public static bool ReportUncaughtExceptionsAsFatal
	{
		[CompilerGenerated]
		 get { } //Length: 78
	}

	private static Crashlytics() { }

	[CompilerGenerated]
	public static bool get_ReportUncaughtExceptionsAsFatal() { }

	[Preserve]
	private static void Initialize() { }

	public static void LogException(Exception exception) { }

	internal static void LogExceptionAsFatal(Exception exception) { }

}

