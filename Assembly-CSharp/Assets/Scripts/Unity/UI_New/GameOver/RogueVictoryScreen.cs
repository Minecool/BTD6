namespace Assets.Scripts.Unity.UI_New.GameOver;

public class RogueVictoryScreen : SummaryScreen
{
	[SerializeField]
	private Image scoreIcon; //Field offset: 0x110
	[SerializeField]
	private AudioClip victorySound; //Field offset: 0x118
	[SerializeField]
	private NK_TextMeshProUGUI scoreTxt; //Field offset: 0x120
	[SerializeField]
	private NK_TextMeshProUGUI victoryMessage; //Field offset: 0x128
	[SerializeField]
	private GameObject scoreObj; //Field offset: 0x130
	[SerializeField]
	private GameObject starsObj; //Field offset: 0x138
	[SerializeField]
	private GameObject victoryBanner; //Field offset: 0x140
	[SerializeField]
	private GameObject completeBanner; //Field offset: 0x148
	[SerializeField]
	private GameObject victoryMonkey; //Field offset: 0x150
	[SerializeField]
	private GameObject completeMonkey; //Field offset: 0x158
	[SerializeField]
	private Image artifactBg; //Field offset: 0x160
	[SerializeField]
	private Image bossImg; //Field offset: 0x168
	[SerializeField]
	private GameObject bossRibon; //Field offset: 0x170
	[SerializeField]
	private GameObject artifactObj; //Field offset: 0x178
	[SerializeField]
	private GameObject tokenObj; //Field offset: 0x180
	[SerializeField]
	private SpriteReference leastCashSprite; //Field offset: 0x188
	[SerializeField]
	private Button freeplayBtn; //Field offset: 0x190
	public NK_TextMeshProUGUI timeScoreTxt; //Field offset: 0x198
	public GameObject timeScoreObj; //Field offset: 0x1A0

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueVictoryScreen() { }

	protected virtual void Awake() { }

	private void FreePlayClicked() { }

	protected virtual bool get_IsVictoryScreen() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private RogueLootData GetLootData() { }

	private long GetScore() { }

	private void GiveXp(RogueTileType tileType, RogueLootData lootData) { }

	public virtual void Open(object menuData) { }

	private void SetupUIs(RogueTileType tileType, RogueLootData lootData) { }

	private void UpdateStatsAndAnalytics() { }

}

