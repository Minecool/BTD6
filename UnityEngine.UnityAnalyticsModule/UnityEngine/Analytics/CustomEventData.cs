namespace UnityEngine.Analytics;

[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
internal class CustomEventData : IDisposable
{
	internal IntPtr m_Ptr; //Field offset: 0x10

	public CustomEventData(string name) { }

	public bool AddBool(string key, bool value) { }

	public bool AddDictionary(IDictionary<String, Object> eventData) { }

	public bool AddDouble(string key, double value) { }

	public bool AddInt32(string key, int value) { }

	public bool AddInt64(string key, long value) { }

	public bool AddString(string key, string value) { }

	public bool AddUInt32(string key, uint value) { }

	public bool AddUInt64(string key, ulong value) { }

	private void Destroy() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	internal static IntPtr Internal_Create(CustomEventData ced, string name) { }

	[ThreadSafe]
	internal static void Internal_Destroy(IntPtr ptr) { }

}

