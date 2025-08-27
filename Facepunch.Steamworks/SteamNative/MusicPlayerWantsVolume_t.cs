namespace SteamNative;

internal struct MusicPlayerWantsVolume_t
{
	public struct PackSmall
	{
		internal float NewVolume; //Field offset: 0x0

		public static MusicPlayerWantsVolume_t op_Implicit(PackSmall d) { }

	}

	internal float NewVolume; //Field offset: 0x0

	internal static MusicPlayerWantsVolume_t FromPointer(IntPtr p) { }

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

