namespace Assets.Scripts.Unity.UI_New;

public class LeaderboardRewardsScreen : GameMenu
{
	public LeaderboardRewardsPanel rewardsPanel; //Field offset: 0x48
	public LeaderboardRewardsPanel eliteRewardsPanel; //Field offset: 0x50
	private LeaderboardRewardsScreenData menuData; //Field offset: 0x58

	public LeaderboardRewardsScreen() { }

	public virtual void Open(object data) { }

}

