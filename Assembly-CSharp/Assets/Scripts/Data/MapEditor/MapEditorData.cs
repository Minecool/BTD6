namespace Assets.Scripts.Data.MapEditor;

public class MapEditorData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<MapEditorProp, Task> <>9__58_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Task <LoadMapEditorDataAsync>b__58_0(MapEditorProp prop) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass59_0() { }

		internal bool <TryGetMapEditorProp>b__0(MapEditorProp x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass60_0() { }

		internal bool <TryGetMapEditorStampData>b__0(MapEditorStampData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal bool <TryGetMapEditorAreaTextureData>b__0(MapEditorAreaTextureData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <TryGetMapEditorTrackTextureData>b__0(MapEditorTrackTextureData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal bool <TryGetMapEditorBaseMapTextureData>b__0(MapEditorBaseMapTextureData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public MapEditorItem item; //Field offset: 0x10

		public <>c__DisplayClass67_0() { }

		internal bool <GetItemById>b__0(MapEditorProp x) { }

		internal bool <GetItemById>b__1(MapEditorStampData x) { }

		internal bool <GetItemById>b__2(MapEditorAreaTextureData x) { }

		internal bool <GetItemById>b__3(MapEditorTrackTextureData x) { }

		internal bool <GetItemById>b__4(MapEditorBaseMapTextureData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public MapEditorItem item; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <GetGroupVarientCount>b__0(MapEditorProp x) { }

		internal bool <GetGroupVarientCount>b__1(MapEditorStampData x) { }

		internal bool <GetGroupVarientCount>b__2(MapEditorAreaTextureData x) { }

		internal bool <GetGroupVarientCount>b__3(MapEditorTrackTextureData x) { }

		internal bool <GetGroupVarientCount>b__4(MapEditorBaseMapTextureData x) { }

	}

	[CompilerGenerated]
	private struct <LoadMapEditorDataAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapEditorData <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const int MAX_AREA_NODES = 25; //Field offset: 0x0
	public const float MIN_TANGENT_DISTANCE = 10; //Field offset: 0x0
	public const float MAX_TANGENT_DISTANCE = 100; //Field offset: 0x0
	public const float MAP_BOARDER_ENTRY_EXIT_DISTANCE = 23; //Field offset: 0x0
	public const float MIN_PATH_MOAB_SIZE_SCALE = 0; //Field offset: 0x0
	public const int MAX_PATH_NODES = 25; //Field offset: 0x0
	public const int MAX_AREA_LAYERS = 10; //Field offset: 0x0
	public const int MAX_STAMP_LAYERS = 10; //Field offset: 0x0
	public const int MAX_PATH_LAYERS = 5; //Field offset: 0x0
	public const int MAX_LAYERS = 50; //Field offset: 0x0
	public const int MIN_PATH_WIDTH = 1; //Field offset: 0x0
	public const int MAX_PATH_WIDTH = 3; //Field offset: 0x0
	public const int DEFAULT_PATH_WIDTH = 2; //Field offset: 0x0
	public const int CONSIDER_INFINITE = 1000; //Field offset: 0x0
	public const int SORTING_LAYER_BASE = 1000; //Field offset: 0x0
	public const float MAX_PATH_MOAB_SIZE_SCALE = 2; //Field offset: 0x0
	public const float MIN_PATH_BLOON_SIZE_SCALE = 0; //Field offset: 0x0
	public const float MAX_PATH_BLOON_SIZE_SCALE = 2; //Field offset: 0x0
	public const float PATH_SCALE_SETEP_SIZE = 0.25; //Field offset: 0x0
	public const int kAmbientFXIdOffset = 10000; //Field offset: 0x0
	public const int kFXIdOffset = 20000; //Field offset: 0x0
	public const int kPropsIdOffset = 30000; //Field offset: 0x0
	public const int kAreasIdOffset = 40000; //Field offset: 0x0
	public const int kTerrainsIdOffset = 50000; //Field offset: 0x0
	public const int kStampsIdOffset = 60000; //Field offset: 0x0
	public const int kTrackIdOffset = 70000; //Field offset: 0x0
	public const float MIN_PATH_BLOON_SPEED_SCALE = 0.5; //Field offset: 0x0
	public const float MAX_PATH_BLOON_SPEED_SCALE = 5; //Field offset: 0x0
	public PrefabReference mapEditorPath; //Field offset: 0x18
	public PrefabReference mapEditorArea; //Field offset: 0x20
	public PrefabReference mapEditorSceneControllerPrefab; //Field offset: 0x28
	public PrefabReference mapNodePrefab; //Field offset: 0x30
	public PrefabReference mapPathNodePrefab; //Field offset: 0x38
	public PrefabReference mapEditorTargetReticle; //Field offset: 0x40
	public PrefabReference mapEditorStampPrefab; //Field offset: 0x48
	public PrefabReference placementEffect; //Field offset: 0x50
	public PrefabReference placementEffectLarge; //Field offset: 0x58
	public PrefabReference sellEffect; //Field offset: 0x60
	public PrefabReference thumbnailPrefab; //Field offset: 0x68
	public SpriteShapeReference hiddenRevealedPathSpriteShape; //Field offset: 0x70
	[SerializeField]
	private List<MapEditorProp> mapEditorProps; //Field offset: 0x78
	[SerializeField]
	private List<MapEditorStampData> stampTextureData; //Field offset: 0x80
	[SerializeField]
	private List<MapEditorAreaTextureData> areaTextureData; //Field offset: 0x88
	[SerializeField]
	private List<MapEditorBaseMapTextureData> mapTextureData; //Field offset: 0x90
	[SerializeField]
	private List<MapEditorTrackTextureData> trackTextureData; //Field offset: 0x98

	public IEnumerable<MapEditorAreaTextureData> AreaTextureData
	{
		 get { } //Length: 8
	}

	public MapEditorBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public MapEditorBaseMapTextureData DefaultMapTextureData
	{
		 get { } //Length: 73
	}

	public IEnumerable<MapEditorProp> MapEditorProps
	{
		 get { } //Length: 70
	}

	public IEnumerable<MapEditorBaseMapTextureData> MapTextureData
	{
		 get { } //Length: 8
	}

	public IEnumerable<MapEditorStampData> StampTextureData
	{
		 get { } //Length: 8
	}

	public IEnumerable<MapEditorTrackTextureData> TrackTextureData
	{
		 get { } //Length: 8
	}

	public MapEditorData() { }

	public IEnumerable<MapEditorAreaTextureData> get_AreaTextureData() { }

	public MapEditorBehaviorModel get_Def() { }

	public MapEditorBaseMapTextureData get_DefaultMapTextureData() { }

	public IEnumerable<MapEditorProp> get_MapEditorProps() { }

	public IEnumerable<MapEditorBaseMapTextureData> get_MapTextureData() { }

	public IEnumerable<MapEditorStampData> get_StampTextureData() { }

	public IEnumerable<MapEditorTrackTextureData> get_TrackTextureData() { }

	private int GetGroupVarientCount(MapEditorItem item) { }

	private MapEditorItem GetItemById(MapEditorItem item) { }

	public ItemVarientData GetItemVarientData(MapEditorItem item) { }

	[AsyncStateMachine(typeof(<LoadMapEditorDataAsync>d__58))]
	public Task LoadMapEditorDataAsync() { }

	public static string PlayerFacingIdForItem(int itemId) { }

	public bool TryGetMapEditorAreaTextureData(int id, out MapEditorAreaTextureData data) { }

	public bool TryGetMapEditorBaseMapTextureData(int id, out MapEditorBaseMapTextureData data) { }

	public bool TryGetMapEditorProp(int id, out MapEditorProp data) { }

	public bool TryGetMapEditorStampData(int id, out MapEditorStampData data) { }

	public bool TryGetMapEditorTrackTextureData(int id, out MapEditorTrackTextureData data) { }

}

