namespace Assets.Scripts.Models.ServerEvents;

public class BossSettings
{
	public const string defaultRewardsKey = "default"; //Field offset: 0x0
	public BossRewards rewards; //Field offset: 0x10
	public Int32[] checkpointCosts; //Field offset: 0x18
	public Int32[] challengeCheckpointCosts; //Field offset: 0x20
	public int miniLeaderboardPlayers; //Field offset: 0x28
	public Dictionary<Int32, Single> coopHealthMultipliers; //Field offset: 0x30
	public bool canPlayEvents; //Field offset: 0x38
	public bool canPlayChallenge; //Field offset: 0x39

	public BossSettings() { }

	public LeaderboardReward[][] GetAllLeaderboardRewards(BossEvent bossEvent) { }

	public LeaderboardReward[] GetLeaderboardRewards(BossEvent bossEvent, bool isMini, bool isElite) { }

	public LootSet GetTierRewards(BossEvent bossEvent, BossDataModel bossData, int bossTier, bool isElite) { }

	private String[] GetTiersRewards(BossEvent bossEvent) { }

}

