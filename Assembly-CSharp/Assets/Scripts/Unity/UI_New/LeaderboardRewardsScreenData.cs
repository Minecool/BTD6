namespace Assets.Scripts.Unity.UI_New;

public class LeaderboardRewardsScreenData
{
	public readonly LeaderboardScreenData leaderboardMenuData; //Field offset: 0x10
	public readonly List<LeaderboardData> leaderboards; //Field offset: 0x18

	public LeaderboardRewardsScreenData(LeaderboardScreenData leaderboardMenuData, List<LeaderboardData> leaderboards) { }

}

