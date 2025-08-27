namespace Assets.Scripts.Models.Profile;

public class BossEventData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<BossLeaderboardStanding> <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <HasPendingLeaderboardRewards>b__7_0(BossLeaderboardStanding s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public BossLeaderboardType leaderboardType; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetStanding>b__0(BossLeaderboardStanding x) { }

	}

	public string eventId; //Field offset: 0x10
	public BossModeData normal; //Field offset: 0x18
	public BossModeData elite; //Field offset: 0x20
	public List<BossLeaderboardStanding> leaderboardStandings; //Field offset: 0x28
	public bool hasClaimedRewards; //Field offset: 0x30

	public BossEventData() { }

	public long GetScore(BossLeaderboardType leaderboardType) { }

	private BossLeaderboardStanding GetStanding(BossLeaderboardType leaderboardType) { }

	public string GetTeamId(BossLeaderboardType leaderboardType) { }

	public bool HasPendingLeaderboardRewards() { }

	public void SetBestTime(BossLeaderboardType leaderboardType, long score, string teamId) { }

}

