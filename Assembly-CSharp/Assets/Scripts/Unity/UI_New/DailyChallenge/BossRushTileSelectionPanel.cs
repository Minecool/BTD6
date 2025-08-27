namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushTileSelectionPanel : MonoBehaviour
{
	[SerializeField]
	private Image mapImage; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI titleTxt; //Field offset: 0x28
	[SerializeField]
	private Button playBtn; //Field offset: 0x30
	[SerializeField]
	private Button replayBtn; //Field offset: 0x38
	[SerializeField]
	private HoverableInfoPopup playBtnHoverableInfoPopup; //Field offset: 0x40
	[SerializeField]
	private Image playBtnDisabledImage; //Field offset: 0x48
	[SerializeField]
	private GameObject completedBannerObj; //Field offset: 0x50
	[SerializeField]
	private GameObject lockedBossIconObj; //Field offset: 0x58
	[SerializeField]
	private Image bossIconImg; //Field offset: 0x60
	[SerializeField]
	private GameObject bossIconObj; //Field offset: 0x68
	[SerializeField]
	private GameObject scoresObj; //Field offset: 0x70
	[SerializeField]
	private GameObject rewardsObj; //Field offset: 0x78
	[SerializeField]
	private BossRushScoreDisplay scoreDisplayTemplate; //Field offset: 0x80
	[SerializeField]
	private Transform scoreDisplaysContainer; //Field offset: 0x88
	[SerializeField]
	private GameObject scoreSlotsTimerContainer; //Field offset: 0x90
	[SerializeField]
	private NK_TextMeshProUGUI scoreSlotsTimerText; //Field offset: 0x98
	[SerializeField]
	private LootPanel rewardsPanel; //Field offset: 0xA0
	public AudioClip openSound; //Field offset: 0xA8
	private readonly List<BossRushScoreDisplay> activeScoreDisplays; //Field offset: 0xB0
	private int currentTileIndex; //Field offset: 0xB8
	private BossRushEvent bossRushEvent; //Field offset: 0xC0
	private TileCompletionState tileCompletionState; //Field offset: 0xC8
	private BossRushTileRules tileRules; //Field offset: 0xD0
	private List<Int32> scores; //Field offset: 0xD8
	private int currentScore; //Field offset: 0xE0
	private Nullable<UInt64> latestTeamScoreId; //Field offset: 0xE8
	private Nullable<DateTime> nextScoreSlotRefreshTime; //Field offset: 0xF8

	public BossRushTileSelectionPanel() { }

	private void Awake() { }

	private void EnsureNumberOfScoreDisplays(int dailyScoreSlots) { }

	private Nullable<DateTime> GetScoreSlotRefilTime(TileCompletionState tileCompletionState) { }

	private void OpenPlayMenu() { }

	public void SetInfo(BossRushTileRules tileRules, TileCompletionState tileCompletionState, List<Int32> scores, int currentTileIndex, BossRushEvent bossRushEvent, int currentScore, Nullable<UInt64> latestTeamScoreId) { }

	private void SetPlayButton(TileCompletionState tileCompletionState, BossRushEvent bossRushEvent) { }

	private void Update() { }

}

