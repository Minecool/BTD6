namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class RogueCampaignSummaryScreen : MonoBehaviour
{
	[SerializeField]
	private NK_TextMeshProUGUI stageBannerTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI xpAmountTxt; //Field offset: 0x28
	[SerializeField]
	private GameObject xpAmountObj; //Field offset: 0x30
	[SerializeField]
	private GameObject defeatBanner; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI defeatTxt; //Field offset: 0x40
	[SerializeField]
	private GameObject completeObj; //Field offset: 0x48
	[SerializeField]
	private GameObject stageVictoryBanner; //Field offset: 0x50
	[SerializeField]
	private GameObject campaignVictoryBanner; //Field offset: 0x58
	[SerializeField]
	private GameObject currentStatsContainer; //Field offset: 0x60
	[SerializeField]
	private GameObject totalStatsContainer; //Field offset: 0x68
	[SerializeField]
	private Animator animator; //Field offset: 0x70
	[SerializeField]
	private Button nextStageBtn; //Field offset: 0x78
	[SerializeField]
	private Button homeBtn; //Field offset: 0x80
	private bool isDefeated; //Field offset: 0x88
	private RogueMapScreen rogueMapScreen; //Field offset: 0x90
	private GameObject statPrefab; //Field offset: 0x98
	private List<LegendsStatUI> currentStats; //Field offset: 0xA0
	private List<LegendsStatUI> totalStats; //Field offset: 0xA8

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueCampaignSummaryScreen() { }

	private void Awake() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private void HomeClicked() { }

	private void NextStageClicked() { }

	public void OpenCampaignVictory() { }

	public void OpenDefeat() { }

	public void OpenStageVictory(int stageNumber) { }

	private void SetupStatPrefabs() { }

	private void SetupStatValues() { }

}

