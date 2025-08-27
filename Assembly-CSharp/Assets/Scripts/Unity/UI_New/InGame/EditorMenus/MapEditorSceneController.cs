namespace Assets.Scripts.Unity.UI_New.InGame.EditorMenus;

public class MapEditorSceneController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StampDisplay, MapEditorStampData> <>9__68_0; //Field offset: 0x8
		public static Func<PropToSimulation, Boolean> <>9__71_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal MapEditorStampData <GetStampData>b__68_0(StampDisplay x) { }

		internal bool <OnCreateScreenWideAmbientFxTriggered>b__71_0(PropToSimulation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public int layer; //Field offset: 0x10

		public <>c__DisplayClass39_0() { }

		internal bool <TryGetStampLayer>b__0(StampLayer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		private struct <<LoadStamp>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public AsyncOperationHandle<GameObject> h; //Field offset: 0x28
			public <>c__DisplayClass57_0 <>4__this; //Field offset: 0x40
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public StampDisplay stampDisplay; //Field offset: 0x10
		public MapEditorStampData stampData; //Field offset: 0x18
		public StampLayer layerData; //Field offset: 0x20
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x28

		public <>c__DisplayClass57_0() { }

		[AsyncStateMachine(typeof(<<LoadStamp>b__0>d))]
		internal void <LoadStamp>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		private struct <<CreateSmokeAndMirrorsStampDisplay>b__0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public AsyncOperationHandle<GameObject> h; //Field offset: 0x28
			public <>c__DisplayClass60_0 <>4__this; //Field offset: 0x40
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public MapEditorSceneController <>4__this; //Field offset: 0x10
		public MapEditorStampData stampData; //Field offset: 0x18
		public TaskCompletionSource<Boolean> tcs; //Field offset: 0x20

		public <>c__DisplayClass60_0() { }

		[AsyncStateMachine(typeof(<<CreateSmokeAndMirrorsStampDisplay>b__0>d))]
		internal void <CreateSmokeAndMirrorsStampDisplay>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private struct <CreateSmokeAndMirrorsStampDisplay>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSceneController <>4__this; //Field offset: 0x20
		public MapEditorStampData stampData; //Field offset: 0x28
		private <>c__DisplayClass60_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateStamp>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StampDisplay> <>t__builder; //Field offset: 0x8
		public MapEditorSceneController <>4__this; //Field offset: 0x20
		public MapEditorStampData stampData; //Field offset: 0x28
		private TaskAwaiter<StampDisplay> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetStampData>d__68 : IEnumerable<MapEditorStampData>, IEnumerable, IEnumerator<MapEditorStampData>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private MapEditorStampData <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MapEditorSceneController <>4__this; //Field offset: 0x28
		private Enumerator<StampLayer> <>7__wrap1; //Field offset: 0x30
		private IEnumerator<MapEditorStampData> <>7__wrap2; //Field offset: 0x48

		private override MapEditorStampData System.Collections.Generic.IEnumerator<Assets.Scripts.Models.ContentBrowser.MapEditorStampData>.Current
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
		public <GetStampData>d__68(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<MapEditorStampData> System.Collections.Generic.IEnumerable<Assets.Scripts.Models.ContentBrowser.MapEditorStampData>.GetEnumerator() { }

		[DebuggerHidden]
		private override MapEditorStampData System.Collections.Generic.IEnumerator<Assets.Scripts.Models.ContentBrowser.MapEditorStampData>.get_Current() { }

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
	private struct <Initialise>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSceneController <>4__this; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMapTexture>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel customMapModel; //Field offset: 0x20
		public MapEditorSceneController <>4__this; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadStamp>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<StampDisplay> <>t__builder; //Field offset: 0x8
		public MapEditorStampData stampData; //Field offset: 0x20
		public StampLayer layerData; //Field offset: 0x28
		private <>c__DisplayClass57_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadStamps>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CustomMapModel customMapModel; //Field offset: 0x20
		public MapEditorSceneController <>4__this; //Field offset: 0x28
		private TaskAwaiter<StampDisplay[]> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCreateSmokeAndMirrorsStampTriggered>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object metadata; //Field offset: 0x28
		public MapEditorSceneController <>4__this; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnCreateStampTriggered>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public object metadata; //Field offset: 0x28
		public MapEditorSceneController <>4__this; //Field offset: 0x30
		private MapEditorStampData <stampData>5__2; //Field offset: 0x38
		private TaskAwaiter<StampDisplay> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetBaseMaterial>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSceneController <>4__this; //Field offset: 0x20
		public MaterialReference materialReference; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter<Material> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetBaseTexture>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorSceneController <>4__this; //Field offset: 0x20
		public MapTextureModel textureData; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SwapSmokeAndMirrorsStampDisplay>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorStampData stampData; //Field offset: 0x20
		public MapEditorSceneController <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnCreateScreenWideAmbientFx : MulticastDelegate
	{

		public OnCreateScreenWideAmbientFx(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(PropModel model, bool removeEffect, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(PropModel model, bool removeEffect) { }

	}

	internal sealed class OnEndEraserEvent : MulticastDelegate
	{

		public OnEndEraserEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnEndIconPlacementEvent : MulticastDelegate
	{

		public OnEndIconPlacementEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnSetSmokeAndMirrorsGraphicRotation : MulticastDelegate
	{

		public OnSetSmokeAndMirrorsGraphicRotation(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector3 rotation, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector3 rotation) { }

	}

	internal sealed class OnStampErasedEvent : MulticastDelegate
	{

		public OnStampErasedEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnStartEraserEvent : MulticastDelegate
	{

		public OnStartEraserEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Sprite sprite, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Sprite sprite) { }

	}

	internal sealed class OnStartIconPlacementEvent : MulticastDelegate
	{

		public OnStartIconPlacementEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CustomMapItemPurchaseButton rotation, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(CustomMapItemPurchaseButton rotation) { }

	}

	internal sealed class OnUpdateEraserEvent : MulticastDelegate
	{

		public OnUpdateEraserEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnUpdateIconPlacementEvent : MulticastDelegate
	{

		public OnUpdateIconPlacementEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector2 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 position) { }

	}

	internal sealed class OnUpdateTargetReticulePlacementEvent : MulticastDelegate
	{

		public OnUpdateTargetReticulePlacementEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Vector3 position, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector3 position) { }

	}

	private class StampLayer
	{
		public GameObject layerObj; //Field offset: 0x10
		public List<StampDisplay> stampsList; //Field offset: 0x18
		public int stampLayerId; //Field offset: 0x20

		public StampLayer() { }

	}

	private GameObject environmentLayer; //Field offset: 0x20
	private GameObject propsLayer; //Field offset: 0x28
	private GameObject stampsLayer; //Field offset: 0x30
	private GameObject areasLayer; //Field offset: 0x38
	private GameObject pathsLayer; //Field offset: 0x40
	private GameObject stampLayerPrefab; //Field offset: 0x48
	private MeshRenderer baseTerrainMesh; //Field offset: 0x50
	private PathSelectNodes pathSelectNodes; //Field offset: 0x58
	private GameObject targetReticle; //Field offset: 0x60
	private Animator targetReticleAnim; //Field offset: 0x68
	private StampDisplay smokeAndMirrorsStamp; //Field offset: 0x70
	[CompilerGenerated]
	private int <BaseMapTextureId>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private string <MusicTrack>k__BackingField; //Field offset: 0x80
	private List<StampLayer> stampLayers; //Field offset: 0x88
	private Texture snapShot; //Field offset: 0x90
	private AsyncOperationHandle<Material> terrainMaterialHandle; //Field offset: 0x98

	public Transform AreasLayer
	{
		 get { } //Length: 29
	}

	public private int BaseMapTextureId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string MusicTrack
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public PathSelectNodes PathSelectNodes
	{
		 get { } //Length: 5
	}

	public Transform PathsLayer
	{
		 get { } //Length: 29
	}

	public MapEditorSceneController() { }

	[CompilerGenerated]
	private void <Initialise>b__42_0(AsyncOperationHandle<GameObject> h) { }

	private StampLayer AddStampLayer(MapEditorStampData stampData) { }

	private void Awake() { }

	public void Bake(bool useRedrawLayerMask = false) { }

	public void CleanUp() { }

	private void ClosePropSelectionTriggered() { }

	private MeshRenderer CreateBakedMeshRenderer(float width, float height) { }

	private static Mesh CreateQuad(float w, float h) { }

	[AsyncStateMachine(typeof(<CreateSmokeAndMirrorsStampDisplay>d__60))]
	private Task CreateSmokeAndMirrorsStampDisplay(MapEditorStampData stampData) { }

	[AsyncStateMachine(typeof(<CreateStamp>d__56))]
	private Task<StampDisplay> CreateStamp(MapEditorStampData stampData) { }

	public void DestroyStamps() { }

	public void DestroyTerrain() { }

	private GameObject FindOrCreateNewObjectContainer(string name, Transform transfom = null) { }

	public Transform get_AreasLayer() { }

	[CompilerGenerated]
	public int get_BaseMapTextureId() { }

	[CompilerGenerated]
	public string get_MusicTrack() { }

	public PathSelectNodes get_PathSelectNodes() { }

	public Transform get_PathsLayer() { }

	private int GetOrderInLayer(MapEditorStampData stampData) { }

	public int GetStampCount() { }

	[IteratorStateMachine(typeof(<GetStampData>d__68))]
	public IEnumerable<MapEditorStampData> GetStampData() { }

	public bool HasAnyStampData() { }

	[AsyncStateMachine(typeof(<Initialise>d__42))]
	public void Initialise() { }

	[AsyncStateMachine(typeof(<LoadMapTexture>d__48))]
	public Task LoadMapTexture(CustomMapModel customMapModel, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<LoadStamp>d__57))]
	private Task<StampDisplay> LoadStamp(StampLayer layerData, MapEditorStampData stampData) { }

	[AsyncStateMachine(typeof(<LoadStamps>d__49))]
	public Task LoadStamps(CustomMapModel customMapModel) { }

	public void OnClickEraseStamps(Vector2 screenPosition) { }

	private void OnCreateScreenWideAmbientFxTriggered(PropModel model, bool removeEffect) { }

	[AsyncStateMachine(typeof(<OnCreateSmokeAndMirrorsStampTriggered>d__75))]
	private void OnCreateSmokeAndMirrorsStampTriggered(object metadata) { }

	[AsyncStateMachine(typeof(<OnCreateStampTriggered>d__79))]
	private void OnCreateStampTriggered(object metadata) { }

	private void OnDestroy() { }

	private void OnDestroySmokeAndMirrorsStampTriggered() { }

	public void OnEndEraser() { }

	public void OnEndIconPlacement() { }

	private void OnSetSmokeAndMirrorsGraphicRotationCallback(Vector3 rotation) { }

	public void OnStartEraser(Sprite sprite) { }

	public void OnStartIconPlacement(CustomMapItemPurchaseButton button) { }

	private void OnToggleStampLayerTriggered(StampLayerButton stampLayerBtn) { }

	public void OnUpdateEraser(Vector2 screenPosition) { }

	public void OnUpdateIconPlacer(Vector2 pos) { }

	private void OnUpdateSmokeAndMirrorsStampTriggered(Vector2 position, bool showGhost) { }

	private void OnUpdateTargetReticulePlacementEventTriggered(Vector3 position) { }

	private void RemoveStamp(int layer, StampDisplay stamp) { }

	private void RemoveStampLayer(int layer) { }

	private void ReorderStampLayerSorting(int layerIndex, int baseSortingLayer) { }

	public void ResetAllData() { }

	[CompilerGenerated]
	private void set_BaseMapTextureId(int value) { }

	[CompilerGenerated]
	public void set_MusicTrack(string value) { }

	[AsyncStateMachine(typeof(<SetBaseMaterial>d__47))]
	private Task SetBaseMaterial(MaterialReference materialReference, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(<SetBaseTexture>d__46))]
	public Task SetBaseTexture(MapTextureModel textureData, CancellationToken cancellationToken) { }

	public void SetMapMusic(string musicTrack) { }

	public void SetupScene(bool forceRedraw = false) { }

	[AsyncStateMachine(typeof(<SwapSmokeAndMirrorsStampDisplay>d__58))]
	private Task SwapSmokeAndMirrorsStampDisplay(MapEditorStampData stampData) { }

	public void SwitchChildLayerMasks(bool temporaryRenderLayer) { }

	private static Texture TakeSnapshot(int width, float aspectRatio, float orthographicSize, bool useRedrawLayerMask = false) { }

	private void ToggleTargetReticle(bool show, PropToSimulation prop = null) { }

	private bool TryGetStampLayer(int layer, out StampLayer layerData) { }

	private static int WidthForBake(float aspectRatio, float scaleFactor = 1) { }

}

