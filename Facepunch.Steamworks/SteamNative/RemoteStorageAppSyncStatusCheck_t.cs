namespace SteamNative;

internal struct RemoteStorageAppSyncStatusCheck_t
{
	public struct PackSmall
	{
		internal uint AppID; //Field offset: 0x0
		internal Result Result; //Field offset: 0x4

		public static RemoteStorageAppSyncStatusCheck_t op_Implicit(PackSmall d) { }

	}

	internal uint AppID; //Field offset: 0x0
	internal Result Result; //Field offset: 0x4

	internal static RemoteStorageAppSyncStatusCheck_t FromPointer(IntPtr p) { }

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

