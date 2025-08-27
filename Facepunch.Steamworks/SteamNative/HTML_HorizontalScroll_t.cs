namespace SteamNative;

internal struct HTML_HorizontalScroll_t
{
	public struct PackSmall
	{
		internal uint UnBrowserHandle; //Field offset: 0x0
		internal uint UnScrollMax; //Field offset: 0x4
		internal uint UnScrollCurrent; //Field offset: 0x8
		internal float FlPageScale; //Field offset: 0xC
		internal bool BVisible; //Field offset: 0x10
		internal uint UnPageSize; //Field offset: 0x14

		public static HTML_HorizontalScroll_t op_Implicit(PackSmall d) { }

	}

	internal uint UnBrowserHandle; //Field offset: 0x0
	internal uint UnScrollMax; //Field offset: 0x4
	internal uint UnScrollCurrent; //Field offset: 0x8
	internal float FlPageScale; //Field offset: 0xC
	internal bool BVisible; //Field offset: 0x10
	internal uint UnPageSize; //Field offset: 0x14

	internal static HTML_HorizontalScroll_t FromPointer(IntPtr p) { }

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

