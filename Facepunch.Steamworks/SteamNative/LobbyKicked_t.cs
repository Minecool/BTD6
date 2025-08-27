namespace SteamNative;

internal struct LobbyKicked_t
{
	public struct PackSmall
	{
		internal ulong SteamIDLobby; //Field offset: 0x0
		internal ulong SteamIDAdmin; //Field offset: 0x8
		internal byte KickedDueToDisconnect; //Field offset: 0x10

		public static LobbyKicked_t op_Implicit(PackSmall d) { }

	}

	internal ulong SteamIDLobby; //Field offset: 0x0
	internal ulong SteamIDAdmin; //Field offset: 0x8
	internal byte KickedDueToDisconnect; //Field offset: 0x10

	internal static LobbyKicked_t FromPointer(IntPtr p) { }

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

