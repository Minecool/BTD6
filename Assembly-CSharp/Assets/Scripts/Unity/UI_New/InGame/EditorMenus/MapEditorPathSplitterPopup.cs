namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorPathSplitterPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorPathSplitterPanel, Boolean> <>9__15_0; //Field offset: 0x8
		public static Func<PathLayerButton, Int32> <>9__15_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Initialise>b__15_0(MapEditorPathSplitterPanel x) { }

		internal int <Initialise>b__15_1(PathLayerButton layer) { }

	}

	internal sealed class OnAddClickedEvent : MulticastDelegate
	{

		public OnAddClickedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnRemoveClickedEvent : MulticastDelegate
	{

		public OnRemoveClickedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnUpdatePathSettingsEvent : MulticastDelegate
	{

		public OnUpdatePathSettingsEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private const int MAX_PATH_SPLITTERS = 10; //Field offset: 0x0
	public Button closeBtn; //Field offset: 0x20
	public Button addBtn; //Field offset: 0x28
	public Button removeBtn; //Field offset: 0x30
	public Transform pathSplitterContainer; //Field offset: 0x38
	public GameObject noPathsTxtPanel; //Field offset: 0x40
	public GameObject pathSplitterPrefab; //Field offset: 0x48
	private List<MapEditorPathSplitterPanel> pathSplitters; //Field offset: 0x50
	private int pathSplitterPatternCount; //Field offset: 0x58

	public MapEditorPathSplitterPopup() { }

	[CompilerGenerated]
	private void <OnEnable>b__13_0() { }

	private void Awake() { }

	public void CreatePathSplitter(PathLayerButton linkedPathLayer) { }

	public void Initialise(List<PathLayerButton> pathLayers) { }

	public void OnAddClicked() { }

	public void OnDisable() { }

	public void OnEnable() { }

	public void OnRemoveClicked() { }

	public void OnUpdateCustomPathManagerDataEventTriggered(bool addedColumn) { }

	private void OnUpdateSeqenceValidationChecks() { }

	private void UpdateButtons() { }

}

