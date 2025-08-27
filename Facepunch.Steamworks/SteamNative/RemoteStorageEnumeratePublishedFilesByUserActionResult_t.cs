namespace SteamNative;

internal struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
{
	public struct PackSmall
	{
		internal Result Result; //Field offset: 0x0
		internal WorkshopFileAction Action; //Field offset: 0x4
		internal int ResultsReturned; //Field offset: 0x8
		internal int TotalResultCount; //Field offset: 0xC
		internal UInt64[] GPublishedFileId; //Field offset: 0x10
		internal UInt32[] GRTimeUpdated; //Field offset: 0x18

		public static RemoteStorageEnumeratePublishedFilesByUserActionResult_t op_Implicit(PackSmall d) { }

	}

	internal Result Result; //Field offset: 0x0
	internal WorkshopFileAction Action; //Field offset: 0x4
	internal int ResultsReturned; //Field offset: 0x8
	internal int TotalResultCount; //Field offset: 0xC
	internal UInt64[] GPublishedFileId; //Field offset: 0x10
	internal UInt32[] GRTimeUpdated; //Field offset: 0x18

	internal static RemoteStorageEnumeratePublishedFilesByUserActionResult_t FromPointer(IntPtr p) { }

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

