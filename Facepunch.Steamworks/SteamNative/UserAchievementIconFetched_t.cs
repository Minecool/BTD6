namespace SteamNative;

internal struct UserAchievementIconFetched_t
{
	public struct PackSmall
	{
		internal ulong GameID; //Field offset: 0x0
		internal string AchievementName; //Field offset: 0x8
		internal bool Achieved; //Field offset: 0x10
		internal int IconHandle; //Field offset: 0x14

		public static UserAchievementIconFetched_t op_Implicit(PackSmall d) { }

	}

	internal ulong GameID; //Field offset: 0x0
	internal string AchievementName; //Field offset: 0x8
	internal bool Achieved; //Field offset: 0x10
	internal int IconHandle; //Field offset: 0x14

	internal static UserAchievementIconFetched_t FromPointer(IntPtr p) { }

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

