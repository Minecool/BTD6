namespace Assets.Scripts.Unity.CollectionEvent;

public class CollectionEventRewardsUI : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public CollectionEventRewardsUI <>4__this; //Field offset: 0x10
		public CollectionEventRewardsContainer container; //Field offset: 0x18
		public int index; //Field offset: 0x20

		public <>c__DisplayClass16_0() { }

		internal void <OnCardClicked>b__0() { }

	}

	public GameObject[] boxGameObjects; //Field offset: 0x48
	public CollectionEventRewardsContainer eventRewards2; //Field offset: 0x50
	public CollectionEventRewardsContainer eventRewards3; //Field offset: 0x58
	public GameObject clickArea; //Field offset: 0x60
	public Button continueButton; //Field offset: 0x68
	public GameObject[] unrevealedCardGameObjects; //Field offset: 0x70
	public AudioClip returnSound; //Field offset: 0x78
	private CollectionEventDataHelper helper; //Field offset: 0x80
	private List<LootSet> lootSets; //Field offset: 0x88
	private CollectionEventRewardsContainer activeEventRewards; //Field offset: 0x90

	public CollectionEventRewardsUI() { }

	[CompilerGenerated]
	private void <Open>b__10_0() { }

	private void CheckForAllRewardsCollected() { }

	public virtual void Close() { }

	private void GamepadSelectFirst() { }

	public void OnCardClicked(CollectionEventRewardsContainer container, int index) { }

	public void OnCrateOpenAnimFinished() { }

	public void OnCursorDown() { }

	public virtual void Open(object data) { }

	public virtual void ReOpen(object data) { }

	private void ShowCardArt(CollectionEventRewardsContainer container, int index) { }

}

