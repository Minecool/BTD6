namespace SteamNative;

internal struct GameConnectedFriendChatMsg_t
{
	public struct PackSmall
	{
		internal ulong SteamIDUser; //Field offset: 0x0
		internal int MessageID; //Field offset: 0x8

		public static GameConnectedFriendChatMsg_t op_Implicit(PackSmall d) { }

	}

	internal ulong SteamIDUser; //Field offset: 0x0
	internal int MessageID; //Field offset: 0x8

	internal static GameConnectedFriendChatMsg_t FromPointer(IntPtr p) { }

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

