namespace SteamNative;

internal struct FavoritesListChanged_t
{
	public struct PackSmall
	{
		internal uint IP; //Field offset: 0x0
		internal uint QueryPort; //Field offset: 0x4
		internal uint ConnPort; //Field offset: 0x8
		internal uint AppID; //Field offset: 0xC
		internal uint Flags; //Field offset: 0x10
		internal bool Add; //Field offset: 0x14
		internal uint AccountId; //Field offset: 0x18

		public static FavoritesListChanged_t op_Implicit(PackSmall d) { }

	}

	internal uint IP; //Field offset: 0x0
	internal uint QueryPort; //Field offset: 0x4
	internal uint ConnPort; //Field offset: 0x8
	internal uint AppID; //Field offset: 0xC
	internal uint Flags; //Field offset: 0x10
	internal bool Add; //Field offset: 0x14
	internal uint AccountId; //Field offset: 0x18

	internal static FavoritesListChanged_t FromPointer(IntPtr p) { }

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

