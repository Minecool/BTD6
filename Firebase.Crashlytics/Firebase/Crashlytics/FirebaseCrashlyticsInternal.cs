namespace Firebase.Crashlytics;

internal class FirebaseCrashlyticsInternal : IDisposable
{
	private HandleRef swigCPtr; //Field offset: 0x10
	protected bool swigCMemOwn; //Field offset: 0x20

	internal bool IsDisposed
	{
		internal get { } //Length: 16
	}

	internal FirebaseCrashlyticsInternal(IntPtr cPtr, bool cMemoryOwn) { }

	public override void Dispose() { }

	public override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	internal bool get_IsDisposed() { }

	internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app, out InitResult init_result_out) { }

	public void LogException(string name, string reason, StackFrames frames) { }

	public void LogExceptionAsFatal(string name, string reason, StackFrames frames) { }

	public void SetCustomKey(string key, string value) { }

}

