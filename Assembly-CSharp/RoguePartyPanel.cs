//Type is in global namespace

public class RoguePartyPanel : MonoBehaviour
{
	[SerializeField]
	private Image heroImg; //Field offset: 0x20
	[SerializeField]
	private GameObject instaTowerDisplayPrefab; //Field offset: 0x28
	[SerializeField]
	private Transform instasContainer; //Field offset: 0x30
	[SerializeField]
	private RogueArtifactDisplayIcon artifactImg; //Field offset: 0x38
	[SerializeField]
	private Button artifactBtn; //Field offset: 0x40
	[SerializeField]
	private Button infoBtn; //Field offset: 0x48
	[SerializeField]
	private Button removeBtn; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI partyCountTxt; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI descTxt; //Field offset: 0x68
	[SerializeField]
	private Button closeBtn; //Field offset: 0x70
	[SerializeField]
	private Lightbox closeBg; //Field offset: 0x78
	private InstaTowerDisplay selectedInsta; //Field offset: 0x80
	private List<InstaTowerDisplay> activeInstaIcons; //Field offset: 0x88

	private int InventorySize
	{
		private get { } //Length: 127
	}

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

	public RoguePartyPanel() { }

	[CompilerGenerated]
	private void <InfoClicked>b__32_0() { }

	[CompilerGenerated]
	private bool <RemovePartyMember>b__34_0(RogueInstaMonkey x) { }

	private void ArtifactClicked() { }

	private void Awake() { }

	public void Close() { }

	private void DisplayArtifacts() { }

	private void DisplayHero() { }

	private void DisplayInstas(List<RogueInstaMonkey> instas) { }

	private int get_InventorySize() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private ArtifactModelBase GetHeroArtifactModel() { }

	private void InfoClicked() { }

	public void Open(bool viewOnlyMode) { }

	public void Refresh(bool viewOnlyMode) { }

	private void RemoveClicked() { }

	private void RemovePartyMember() { }

	private void TowerClicked(InstaTowerDisplay instaTowerDisplay) { }

}

