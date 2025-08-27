namespace SteamNative;

internal struct HTML_URLChanged_t
{
	public struct PackSmall
	{
		internal uint UnBrowserHandle; //Field offset: 0x0
		internal string PchURL; //Field offset: 0x8
		internal string PchPostData; //Field offset: 0x10
		internal bool BIsRedirect; //Field offset: 0x18
		internal string PchPageTitle; //Field offset: 0x20
		internal bool BNewNavigation; //Field offset: 0x28

		public static HTML_URLChanged_t op_Implicit(PackSmall d) { }

	}

	internal uint UnBrowserHandle; //Field offset: 0x0
	internal string PchURL; //Field offset: 0x8
	internal string PchPostData; //Field offset: 0x10
	internal bool BIsRedirect; //Field offset: 0x18
	internal string PchPageTitle; //Field offset: 0x20
	internal bool BNewNavigation; //Field offset: 0x28

	internal static HTML_URLChanged_t FromPointer(IntPtr p) { }

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

