namespace Assets.Scripts.Models.ServerEvents;

public class GameEvents
{
	internal class RoundsContainer
	{
		public List<RoundInfo> rounds; //Field offset: 0x10
		public float scale; //Field offset: 0x18

		public RoundsContainer() { }

	}

	public String[] dailyRewards; //Field offset: 0x10
	public DailyChallenges dailyChallenges; //Field offset: 0x18
	public Races races; //Field offset: 0x20
	public Collection collection; //Field offset: 0x28
	public Dictionary<String, RoundsContainer> roundSets; //Field offset: 0x30
	public GoldenBloon goldenBloon; //Field offset: 0x38
	public MonkeyTeams monkeyTeams; //Field offset: 0x40
	public BossSettings bosses; //Field offset: 0x48
	public QuestSettings quests; //Field offset: 0x50
	public ContestedTerritorySettings contestedTerritory; //Field offset: 0x58
	public OdysseySettings odyssey; //Field offset: 0x60
	public BossRushSkuSettings bossRush; //Field offset: 0x68
	public string general; //Field offset: 0x70
	public GameEventFrequency frequency; //Field offset: 0x78

	public GameEvents() { }

	public string GetDailyReward(int dayIndex) { }

	public static bool IsValidLoot(string loot, Btd6Player player) { }

	public void ValidateDailyRewards(Btd6Player player) { }

}

