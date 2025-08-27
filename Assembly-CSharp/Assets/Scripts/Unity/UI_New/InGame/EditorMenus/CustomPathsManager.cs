namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class CustomPathsManager : CustomEditorManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		private struct <<CreatePath>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass18_0 <>4__this; //Field offset: 0x28
			public AsyncOperationHandle<GameObject> h; //Field offset: 0x30
			private MapEditorPath <editor>5__2; //Field offset: 0x48
			private TaskAwaiter <>u__1; //Field offset: 0x50

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public CancellationToken cancellationToken; //Field offset: 0x10
		public CustomPathsManager <>4__this; //Field offset: 0x18
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x20
		public MapEditorSceneController sceneController; //Field offset: 0x28
		public MapEditorPathData pathData; //Field offset: 0x30
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x38
		public bool isNewPath; //Field offset: 0x40
		public Vector2 screenSpacePosition; //Field offset: 0x44
		public TrackTextureModel trackTrextureModel; //Field offset: 0x50

		public <>c__DisplayClass18_0() { }

		[AsyncStateMachine(typeof(<<CreatePath>b__0>d))]
		internal void <CreatePath>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <CreatePath>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public CustomPathsManager <>4__this; //Field offset: 0x28
		public MapEditorSceneController sceneController; //Field offset: 0x30
		public MapEditorPathData pathData; //Field offset: 0x38
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x40
		public bool isNewPath; //Field offset: 0x48
		public Vector2 screenSpacePosition; //Field offset: 0x4C
		public TrackTextureModel trackTrextureModel; //Field offset: 0x58
		private <>c__DisplayClass18_0 <>8__1; //Field offset: 0x60
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x68
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPaths>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public IEnumerable<MapEditorPathData> data; //Field offset: 0x20
		public CustomPathsManager <>4__this; //Field offset: 0x28
		public MapEditorSceneController controller; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public SpriteShapeReference spriteShapeOverride; //Field offset: 0x40
		private IEnumerator<MapEditorPathData> <>7__wrap1; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleEditingMode>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isEditing; //Field offset: 0x20
		public CustomPathsManager <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnGetCustomPathsManagerEvent : MulticastDelegate
	{

		public OnGetCustomPathsManagerEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override CustomPathsManager EndInvoke(IAsyncResult result) { }

		public override CustomPathsManager Invoke() { }

	}

	internal sealed class OnGetPathSettingsEvent : MulticastDelegate
	{

		public OnGetPathSettingsEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override MapEditorSettingsData EndInvoke(IAsyncResult result) { }

		public override MapEditorSettingsData Invoke() { }

	}

	internal sealed class OnUpdatePathSettingsEvent : MulticastDelegate
	{

		public OnUpdatePathSettingsEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool addedColumn, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool addedColumn) { }

	}

	private readonly List<MapEditorPath> paths; //Field offset: 0x10
	private MapEditorSettingsData mapEditorSettingsData; //Field offset: 0x18
	[CompilerGenerated]
	private MapEditorPath <SelectedEditor>k__BackingField; //Field offset: 0x20

	public bool InPlacementMode
	{
		 get { } //Length: 15
	}

	public List<MapEditorPath> Paths
	{
		 get { } //Length: 5
	}

	public private MapEditorPath SelectedEditor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public CustomPathsManager() { }

	public void CheckForInvalidPathNotifications() { }

	[AsyncStateMachine(typeof(<CreatePath>d__18))]
	public Task CreatePath(MapEditorPathData pathData, MapEditorSceneController sceneController, Vector2 screenSpacePosition, CancellationToken cancellationToken, bool isNewPath = false, TrackTextureModel trackTrextureModel = null, SpriteShapeReference spriteShapeOverride = null) { }

	public virtual void DeleteSelectedEditor() { }

	public void Destroy() { }

	public bool get_InPlacementMode() { }

	public List<MapEditorPath> get_Paths() { }

	[CompilerGenerated]
	public MapEditorPath get_SelectedEditor() { }

	public void LoadPathPatternSettings(CustomMapModel customMapData) { }

	[AsyncStateMachine(typeof(<LoadPaths>d__17))]
	public Task LoadPaths(IEnumerable<MapEditorPathData> data, MapEditorSceneController controller, CancellationToken cancellationToken, SpriteShapeReference spriteShapeOverride = null) { }

	public CustomPathsManager OnGetCustomPathsManagerEventTriggered() { }

	public MapEditorSettingsData OnGetMapEditorSettingsEventTriggered() { }

	public virtual void OnMapCleared() { }

	public void OnUpdateMapEditorSettingsEventTriggered(bool addedColumn) { }

	private void PathSeqenceValidationChecks() { }

	[CompilerGenerated]
	private void set_SelectedEditor(MapEditorPath value) { }

	private void SetSelectedEditor(MapEditorPath path) { }

	[AsyncStateMachine(typeof(<ToggleEditingMode>d__16))]
	public virtual Task ToggleEditingMode(bool isEditing, MapEditorSceneController controller, CancellationToken cancellationToken) { }

}

