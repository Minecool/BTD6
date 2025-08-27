namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyCompletedPopup : OdysseyPopup
{
	public NK_TextMeshProUGUI txtOdysseyTitle; //Field offset: 0x48
	public LootPanel lootPanel; //Field offset: 0x50
	public Button btnCollect; //Field offset: 0x58
	public AudioClip victorySound; //Field offset: 0x60
	public Animator sceneAnimator; //Field offset: 0x68
	public Toggle userChalLikeTgl; //Field offset: 0x70
	public Toggle userChalFavTgl; //Field offset: 0x78
	public GameObject likeTglEnabledBg; //Field offset: 0x80
	public NK_TextMeshProUGUI ratingCountTxt; //Field offset: 0x88
	public LootSet lootSetToCollect; //Field offset: 0x90
	public GameObject claimedLootPanel; //Field offset: 0x98
	public Button btnNextPanel; //Field offset: 0xA0
	public NK_TextMeshProUGUI txtStatTimeTaken; //Field offset: 0xA8
	public NK_TextMeshProUGUI txtStatLivesRemaining; //Field offset: 0xB0
	public NK_TextMeshProUGUI txtStatPopCount; //Field offset: 0xB8
	public NK_TextMeshProUGUI txtStatCashGenerated; //Field offset: 0xC0
	public NK_TextMeshProUGUI txtStatMoabsPopped; //Field offset: 0xC8
	public NK_TextMeshProUGUI txtStatAbilitiesUsed; //Field offset: 0xD0
	public OdysseyTowerDisplay prefabTower; //Field offset: 0xD8
	public OdysseyPowerDisplay prefabPower; //Field offset: 0xE0
	public OdysseyTowerDisplay prefabHero; //Field offset: 0xE8
	public GameObject prefabTowerBackground; //Field offset: 0xF0
	public GameObject prefabPowerBackgorund; //Field offset: 0xF8
	public GameObject prefabHeroBackgorund; //Field offset: 0x100
	public GameObject objTowerContent; //Field offset: 0x108
	public GameObject objTowerSeatsContent; //Field offset: 0x110
	public GameObject objPowerContent; //Field offset: 0x118
	public GameObject objPowerSlotsContent; //Field offset: 0x120
	private List<GameObject> towerDisplayList; //Field offset: 0x128
	private List<GameObject> powerDisplayList; //Field offset: 0x130
	private List<GameObject> towerBackgroundList; //Field offset: 0x138
	private List<GameObject> powerBackgroundList; //Field offset: 0x140

	public OdysseyCompletedPopup() { }

	private void ClearUi() { }

	private void CollectRewards() { }

	private void ContinueAfterRating() { }

	private void FavouriteToggled(bool result) { }

	public virtual void Initialize(OdysseyEventScreen parentScreen, object metaData) { }

	private void InitiatelizeLootScreen() { }

	private void InitiatelizeRatingScreen() { }

	private void LikeToggled(bool result) { }

	public void OnClickNextVictoryPanel() { }

	public virtual void OnCloseClick() { }

	public void SetupUi() { }

}

