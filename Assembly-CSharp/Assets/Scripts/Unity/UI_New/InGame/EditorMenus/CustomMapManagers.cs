namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class CustomMapManagers
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<LayerData, Boolean> <>9__23_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnRemovableSoldTriggeredRerender>b__23_0(LayerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public MapEditorAreaData customArea; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal bool <OnAreasChangedRedrawTriggered>b__0(Area x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public MapEditorStampData stamp; //Field offset: 0x10

		public <>c__DisplayClass23_0() { }

		internal bool <OnRemovableSoldTriggeredRerender>b__1(LayerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public RemoveableTypeGroup removeableState; //Field offset: 0x10
		public LayerData assetLayerData; //Field offset: 0x14
		public Func<LayerData, Boolean> <>9__1; //Field offset: 0x20

		public <>c__DisplayClass31_0() { }

		internal bool <TryFindLayerDataMatch>b__0(MapEditorAreaData removableArea) { }

		internal bool <TryFindLayerDataMatch>b__1(LayerData layerId) { }

	}

	[CompilerGenerated]
	private struct <AsyncCleanUp>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapManagers <>4__this; //Field offset: 0x20
		private YieldAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Draw>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel customMapModel; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public CustomMapManagers <>4__this; //Field offset: 0x30
		public MapEditorSceneController controller; //Field offset: 0x38
		public Options options; //Field offset: 0x40
		public bool useRedrawLayerMask; //Field offset: 0x44
		private YieldAwaiter <>u__1; //Field offset: 0x45
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DrawInternal>d__14 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSceneController controller; //Field offset: 0x20
		public Options options; //Field offset: 0x28
		public CustomMapModel customMapModel; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public CustomMapManagers <>4__this; //Field offset: 0x40
		public bool useRedrawLayerMask; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private YieldAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <DrawPathAndAreaTasks>d__15 : IEnumerable<Task>, IEnumerable, IEnumerator<Task>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Task <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private Options options; //Field offset: 0x24
		public Options <>3__options; //Field offset: 0x28
		public CustomMapManagers <>4__this; //Field offset: 0x30
		private CustomMapModel customMapModel; //Field offset: 0x38
		public CustomMapModel <>3__customMapModel; //Field offset: 0x40
		private MapEditorSceneController controller; //Field offset: 0x48
		public MapEditorSceneController <>3__controller; //Field offset: 0x50
		private CancellationToken cancellationToken; //Field offset: 0x58
		public CancellationToken <>3__cancellationToken; //Field offset: 0x60

		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <DrawPathAndAreaTasks>d__15(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Task> System.Collections.Generic.IEnumerable<System.Threading.Tasks.Task>.GetEnumerator() { }

		[DebuggerHidden]
		private override Task System.Collections.Generic.IEnumerator<System.Threading.Tasks.Task>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <OnAreasChangedRedrawTriggered>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapManagers <>4__this; //Field offset: 0x28
		public List<Area> existingAreas; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRemovableSoldTriggeredRerender>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public List<CustomRemoveable> customRemovables; //Field offset: 0x28
		public CustomMapManagers <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnRestartCallback>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapManagers <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RerenderMap>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapManagers <>4__this; //Field offset: 0x20
		public CustomMapModel clonedCustomMapModel; //Field offset: 0x28
		public Options options; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnLoadComplete : MulticastDelegate
	{

		public OnLoadComplete(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnMapEditorSwitchingEditModes : MulticastDelegate
	{

		public OnMapEditorSwitchingEditModes(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isLoading, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isLoading) { }

	}

	[CompilerGenerated]
	private readonly CustomPathsManager <CustomPathsManager>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly CustomAreasManager <CustomAreasManager>k__BackingField; //Field offset: 0x18
	private bool isDrawing; //Field offset: 0x20

	public CustomAreasManager CustomAreasManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CustomPathsManager CustomPathsManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private static MapEditorData MapEditorData
	{
		private get { } //Length: 71
	}

	public CustomMapManagers() { }

	[AsyncStateMachine(typeof(<AsyncCleanUp>d__21))]
	private Task AsyncCleanUp() { }

	public void Destroy() { }

	[AsyncStateMachine(typeof(<Draw>d__13))]
	public Task Draw(CustomMapModel customMapModel, MapEditorSceneController controller, Options options, CancellationToken cancellationToken, bool useRedrawLayerMask = false) { }

	[AsyncStateMachine(typeof(<DrawInternal>d__14))]
	private Task DrawInternal(CustomMapModel customMapModel, MapEditorSceneController controller, Options options, CancellationToken cancellationToken = null, bool useRedrawLayerMask = false) { }

	[IteratorStateMachine(typeof(<DrawPathAndAreaTasks>d__15))]
	private IEnumerable<Task> DrawPathAndAreaTasks(CustomMapModel customMapModel, Options options, MapEditorSceneController controller, CancellationToken cancellationToken = null) { }

	public CustomMapModel GenerateSaveData() { }

	[CompilerGenerated]
	public CustomAreasManager get_CustomAreasManager() { }

	[CompilerGenerated]
	public CustomPathsManager get_CustomPathsManager() { }

	private static MapEditorData get_MapEditorData() { }

	public static List<T> GetAssetsToRenderExludingHidden(List<T> assetsToFilter, List<MapEditorAreaData> removableAreas, RemoveableTypeGroup removeableState) { }

	private static LayerData[] GetRemovableListFromState(MapEditorAreaData removableArea, RemoveableTypeGroup removeableState) { }

	private static bool IsHidden(MapEditorSplineData data) { }

	public bool IsMapEmpty() { }

	private static bool IsNotHidden(MapEditorSplineData data) { }

	public void LoadData() { }

	[AsyncStateMachine(typeof(<OnAreasChangedRedrawTriggered>d__22))]
	public void OnAreasChangedRedrawTriggered(List<Area> existingAreas) { }

	[AsyncStateMachine(typeof(<OnRemovableSoldTriggeredRerender>d__23))]
	public void OnRemovableSoldTriggeredRerender(List<CustomRemoveable> customRemovables) { }

	[AsyncStateMachine(typeof(<OnRestartCallback>d__20))]
	private void OnRestartCallback() { }

	public bool OnReturnToMenuCheckHasDataToSave() { }

	public void PostInitialised() { }

	private void ReAddListeners() { }

	[AsyncStateMachine(typeof(<RerenderMap>d__11))]
	private Task RerenderMap(CustomMapModel clonedCustomMapModel, Options options, CancellationToken cancellationToken) { }

	public void SaveData(CustomMapModel customMapSaveDataOverride = null) { }

	private static bool ShouldExcludeAsset(T assetToFilter, List<MapEditorAreaData> removableAreas, RemoveableTypeGroup removeableState, ref int categoryLayerId) { }

	private static bool TryFindLayerDataMatch(List<MapEditorAreaData> removableAreas, LayerData assetLayerData, RemoveableTypeGroup removeableState) { }

}

