namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorPath : MapEditorSpriteShapeController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<SplineNode> <>9__31_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <TryGetPathExitNode>b__31_0(SplineNode x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass30_0() { }

		internal bool <TryGetPathNode>b__0(SplineNode x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass76_0() { }

		internal bool <GetPathNode>b__0(SplineNode x) { }

	}

	[CompilerGenerated]
	private struct <AsyncInitialise>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public IEnumerable<StartEndNode> eeNodes; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateControlNode>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SplineNode> <>t__builder; //Field offset: 0x8
		public PathNode nodeSaveData; //Field offset: 0x20
		public MapEditorPath <>4__this; //Field offset: 0x28
		public Vector3 anchorPos; //Field offset: 0x30
		public CancellationToken ct; //Field offset: 0x40
		public int index; //Field offset: 0x48
		public bool insertNode; //Field offset: 0x4C
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter<SplineNode> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateStandbyPathEndNode>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public CancellationToken ct; //Field offset: 0x28
		private TaskAwaiter<SplineNode> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadData>d__81 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public MapEditorSplineData saveData; //Field offset: 0x28
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x30
		public CancellationToken ct; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private Enumerator<PathNode> <>7__wrap1; //Field offset: 0x48
		private PathNode <nodeSaveData>5__3; //Field offset: 0x60
		private TaskAwaiter<SplineNode> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnSceneHitSpawnNodeTriggered>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public Vector3 position; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter<SplineNode> <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetSpriteShape>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public SpriteShapeReference spriteShapeReference; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x30
		private TaskAwaiter<SpriteShape> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetTexture>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public TrackTextureModel trackTextureModel; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnDefaultTrackStart>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorPath <>4__this; //Field offset: 0x20
		public Vector3 anchorPos; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x38
		public TrackTextureModel trackTextureModel; //Field offset: 0x40
		private TaskAwaiter<SplineNode> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnPathSelected : MulticastDelegate
	{

		public OnPathSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapEditorPath path, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapEditorPath path) { }

	}

	private const float START_NODE_INDEX = 1; //Field offset: 0x0
	[CompilerGenerated]
	private MapEditorPathData <PathSaveData>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private PathSplineNode <DraggedPathNode>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private PathSplineNode <SelectedPathNode>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private float <PathLength>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private bool <IsDraggingPathNode>k__BackingField; //Field offset: 0xC4
	private IEnumerable<StartEndNode> OffScreenEntryExitNodes; //Field offset: 0xC8
	private StartEndNode offscreenEntryPoint; //Field offset: 0xD0
	private StartEndNode offscreenExitPoint; //Field offset: 0xD8
	private PathExitSplineNode standbyExitNode; //Field offset: 0xE0
	private AsyncOperationHandle<SpriteShape> spriteShapeHandle; //Field offset: 0xE8

	public PathSplineNode DraggedPathNode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public bool IsDraggingPathNode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsEntryNodeSelected
	{
		 get { } //Length: 64
	}

	public bool IsExitNodeSelected
	{
		 get { } //Length: 83
	}

	public bool IsPathLongEnough
	{
		 get { } //Length: 51
	}

	public bool IsValid
	{
		 get { } //Length: 323
	}

	private float MinPathLength
	{
		private get { } //Length: 31
	}

	public private float PathLength
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float PathLengthScale
	{
		 get { } //Length: 106
	}

	public private MapEditorPathData PathSaveData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public PathSplineNode SelectedPathNode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	protected virtual PrefabReference SplinePrefab
	{
		 get { } //Length: 30
	}

	private bool UserHasPlacedSomeNodes
	{
		private get { } //Length: 22
	}

	public MapEditorPath() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task<SplineNode> <>n__0(Vector3 anchorPos, CancellationToken ct, int index, bool insertNode, PathNode nodeSaveData) { }

	[AsyncStateMachine(typeof(<AsyncInitialise>d__42))]
	public Task AsyncInitialise(IEnumerable<StartEndNode> eeNodes, CancellationToken cancellationToken) { }

	private void AttemptToConnectPlacedNodeWithExitNode(PathSplineNode selectedNode) { }

	public virtual void Awake() { }

	public virtual void CheckFirstTimeEvents() { }

	private bool CheckForConnectionWithOffscreenEntryExitPoint(PathSplineNode selectedNode, ref StartEndNode node) { }

	private void ConnectExitNodeToSpline(PathNode nodeSaveData = null) { }

	[AsyncStateMachine(typeof(<CreateControlNode>d__45))]
	protected virtual Task<SplineNode> CreateControlNode(Vector3 anchorPos, CancellationToken ct, int index = -1, bool insertNode = false, PathNode nodeSaveData = null) { }

	[AsyncStateMachine(typeof(<CreateStandbyPathEndNode>d__62))]
	private Task CreateStandbyPathEndNode(CancellationToken ct) { }

	private void DisconnectExitNode() { }

	protected virtual void Draw() { }

	public virtual void ExitEditingMode() { }

	private StartEndNode FindClosestUnusedOffscreenNode(Vector3 anchorPos, StartEndNode currentNode = null) { }

	public MapEditorPathData GenerateSaveData() { }

	[CompilerGenerated]
	public PathSplineNode get_DraggedPathNode() { }

	[CompilerGenerated]
	public bool get_IsDraggingPathNode() { }

	public bool get_IsEntryNodeSelected() { }

	public bool get_IsExitNodeSelected() { }

	public bool get_IsPathLongEnough() { }

	public bool get_IsValid() { }

	private float get_MinPathLength() { }

	[CompilerGenerated]
	public float get_PathLength() { }

	public float get_PathLengthScale() { }

	[CompilerGenerated]
	public MapEditorPathData get_PathSaveData() { }

	[CompilerGenerated]
	public PathSplineNode get_SelectedPathNode() { }

	protected virtual PrefabReference get_SplinePrefab() { }

	private bool get_UserHasPlacedSomeNodes() { }

	protected virtual SplineNode GetEntryNode() { }

	protected virtual object GetNodeMetaData(SplineNode node) { }

	public virtual List<PathNode> GetNodeSaveData() { }

	public PathSplineNode GetPathNode(int index) { }

	private bool IsDraggingLastOnScreenPathNode() { }

	public bool IsNodeOutsideOfBoarder(Vector2 position) { }

	private bool IsOffscreenEntryExitNodeNullOrUsed(StartEndNode offscreenNode) { }

	[AsyncStateMachine(typeof(<LoadData>d__81))]
	public virtual Task LoadData(MapEditorSplineData saveData, CancellationToken ct, SpriteShapeReference spriteShapeOverride = null) { }

	private void OnDeleteSplineNodeEventTriggered() { }

	public virtual void OnDestroy() { }

	protected virtual void OnRemoveNodePropagateNodeSettings(object metadata) { }

	[AsyncStateMachine(typeof(<OnSceneHitSpawnNodeTriggered>d__49))]
	protected virtual Task OnSceneHitSpawnNodeTriggered(Vector3 position, Vector2 position2d, CancellationToken ct) { }

	protected virtual void OnSplineChangedTriggered(MapEditorSpriteShapeController spline) { }

	protected virtual void OnUpdateSelectedNode(SplineNode node) { }

	private void PropagateNodeSetting(PathSettingType settingsType, bool isEnabled) { }

	protected virtual void ResetDragging() { }

	[CompilerGenerated]
	public void set_DraggedPathNode(PathSplineNode value) { }

	[CompilerGenerated]
	public void set_IsDraggingPathNode(bool value) { }

	[CompilerGenerated]
	private void set_PathLength(float value) { }

	[CompilerGenerated]
	private void set_PathSaveData(MapEditorPathData value) { }

	[CompilerGenerated]
	public void set_SelectedPathNode(PathSplineNode value) { }

	public void SetPathSettings(PathSettingType settingsType, bool isEnabled) { }

	public void SetPathWidth(int pathWidth = 0) { }

	public virtual void SetSelected() { }

	private static void SetSplineWidth(Spline spline, int pathWidth) { }

	[AsyncStateMachine(typeof(<SetSpriteShape>d__69))]
	public Task SetSpriteShape(SpriteShapeReference spriteShapeReference, CancellationToken ct) { }

	[AsyncStateMachine(typeof(<SetTexture>d__68))]
	public Task SetTexture(TrackTextureModel trackTextureModel, CancellationToken ct) { }

	public virtual void SetWorldSortingOrder(int sortingLayerOrder) { }

	[AsyncStateMachine(typeof(<SpawnDefaultTrackStart>d__50))]
	public Task SpawnDefaultTrackStart(Vector3 anchorPos, TrackTextureModel trackTextureModel, CancellationToken ct) { }

	private void TryConnectWithOffscreenEntryExitPoint(PathSplineNode selectedNode) { }

	public bool TryGetPathExitNode(out PathSplineNode node) { }

	public bool TryGetPathNode(int index, out PathSplineNode node) { }

	private void UpdateEntryNodeConnection() { }

	protected void UpdateEstimatedPathLength() { }

	private void UpdateExitNodeConnection() { }

}

