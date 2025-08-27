namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class CustomAreasManager : CustomEditorManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		private struct <<CreateArea>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass24_0 <>4__this; //Field offset: 0x28
			public AsyncOperationHandle<GameObject> h; //Field offset: 0x30
			private MapEditorArea <editor>5__2; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CancellationToken cancellationTokenToLink; //Field offset: 0x10
		public CustomAreasManager <>4__this; //Field offset: 0x18
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x20
		public Vector2 screenSpacePosition; //Field offset: 0x28
		public AreaTextureModel textureModel; //Field offset: 0x30
		public MapEditorAreaData data; //Field offset: 0x38
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x40

		public <>c__DisplayClass24_0() { }

		[AsyncStateMachine(typeof(<<CreateArea>b__0>d))]
		internal void <CreateArea>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <CreateArea>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationTokenToLink; //Field offset: 0x20
		public CustomAreasManager <>4__this; //Field offset: 0x28
		public Vector2 screenSpacePosition; //Field offset: 0x30
		public AreaTextureModel textureModel; //Field offset: 0x38
		public MapEditorAreaData data; //Field offset: 0x40
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x48
		public MapEditorSceneController sceneController; //Field offset: 0x50
		private <>c__DisplayClass24_0 <>8__1; //Field offset: 0x58
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x60
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAreas>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<MapEditorAreaData> data; //Field offset: 0x20
		public CustomAreasManager <>4__this; //Field offset: 0x28
		public MapEditorSceneController controller; //Field offset: 0x30
		public CancellationToken cancellationTokenToLink; //Field offset: 0x38
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x40
		private IEnumerator<MapEditorAreaData> <>7__wrap1; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleEditingMode>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isEditing; //Field offset: 0x20
		public CustomAreasManager <>4__this; //Field offset: 0x28
		public MapEditorSceneController controller; //Field offset: 0x30
		public CancellationToken cancellationTokenToLink; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly List<MapEditorArea> areas; //Field offset: 0x10
	[CompilerGenerated]
	private MapEditorArea <SelectedEditor>k__BackingField; //Field offset: 0x18

	public List<MapEditorArea> Areas
	{
		 get { } //Length: 5
	}

	public bool InMovingMode
	{
		 get { } //Length: 15
	}

	public bool InPlacementMode
	{
		 get { } //Length: 15
	}

	public bool InRemovableEditMode
	{
		 get { } //Length: 18
	}

	public bool InSmoothCornersMode
	{
		 get { } //Length: 15
	}

	public private MapEditorArea SelectedEditor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public CustomAreasManager() { }

	[AsyncStateMachine(typeof(<CreateArea>d__24))]
	public Task CreateArea(MapEditorAreaData data, MapEditorSceneController sceneController, Vector2 screenSpacePosition, CancellationToken cancellationTokenToLink, AreaTextureModel textureModel = null, SpriteShapeReference spriteShapeOverride = null) { }

	public virtual void DeleteSelectedEditor() { }

	public void Destroy() { }

	public List<MapEditorArea> get_Areas() { }

	public bool get_InMovingMode() { }

	public bool get_InPlacementMode() { }

	public bool get_InRemovableEditMode() { }

	public bool get_InSmoothCornersMode() { }

	[CompilerGenerated]
	public MapEditorArea get_SelectedEditor() { }

	[AsyncStateMachine(typeof(<LoadAreas>d__22))]
	public Task LoadAreas(IEnumerable<MapEditorAreaData> data, MapEditorSceneController controller, CancellationToken cancellationTokenToLink, SpriteShapeReference spriteShapeOverride = null) { }

	public virtual void OnMapCleared() { }

	[CompilerGenerated]
	private void set_SelectedEditor(MapEditorArea value) { }

	private void SetSelectedEditor(MapEditorArea area) { }

	[AsyncStateMachine(typeof(<ToggleEditingMode>d__18))]
	public virtual Task ToggleEditingMode(bool isEditing, MapEditorSceneController controller, CancellationToken cancellationTokenToLink) { }

	public void TryToggleMoveingMode() { }

	public void TryToggleRemoveableEditMode(bool enterRemoveableMode) { }

	public void TryToggleSharpCornersMode(bool sharpCornersMode) { }

}

