namespace Assets.Scripts.Unity.UI_New.InGame;

public class InputManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass231_0
	{
		public List<UnityDisplayNode> smokeAndMirrorsGraphics; //Field offset: 0x10
		public InputManager <>4__this; //Field offset: 0x18
		public bool wasPowerMode; //Field offset: 0x20
		public PowerButton wasPowerButton; //Field offset: 0x28
		public bool wasInstaMode; //Field offset: 0x30
		public StandardInstaTowerButton wasInstaButton; //Field offset: 0x38
		public TowerBasedShopMenuItemUi wasGeraldoItemMode; //Field offset: 0x40

		public <>c__DisplayClass231_0() { }

		internal void <CreatePlacementTower>b__0(bool success) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass258_0
	{
		public InputManager <>4__this; //Field offset: 0x10
		public List<UnityDisplayNode> towerSnappingGraphics; //Field offset: 0x18
		public float scaleMod; //Field offset: 0x20
		public Dictionary<PrefabReference, Vector3> offsetsToAdd; //Field offset: 0x28

		public <>c__DisplayClass258_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass258_1
	{
		public PrefabReference display; //Field offset: 0x10
		public <>c__DisplayClass258_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass258_1() { }

		internal void <CreateTowerSnappingGraphicAsync>b__0(UnityDisplayNode node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass259_0
	{
		public InputManager <>4__this; //Field offset: 0x10
		public List<UnityDisplayNode> placementGraphics; //Field offset: 0x18
		public float scaleMod; //Field offset: 0x20
		public Dictionary<PrefabReference, Vector3> offsetsToAdd; //Field offset: 0x28

		public <>c__DisplayClass259_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass259_1
	{
		public PrefabReference display; //Field offset: 0x10
		public <>c__DisplayClass259_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass259_1() { }

		internal void <CreateTowerGraphicsAsync>b__0(UnityDisplayNode node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public InputManager <>4__this; //Field offset: 0x10
		public List<UnityDisplayNode> placementGraphics; //Field offset: 0x18
		public PropModel mapPropModel; //Field offset: 0x20

		public <>c__DisplayClass71_0() { }

		internal void <CreateMapEditorPropAsync>b__0(UnityDisplayNode node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public InputManager <>4__this; //Field offset: 0x10
		public List<UnityDisplayNode> smokeAndMirrorsGraphics; //Field offset: 0x18

		public <>c__DisplayClass78_0() { }

		internal void <SpawnEditorPlacementProp>b__0(bool success) { }

	}

	internal sealed class BoolDelegate : MulticastDelegate
	{

		public BoolDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool b, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool b) { }

	}

	internal enum CursorMode
	{
		Follow = 0,
		Nudge = 1,
		Disengaged = 2,
	}

	internal enum EditorMode
	{
		None = 0,
		Placing = 1,
		Moving = 2,
		Copying = 3,
	}

	internal sealed class OnCursorDown : MulticastDelegate
	{

		public OnCursorDown(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnCursorDownHitScene : MulticastDelegate
	{

		public OnCursorDownHitScene(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnCursorUp : MulticastDelegate
	{

		public OnCursorUp(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnCustomPlacementModeUpdatePlacer : MulticastDelegate
	{

		public OnCustomPlacementModeUpdatePlacer(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnDragOutOfWorld : MulticastDelegate
	{

		public OnDragOutOfWorld(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnEnterCustomPlacementModeCallback : MulticastDelegate
	{

		public OnEnterCustomPlacementModeCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool success, Vector2 cursorPos, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool success, Vector2 cursorPos) { }

	}

	internal sealed class OnEnteredMultiPlacementMode : MulticastDelegate
	{

		public OnEnteredMultiPlacementMode(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnEscPlacementMode : MulticastDelegate
	{

		public OnEscPlacementMode(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPlaceablesPlacedOrRemoved : MulticastDelegate
	{

		public OnPlaceablesPlacedOrRemoved(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSelectablePropPlaced : MulticastDelegate
	{

		public OnSelectablePropPlaced(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropToSimulation pts, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropToSimulation pts) { }

	}

	internal sealed class OnSetHelperMessage : MulticastDelegate
	{

		public OnSetHelperMessage(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string msg, float timeUntilClear, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string msg, float timeUntilClear = -1) { }

	}

	internal sealed class OnToggleCustomPlacementMode : MulticastDelegate
	{

		public OnToggleCustomPlacementMode(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(OnEnterCustomPlacementModeCallback callback, bool forceExitOverride, AsyncCallback __callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(OnEnterCustomPlacementModeCallback callback, bool forceExitOverride = false) { }

	}

	internal sealed class PositionDelegate : MulticastDelegate
	{

		public PositionDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 pos, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 pos) { }

	}

	internal class RepositionalData
	{
		public PositionalData positionalData; //Field offset: 0x10
		public bool isAnimationDisabled; //Field offset: 0x18
		public bool isBlockerDisabled; //Field offset: 0x19

		public RepositionalData() { }

	}

	internal sealed class SelectedDelegate : MulticastDelegate
	{

		public SelectedDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Selectable s, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Selectable s) { }

	}

	internal sealed class StringDelegate : MulticastDelegate
	{

		public StringDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string s, float t, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string s, float t) { }

	}

	internal sealed class TriggerExitPlacementMode : MulticastDelegate
	{

		public TriggerExitPlacementMode(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private const float nudgeCursorMovementScale = 0.33; //Field offset: 0x0
	private const float selectionRange = 20; //Field offset: 0x0
	private const float nudgeCancelRadiusSquared = 100; //Field offset: 0x0
	[CompilerGenerated]
	private Action<Vector2, Boolean> OnMovingStampSmokeAndMirrorsGraphic; //Field offset: 0x10
	[CompilerGenerated]
	private Action<Object> OnCreateSmokeAndMirrorsGraphic; //Field offset: 0x18
	[CompilerGenerated]
	private Action<Object> OnCreateGraphic; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnDestroySmokeAndMirrorsGraphic; //Field offset: 0x28
	[CompilerGenerated]
	private Action<Vector2> OnEraseStamps; //Field offset: 0x30
	[CompilerGenerated]
	private Action<Boolean, PropToSimulation> OnTogglePropSelected; //Field offset: 0x38
	private StandardPropPurchaseButton mapEditorPropButton; //Field offset: 0x40
	private PropModel editorPropPlacementModel; //Field offset: 0x48
	private StandardStampPurchaseButton mapEditorStampButton; //Field offset: 0x50
	private StampTextureModel mapEditorStampModel; //Field offset: 0x58
	private CustomMapItemPurchaseButton mapEditorItemPurchaseCustomButton; //Field offset: 0x60
	private bool inMapEditorMultiPlacerMode; //Field offset: 0x68
	private bool inEditorCustomPlacementMode; //Field offset: 0x69
	private bool inMapEditorItemPlacementMode; //Field offset: 0x6A
	private bool inMapEditorStampPlacementMode; //Field offset: 0x6B
	private bool isSelectPropOnceSpawnedEnabled; //Field offset: 0x6C
	private bool isMultiPlaceModeInStandbyAsCurrentlyPlacing; //Field offset: 0x6D
	[CompilerGenerated]
	private EditorMode <inMapEditorPlacementMode>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private bool <inMapEditorCustomItemPlacementMode>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private bool <inMapEditorStampEraserMode>k__BackingField; //Field offset: 0x75
	[CompilerGenerated]
	private bool <RandomizeMapEditorItemPlacement>k__BackingField; //Field offset: 0x76
	[CompilerGenerated]
	private bool <RandomizeMapEditorStampPlacement>k__BackingField; //Field offset: 0x77
	private float randomEditorRotation; //Field offset: 0x78
	private bool waitingForRepositioningNextTouchInput; //Field offset: 0x7C
	private RepositionalData repositionalData; //Field offset: 0x80
	private InGame ig; //Field offset: 0x88
	public ITowerPurchaseButton towerButton; //Field offset: 0x90
	private TowerModel towerModel; //Field offset: 0x98
	private int costOverride; //Field offset: 0xA0
	private PowerButton powerButton; //Field offset: 0xA8
	private PowerModel powerModel; //Field offset: 0xB0
	private StandardInstaTowerButton instaButton; //Field offset: 0xB8
	private TowerModel instaModel; //Field offset: 0xC0
	private CustomInput customInput; //Field offset: 0xC8
	private Model towerShopItemModel; //Field offset: 0xD0
	private TowerBasedShopMenuItemUi towerBasedShopItemUi; //Field offset: 0xD8
	private bool inTowerMode; //Field offset: 0xE0
	private bool inPowerMode; //Field offset: 0xE1
	private bool inInstaMode; //Field offset: 0xE2
	private bool inCustomMode; //Field offset: 0xE3
	private bool inGeraldoShopItemMode; //Field offset: 0xE4
	private bool inCorvusSpellModel; //Field offset: 0xE5
	private TowerModel placementModel; //Field offset: 0xE8
	private ObjectId placementEntityId; //Field offset: 0xF0
	private List<UnityDisplayNode> placementGraphics; //Field offset: 0xF8
	private List<UnityDisplayNode> towerSnappingGraphics; //Field offset: 0x100
	private List<Mesh> placementMeshes; //Field offset: 0x108
	private PositionDelegate PlacementModeSuccessCallback; //Field offset: 0x110
	private bool inPlacementMode; //Field offset: 0x118
	private bool cursorInWorld; //Field offset: 0x119
	private bool cursorDown; //Field offset: 0x11A
	private bool wasCursorInWorld; //Field offset: 0x11B
	public bool ignoreFirstUp; //Field offset: 0x11C
	private Vector2 cursorPositionWorld; //Field offset: 0x120
	private Vector2 cursorPositionWorldLast; //Field offset: 0x128
	private Vector2 entityPositionWorld; //Field offset: 0x130
	private Nullable<Vector2> lastValidPosition; //Field offset: 0x138
	private List<PlacementRestriction> placementRestrictions; //Field offset: 0x148
	private CursorMode cursorMode; //Field offset: 0x150
	private float selectionGrace; //Field offset: 0x154
	private Selectable downSelection; //Field offset: 0x158
	private bool wasDownOnScene; //Field offset: 0x160
	private float downOnSelectionTimer; //Field offset: 0x164
	private bool downOnSelectionTriggered; //Field offset: 0x168
	private bool hidePowers; //Field offset: 0x169
	private bool ignoreNudgeOnFirstTouch; //Field offset: 0x16A
	[CompilerGenerated]
	private Action OnSceneHit; //Field offset: 0x170
	[CompilerGenerated]
	private Action<Vector2> OnSceneHitLocation; //Field offset: 0x178
	[CompilerGenerated]
	private Action OnEnterPlacementMode; //Field offset: 0x180
	[CompilerGenerated]
	private Action OnExitPlacementMode; //Field offset: 0x188
	[CompilerGenerated]
	private Action TriggerPlacementAudio; //Field offset: 0x190
	[CompilerGenerated]
	private BoolDelegate OnHideShowPlacementBlockingUI; //Field offset: 0x198
	[CompilerGenerated]
	private StringDelegate OnHelperMessageChanged; //Field offset: 0x1A0
	[CompilerGenerated]
	private SelectedDelegate OnSelectionChanged; //Field offset: 0x1A8
	public Action OnCloseSelectionMenu; //Field offset: 0x1B0
	private TowerToSimulation customInputSelectedTower; //Field offset: 0x1B8
	private TowerToSimulation selectedGeraldo; //Field offset: 0x1C0
	private TowerToSimulation selectedCorvus; //Field offset: 0x1C8
	private Selectable selected; //Field offset: 0x1D0
	public bool isPlacingTower; //Field offset: 0x1D8
	private Selectable hovered; //Field offset: 0x1E0

	public event Action<Object> OnCreateGraphic
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action<Object> OnCreateSmokeAndMirrorsGraphic
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action OnDestroySmokeAndMirrorsGraphic
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action OnEnterPlacementMode
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action<Vector2> OnEraseStamps
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action OnExitPlacementMode
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event StringDelegate OnHelperMessageChanged
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event BoolDelegate OnHideShowPlacementBlockingUI
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action<Vector2, Boolean> OnMovingStampSmokeAndMirrorsGraphic
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action OnSceneHit
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action<Vector2> OnSceneHitLocation
	{
		[CompilerGenerated]
		 add { } //Length: 186
		[CompilerGenerated]
		 remove { } //Length: 186
	}

	public event SelectedDelegate OnSelectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public event Action<Boolean, PropToSimulation> OnTogglePropSelected
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	public event Action TriggerPlacementAudio
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	private bool CanEnterPlacementMode
	{
		private get { } //Length: 59
	}

	public bool CanPlaceEditorItem
	{
		 get { } //Length: 102
	}

	public Vector2 CursorPositionWorld
	{
		 get { } //Length: 25
	}

	public Vector2 CursorWorldPosition
	{
		 get { } //Length: 25
	}

	public Vector2 EntityPositionWorld
	{
		 get { } //Length: 25
	}

	public TowerToSimulation HoveredTower
	{
		 get { } //Length: 133
	}

	public private bool inMapEditorCustomItemPlacementMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EditorMode inMapEditorPlacementMode
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool inMapEditorStampEraserMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsEditorModeMovingOrCopying
	{
		 get { } //Length: 17
	}

	public bool IsEditorMultiPlacementModeBlockingPlacement
	{
		 get { } //Length: 32
	}

	public bool IsEditorPlacementMode
	{
		 get { } //Length: 20
	}

	public bool IsInEditorMultiPlacementMode
	{
		 get { } //Length: 94
	}

	public bool IsInPlacementMode
	{
		 get { } //Length: 8
	}

	public bool IsTowerPrimed
	{
		 get { } //Length: 50
	}

	public private bool RandomizeMapEditorItemPlacement
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool RandomizeMapEditorStampPlacement
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TowerToSimulation SelectedTower
	{
		 get { } //Length: 133
	}

	public InputManager() { }

	[CompilerGenerated]
	public void add_OnCreateGraphic(Action<Object> value) { }

	[CompilerGenerated]
	public void add_OnCreateSmokeAndMirrorsGraphic(Action<Object> value) { }

	[CompilerGenerated]
	public void add_OnDestroySmokeAndMirrorsGraphic(Action value) { }

	[CompilerGenerated]
	public void add_OnEnterPlacementMode(Action value) { }

	[CompilerGenerated]
	public void add_OnEraseStamps(Action<Vector2> value) { }

	[CompilerGenerated]
	public void add_OnExitPlacementMode(Action value) { }

	[CompilerGenerated]
	public void add_OnHelperMessageChanged(StringDelegate value) { }

	[CompilerGenerated]
	public void add_OnHideShowPlacementBlockingUI(BoolDelegate value) { }

	[CompilerGenerated]
	public void add_OnMovingStampSmokeAndMirrorsGraphic(Action<Vector2, Boolean> value) { }

	[CompilerGenerated]
	public void add_OnSceneHit(Action value) { }

	[CompilerGenerated]
	public void add_OnSceneHitLocation(Action<Vector2> value) { }

	[CompilerGenerated]
	public void add_OnSelectionChanged(SelectedDelegate value) { }

	[CompilerGenerated]
	public void add_OnTogglePropSelected(Action<Boolean, PropToSimulation> value) { }

	[CompilerGenerated]
	public void add_TriggerPlacementAudio(Action value) { }

	public void AddNewPlacementRestriction(PlacementRestriction pr) { }

	private void CancelAllPlacementActions() { }

	public void CancelClicked() { }

	public void CancelSelection() { }

	private void CheckPrimes() { }

	private void CheckPrimesOnCursorUp() { }

	private void ConfirmPlacementClicked() { }

	public Vector2 ConstrainToWorld(Vector2 point) { }

	private void CreateMapEditorPropAsync(PropModel mapPropModel, List<UnityDisplayNode> placementGraphics) { }

	private void CreatePlacementTower(Vector2 pos) { }

	private void CreateTowerGraphicsAsync(TowerModel towerModel, List<UnityDisplayNode> placementGraphics, ObjectId forTowerId) { }

	private void CreateTowerSnappingGraphicAsync(TowerModel towerModel, List<UnityDisplayNode> towerSnappingGraphics, ObjectId forTowerId) { }

	private void CursorDown() { }

	private void CursorUp() { }

	public void DeselectGeraldoDuringShopItemPlacement() { }

	private void DragOutOfWorld() { }

	public void EnterCorvusSpellMode(CorvusSpellbookSpellUi spellToCast) { }

	private void EnterCustomMode() { }

	public void EnterGeraldoItemMode() { }

	private void EnterInstaMode() { }

	private void EnterMapEditorCustomItemMode() { }

	public void EnterMapEditorPropMode() { }

	private void EnterMapEditorStampMode() { }

	public void EnterPlacementMode(TowerModel forTowerModel, PositionDelegate customCallback, ObjectId forTowerId, bool ignoreNudgeOnFirstTouch = false, int costOverride = 0) { }

	public void EnterPowerMode() { }

	public void EnterPropPlacementMode(PositionDelegate customCallback, ObjectId forTowerId, bool ignoreNudgeOnFirstTouch = false, EditorMode editorMode = 1, PropToSimulation prop = null, bool overrideCursorModeFollowTouch = false) { }

	public void EnterStampEraserMode(Sprite eraserSprite) { }

	public void EnterStampPlacementMode(PositionDelegate customCallback, ObjectId forTowerId, bool ignoreNudgeOnFirstTouch = false) { }

	private void EnterTowerMode() { }

	public void EraseStamps(Vector2 screenPosition) { }

	private void ExitCorvusSpellMode() { }

	public void ExitCustomMode() { }

	private void ExitEditorCustomPlacementMode() { }

	private void ExitGeraldoItemMode() { }

	private void ExitInstaMode() { }

	private void ExitMapEditorCustomItemMode() { }

	private void ExitMapEditorPropMode() { }

	public void ExitMapEditorStampEraserMode() { }

	private void ExitMapEditorStampMode() { }

	private void ExitPlacementMode() { }

	private void ExitPowerMode() { }

	public void ExitTowerMode() { }

	private float GenerateNonSeededRandomNumber() { }

	private UnityToSimulation get_Bridge() { }

	private bool get_CanEnterPlacementMode() { }

	public bool get_CanPlaceEditorItem() { }

	public Vector2 get_CursorPositionWorld() { }

	public Vector2 get_CursorWorldPosition() { }

	public Vector2 get_EntityPositionWorld() { }

	public TowerToSimulation get_HoveredTower() { }

	[CompilerGenerated]
	public bool get_inMapEditorCustomItemPlacementMode() { }

	[CompilerGenerated]
	public EditorMode get_inMapEditorPlacementMode() { }

	[CompilerGenerated]
	public bool get_inMapEditorStampEraserMode() { }

	public bool get_IsEditorModeMovingOrCopying() { }

	public bool get_IsEditorMultiPlacementModeBlockingPlacement() { }

	public bool get_IsEditorPlacementMode() { }

	public bool get_IsInEditorMultiPlacementMode() { }

	public bool get_IsInPlacementMode() { }

	public bool get_IsTowerPrimed() { }

	[CompilerGenerated]
	public bool get_RandomizeMapEditorItemPlacement() { }

	[CompilerGenerated]
	public bool get_RandomizeMapEditorStampPlacement() { }

	public TowerToSimulation get_SelectedTower() { }

	private bool GetCursorDown() { }

	public static Vector2 GetCursorPosition() { }

	public static Vector2 GetCursorPositionNormalized() { }

	public bool HasSomethingSelected() { }

	public void HideCoopPlacementArea() { }

	private void HidePlacementBlockingUI() { }

	public bool InAnyMode() { }

	public void Init(InGame ig) { }

	private void OnCheckForMultiPlacementMode() { }

	private void OnEnteredMultiPlacementModeEvent() { }

	public void OnEnterExitEditMode(bool enterPlacementMode) { }

	private void OnMovingPropSmokeAndMirrorsGraphicEvent(PlacementQuery placementQuery, Vector2 position, bool showGhost) { }

	private void OnMovingTowerSmokeAndMirrorsGraphic(PlacementQuery placementQuery, Vector2 position) { }

	public void OnPlaceablesPlacedCallback() { }

	public void OnSelectablePropPlacedCallback(PropToSimulation pts) { }

	public void OnToggleCustomPlacementModeEvent(OnEnterCustomPlacementModeCallback callback, bool forceOverrideExitCustomPlacementMode = false) { }

	public void OnTogglePropSelectedEventTriggered(bool isSelected, PropToSimulation prop = null) { }

	public void OnToggleRandomizePropPlacement(bool isOn) { }

	public void OnToggleRandomizeStampPlacement(bool isOn) { }

	public void PrimeCustomInput(CustomInput ci) { }

	public void PrimeInsta(StandardInstaTowerButton ib, TowerModel im) { }

	public void PrimeMapEditorCustomItemPlacement(CustomMapItemPurchaseButton button) { }

	public void PrimeMapEditorProp(StandardPropPurchaseButton ib) { }

	public void PrimeMapEditorStamp(StandardStampPurchaseButton ib, StampTextureModel model) { }

	public void PrimePower(PowerButton pb, PowerModel pm) { }

	public void PrimeTower(ITowerPurchaseButton tb, TowerModel tm) { }

	public void PrimeTowerShopItem(TowerBasedShopMenuItemUi itemUi, Model model) { }

	public void Quit() { }

	[CompilerGenerated]
	public void remove_OnCreateGraphic(Action<Object> value) { }

	[CompilerGenerated]
	public void remove_OnCreateSmokeAndMirrorsGraphic(Action<Object> value) { }

	[CompilerGenerated]
	public void remove_OnDestroySmokeAndMirrorsGraphic(Action value) { }

	[CompilerGenerated]
	public void remove_OnEnterPlacementMode(Action value) { }

	[CompilerGenerated]
	public void remove_OnEraseStamps(Action<Vector2> value) { }

	[CompilerGenerated]
	public void remove_OnExitPlacementMode(Action value) { }

	[CompilerGenerated]
	public void remove_OnHelperMessageChanged(StringDelegate value) { }

	[CompilerGenerated]
	public void remove_OnHideShowPlacementBlockingUI(BoolDelegate value) { }

	[CompilerGenerated]
	public void remove_OnMovingStampSmokeAndMirrorsGraphic(Action<Vector2, Boolean> value) { }

	[CompilerGenerated]
	public void remove_OnSceneHit(Action value) { }

	[CompilerGenerated]
	public void remove_OnSceneHitLocation(Action<Vector2> value) { }

	[CompilerGenerated]
	public void remove_OnSelectionChanged(SelectedDelegate value) { }

	[CompilerGenerated]
	public void remove_OnTogglePropSelected(Action<Boolean, PropToSimulation> value) { }

	[CompilerGenerated]
	public void remove_TriggerPlacementAudio(Action value) { }

	private void SelectedDestroyed() { }

	private void SelectedSelectionDisabled() { }

	[CompilerGenerated]
	private void set_inMapEditorCustomItemPlacementMode(bool value) { }

	[CompilerGenerated]
	private void set_inMapEditorPlacementMode(EditorMode value) { }

	[CompilerGenerated]
	private void set_inMapEditorStampEraserMode(bool value) { }

	[CompilerGenerated]
	private void set_RandomizeMapEditorItemPlacement(bool value) { }

	[CompilerGenerated]
	private void set_RandomizeMapEditorStampPlacement(bool value) { }

	public void SetHelperMessage(string msg, float timeUntilClear = -1) { }

	public void SetHovered(Selectable value) { }

	public void SetSelected(Selectable value) { }

	public void ShowCoopPlacementArea(Mesh mesh, Mesh playerMesh) { }

	public void ShowGeraldoRangeCircle() { }

	private void ShowPlacementBlockingUI() { }

	public void SpawnEditorPlacementProp(Vector2 pos) { }

	private void SpawnMapEditorCustomPlacementItem(Vector2 position) { }

	private void SpawnPlacementStamp(Vector2 pos) { }

	private void StoreTemporaryPositionalData(PropToSimulation prop) { }

	private void TryPlace() { }

	public void Update() { }

	private void UpdateRangeMeshes() { }

	private void UpdateSnappingGraphicPosition(bool isSnapping) { }

}

