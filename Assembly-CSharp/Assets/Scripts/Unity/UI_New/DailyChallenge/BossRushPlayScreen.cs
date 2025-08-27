namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushPlayScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerData, Boolean> <>9__49_0; //Field offset: 0x8
		public static Func<TowerDetailsModel, String> <>9__49_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Open>b__49_0(TowerData x) { }

		internal string <Open>b__49_1(TowerDetailsModel towerDetailsModel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public String[] bannedHeroes; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <Open>b__2(string heroId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public Btd6Player player; //Field offset: 0x10
		public int purchaseTicketCost; //Field offset: 0x18
		public BossRushPlayScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass58_0() { }

		internal void <BuyTicketAndStartGame>b__0() { }

		internal void <BuyTicketAndStartGame>b__1() { }

	}

	[SerializeField]
	private Button playBtn; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI playBtnTicketsTxt; //Field offset: 0x50
	[SerializeField]
	private Button buyAndPlayBtn; //Field offset: 0x58
	[SerializeField]
	private GameObject ticketsCountdownObj; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI ticketRefilTimerText; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI buyBtnCostTxt; //Field offset: 0x70
	[SerializeField]
	private Button bgBackBtn; //Field offset: 0x78
	[SerializeField]
	private Image mapImage; //Field offset: 0x80
	[SerializeField]
	private Image bossIcon; //Field offset: 0x88
	[SerializeField]
	private TextMeshProUGUI bossNameTitleTxt; //Field offset: 0x90
	[SerializeField]
	private DCTowerRulesPanel towerRulesPanel; //Field offset: 0x98
	[SerializeField]
	private TextMeshProUGUI mapNameTxt; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI startingCashTxt; //Field offset: 0xA8
	[SerializeField]
	private TextMeshProUGUI startingHealthTxt; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI startingRevivesTxt; //Field offset: 0xB8
	[SerializeField]
	private TextMeshProUGUI maxTowersTxt; //Field offset: 0xC0
	[SerializeField]
	private BossRushRelicDisplay relicDisplayTemplate; //Field offset: 0xC8
	[SerializeField]
	private Transform relicsContainer; //Field offset: 0xD0
	[SerializeField]
	private GameObject relicInfoObj; //Field offset: 0xD8
	[SerializeField]
	private GameObject relicInfoPointerObj; //Field offset: 0xE0
	[SerializeField]
	private NK_TextMeshProUGUI relicTitleTxt; //Field offset: 0xE8
	[SerializeField]
	private NK_TextMeshProUGUI relicDescriptionTxt; //Field offset: 0xF0
	[SerializeField]
	private BossRushScoreDisplay scoreDisplayTemplate; //Field offset: 0xF8
	[SerializeField]
	private Transform scoreDisplaysContainer; //Field offset: 0x100
	[SerializeField]
	private NK_TextMeshProUGUI scoreSubmissionsAmountTxt; //Field offset: 0x108
	[SerializeField]
	private NK_TextMeshProUGUI totalScoreTxt; //Field offset: 0x110
	[SerializeField]
	private GameObject scoresLockedObj; //Field offset: 0x118
	[SerializeField]
	private LootPanel rewardsPanel; //Field offset: 0x120
	[SerializeField]
	private GameObject rewardsClaimedObj; //Field offset: 0x128
	[SerializeField]
	private NK_TextMeshProUGUI healthBarTxt; //Field offset: 0x130
	[SerializeField]
	private Image healthBarImg; //Field offset: 0x138
	private bool isInitialized; //Field offset: 0x140
	private readonly List<BossRushScoreDisplay> activeScoreDisplays; //Field offset: 0x148
	private BossType bossType; //Field offset: 0x150
	private int availableTickets; //Field offset: 0x154
	private Nullable<DateTime> nextTicketRefilTime; //Field offset: 0x158
	private DailyChallengeModel tileDCM; //Field offset: 0x168
	private BossRushPlayScreenData screenData; //Field offset: 0x170

	private BossRushEvent BossRushEvent
	{
		private get { } //Length: 30
	}

	private BossRushSettings BossRushSettings
	{
		private get { } //Length: 73
	}

	private int CurrentTile
	{
		private get { } //Length: 29
	}

	private List<Int32> PlayerScores
	{
		private get { } //Length: 114
	}

	private BossRushTileRules TileRules
	{
		private get { } //Length: 30
	}

	public BossRushPlayScreen() { }

	[CompilerGenerated]
	private void <Awake>b__48_0() { }

	protected virtual void Awake() { }

	private void BackgroundClicked() { }

	private void ButtonsInteractable(bool isInteractable) { }

	public void BuyTicketAndStartGame() { }

	private DailyChallengeModel CreateTileDCM() { }

	private void DisplayRelics() { }

	private void EnsureNumberOfScoreDisplays(int dailyScoreSlots) { }

	private BossRushEvent get_BossRushEvent() { }

	private BossRushSettings get_BossRushSettings() { }

	private int get_CurrentTile() { }

	private List<Int32> get_PlayerScores() { }

	private BossRushTileRules get_TileRules() { }

	private ValueTuple<Int32, Nullable`1<DateTime>> GetTicketStatus() { }

	public virtual void Open(object data) { }

	private void RelicHovered(ContestedTerritoryRelicType relicType, bool exit, float position) { }

	private void SetupPlayButtons() { }

	private void StartGame(int purchaseTicketCost) { }

	private void Update() { }

	private void UpdateTicketStatus() { }

}

