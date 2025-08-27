namespace Firebase.Crashlytics;

public class FirebaseCrashlyticsFrame : IDisposable
{
	private HandleRef swigCPtr; //Field offset: 0x10
	protected bool swigCMemOwn; //Field offset: 0x20

	public string fileName
	{
		 set { } //Length: 323
	}

	public string library
	{
		 set { } //Length: 323
	}

	public string lineNumber
	{
		 set { } //Length: 323
	}

	public string symbol
	{
		 set { } //Length: 323
	}

	internal FirebaseCrashlyticsFrame(IntPtr cPtr, bool cMemoryOwn) { }

	public FirebaseCrashlyticsFrame() { }

	public override void Dispose() { }

	public override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	internal static HandleRef getCPtr(FirebaseCrashlyticsFrame obj) { }

	public void set_fileName(string value) { }

	public void set_library(string value) { }

	public void set_lineNumber(string value) { }

	public void set_symbol(string value) { }

}

