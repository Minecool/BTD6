namespace SteamNative;

internal struct RemoteStorageGetPublishedItemVoteDetailsResult_t
{
	public struct PackSmall
	{
		internal Result Result; //Field offset: 0x0
		internal ulong PublishedFileId; //Field offset: 0x4
		internal int VotesFor; //Field offset: 0xC
		internal int VotesAgainst; //Field offset: 0x10
		internal int Reports; //Field offset: 0x14
		internal float FScore; //Field offset: 0x18

		public static RemoteStorageGetPublishedItemVoteDetailsResult_t op_Implicit(PackSmall d) { }

	}

	internal Result Result; //Field offset: 0x0
	internal ulong PublishedFileId; //Field offset: 0x8
	internal int VotesFor; //Field offset: 0x10
	internal int VotesAgainst; //Field offset: 0x14
	internal int Reports; //Field offset: 0x18
	internal float FScore; //Field offset: 0x1C

	internal static RemoteStorageGetPublishedItemVoteDetailsResult_t FromPointer(IntPtr p) { }

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

