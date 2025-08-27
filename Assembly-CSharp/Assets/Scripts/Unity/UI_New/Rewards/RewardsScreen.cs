namespace Assets.Scripts.Unity.UI_New.Rewards;

public class RewardsScreen : GameMenu
{
	public GenericRewardPanel genericRewardPanel; //Field offset: 0x48
	public InstaRankRewardPanel instaRankRewardPanel; //Field offset: 0x50
	public PowerRewardPanel powerRewardPanel; //Field offset: 0x58
	public InstaMonkeyRewardPanel instaMonkeyRewardPanel; //Field offset: 0x60
	public EventRewardPanel eventRewardPanel; //Field offset: 0x68
	public CollectionRewardPanel collectionRewardPanel; //Field offset: 0x70
	public HeroRewardPanel heroRewardPanel; //Field offset: 0x78
	public GenericRewardPanel mapEditorUnlockRewardPanel; //Field offset: 0x80
	public Button nextBtn; //Field offset: 0x88
	private readonly LootSet lootSet; //Field offset: 0x90
	private BaseRewardPanel activePanel; //Field offset: 0x98
	private int lootIndex; //Field offset: 0xA0

	private BaseRewardPanel[] AllPanels
	{
		private get { } //Length: 612
	}

	public RewardsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__14_0() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void DeInit() { }

	private BaseRewardPanel[] get_AllPanels() { }

	private BaseRewardPanel GetRewardPanel(BaseLoot item) { }

	private void Init() { }

	private void OnRewardPanelClosed() { }

	public virtual void Open(object menuData) { }

	private void ShowNextItem(bool checkForActivePanel) { }

}

