namespace SteamNative;

internal struct RemoteStorageGetPublishedFileDetailsResult_t
{
	public struct PackSmall
	{
		internal Result Result; //Field offset: 0x0
		internal ulong PublishedFileId; //Field offset: 0x8
		internal uint CreatorAppID; //Field offset: 0x10
		internal uint ConsumerAppID; //Field offset: 0x14
		internal string Title; //Field offset: 0x18
		internal string Description; //Field offset: 0x20
		internal ulong File; //Field offset: 0x28
		internal ulong PreviewFile; //Field offset: 0x30
		internal ulong SteamIDOwner; //Field offset: 0x38
		internal uint TimeCreated; //Field offset: 0x40
		internal uint TimeUpdated; //Field offset: 0x44
		internal RemoteStoragePublishedFileVisibility Visibility; //Field offset: 0x48
		internal bool Banned; //Field offset: 0x4C
		internal string Tags; //Field offset: 0x50
		internal bool TagsTruncated; //Field offset: 0x58
		internal string PchFileName; //Field offset: 0x60
		internal int FileSize; //Field offset: 0x68
		internal int PreviewFileSize; //Field offset: 0x6C
		internal string URL; //Field offset: 0x70
		internal WorkshopFileType FileType; //Field offset: 0x78
		internal bool AcceptedForUse; //Field offset: 0x7C

		public static RemoteStorageGetPublishedFileDetailsResult_t op_Implicit(PackSmall d) { }

	}

	internal Result Result; //Field offset: 0x0
	internal ulong PublishedFileId; //Field offset: 0x8
	internal uint CreatorAppID; //Field offset: 0x10
	internal uint ConsumerAppID; //Field offset: 0x14
	internal string Title; //Field offset: 0x18
	internal string Description; //Field offset: 0x20
	internal ulong File; //Field offset: 0x28
	internal ulong PreviewFile; //Field offset: 0x30
	internal ulong SteamIDOwner; //Field offset: 0x38
	internal uint TimeCreated; //Field offset: 0x40
	internal uint TimeUpdated; //Field offset: 0x44
	internal RemoteStoragePublishedFileVisibility Visibility; //Field offset: 0x48
	internal bool Banned; //Field offset: 0x4C
	internal string Tags; //Field offset: 0x50
	internal bool TagsTruncated; //Field offset: 0x58
	internal string PchFileName; //Field offset: 0x60
	internal int FileSize; //Field offset: 0x68
	internal int PreviewFileSize; //Field offset: 0x6C
	internal string URL; //Field offset: 0x70
	internal WorkshopFileType FileType; //Field offset: 0x78
	internal bool AcceptedForUse; //Field offset: 0x7C

	internal static RemoteStorageGetPublishedFileDetailsResult_t FromPointer(IntPtr p) { }

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

