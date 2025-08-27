namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class RogueCampfirePanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ArtifactModelBase artifactModel; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <GetNextTierForArtifact>b__0(ArtifactModelBase x) { }

	}

	[SerializeField]
	private Toggle towerBtn; //Field offset: 0x20
	[SerializeField]
	private Toggle mentorBtn; //Field offset: 0x28
	[SerializeField]
	private Toggle enhanceBtn; //Field offset: 0x30
	[SerializeField]
	private Toggle healBtn; //Field offset: 0x38
	[SerializeField]
	private Button selectBtn; //Field offset: 0x40
	[SerializeField]
	private Lightbox backBtn; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI descriptionTxt; //Field offset: 0x50
	[SerializeField]
	private string towerLocKey; //Field offset: 0x58
	[SerializeField]
	private string mentorLocKey; //Field offset: 0x60
	[SerializeField]
	private string enhanceLocKey; //Field offset: 0x68
	[SerializeField]
	private string healLocKey; //Field offset: 0x70
	[SerializeField]
	private GameObject heartPrefab; //Field offset: 0x78
	[SerializeField]
	private GameObject heartsContainer; //Field offset: 0x80
	private List<GameObject> activeHeartObjs; //Field offset: 0x88
	private RogueTile campfireTile; //Field offset: 0x90

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private RogueMapScreen RogueMapScreen
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueCampfirePanel() { }

	[CompilerGenerated]
	private void <Awake>b__23_0() { }

	[CompilerGenerated]
	private void <TowerClicked>b__35_0() { }

	[CompilerGenerated]
	private void <TowerClicked>b__35_1() { }

	private void Awake() { }

	private bool CanEnhance() { }

	private bool CanHeal() { }

	public void Close(bool fromSubPanel = false) { }

	public void CloseComplete(int livesAdded = 0, bool fromSubPanel = false) { }

	private void CreateHearts() { }

	private void EnhanceClicked() { }

	private void EnhanceDesc(bool isOn) { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueMapScreen get_RogueMapScreen() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public ArtifactModelBase GetNextTierForArtifact(ArtifactModelBase artifactModel) { }

	private void HealDesc(bool isOn) { }

	private void KillSoundLoop() { }

	private void MentorClicked() { }

	private void MentorDesc(bool isOn) { }

	public void Open(RogueTile campfireTile, bool selectDefaultOption = false) { }

	private void SelectClicked() { }

	private void TowerClicked() { }

	private void TowerDesc(bool isOn) { }

	private void UpdateHearts() { }

}

