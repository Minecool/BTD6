namespace Assets.Scripts.Utils.Leaderboards;

public class LeaderboardRankCache
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string leaderboardId; //Field offset: 0x10
		public LeaderboardRankCache <>4__this; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal bool <ClearCache>b__0(LeaderboardRankCacheModel x) { }

	}

	private class LeaderboardRankCacheModel
	{
		public string id; //Field offset: 0x10
		public RankModel rankModel; //Field offset: 0x18
		public TimeSpan creationTime; //Field offset: 0x20

		public LeaderboardRankCacheModel(string id, RankModel rankModel, TimeSpan creationTime) { }

	}

	private readonly List<LeaderboardRankCacheModel> leaderboardRankCaches; //Field offset: 0x10

	private TimeSpan CacheLife
	{
		private get { } //Length: 159
	}

	private TimeSpan Now
	{
		private get { } //Length: 91
	}

	public LeaderboardRankCache() { }

	[CompilerGenerated]
	private bool <Get>b__5_0(LeaderboardRankCacheModel x) { }

	public void ClearCache(string leaderboardId) { }

	public RankModel Get(string id) { }

	private TimeSpan get_CacheLife() { }

	private TimeSpan get_Now() { }

	private bool HasExpired(LeaderboardRankCacheModel rankCacheModel) { }

	public void Set(string id, RankModel rankModel) { }

}

