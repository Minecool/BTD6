namespace Assets.Scripts.Utils.Leaderboards;

public class LeaderboardScoreCache
{
	public string id; //Field offset: 0x10
	public IEnumerable<ScoreModel> scores; //Field offset: 0x18
	public TimeSpan creationTime; //Field offset: 0x20
	public bool isHighPriority; //Field offset: 0x28
	public int maxScores; //Field offset: 0x2C

	public LeaderboardScoreCache(string id, IEnumerable<ScoreModel> scores, TimeSpan creationTime) { }

	[JsonConstructor]
	public LeaderboardScoreCache(string id, IEnumerable<ScoreModel> scores, bool isHighPriority, int maxScores, TimeSpan creationTime) { }

	public bool IsValid(string id, TimeSpan now, TimeSpan cacheLife) { }

	public bool IsValid(string id, bool isHighPriority, int maxScores, TimeSpan now, TimeSpan cacheLife) { }

}

