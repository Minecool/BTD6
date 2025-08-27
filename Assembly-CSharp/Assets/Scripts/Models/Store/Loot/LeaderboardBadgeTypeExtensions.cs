namespace Assets.Scripts.Models.Store.Loot;

[Extension]
public static class LeaderboardBadgeTypeExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LeaderboardBadgeType, Boolean> <>9__0_0; //Field offset: 0x8
		public static Func<LeaderboardBadgeType, Int32> <>9__0_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetSortedBadges>b__0_0(LeaderboardBadgeType badge) { }

		internal int <GetSortedBadges>b__0_1(LeaderboardBadgeType badge) { }

	}


	public static IEnumerable<LeaderboardBadgeType> GetSortedBadges() { }

	[Extension]
	public static int ToSortedInt(LeaderboardBadgeType badgeType) { }

	[Extension]
	public static LeaderboardBadgeType ToSortedLeaderboardBadgeType(int badgeInt) { }

}

