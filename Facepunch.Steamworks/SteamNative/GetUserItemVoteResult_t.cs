namespace SteamNative;

internal struct GetUserItemVoteResult_t
{
	public struct PackSmall
	{
		internal ulong PublishedFileId; //Field offset: 0x0
		internal Result Result; //Field offset: 0x8
		internal bool VotedUp; //Field offset: 0xC
		internal bool VotedDown; //Field offset: 0xD
		internal bool VoteSkipped; //Field offset: 0xE

		public static GetUserItemVoteResult_t op_Implicit(PackSmall d) { }

	}

	internal ulong PublishedFileId; //Field offset: 0x0
	internal Result Result; //Field offset: 0x8
	internal bool VotedUp; //Field offset: 0xC
	internal bool VotedDown; //Field offset: 0xD
	internal bool VoteSkipped; //Field offset: 0xE

	internal static GetUserItemVoteResult_t FromPointer(IntPtr p) { }

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

