namespace SteamNative;

internal struct HTML_NewWindow_t
{
	public struct PackSmall
	{
		internal uint UnBrowserHandle; //Field offset: 0x0
		internal string PchURL; //Field offset: 0x8
		internal uint UnX; //Field offset: 0x10
		internal uint UnY; //Field offset: 0x14
		internal uint UnWide; //Field offset: 0x18
		internal uint UnTall; //Field offset: 0x1C
		internal uint UnNewWindow_BrowserHandle; //Field offset: 0x20

		public static HTML_NewWindow_t op_Implicit(PackSmall d) { }

	}

	internal uint UnBrowserHandle; //Field offset: 0x0
	internal string PchURL; //Field offset: 0x8
	internal uint UnX; //Field offset: 0x10
	internal uint UnY; //Field offset: 0x14
	internal uint UnWide; //Field offset: 0x18
	internal uint UnTall; //Field offset: 0x1C
	internal uint UnNewWindow_BrowserHandle; //Field offset: 0x20

	internal static HTML_NewWindow_t FromPointer(IntPtr p) { }

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

