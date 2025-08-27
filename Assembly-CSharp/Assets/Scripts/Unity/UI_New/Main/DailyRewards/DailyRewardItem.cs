namespace Assets.Scripts.Unity.UI_New.Main.DailyRewards;

public class DailyRewardItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public BaseLoot loot; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <Bind>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	public TMP_Text date; //Field offset: 0x20
	public GameObject active; //Field offset: 0x28
	public Transform container; //Field offset: 0x30
	private DailyRewardsScreen dailyRewardsScreen; //Field offset: 0x38
	private BaseLoot loot; //Field offset: 0x40
	public Animator tickAnimator; //Field offset: 0x48

	public DailyRewardItem() { }

	public void Bind(DailyRewardsScreen dailyRewardsScreen, BaseLoot loot, int todayIndex, int offsetIndex, bool claim) { }

	public void ShowInfoClicked() { }

}

