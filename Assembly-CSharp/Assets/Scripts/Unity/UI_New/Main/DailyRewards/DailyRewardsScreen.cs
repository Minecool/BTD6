namespace Assets.Scripts.Unity.UI_New.Main.DailyRewards;

public class DailyRewardsScreen : GameMenu
{
	public DailyRewardItem todayItemPrefab; //Field offset: 0x48
	public DailyRewardItem itemPrefab; //Field offset: 0x50
	public Transform lootContainer; //Field offset: 0x58
	public TMP_Text rewardInfo; //Field offset: 0x60

	public DailyRewardsScreen() { }

	public void BackClicked() { }

	public virtual void Open(object menuData) { }

}

