namespace SteamNative;

internal struct LeaderboardScoreUploaded_t
{
	public struct PackSmall
	{
		internal byte Success; //Field offset: 0x0
		internal ulong SteamLeaderboard; //Field offset: 0x4
		internal int Score; //Field offset: 0xC
		internal byte ScoreChanged; //Field offset: 0x10
		internal int GlobalRankNew; //Field offset: 0x14
		internal int GlobalRankPrevious; //Field offset: 0x18

		public static LeaderboardScoreUploaded_t op_Implicit(PackSmall d) { }

	}

	internal byte Success; //Field offset: 0x0
	internal ulong SteamLeaderboard; //Field offset: 0x8
	internal int Score; //Field offset: 0x10
	internal byte ScoreChanged; //Field offset: 0x14
	internal int GlobalRankNew; //Field offset: 0x18
	internal int GlobalRankPrevious; //Field offset: 0x1C

	internal static LeaderboardScoreUploaded_t FromPointer(IntPtr p) { }

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

