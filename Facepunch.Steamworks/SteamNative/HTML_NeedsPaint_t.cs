namespace SteamNative;

internal struct HTML_NeedsPaint_t
{
	public struct PackSmall
	{
		internal uint UnBrowserHandle; //Field offset: 0x0
		internal IntPtr PBGRA; //Field offset: 0x4
		internal uint UnWide; //Field offset: 0xC
		internal uint UnTall; //Field offset: 0x10
		internal uint UnUpdateX; //Field offset: 0x14
		internal uint UnUpdateY; //Field offset: 0x18
		internal uint UnUpdateWide; //Field offset: 0x1C
		internal uint UnUpdateTall; //Field offset: 0x20
		internal uint UnScrollX; //Field offset: 0x24
		internal uint UnScrollY; //Field offset: 0x28
		internal float FlPageScale; //Field offset: 0x2C
		internal uint UnPageSerial; //Field offset: 0x30

		public static HTML_NeedsPaint_t op_Implicit(PackSmall d) { }

	}

	internal uint UnBrowserHandle; //Field offset: 0x0
	internal IntPtr PBGRA; //Field offset: 0x8
	internal uint UnWide; //Field offset: 0x10
	internal uint UnTall; //Field offset: 0x14
	internal uint UnUpdateX; //Field offset: 0x18
	internal uint UnUpdateY; //Field offset: 0x1C
	internal uint UnUpdateWide; //Field offset: 0x20
	internal uint UnUpdateTall; //Field offset: 0x24
	internal uint UnScrollX; //Field offset: 0x28
	internal uint UnScrollY; //Field offset: 0x2C
	internal float FlPageScale; //Field offset: 0x30
	internal uint UnPageSerial; //Field offset: 0x34

	internal static HTML_NeedsPaint_t FromPointer(IntPtr p) { }

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

