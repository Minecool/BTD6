//Type is in global namespace

public class RogueExtractionPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass21_0
	{
		public ArtifactModelBase artifactModel; //Field offset: 0x10

		public <>c__DisplayClass21_0() { }

		internal bool <CanExtractArtifact>b__0(string x) { }

	}

	[CompilerGenerated]
	private struct <ExtractArtifact>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueExtractionPanel <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GameObject artifactsInventoryContainer; //Field offset: 0x20
	[SerializeField]
	private GameObject artifactDisplayPrefab; //Field offset: 0x28
	[SerializeField]
	private RogueArtifactDisplayIcon selectedArtifactDisplay; //Field offset: 0x30
	[SerializeField]
	private NK_TextMeshProUGUI artifactNameTxt; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI artifactDescTxt; //Field offset: 0x40
	[SerializeField]
	private Button confirmBtn; //Field offset: 0x48
	[SerializeField]
	private Button skipBtn; //Field offset: 0x50
	[SerializeField]
	private float extractionAnimTime; //Field offset: 0x58
	[SerializeField]
	private Animator extractionAnim; //Field offset: 0x60
	private ArtifactModelBase selectedArtifact; //Field offset: 0x68
	private List<RogueArtifactDisplayIcon> activeArtifactIcons; //Field offset: 0x70

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

	public RogueExtractionPanel() { }

	[CompilerGenerated]
	private bool <ExtractArtifact>b__24_0(ArtifactLoot x) { }

	[CompilerGenerated]
	private bool <PopulateArtifacts>b__22_0(ArtifactLoot x) { }

	private void Awake() { }

	private bool CanExtractArtifact(ArtifactLoot artifactLoot) { }

	public void Close() { }

	[AsyncStateMachine(typeof(<ExtractArtifact>d__24))]
	private void ExtractArtifact() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public void Open() { }

	private void PopulateArtifacts() { }

	private void SelectArtifact(RogueArtifactDisplayIcon artifactIcon) { }

}

