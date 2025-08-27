//Type is in global namespace

public class RogueArtifactDisplayIcon : MonoBehaviour
{
	internal sealed class ArtifactSelected : MulticastDelegate
	{

		public ArtifactSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RogueArtifactDisplayIcon artifact, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RogueArtifactDisplayIcon artifact) { }

	}

	[SerializeField]
	private Image icon; //Field offset: 0x20
	[SerializeField]
	private Image bg; //Field offset: 0x28
	[SerializeField]
	private Button selectBtn; //Field offset: 0x30
	[SerializeField]
	private GameObject powerObj; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI powerTxt; //Field offset: 0x40
	[SerializeField]
	private GameObject selectionObj; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI descTxt; //Field offset: 0x58
	[SerializeField]
	private GameObject stackCountObj; //Field offset: 0x60
	[SerializeField]
	private NK_TextMeshProUGUI stackCountTxt; //Field offset: 0x68
	private int stackCount; //Field offset: 0x70
	[SerializeField]
	private Button addBtn; //Field offset: 0x78
	[SerializeField]
	private Button removeBtn; //Field offset: 0x80
	[SerializeField]
	private bool useHoverTrigger; //Field offset: 0x88
	public ArtifactModelBase artifactModel; //Field offset: 0x90
	private ArtifactSelected onSelectedCallback; //Field offset: 0x98
	private ArtifactSelected onAddCallback; //Field offset: 0xA0
	private ArtifactSelected onRemoveCallback; //Field offset: 0xA8

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

	[HideInInspector]
	public int StackCount
	{
		 get { } //Length: 4
		 set { } //Length: 123
	}

	public RogueArtifactDisplayIcon() { }

	private void AddClicked() { }

	private void Awake() { }

	public void Bind(ArtifactModelBase artifactModel, ArtifactSelected onSelectedCallback, bool displayPower = false, ArtifactSelected onAddCallback = null, ArtifactSelected onRemoveCallback = null, bool isMerchantIcon = false, int powerDiscount = 0) { }

	public void Clear() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public int get_StackCount() { }

	private void OnHover(BaseEventData _) { }

	private void OnHoverEnd(BaseEventData _) { }

	private void RemoveClicked() { }

	private void Select() { }

	public void set_StackCount(int value) { }

	public void SetAvailable(bool isAvailable) { }

	public void SetInteractable(bool interactable) { }

	public void SetSelectionVisual(bool isOn) { }

	public void ToggleAddButtonInteractable(bool isAvailable) { }

}

