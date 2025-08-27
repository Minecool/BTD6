namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueTileInfoPanel : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI tileNameTxt; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI tileDescTxt; //Field offset: 0x28
	[SerializeField]
	private Button playBtn; //Field offset: 0x30
	[SerializeField]
	private Button playBtnFlamey; //Field offset: 0x38
	[SerializeField]
	private Button skipBtn; //Field offset: 0x40
	[SerializeField]
	private Button retryBtn; //Field offset: 0x48
	[SerializeField]
	private Button continueBtn; //Field offset: 0x50
	[SerializeField]
	private Image mapImg; //Field offset: 0x58
	[SerializeField]
	private Image bossImage; //Field offset: 0x60
	[SerializeField]
	private Image minigameImage; //Field offset: 0x68
	[SerializeField]
	private GameObject standardObj; //Field offset: 0x70
	[SerializeField]
	private GameObject[] bossObjects; //Field offset: 0x78
	[SerializeField]
	private GameObject[] scoreObjects; //Field offset: 0x80
	[SerializeField]
	private GameObject scoreContainer; //Field offset: 0x88
	[SerializeField]
	private GameObject standardBanner; //Field offset: 0x90
	[SerializeField]
	private GameObject finalBossBanner; //Field offset: 0x98
	[SerializeField]
	private GameObject specialTileBanner; //Field offset: 0xA0
	[SerializeField]
	private TextMeshProUGUI roundsTxt; //Field offset: 0xA8
	[SerializeField]
	private float selectionPopupOffset; //Field offset: 0xB0
	private RogueTile selectedTile; //Field offset: 0xB8
	private RogueMapScreen rogueScreen; //Field offset: 0xC0

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueTileInfoPanel() { }

	private void Awake() { }

	public void Bind(RogueTile selectedTile, bool showPlayButton, bool showSkipBtn, bool showContinueBtn, bool showRetryBtn) { }

	public void Close() { }

	private void ContinueClicked() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private Vector2 GetTileCanvasPosition(RogueTile tile) { }

	private void PlayClicked() { }

	private void RetryGame() { }

	private void SetInfoPopupPosition() { }

	private void SkipTileClicked() { }

	private void Update() { }

}

