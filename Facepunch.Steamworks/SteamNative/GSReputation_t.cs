namespace SteamNative;

internal struct GSReputation_t
{
	public struct PackSmall
	{
		internal Result Result; //Field offset: 0x0
		internal uint ReputationScore; //Field offset: 0x4
		internal bool Banned; //Field offset: 0x8
		internal uint BannedIP; //Field offset: 0xC
		internal ushort BannedPort; //Field offset: 0x10
		internal ulong BannedGameID; //Field offset: 0x14
		internal uint BanExpires; //Field offset: 0x1C

		public static GSReputation_t op_Implicit(PackSmall d) { }

	}

	internal Result Result; //Field offset: 0x0
	internal uint ReputationScore; //Field offset: 0x4
	internal bool Banned; //Field offset: 0x8
	internal uint BannedIP; //Field offset: 0xC
	internal ushort BannedPort; //Field offset: 0x10
	internal ulong BannedGameID; //Field offset: 0x18
	internal uint BanExpires; //Field offset: 0x20

	internal static GSReputation_t FromPointer(IntPtr p) { }

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

