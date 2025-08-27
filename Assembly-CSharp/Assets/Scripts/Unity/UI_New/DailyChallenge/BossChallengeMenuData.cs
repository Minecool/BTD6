namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossChallengeMenuData
{
	public BossType boss; //Field offset: 0x10
	public string map; //Field offset: 0x18
	public bool isRanked; //Field offset: 0x20
	public bool isElite; //Field offset: 0x21
	public LeaderboardScoringType scoringType; //Field offset: 0x24

	public BossChallengeMenuData(BossType boss, string map, bool isRanked, bool isElite, LeaderboardScoringType scoringType) { }

}

