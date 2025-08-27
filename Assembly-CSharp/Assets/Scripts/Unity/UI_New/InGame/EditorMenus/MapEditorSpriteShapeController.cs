namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public abstract class MapEditorSpriteShapeController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass115_0
	{
		public bool show; //Field offset: 0x10

		public <>c__DisplayClass115_0() { }

		internal void <ToggleControlNodesVisibility>b__0(SplineNode node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass87_0
	{
		public CancellationToken ct; //Field offset: 0x10
		public int index; //Field offset: 0x18
		public MapEditorSpriteShapeController <>4__this; //Field offset: 0x20
		public Vector3 anchorPos; //Field offset: 0x28
		public PathNode nodeSaveData; //Field offset: 0x38

		public <>c__DisplayClass87_0() { }

		internal void <InitialiseSplineDisplayNode>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <CreateControlNode>d__86 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SplineNode> <>t__builder; //Field offset: 0x8
		public MapEditorSpriteShapeController <>4__this; //Field offset: 0x20
		public Vector3 anchorPos; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x38
		public int index; //Field offset: 0x40
		public PathNode nodeSaveData; //Field offset: 0x48
		public bool insertNode; //Field offset: 0x50
		private TaskAwaiter<SplineNode> <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitialiseSplineDisplayNode>d__87 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SplineNode> <>t__builder; //Field offset: 0x8
		public CancellationToken ct; //Field offset: 0x20
		public int index; //Field offset: 0x28
		public MapEditorSpriteShapeController <>4__this; //Field offset: 0x30
		public Vector3 anchorPos; //Field offset: 0x38
		public PathNode nodeSaveData; //Field offset: 0x48
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InsertSegment>d__93 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int index; //Field offset: 0x20
		public MapEditorSpriteShapeController <>4__this; //Field offset: 0x28
		public Vector3 pos; //Field offset: 0x30
		public CancellationToken ct; //Field offset: 0x40
		private TaskAwaiter<SplineNode> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSceneHit>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSpriteShapeController <>4__this; //Field offset: 0x28
		public Vector2 position; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSceneHitSpawnNodeTriggered>d__76 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSpriteShapeController <>4__this; //Field offset: 0x20
		public Vector3 position; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x38
		private TaskAwaiter<SplineNode> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnSplineChangedEvent : MulticastDelegate
	{

		public OnSplineChangedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapEditorSpriteShapeController spline, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapEditorSpriteShapeController spline) { }

	}

	protected const float MIN_NODE_DISTANCE = 20; //Field offset: 0x0
	public SpriteShapeController ShapeController; //Field offset: 0x20
	public SpriteShapeRenderer SpriteShapeRenderer; //Field offset: 0x28
	[CompilerGenerated]
	private bool <InPlacementMode>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <InMovingMode>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private bool <InSmoothCornersMode>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	private bool <IsDragging>k__BackingField; //Field offset: 0x33
	[CompilerGenerated]
	private bool <IsMoveModeDagging>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private SplineNode <SelectedNode>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private DraggableNode <HighlightedNode>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private DraggableNode <DraggedNode>k__BackingField; //Field offset: 0x48
	public Action OnDeleteSplineNodeEvent; //Field offset: 0x50
	public Action<Boolean> OnIsDraggingNodeEvent; //Field offset: 0x58
	public Action<DraggableNode> OnDraggableNodeHoverUpdateEvent; //Field offset: 0x60
	protected bool currentlySpawningNode; //Field offset: 0x68
	protected List<SplineNode> splineNodes; //Field offset: 0x70
	protected MethodInfo setSplineCornerModeMethod; //Field offset: 0x78
	protected Vector3 movingModeCursorPosOriginWorldSpace; //Field offset: 0x80
	private RaycastHit[] raycastResults; //Field offset: 0x90
	public CancellationTokenSource spriteControllerCts; //Field offset: 0x98
	private readonly float KEpsilon; //Field offset: 0xA0

	public bool CanDeleteSelectedNode
	{
		 get { } //Length: 142
	}

	public DraggableNode DraggedNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public MapEditorSettings EditorSettings
	{
		 get { } //Length: 147
	}

	protected static bool GameTypeIsMapEditor
	{
		 get { } //Length: 74
	}

	public DraggableNode HighlightedNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool InMovingMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool InPlacementMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 86
	}

	public bool InSmoothCornersMode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsDragging
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private bool IsMoveModeDagging
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected override bool IsPlacementBlocked
	{
		 get { } //Length: 3
	}

	protected MapEditorData MapEditorData
	{
		 get { } //Length: 71
	}

	public int NumPoints
	{
		 get { } //Length: 60
	}

	protected bool SelectedModeIsMapEditor
	{
		 get { } //Length: 137
	}

	public SplineNode SelectedNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Spline Spline
	{
		 get { } //Length: 30
	}

	protected override PrefabReference SplinePrefab
	{
		 get { } //Length: 80
	}

	protected MapEditorSpriteShapeController() { }

	[CompilerGenerated]
	internal static Vector2 <GetClosestTrackSubNodeIndex>g__ToGroundVector2|116_0(Vector3 p) { }

	public override void Awake() { }

	protected void CancelAndRenewCancellationTokenSource() { }

	protected override bool CanPlaceNode(Vector2 position) { }

	public override void CheckFirstTimeEvents() { }

	private void CheckHoverState() { }

	private void CleanUpCanellationTokens() { }

	protected override void ConnectSplineNodeWithSpline(SplineNode splineDisplayNode, bool insertNode = false, bool isLoadingSave = false, bool overrideTangentSnapping = false) { }

	protected Vector3 ConvertScreenSpaceToWorld(Vector2 screenspace) { }

	[AsyncStateMachine(typeof(<CreateControlNode>d__86))]
	protected override Task<SplineNode> CreateControlNode(Vector3 anchorPos, CancellationToken ct, int index = -1, bool insertNode = false, PathNode nodeSaveData = null) { }

	public override void DeleteSegment() { }

	protected abstract void Draw() { }

	public override void EnterEditingMode(CancellationToken cancellationToken) { }

	public override void ExitEditingMode() { }

	protected override void ForceSplineRerender() { }

	public bool get_CanDeleteSelectedNode() { }

	[CompilerGenerated]
	public DraggableNode get_DraggedNode() { }

	public MapEditorSettings get_EditorSettings() { }

	protected static bool get_GameTypeIsMapEditor() { }

	[CompilerGenerated]
	public DraggableNode get_HighlightedNode() { }

	[CompilerGenerated]
	public bool get_InMovingMode() { }

	[CompilerGenerated]
	public bool get_InPlacementMode() { }

	[CompilerGenerated]
	public bool get_InSmoothCornersMode() { }

	[CompilerGenerated]
	public bool get_IsDragging() { }

	[CompilerGenerated]
	public bool get_IsMoveModeDagging() { }

	protected override bool get_IsPlacementBlocked() { }

	protected MapEditorData get_MapEditorData() { }

	public int get_NumPoints() { }

	protected bool get_SelectedModeIsMapEditor() { }

	[CompilerGenerated]
	public SplineNode get_SelectedNode() { }

	public Spline get_Spline() { }

	protected override PrefabReference get_SplinePrefab() { }

	private int GetClosestTrackSubNodeIndex() { }

	protected override SplineNode GetEntryNode() { }

	protected override object GetNodeMetaData(SplineNode node) { }

	public abstract List<PathNode> GetNodeSaveData() { }

	public Vector3 GetTangentPosition(Vector3 tangent3dPos, Vector3 currentAnchor2dPos, Vector3 previousAnchor2dPos) { }

	[AsyncStateMachine(typeof(<InitialiseSplineDisplayNode>d__87))]
	protected override Task<SplineNode> InitialiseSplineDisplayNode(Vector3 anchorPos, CancellationToken ct, int index = -1, PathNode nodeSaveData = null) { }

	[AsyncStateMachine(typeof(<InsertSegment>d__93))]
	public override Task InsertSegment(Vector3 pos, CancellationToken ct, int index = -1) { }

	public abstract Task LoadData(MapEditorSplineData data, CancellationToken ct, SpriteShapeReference spriteShapeOverride = null) { }

	public override void OnDestroy() { }

	protected void OnDraggableNodeHoverUpdate(DraggableNode draggableNode) { }

	private void OnExitMovingModeEvent() { }

	private void OnInputManagerCursorDownEvent(Vector2 cursorPositionWorld) { }

	private void OnInputManagerCursorUpEvent(Vector2 cursorPositionWorld) { }

	private void OnInputManagerCustomPlacementModeUpdatePlacerEvent(Vector2 cursorPositionWorld) { }

	private void OnInputManagerDragOutOfWorldEvent(Vector2 cursorPositionWorld) { }

	protected override void OnMovingModeCursorDownEventTriggered(Vector2 currentCursorPosition) { }

	protected override void OnMovingModeCursorUpEventTriggered(Vector2 currentCursorPosition) { }

	protected override void OnMovingModeDragOutOfWorldEventTriggered(Vector2 currentCursorPosition) { }

	protected override void OnMovingModeUpdatePlacerTriggered(Vector2 currentCursorPosition) { }

	private void OnQuitOrCancel() { }

	protected override void OnRemoveNodePropagateNodeSettings(object metadata) { }

	[AsyncStateMachine(typeof(<OnSceneHit>d__71))]
	public override void OnSceneHit(Vector2 position) { }

	[AsyncStateMachine(typeof(<OnSceneHitSpawnNodeTriggered>d__76))]
	protected override Task OnSceneHitSpawnNodeTriggered(Vector3 position, Vector2 position2d, CancellationToken ct) { }

	protected override void OnSplineChangedTriggered(MapEditorSpriteShapeController spline) { }

	private void OnToggleCustomPlacementModeCallback(bool isInCustomPlacementMode, Vector2 cursorPos) { }

	protected override void OnUpdateDraggingNode() { }

	protected override void OnUpdateSelectedNode(SplineNode node) { }

	protected override void ResetDragging() { }

	protected void RotateLeftTangentToPreviousNode(SplineNode splineNode) { }

	protected void RotateRightTangentToNextNode(SplineNode splineNode) { }

	[CompilerGenerated]
	public void set_DraggedNode(DraggableNode value) { }

	[CompilerGenerated]
	public void set_HighlightedNode(DraggableNode value) { }

	[CompilerGenerated]
	public void set_InMovingMode(bool value) { }

	[CompilerGenerated]
	protected void set_InPlacementMode(bool value) { }

	[CompilerGenerated]
	public void set_InSmoothCornersMode(bool value) { }

	[CompilerGenerated]
	public void set_IsDragging(bool value) { }

	[CompilerGenerated]
	private void set_IsMoveModeDagging(bool value) { }

	[CompilerGenerated]
	public void set_SelectedNode(SplineNode value) { }

	public abstract void SetSelected() { }

	public override void SetVisible(bool visible) { }

	public override void SetWorldSortingOrder(int sortingLayerOrder) { }

	protected Vector3 SplinePosToUnityWorld(Vector3 splinePos) { }

	protected void ToggleControlNodesVisibility(bool show) { }

	public bool TrySetSplinePosition(int index, Vector3 position) { }

	public override void TryToggleMovingMode() { }

	public override void TryToggleSharpCornersMode(bool sharpCornersMode) { }

	public override void Update() { }

}

