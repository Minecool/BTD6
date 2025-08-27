namespace Assets.Scripts.Models.ServerEvents;

public class BossRewards
{
	public Dictionary<String, LeaderboardReward[]> leaderboard; //Field offset: 0x10
	public Dictionary<String, LeaderboardReward[]> leaderboardElite; //Field offset: 0x18
	public Dictionary<String, LeaderboardReward[]> miniLeaderboard; //Field offset: 0x20
	public Dictionary<String, LeaderboardReward[]> miniEliteLeaderboard; //Field offset: 0x28
	public Dictionary<String, String[]> tiers; //Field offset: 0x30

	public BossRewards() { }

}

