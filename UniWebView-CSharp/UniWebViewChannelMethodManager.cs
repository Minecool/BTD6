//Type is in global namespace

internal class UniWebViewChannelMethodManager
{
	[CompilerGenerated]
	private struct <>c__DisplayClass9_0
	{
		public Func<Object, Object> func; //Field offset: 0x0

	}

	private static UniWebViewChannelMethodManager instance; //Field offset: 0x0
	private Dictionary<String, Dictionary`2<String, Func`2<Object, Object>>> channels; //Field offset: 0x10

	internal static UniWebViewChannelMethodManager Instance
	{
		internal get { } //Length: 207
	}

	public UniWebViewChannelMethodManager() { }

	[CompilerGenerated]
	internal static bool <InvokeMethod>g__Func|9_0(UniWebViewChannelMethodHandleRequest i, ref <>c__DisplayClass9_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static UniWebViewMediaCapturePermissionDecision <InvokeMethod>g__Func|9_1(UniWebViewChannelMethodMediaCapturePermission i, ref <>c__DisplayClass9_0 unnamed_param_1) { }

	internal static UniWebViewChannelMethodManager get_Instance() { }

	private bool HasRegisteredChannel(string webViewName) { }

	private bool HasRegisteredMethod(string webViewName, string methodName) { }

	internal string InvokeMethod(string webViewName, string methodName, string parameters) { }

	internal void RegisterChannelMethod(string webViewName, UniWebViewChannelMethod method, Func<Object, Object> handler) { }

	private string ResultJsonWith(bool value) { }

	private string ResultJsonWith(UniWebViewMediaCapturePermissionDecision decision) { }

	internal void UnregisterChannel(string webViewName) { }

	internal void UnregisterChannelMethod(string webViewName, UniWebViewChannelMethod method) { }

}

