namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class EditorMenu : RatioObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorPropData, MapEditorPropDataModel> <>9__91_0; //Field offset: 0x8
		public static Func<MapEditorTowerData, MapEditorTowerDataModel> <>9__91_1; //Field offset: 0x10
		public static Func<MapEditorPowerData, MapEditorPowerDataModel> <>9__91_2; //Field offset: 0x18
		public static Func<MapEditorStampData, MapEditorStampDataModel> <>9__91_3; //Field offset: 0x20
		public static Func<MapEditorPathData, Int32, MapEditorPathDataModel> <>9__91_4; //Field offset: 0x28
		public static Func<MapEditorAreaData, Int32, MapEditorAreaDataModel> <>9__91_5; //Field offset: 0x30
		public static Func<MapEditorLayerBehavior, MapEditorLayerBehaviorModel> <>9__91_6; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal MapEditorPropDataModel <CustomMapModelDataDef>b__91_0(MapEditorPropData data) { }

		internal MapEditorTowerDataModel <CustomMapModelDataDef>b__91_1(MapEditorTowerData data) { }

		internal MapEditorPowerDataModel <CustomMapModelDataDef>b__91_2(MapEditorPowerData data) { }

		internal MapEditorStampDataModel <CustomMapModelDataDef>b__91_3(MapEditorStampData data) { }

		internal MapEditorPathDataModel <CustomMapModelDataDef>b__91_4(MapEditorPathData data, int index) { }

		internal MapEditorAreaDataModel <CustomMapModelDataDef>b__91_5(MapEditorAreaData data, int index) { }

		internal MapEditorLayerBehaviorModel <CustomMapModelDataDef>b__91_6(MapEditorLayerBehavior behavior) { }

	}

	[CompilerGenerated]
	private struct <OnSandboxButtonClickedEvent>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EditorMenu <>4__this; //Field offset: 0x28
		public bool enterSandbox; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct AreaEditingPanel
	{
		public Button exitEditButton; //Field offset: 0x0
		public Button deleteNodeButton; //Field offset: 0x8
		public Button deleteButton; //Field offset: 0x10
		public Button moveButton; //Field offset: 0x18
		public Button cancelMoveModeButton; //Field offset: 0x20
		public Button sharpCornersButton; //Field offset: 0x28
		public Button smoothCornersButton; //Field offset: 0x30
		public Button removeableEditButton; //Field offset: 0x38
		public GameObject removeableEditPanel; //Field offset: 0x40
		public EditorRemoveablesLayerSelectPanel removableEditSettings; //Field offset: 0x48

	}

	internal sealed class OnCheckCustomMapModelSaveOveride : MulticastDelegate
	{

		public OnCheckCustomMapModelSaveOveride(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref CustomMapModel customMapModel, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref CustomMapModel customMapModel, IAsyncResult result) { }

		public override void Invoke(ref CustomMapModel customMapModel) { }

	}

	internal sealed class OnDebugShopPanelButtonClicked : MulticastDelegate
	{

		public OnDebugShopPanelButtonClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSandboxButtonClicked : MulticastDelegate
	{

		public OnSandboxButtonClicked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enterSandbox, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enterSandbox) { }

	}

	internal sealed class OnSetDebugOutputText : MulticastDelegate
	{

		public OnSetDebugOutputText(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string text, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string text) { }

	}

	internal sealed class OnToggleOutputText : MulticastDelegate
	{

		public OnToggleOutputText(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool active, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool active) { }

	}

	internal struct PathEditingPanel
	{
		public Button exitEditButton; //Field offset: 0x0
		public Button deleteNodeButton; //Field offset: 0x8
		public Button deleteButton; //Field offset: 0x10
		public Button sharpCornersButton; //Field offset: 0x18
		public Button smoothCornersButton; //Field offset: 0x20
		public GameObject invulMoabsGroup; //Field offset: 0x28
		public GameObject invulBloonsGroup; //Field offset: 0x30
		public GameObject scaleMoabsGroup; //Field offset: 0x38
		public GameObject scaleBloonsGroup; //Field offset: 0x40
		public GameObject scaleSpeedGroup; //Field offset: 0x48
		public Toggle invulMoabsStart; //Field offset: 0x50
		public Toggle invulBloonsStart; //Field offset: 0x58
		public Button scaleMoabsSliderLeft; //Field offset: 0x60
		public Button scaleMoabsSliderRight; //Field offset: 0x68
		public TextMeshProUGUI scaleMoabsText; //Field offset: 0x70
		public Button scaleBloonsSliderLeft; //Field offset: 0x78
		public Button scaleBloonsSliderRight; //Field offset: 0x80
		public TextMeshProUGUI scaleBloonsText; //Field offset: 0x88
		public Button speedScaleSliderLeft; //Field offset: 0x90
		public Button speedScaleSliderRight; //Field offset: 0x98
		public TextMeshProUGUI scaleSpeedText; //Field offset: 0xA0

	}

	public EditorMenuPopout editorMenuPopout; //Field offset: 0x20
	public Button saveMapBtn; //Field offset: 0x28
	public Button saveAndExitMapBtn; //Field offset: 0x30
	public Button undoBtn; //Field offset: 0x38
	public Button clearAllBtn; //Field offset: 0x40
	public Button howToBtn; //Field offset: 0x48
	public Button musicBtn; //Field offset: 0x50
	public Button editMapOpenBtn; //Field offset: 0x58
	public Button editMapCloseBtn; //Field offset: 0x60
	public Toggle dragAndDropTgl; //Field offset: 0x68
	public Toggle dropAndLockTgl; //Field offset: 0x70
	public Animator saveAnim; //Field offset: 0x78
	public GameObject howToPanel; //Field offset: 0x80
	public Button sandboxBtn; //Field offset: 0x88
	public Image sandboxLoadingIcon; //Field offset: 0x90
	public Button gameEditorBtn; //Field offset: 0x98
	public Button okHowToPanelBtn; //Field offset: 0xA0
	public Lightbox backgroundHowToPanelBtn; //Field offset: 0xA8
	public GameObject editingPanel; //Field offset: 0xB0
	public Button deleteBtn; //Field offset: 0xB8
	public Button exitBtn; //Field offset: 0xC0
	public TextMeshProUGUI closeBtnTxt; //Field offset: 0xC8
	public GameObject panelLock; //Field offset: 0xD0
	public GameObject mainDashBoard; //Field offset: 0xD8
	public GameObject trackEditingBoarderModeObj; //Field offset: 0xE0
	public MapEditorMusicSelectPanel musicSelectPanel; //Field offset: 0xE8
	public Animator editorMenuPopoutAnim; //Field offset: 0xF0
	public Animator loadingScreenAnim; //Field offset: 0xF8
	public PathEditingPanel pathEditingPanel; //Field offset: 0x100
	public AreaEditingPanel areaEditingPanel; //Field offset: 0x1A8
	public AudioClip clickSound; //Field offset: 0x1F8
	public AudioClip tabSound; //Field offset: 0x200
	public AudioClip closeSound; //Field offset: 0x208
	public AudioClip tickSound; //Field offset: 0x210
	public Button debugPanelBtn; //Field offset: 0x218
	public Button debugTowerBtn; //Field offset: 0x220
	public MapEditorDebugPanel debugPanelScript; //Field offset: 0x228
	public GameEditorView gameEditorUI; //Field offset: 0x230
	public NK_TextMeshProUGUI debugOutputTxt; //Field offset: 0x238
	[CompilerGenerated]
	private bool <Is16_9Enabled>k__BackingField; //Field offset: 0x240
	[CompilerGenerated]
	private bool <IsInitialised>k__BackingField; //Field offset: 0x241
	public bool runningReinitialization; //Field offset: 0x242
	private CustomMapModel _TestingCustomMapModel; //Field offset: 0x248
	private GameEditorModel _TestingCustomGameEditorModel; //Field offset: 0x250

	private PlayerContentInfo CreationContentInfo
	{
		private get { } //Length: 431
	}

	private CustomMapModel CurrentCustomMapModel
	{
		private get { } //Length: 42
	}

	public private bool Is16_9Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsGameEditorEditMode
	{
		 get { } //Length: 89
	}

	public private bool IsInitialised
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsMapEditorEditMode
	{
		 get { } //Length: 37
	}

	public EditorMenu() { }

	[CompilerGenerated]
	private void <Initialise>b__59_0() { }

	[CompilerGenerated]
	private void <Initialise>b__59_1() { }

	[CompilerGenerated]
	private void <Initialise>b__59_10() { }

	[CompilerGenerated]
	private void <Initialise>b__59_11() { }

	[CompilerGenerated]
	private void <Initialise>b__59_12() { }

	[CompilerGenerated]
	private void <Initialise>b__59_13() { }

	[CompilerGenerated]
	private void <Initialise>b__59_14() { }

	[CompilerGenerated]
	private void <Initialise>b__59_15() { }

	[CompilerGenerated]
	private void <Initialise>b__59_2() { }

	[CompilerGenerated]
	private void <Initialise>b__59_3() { }

	[CompilerGenerated]
	private void <Initialise>b__59_4() { }

	[CompilerGenerated]
	private void <Initialise>b__59_5() { }

	[CompilerGenerated]
	private void <Initialise>b__59_6() { }

	[CompilerGenerated]
	private void <Initialise>b__59_7() { }

	[CompilerGenerated]
	private void <Initialise>b__59_8() { }

	[CompilerGenerated]
	private void <Initialise>b__59_9() { }

	[CompilerGenerated]
	private void <OnSaveAndExitClicked>b__72_0() { }

	[CompilerGenerated]
	private void <OnSaveClicked>b__70_0() { }

	public void Awake() { }

	public void ButtonsInteractive(bool interactable) { }

	public CustomMapDataModel CustomMapModelDataDef(CustomMapModel cmm) { }

	private PlayerContentInfo get_CreationContentInfo() { }

	private CustomMapModel get_CurrentCustomMapModel() { }

	[CompilerGenerated]
	public bool get_Is16_9Enabled() { }

	public bool get_IsGameEditorEditMode() { }

	[CompilerGenerated]
	public bool get_IsInitialised() { }

	public bool get_IsMapEditorEditMode() { }

	public int GetRatioAnimIndex(bool show) { }

	public virtual void Initialise() { }

	private void OnCheckCustomMapModelSaveOverideTriggered(ref CustomMapModel customMapModel) { }

	public void OnClearAllClicked() { }

	public void OnConfirmClearAllClicked() { }

	public void OnDebugButtonClicked() { }

	public void OnDebugTowerButtonClicked() { }

	public void OnDebugTowerButtonClickedTriggered() { }

	public void OnDropAndLockValueChanged(bool isOn) { }

	private void OnEditButtonClicked(bool openSliderMenu) { }

	private void OnEditSplineNodeClicked(bool isEditing) { }

	private void OnEnterExitEditMode(bool inPlacementMode) { }

	public void OnGameEditorButtonClickedEvent() { }

	private void OnHowToClicked(bool open) { }

	public void OnMapEditorSwitchingEditModesEvent(bool isLoading) { }

	private void OnMusicSelectPanelClicked() { }

	public virtual void OnQuitToMenu() { }

	public void OnRestartOverrideGameModel(GameModel model) { }

	private void OnReturnFromPauseScreen() { }

	[AsyncStateMachine(typeof(<OnSandboxButtonClickedEvent>d__86))]
	public void OnSandboxButtonClickedEvent(bool enterSandbox) { }

	public void OnSaveAndExitClicked() { }

	public void OnSaveClicked(bool saveAndExit) { }

	public void OnSetDebugOutputTextTriggered(string text) { }

	public void OnToggleOutputTextTriggered(bool active) { }

	public void OnUiLoadCompleteTriggered() { }

	public void OnUndoClicked() { }

	public void OnUpdateUI() { }

	public virtual bool OverrideOpenPauseMenu() { }

	public virtual void PostInitialised() { }

	[CompilerGenerated]
	private void set_Is16_9Enabled(bool value) { }

	[CompilerGenerated]
	private void set_IsInitialised(bool value) { }

	public void SetMusic(string musicTrack) { }

}

