namespace Assets.Scripts.Unity.UI_New.Races;

public class LeaderboardRewardPanel : MonoBehaviour
{
	public GameObject goldBackground; //Field offset: 0x20
	public GameObject glowBackground; //Field offset: 0x28
	public NK_TextMeshProUGUI tierText; //Field offset: 0x30
	public float tierTextGlobalOffsetY; //Field offset: 0x38
	public float tierTextMiniOffsetY; //Field offset: 0x3C
	public Image badgeImg; //Field offset: 0x40
	private LeaderboardReward leaderboardReward; //Field offset: 0x48

	public LeaderboardRewardPanel() { }

	public void Initialise(LeaderboardReward leaderboardReward, bool isPerc, float position, bool hideBadges, SpriteReference[] medalSprites, BadgePlacingType badgePlacingType) { }

	public void PopulateLootContainer(LootSet lootSet) { }

	public void SetBackgroundColor(LeaderboardReward currentRewards) { }

}

