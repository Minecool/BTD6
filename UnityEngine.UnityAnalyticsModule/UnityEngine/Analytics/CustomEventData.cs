namespace UnityEngine.Analytics;

[NativeHeader("Modules/UnityAnalytics/Public/Events/UserCustomEvent.h")]
internal class CustomEventData : IDisposable
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(CustomEventData customEventData) { }

	}

	internal IntPtr m_Ptr; //Field offset: 0x10

	public CustomEventData(string name) { }

	public bool AddBool(string key, bool value) { }

	private static bool AddBool_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, bool value) { }

	public bool AddDictionary(IDictionary<String, Object> eventData) { }

	public bool AddDouble(string key, double value) { }

	private static bool AddDouble_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, double value) { }

	public bool AddInt32(string key, int value) { }

	private static bool AddInt32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, int value) { }

	public bool AddInt64(string key, long value) { }

	private static bool AddInt64_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, long value) { }

	public bool AddString(string key, string value) { }

	private static bool AddString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, ref ManagedSpanWrapper value) { }

	public bool AddUInt32(string key, uint value) { }

	private static bool AddUInt32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, uint value) { }

	public bool AddUInt64(string key, ulong value) { }

	private static bool AddUInt64_Injected(IntPtr _unity_self, ref ManagedSpanWrapper key, ulong value) { }

	private void Destroy() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	internal static IntPtr Internal_Create(CustomEventData ced, string name) { }

	private static IntPtr Internal_Create_Injected(CustomEventData ced, ref ManagedSpanWrapper name) { }

	[ThreadSafe]
	internal static void Internal_Destroy(IntPtr ptr) { }

}

