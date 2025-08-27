namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorArea : MapEditorSpriteShapeController
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public CancellationToken ct; //Field offset: 0x10
		public int index; //Field offset: 0x18
		public MapEditorArea <>4__this; //Field offset: 0x20
		public Vector3 anchorPos; //Field offset: 0x28
		public PathNode nodeSaveData; //Field offset: 0x38

		public <>c__DisplayClass26_0() { }

		internal void <SpawnDefaultNodeController>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <CreateDefaultAreaOnPoint>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorArea <>4__this; //Field offset: 0x20
		public Vector2 pos2d; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x30
		public AreaTextureModel textureData; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadData>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorArea <>4__this; //Field offset: 0x20
		public MapEditorSplineData saveData; //Field offset: 0x28
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x30
		public CancellationToken ct; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private Enumerator<PathNode> <>7__wrap1; //Field offset: 0x48
		private TaskAwaiter<SplineNode> <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetSpriteShape>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorArea <>4__this; //Field offset: 0x20
		public SpriteShapeReference spriteShapeReference; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x30
		private TaskAwaiter<SpriteShape> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetTexture>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorArea <>4__this; //Field offset: 0x20
		public AreaTextureModel areaTextureModel; //Field offset: 0x28
		public CancellationToken ct; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnDefaultNodeController>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken ct; //Field offset: 0x20
		public int index; //Field offset: 0x28
		public MapEditorArea <>4__this; //Field offset: 0x30
		public Vector3 anchorPos; //Field offset: 0x38
		public PathNode nodeSaveData; //Field offset: 0x48
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnAreaSelected : MulticastDelegate
	{

		public OnAreaSelected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MapEditorArea area, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MapEditorArea area) { }

	}

	private const float DEFAULT_BOARD_DEADZONE_WIDTH = 25; //Field offset: 0x0
	private AreaTextureModel areaTextureModel; //Field offset: 0xA8
	[CompilerGenerated]
	private MapEditorAreaData <AreaSaveData>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private RemovableAreaData <RemoveableAreaData>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <InRemovableEditMode>k__BackingField; //Field offset: 0xD8
	private AsyncOperationHandle<SpriteShape> spriteShapeHandle; //Field offset: 0xE0

	public private MapEditorAreaData AreaSaveData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public AreaData Def
	{
		 get { } //Length: 97
	}

	public bool InRemovableEditMode
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	protected virtual bool IsPlacementBlocked
	{
		 get { } //Length: 8
	}

	public bool IsRemovableArea
	{
		 get { } //Length: 33
	}

	public private RemovableAreaData RemoveableAreaData
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public MapEditorArea() { }

	[AsyncStateMachine(typeof(<CreateDefaultAreaOnPoint>d__25))]
	public Task CreateDefaultAreaOnPoint(Vector2 pos2d, CancellationToken ct, AreaTextureModel textureData = null) { }

	protected virtual void Draw() { }

	public virtual void EnterEditingMode(CancellationToken cancellationToken) { }

	public virtual void ExitEditingMode() { }

	[CompilerGenerated]
	public MapEditorAreaData get_AreaSaveData() { }

	public AreaData get_Def() { }

	[CompilerGenerated]
	public bool get_InRemovableEditMode() { }

	protected virtual bool get_IsPlacementBlocked() { }

	public bool get_IsRemovableArea() { }

	[CompilerGenerated]
	public RemovableAreaData get_RemoveableAreaData() { }

	public virtual List<PathNode> GetNodeSaveData() { }

	[AsyncStateMachine(typeof(<LoadData>d__28))]
	public virtual Task LoadData(MapEditorSplineData saveData, CancellationToken ct, SpriteShapeReference spriteShapeOverride = null) { }

	public virtual void OnDestroy() { }

	protected virtual Task OnSceneHitSpawnNodeTriggered(Vector3 position, Vector2 position2d, CancellationToken ct) { }

	[CompilerGenerated]
	private void set_AreaSaveData(MapEditorAreaData value) { }

	[CompilerGenerated]
	public void set_InRemovableEditMode(bool value) { }

	[CompilerGenerated]
	private void set_RemoveableAreaData(RemovableAreaData value) { }

	public void SetRemovableAreaData(RemovableAreaData data) { }

	public virtual void SetSelected() { }

	[AsyncStateMachine(typeof(<SetSpriteShape>d__32))]
	public Task SetSpriteShape(SpriteShapeReference spriteShapeReference, CancellationToken ct) { }

	[AsyncStateMachine(typeof(<SetTexture>d__31))]
	public Task SetTexture(AreaTextureModel areaTextureModel, CancellationToken ct) { }

	public virtual void SetWorldSortingOrder(int sortingLayerOrder) { }

	[AsyncStateMachine(typeof(<SpawnDefaultNodeController>d__26))]
	protected override Task SpawnDefaultNodeController(Vector3 anchorPos, CancellationToken ct, int index = -1, bool insertNode = false, PathNode nodeSaveData = null) { }

	public void TryToggleRemoveableEditMode(bool enterRemoveableMode) { }

	public virtual void TryToggleSharpCornersMode(bool sharpCornersMode) { }

}

