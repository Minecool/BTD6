namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class EditorRemoveablesLayerSelectPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RemoveableLayerButton, LayerData> <>9__31_0; //Field offset: 0x8
		public static Func<RemoveableLayerButton, LayerData> <>9__31_1; //Field offset: 0x10
		public static Func<RemoveableLayerButton, LayerData> <>9__31_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal LayerData <ClosePanel>b__31_0(RemoveableLayerButton x) { }

		internal LayerData <ClosePanel>b__31_1(RemoveableLayerButton x) { }

		internal LayerData <ClosePanel>b__31_2(RemoveableLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public RemoveableLayerButton layer; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <BindData>b__0(RemoveableAreaLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public LayerData layerData; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal bool <LoadSaveData>b__0(RemoveableLayerButton x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_1
	{
		public RemoveableLayerButton layerToLink; //Field offset: 0x10

		public <>c__DisplayClass25_1() { }

		internal bool <LoadSaveData>b__1(RemoveableLayerButton x) { }

	}

	internal sealed class OnLayerSelectionToggledEvent : MulticastDelegate
	{

		public OnLayerSelectionToggledEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(RemoveableLayerButton layer, bool isSelected, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(RemoveableLayerButton layer, bool isSelected) { }

	}

	public TextMeshProUGUI titleTxt; //Field offset: 0x20
	public Button onTriggerLayersButton; //Field offset: 0x28
	public Button showLayersButton; //Field offset: 0x30
	public Button hideLayersButton; //Field offset: 0x38
	public Button costButton; //Field offset: 0x40
	public Button confirmButton; //Field offset: 0x48
	public Button cancelButton; //Field offset: 0x50
	public Button backgroundCloseButton; //Field offset: 0x58
	public TextMeshProUGUI costTxt; //Field offset: 0x60
	public GameObject showButtonHighlight; //Field offset: 0x68
	public GameObject hideButtonHighlight; //Field offset: 0x70
	public GameObject onTriggerButtonHighlight; //Field offset: 0x78
	public GameObject removeableLayersPanel; //Field offset: 0x80
	public GameObject removeableLayerListSorter; //Field offset: 0x88
	public RemoveableLayerButton buttonPrefab; //Field offset: 0x90
	public NK_TextMeshProUGUI selectingModeTxt; //Field offset: 0x98
	public Button closeLayersButton; //Field offset: 0xA0
	private RemoveableTypeGroup mode; //Field offset: 0xA8
	private List<RemoveableLayerButton> removeableLayers; //Field offset: 0xB0
	private RemoveableAreaLayerButton removeableAreaBeingModified; //Field offset: 0xB8
	private Dictionary<RemoveableTypeGroup, List`1<RemoveableLayerButton>> removeableLayerGroups; //Field offset: 0xC0

	public EditorRemoveablesLayerSelectPanel() { }

	[CompilerGenerated]
	private void <Awake>b__22_0() { }

	[CompilerGenerated]
	private void <Awake>b__22_1() { }

	[CompilerGenerated]
	private void <Awake>b__22_2() { }

	[CompilerGenerated]
	private void <Awake>b__22_3() { }

	[CompilerGenerated]
	private void <Awake>b__22_4() { }

	[CompilerGenerated]
	private void <Awake>b__22_5() { }

	[CompilerGenerated]
	private void <SetCostClicked>b__30_0(int value) { }

	public void Awake() { }

	public void BindData(RemoveableAreaLayerButton removeableAreaBeingModified, IEnumerable<EditorLayerButton> layerButtons) { }

	private void ClosePanel(bool saveChanges) { }

	private void HideUI() { }

	private void LoadSaveData() { }

	public void OnDestroy() { }

	private void OnLayerSelectionToggled(RemoveableLayerButton layer, bool isSelected) { }

	private void OnToggleSelectingLayerGroup(RemoveableTypeGroup mode) { }

	private void SetCostClicked() { }

	private void UpdateData() { }

}

