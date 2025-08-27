namespace SteamNative;

internal struct MusicPlayerWantsPlayingRepeatStatus_t
{
	public struct PackSmall
	{
		internal int PlayingRepeatStatus; //Field offset: 0x0

		public static MusicPlayerWantsPlayingRepeatStatus_t op_Implicit(PackSmall d) { }

	}

	internal int PlayingRepeatStatus; //Field offset: 0x0

	internal static MusicPlayerWantsPlayingRepeatStatus_t FromPointer(IntPtr p) { }

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

