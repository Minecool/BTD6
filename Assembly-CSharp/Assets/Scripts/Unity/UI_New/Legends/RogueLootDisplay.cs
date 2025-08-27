namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueLootDisplay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RogueInstaMonkey, Boolean> <>9__22_0; //Field offset: 0x8
		public static Func<RogueInstaMonkey, Boolean> <>9__23_0; //Field offset: 0x10
		public static Func<RogueInstaMonkey, Boolean> <>9__24_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <OpenDelete>b__22_0(RogueInstaMonkey x) { }

		internal bool <OpenDisplay>b__23_0(RogueInstaMonkey x) { }

		internal bool <ShowInstas>b__24_0(RogueInstaMonkey x) { }

	}

	internal sealed class OnDeletedCallback : MulticastDelegate
	{

		public OnDeletedCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[SerializeField]
	private GameObject lootContainer; //Field offset: 0x20
	[SerializeField]
	private GameObject lootPrefab; //Field offset: 0x28
	[SerializeField]
	private GameObject deleteBanner; //Field offset: 0x30
	[SerializeField]
	private RogueLootDisplayButton replacementIcon; //Field offset: 0x38
	[SerializeField]
	private NK_TextMeshProUGUI titleTxt; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI descTxt; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI countTxt; //Field offset: 0x50
	[SerializeField]
	private Button removeBtn; //Field offset: 0x58
	[SerializeField]
	private Button okBtn; //Field offset: 0x60
	[SerializeField]
	private Button infoBtn; //Field offset: 0x68
	public Button cancelBtn; //Field offset: 0x70
	private List<GameObject> activeButtons; //Field offset: 0x78
	private RogueLootDisplayButton selectedInstaBtn; //Field offset: 0x80
	private OnDeletedCallback deletedCallback; //Field offset: 0x88

	private int InventorySize
	{
		private get { } //Length: 127
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueLootDisplay() { }

	private void Awake() { }

	public void Close() { }

	private int get_InventorySize() { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	private void InfoClicked() { }

	public void InstaClicked(RogueLootDisplayButton selectedInstaBtn) { }

	public void OpenDelete(OnDeletedCallback deletedCallback = null) { }

	public void OpenDisplay() { }

	private void RemoveClicked() { }

	public void ShowInstas(RogueInstaIconSelected selectedCallback) { }

	private void UpdateSelectionFx() { }

}

