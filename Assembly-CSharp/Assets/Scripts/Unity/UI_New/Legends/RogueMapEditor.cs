namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueMapEditor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnSharedToClipboard <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SaveToJson>b__26_0() { }

	}

	[CompilerGenerated]
	private struct <ClearGridAsync>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapEditor <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTileDataJsonAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapEditor <>4__this; //Field offset: 0x20
		private RogueMapTemplate <map>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTileDataSOAsync>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapEditor <>4__this; //Field offset: 0x20
		private RogueMapTemplate <map>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTilesFromData>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueTileSaveData[] data; //Field offset: 0x20
		public RogueMapEditor <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RandomizePropsAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMapEditor <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Dictionary<Vector2Int, RogueTile> activeTiles; //Field offset: 0x20
	[SerializeField]
	private GameObject tilesContainer; //Field offset: 0x28
	[SerializeField]
	private RogueTileEditorPanel editorPanel; //Field offset: 0x30
	[SerializeField]
	private GameObject tilePrefab; //Field offset: 0x38
	[SerializeField]
	private Button clearBtn; //Field offset: 0x40
	[SerializeField]
	private GameObject editTools; //Field offset: 0x48
	[SerializeField]
	private GameObject importExportObj; //Field offset: 0x50
	[SerializeField]
	private TMP_Dropdown soImportDD; //Field offset: 0x58
	[SerializeField]
	private TMP_Dropdown themeDD; //Field offset: 0x60
	private RogueTileSaveData clipboardTile; //Field offset: 0x68
	[SerializeField]
	private GameObject mapToolsObj; //Field offset: 0x70
	[SerializeField]
	private Toggle pasteTypeToggle; //Field offset: 0x78
	[SerializeField]
	private Toggle pasteHeightToggle; //Field offset: 0x80
	[SerializeField]
	private Toggle pastePropToggle; //Field offset: 0x88
	[SerializeField]
	private Toggle pasteRandomHeightoggle; //Field offset: 0x90
	[SerializeField]
	private TMP_InputField pasteRandomHeightInputMin; //Field offset: 0x98
	[SerializeField]
	private TMP_InputField pasteRandomHeightInputMax; //Field offset: 0xA0
	public TMP_InputField exportNameInput; //Field offset: 0xA8
	public bool inputEnabled; //Field offset: 0xB0
	private float clickTimer; //Field offset: 0xB4
	private Vector3 touchStartPos; //Field offset: 0xB8
	private bool isOverUI; //Field offset: 0xC4
	private float zoomAmount; //Field offset: 0xC8
	private bool wasTwoFinger; //Field offset: 0xCC
	private float zoomDelta; //Field offset: 0xD0
	[SerializeField]
	private RogueMapCameraRig camRig; //Field offset: 0xD8
	[SerializeField]
	private float pinchSpeedMultiplier; //Field offset: 0xE0
	[SerializeField]
	private float mouseWheelSmoothingMul; //Field offset: 0xE4
	[SerializeField]
	private float groundPlaneHeight; //Field offset: 0xE8

	private int GridSize
	{
		private get { } //Length: 82
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	public RogueMapEditor() { }

	private void Awake() { }

	private void ClearGrid() { }

	[AsyncStateMachine(typeof(<ClearGridAsync>d__38))]
	private Task ClearGridAsync() { }

	public void CopyTile(RogueTileSaveData tile) { }

	public void CreateEditGrid() { }

	public void CreateMapTemplateSO(bool saveToData) { }

	private int get_GridSize() { }

	private LegendsDataModel get_LegendsData() { }

	private void GetMouseInput() { }

	private RogueTile GetTileFromCoords(Vector2Int coords) { }

	private Vector3 GetWorldPosition() { }

	public void LoadTileDataJson() { }

	[AsyncStateMachine(typeof(<LoadTileDataJsonAsync>d__33))]
	private Task LoadTileDataJsonAsync() { }

	public void LoadTileDataSO() { }

	[AsyncStateMachine(typeof(<LoadTileDataSOAsync>d__31))]
	private Task LoadTileDataSOAsync() { }

	[AsyncStateMachine(typeof(<LoadTilesFromData>d__29))]
	private Task LoadTilesFromData(RogueTileSaveData[] data) { }

	public void RandomizeProps() { }

	[AsyncStateMachine(typeof(<RandomizePropsAsync>d__36))]
	private Task RandomizePropsAsync() { }

	public void SaveToJson() { }

	public void SelectCenterPoint() { }

	private void TileClicked(RogueTile tile) { }

	private void TileRightClicked(RogueTile tile) { }

	public void ToggleImportExport() { }

	public void ToggleReverseCamera() { }

	private void Update() { }

}

