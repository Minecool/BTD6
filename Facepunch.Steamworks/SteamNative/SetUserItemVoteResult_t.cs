namespace SteamNative;

internal struct SetUserItemVoteResult_t
{
	public struct PackSmall
	{
		internal ulong PublishedFileId; //Field offset: 0x0
		internal Result Result; //Field offset: 0x8
		internal bool VoteUp; //Field offset: 0xC

		public static SetUserItemVoteResult_t op_Implicit(PackSmall d) { }

	}

	internal ulong PublishedFileId; //Field offset: 0x0
	internal Result Result; //Field offset: 0x8
	internal bool VoteUp; //Field offset: 0xC

	internal static SetUserItemVoteResult_t FromPointer(IntPtr p) { }

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

