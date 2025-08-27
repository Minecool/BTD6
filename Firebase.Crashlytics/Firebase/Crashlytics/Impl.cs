namespace Firebase.Crashlytics;

internal class Impl
{
	private static readonly string LogString; //Field offset: 0x0
	private static readonly string SetKeyValueString; //Field offset: 0x8
	private static readonly string SetUserIdentifierString; //Field offset: 0x10
	private static readonly string LogExceptionString; //Field offset: 0x18
	private static readonly string LogExceptionAsFatalString; //Field offset: 0x20
	private static readonly string IsCrashlyticsCollectionEnabledString; //Field offset: 0x28
	private static readonly string SetCrashlyticsCollectionEnabledString; //Field offset: 0x30

	private static Impl() { }

	public Impl() { }

	public override bool IsSDKInitialized() { }

	public override void LogException(Exception exception) { }

	public override void LogExceptionAsFatal(Exception exception) { }

	public static Impl Make() { }

	public override void SetCustomKey(string key, string value) { }

}

