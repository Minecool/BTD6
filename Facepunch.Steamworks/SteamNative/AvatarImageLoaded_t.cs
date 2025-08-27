namespace SteamNative;

internal struct AvatarImageLoaded_t
{
	public struct PackSmall
	{
		internal ulong SteamID; //Field offset: 0x0
		internal int Image; //Field offset: 0x8
		internal int Wide; //Field offset: 0xC
		internal int Tall; //Field offset: 0x10

		public static AvatarImageLoaded_t op_Implicit(PackSmall d) { }

	}

	internal ulong SteamID; //Field offset: 0x0
	internal int Image; //Field offset: 0x8
	internal int Wide; //Field offset: 0xC
	internal int Tall; //Field offset: 0x10

	internal static AvatarImageLoaded_t FromPointer(IntPtr p) { }

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

