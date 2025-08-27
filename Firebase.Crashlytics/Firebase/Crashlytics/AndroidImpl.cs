namespace Firebase.Crashlytics;

internal class AndroidImpl : Impl
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public AndroidImpl <>4__this; //Field offset: 0x10
		public string key; //Field offset: 0x18
		public string value; //Field offset: 0x20

		public <>c__DisplayClass10_0() { }

		internal void <SetCustomKey>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public AndroidImpl <>4__this; //Field offset: 0x10
		public LoggedException loggedException; //Field offset: 0x18
		public StackFrames frames; //Field offset: 0x20

		public <>c__DisplayClass12_0() { }

		internal void <LogException>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public AndroidImpl <>4__this; //Field offset: 0x10
		public LoggedException loggedException; //Field offset: 0x18
		public StackFrames frames; //Field offset: 0x20

		public <>c__DisplayClass13_0() { }

		internal void <LogExceptionAsFatal>b__0() { }

	}

	private FirebaseCrashlyticsInternal crashlyticsInternal; //Field offset: 0x10
	private readonly FirebaseApp firebaseApp; //Field offset: 0x18

	internal AndroidImpl() { }

	private void CallInternalMethod(Action methodCall, string operation) { }

	private void Dispose() { }

	protected virtual void Finalize() { }

	public virtual bool IsSDKInitialized() { }

	public virtual void LogException(Exception exception) { }

	public virtual void LogExceptionAsFatal(Exception exception) { }

	private void LogOperationFailedWarningDueToShutdown(string operation) { }

	public virtual void SetCustomKey(string key, string value) { }

}

