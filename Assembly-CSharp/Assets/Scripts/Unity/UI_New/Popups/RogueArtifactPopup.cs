namespace Assets.Scripts.Unity.UI_New.Popups;

public class RogueArtifactPopup : Popup
{
	[SerializeField]
	private GameObject artifactsInventoryContainer; //Field offset: 0x128
	[SerializeField]
	private GameObject boostInventoryContainer; //Field offset: 0x130
	[SerializeField]
	private RogueArtifactDisplayIcon artifactDisplayPrefab; //Field offset: 0x138
	private List<RogueArtifactDisplayIcon> activeArtifactIcons; //Field offset: 0x140
	[SerializeField]
	private Toggle queueBoostsToggle; //Field offset: 0x148
	[SerializeField]
	private Animator queueBoostsToggleAnim; //Field offset: 0x150
	[SerializeField]
	private Button close; //Field offset: 0x158

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueArtifactPopup() { }

	public void Awake() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public void OpenShowInventory() { }

	private void PopulateArtifacts(List<ArtifactDataBase> artifactsInv) { }

	private void QueueBoostsChanged(bool isOn) { }

}

