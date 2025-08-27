namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushStageCompletePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public String[] nextTowers; //Field offset: 0x10
		public ContestedTerritoryRelicType[] defeatedBossRelics; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal bool <DisplayStageComplete>b__0(string x) { }

		internal bool <DisplayStageComplete>b__1(ContestedTerritoryRelicType x) { }

	}

	[SerializeField]
	private BossRushStagePanelDisplay[] stages; //Field offset: 0x20
	[SerializeField]
	private Button okButton; //Field offset: 0x28
	[SerializeField]
	private Lightbox bgCloseButton; //Field offset: 0x30
	[SerializeField]
	private TextMeshProUGUI titleTxt; //Field offset: 0x38
	[SerializeField]
	private LootPanel rewardsPanel; //Field offset: 0x40
	[SerializeField]
	private GameObject towersRelicsContainer; //Field offset: 0x48
	[SerializeField]
	private Transform lostTowersContainer; //Field offset: 0x50
	[SerializeField]
	private TowerImageLoader lostTowersTemplate; //Field offset: 0x58
	[SerializeField]
	private Transform gainedRelicsContainer; //Field offset: 0x60
	[SerializeField]
	private BossRushRelicDisplay gainedRelicsTemplate; //Field offset: 0x68
	[SerializeField]
	private GameObject relicInfoObj; //Field offset: 0x70
	[SerializeField]
	private GameObject relicInfoPointerObj; //Field offset: 0x78
	[SerializeField]
	private NK_TextMeshProUGUI relicTitleTxt; //Field offset: 0x80
	[SerializeField]
	private NK_TextMeshProUGUI relicDescriptionTxt; //Field offset: 0x88
	[SerializeField]
	private GameObject eventCompletedFlair; //Field offset: 0x90
	private readonly List<GameObject> lostTowerDisplays; //Field offset: 0x98
	private readonly List<GameObject> gainedRelicDisplays; //Field offset: 0xA0
	private LootSet loot; //Field offset: 0xA8
	private TaskCompletionSource<Boolean> panelCompletedTcs; //Field offset: 0xB0

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	public BossRushStageCompletePanel() { }

	private void Awake() { }

	private void DisplayStageComplete(BossRushTileRules rules, BossRushSettings settings, int defeatedBossIndex, BossRushEvent bossRushEvent) { }

	private LocalizationManager get_Locs() { }

	private void NextClicked() { }

	private void NextStage() { }

	private void RelicHovered(ContestedTerritoryRelicType relicType, bool exit, float position) { }

	public Task ShowAndClaimRewards(BossRushTileRules rules, BossRushSettings settings, int defeatedBossIndex, BossRushEvent bossRushEvent) { }

}

