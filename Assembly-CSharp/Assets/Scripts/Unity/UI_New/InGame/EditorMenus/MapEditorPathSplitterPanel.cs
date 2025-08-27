namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorPathSplitterPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Toggle, Boolean> <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Initialise>b__14_0(Toggle x) { }

	}

	internal sealed class OnToggleToggledEvent : MulticastDelegate
	{

		public OnToggleToggledEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapEditorSplitterPanel splitterToggle, bool isOn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapEditorSplitterPanel splitterToggle, bool isOn) { }

	}

	public Transform container; //Field offset: 0x20
	public GameObject pathPanelButton; //Field offset: 0x28
	public GameObject splitterTogglePrefab; //Field offset: 0x30
	public NK_TextMeshProUGUI pathLayerName; //Field offset: 0x38
	private PathLayerButton linkedPathLayer; //Field offset: 0x40
	private List<MapEditorSplitterPanel> splitterToggles; //Field offset: 0x48

	public string PathID
	{
		 get { } //Length: 42
	}

	public int SplitterCount
	{
		 get { } //Length: 60
	}

	public MapEditorPathSplitterPanel() { }

	public void AddSplitterButtonEventTriggered() { }

	public void Awake() { }

	private void CreatePathSplitterToggle(bool isOn) { }

	public string get_PathID() { }

	public int get_SplitterCount() { }

	public MapEditorSplitterPanel GetSplitterIndex(int index) { }

	public void Initialise(PathLayerButton linkedPathLayer) { }

	public bool IsSplitterToggleOn(int index) { }

	public void OnToggleToggledEventTriggered(MapEditorSplitterPanel splitterToggle, bool isOn) { }

	public void RemoveSplitterButtonEventTriggered() { }

}

