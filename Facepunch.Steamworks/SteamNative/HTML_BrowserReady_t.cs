namespace SteamNative;

internal struct HTML_BrowserReady_t
{
	public struct PackSmall
	{
		internal uint UnBrowserHandle; //Field offset: 0x0

		public static HTML_BrowserReady_t op_Implicit(PackSmall d) { }

	}

	internal uint UnBrowserHandle; //Field offset: 0x0

	internal static CallResult<HTML_BrowserReady_t> CallResult(BaseSteamworks steamworks, SteamAPICall_t call, Action<HTML_BrowserReady_t, Boolean> CallbackFunction) { }

	internal static HTML_BrowserReady_t FromPointer(IntPtr p) { }

	[MonoPInvokeCallback]
	internal static int OnGetSize() { }

	[MonoPInvokeCallback]
	internal static int OnGetSizeThis(IntPtr self) { }

	[MonoPInvokeCallback]
	internal static void OnResult(IntPtr param) { }

	[MonoPInvokeCallback]
	internal static void OnResultThis(IntPtr self, IntPtr param) { }

	[MonoPInvokeCallback]
	internal static void OnResultWithInfo(IntPtr param, bool failure, SteamAPICall_t call) { }

	[MonoPInvokeCallback]
	internal static void OnResultWithInfoThis(IntPtr self, IntPtr param, bool failure, SteamAPICall_t call) { }

	internal static void Register(BaseSteamworks steamworks) { }

	internal static int StructSize() { }

}

