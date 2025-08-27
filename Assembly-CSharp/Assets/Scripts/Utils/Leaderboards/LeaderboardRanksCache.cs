namespace Assets.Scripts.Utils.Leaderboards;

public class LeaderboardRanksCache
{
	public readonly string id; //Field offset: 0x10
	public readonly RankModel[] ranks; //Field offset: 0x18
	public readonly TimeSpan creationTime; //Field offset: 0x20

	public LeaderboardRanksCache(string id, RankModel[] ranks, TimeSpan creationTime) { }

	public bool IsValid(string id, TimeSpan now, TimeSpan cacheLife) { }

}

