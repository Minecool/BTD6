namespace Assets.Scripts.Unity.UI_New;

public class LeaderboardRewardsPanel : MonoBehaviour
{
	public NK_TextMeshProUGUI titleTxt; //Field offset: 0x20
	public Toggle mainLeaderboardTog; //Field offset: 0x28
	public Toggle miniLeaderboardTog; //Field offset: 0x30
	public NK_TextMeshProUGUI mainLeaderboardTxt; //Field offset: 0x38
	public NK_TextMeshProUGUI miniLeaderboardTxt; //Field offset: 0x40
	public List<LeaderboardRewardPanel> rewardPanels; //Field offset: 0x48
	private LeaderboardRewardsScreenData menuData; //Field offset: 0x50
	private PlayerLeaderboardPlacing playerPlacing; //Field offset: 0x58
	private bool isElite; //Field offset: 0x60

	private LeaderboardType LeaderboardScreenType
	{
		private get { } //Length: 35
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public LeaderboardRewardsPanel() { }

	private LeaderboardType get_LeaderboardScreenType() { }

	private LocalizationManager get_Locs() { }

	private string GetMainTogLoc() { }

	private string GetMiniTogLoc() { }

	private LeaderboardReward[] GetRewards(bool isMini, bool isElite) { }

	public void Initialize(LeaderboardRewardsScreenData menuData, bool isElite) { }

	private void LeaderboardToggled(bool isMiniSelected) { }

	private void UpdateDisplayedRewards(bool isMiniSelected) { }

	public void UpdatePlayerGoldBorder(LeaderboardReward[] leaderboardRewards, bool isMiniSelected) { }

}

