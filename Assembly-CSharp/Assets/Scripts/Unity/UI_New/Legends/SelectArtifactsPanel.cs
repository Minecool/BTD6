namespace Assets.Scripts.Unity.UI_New.Legends;

public class SelectArtifactsPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public RogueArtifactDisplayIcon artifactIcon; //Field offset: 0x10

		public <>c__DisplayClass29_0() { }

		internal bool <DeselectClicked>b__0(ArtifactLoot x) { }

	}

	[SerializeField]
	private Button closeBtn; //Field offset: 0x20
	[SerializeField]
	private Lightbox closeBg; //Field offset: 0x28
	[SerializeField]
	private GameObject artifactsInventoryContainer; //Field offset: 0x30
	[SerializeField]
	private GameObject artifactDisplayPrefab; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI totalPowerTxt; //Field offset: 0x40
	[SerializeField]
	private RogueArtifactDisplayIcon heroArtifactIcon; //Field offset: 0x48
	[SerializeField]
	private RogueArtifactDisplayIcon[] eqippedDisplays; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI artifactNameTxt; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI artifactDescTxt; //Field offset: 0x60
	[SerializeField]
	private Animator panelAnimator; //Field offset: 0x68
	[SerializeField]
	private GameObject[] maxObjs; //Field offset: 0x70
	[SerializeField]
	private TMP_InputField searchField; //Field offset: 0x78
	[SerializeField]
	private Button removeSearchTxtBtn; //Field offset: 0x80
	private List<RogueArtifactDisplayIcon> activeArtifactIcons; //Field offset: 0x88

	private ArtifactsData ArtifactsData
	{
		private get { } //Length: 71
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private int StartingArtifactPower
	{
		private get { } //Length: 82
	}

	public SelectArtifactsPanel() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	[CompilerGenerated]
	private int <SortArtifacts>b__31_0(RogueArtifactDisplayIcon a, RogueArtifactDisplayIcon b) { }

	public void AddButtonClicked(RogueArtifactDisplayIcon artifactIcon) { }

	public void ArtifactIconSelected(RogueArtifactDisplayIcon artifactIcon) { }

	private void Awake() { }

	private bool CanSelectArtifact(ArtifactModelBase artifactModel) { }

	public void Close() { }

	private void DeselectClicked(RogueArtifactDisplayIcon artifactIcon) { }

	private void FilterArtifacts(string searchString) { }

	private ArtifactsData get_ArtifactsData() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private int get_StartingArtifactPower() { }

	private int GetTotalPower() { }

	public void Open() { }

	private void PopulateArtifacts() { }

	private void SortArtifacts() { }

	private void UpdateUIs() { }

}

