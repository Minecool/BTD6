namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueCurseInfoPanel : MonoBehaviour
{
	[SerializeField]
	private Button okBtn; //Field offset: 0x20
	[SerializeField]
	private Lightbox bgClose; //Field offset: 0x28
	[SerializeField]
	private Transform curseInfoContainer; //Field offset: 0x30
	[SerializeField]
	private RogueCurseInfoItemDisplay curseInfoPrefab; //Field offset: 0x38
	private List<RogueCurseInfoItemDisplay> activeCurseDisplays; //Field offset: 0x40

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

	public RogueCurseInfoPanel() { }

	private void Awake() { }

	public void Close() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public void Open() { }

	public void PopulateCurseInfos() { }

}

