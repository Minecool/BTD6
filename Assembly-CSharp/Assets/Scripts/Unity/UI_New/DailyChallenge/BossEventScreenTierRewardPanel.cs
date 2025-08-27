namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossEventScreenTierRewardPanel : MonoBehaviour
{
	public GameObject defaultBg; //Field offset: 0x20
	public GameObject completedBg; //Field offset: 0x28
	public TMP_Text tierTitleTxt; //Field offset: 0x30
	public LootPanel lootPanel; //Field offset: 0x38

	public BossEventScreenTierRewardPanel() { }

	public void Setup(int bossTier, bool eliteMode) { }

}

