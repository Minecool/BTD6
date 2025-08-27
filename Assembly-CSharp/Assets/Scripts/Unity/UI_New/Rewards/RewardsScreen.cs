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
	public TrophyStoreRewardPanel trophyStoreItemRewardPanel; //Field offset: 0x80
	public GenericRewardPanel mapEditorUnlockRewardPanel; //Field offset: 0x88
	public GameObject controlsObject; //Field offset: 0x90
	public Button nextBtn; //Field offset: 0x98
	public Button skipBtn; //Field offset: 0xA0
	public GameObject summaryScreen; //Field offset: 0xA8
	public LootPanel summaryScreenLootPanel; //Field offset: 0xB0
	public Button summaryOkButton; //Field offset: 0xB8
	public AudioClip clickSound; //Field offset: 0xC0
	public float timeBetweenRevealingAllLoot; //Field offset: 0xC8
	private readonly LootSet lootSet; //Field offset: 0xD0
	private BaseRewardPanel activePanel; //Field offset: 0xD8
	private int lootIndex; //Field offset: 0xE0
	private int currentAnimationIndex; //Field offset: 0xE4
	private Dictionary<Type, BaseRewardPanel> rewardPanelsByType; //Field offset: 0xE8
	private bool IsSkipped; //Field offset: 0xF0
	private bool IsCurrentlyAnimatingAllLoot; //Field offset: 0xF1
	private float lastLootAnimatedAt; //Field offset: 0xF4
	private HashSet<BaseRewardPanel> uniqueRewardPanels; //Field offset: 0xF8

	public RewardsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__26_0() { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	private void DeInit() { }

	private BaseRewardPanel GetRewardPanel(T item) { }

	private void Init() { }

	private void OnNextButton() { }

	private void OnRewardPanelClosed() { }

	private void OnSkipButton() { }

	public virtual void Open(object menuData) { }

	public virtual bool OverrideClose() { }

	private void ShowNextItem(bool checkForActivePanel) { }

	private void Update() { }

	private void UpdateAllLootPanel(float updateToTime) { }

}

