namespace Assets.Scripts.Unity.UI_New.Legends;

public class UpgradeArtifactsPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public ArtifactModelBase artifactModel; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <GetNextTierForArtifact>b__0(ArtifactModelBase x) { }

	}

	[SerializeField]
	private Button okBtn; //Field offset: 0x20
	[SerializeField]
	private Button cancelBtn; //Field offset: 0x28
	[SerializeField]
	private GameObject artifactsInventoryContainer; //Field offset: 0x30
	[SerializeField]
	private GameObject artifactDisplayPrefab; //Field offset: 0x38
	[SerializeField]
	private RogueArtifactDisplayIcon enhancedArtifactIconBefore; //Field offset: 0x40
	[SerializeField]
	private RogueArtifactDisplayIcon enhancedArtifactIconAfter; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI artifactNameTxt; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI artifactDescTxt; //Field offset: 0x58
	private List<GameObject> activeArtifactIcons; //Field offset: 0x60
	private ArtifactModelBase artifactToEnhance; //Field offset: 0x68
	private RogueTile campfireTile; //Field offset: 0x70

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

	public UpgradeArtifactsPanel() { }

	private void ArtifactIconClicked(RogueArtifactDisplayIcon artifactIcon) { }

	public void ArtifactSelectedEnhance(RogueArtifactDisplayIcon artifactIcon) { }

	private void Awake() { }

	public void Close() { }

	private void EnhanceArtifactAndClose() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public ArtifactModelBase GetNextTierForArtifact(ArtifactModelBase artifactModel) { }

	private void KillSoundLoop() { }

	public void Open(RogueTile campfireTile) { }

	private void TopArtifactIconClicked(RogueArtifactDisplayIcon artifactIcon) { }

}

