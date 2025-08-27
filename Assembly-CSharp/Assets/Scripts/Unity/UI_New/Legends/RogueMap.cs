namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueMap : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BossType, Boolean> <>9__51_2; //Field offset: 0x8
		public static Func<KeyValuePair`2<Vector2Int, RogueTileData>, Boolean> <>9__51_4; //Field offset: 0x10
		public static Func<KeyValuePair`2<Vector2Int, RogueTileData>, Boolean> <>9__51_0; //Field offset: 0x18
		public static Func<RogueTile, Boolean> <>9__54_0; //Field offset: 0x20
		public static Func<RogueTile, Boolean> <>9__54_3; //Field offset: 0x28
		public static Func<RogueTile, Boolean> <>9__54_4; //Field offset: 0x30
		public static Func<KeyValuePair`2<Vector2Int, RogueTile>, Boolean> <>9__54_1; //Field offset: 0x38
		public static Func<RogueTile, Boolean> <>9__54_5; //Field offset: 0x40
		public static Func<KeyValuePair`2<Vector2Int, RogueTile>, Boolean> <>9__56_0; //Field offset: 0x48
		public static Func<RogueTile, Boolean> <>9__61_0; //Field offset: 0x50
		public static Func<RogueTile, Boolean> <>9__63_0; //Field offset: 0x58
		public static Func<RogueTile, Boolean> <>9__67_0; //Field offset: 0x60
		public static Func<RogueTile, Boolean> <>9__69_0; //Field offset: 0x68
		public static Func<RogueTile, Boolean> <>9__115_0; //Field offset: 0x70
		public static Func<RogueTile, Boolean> <>9__128_0; //Field offset: 0x78

		private static <>c() { }

		public <>c() { }

		internal bool <CreateTileDatas>b__51_0(KeyValuePair<Vector2Int, RogueTileData> x) { }

		internal bool <CreateTileDatas>b__51_2(BossType x) { }

		internal bool <CreateTileDatas>b__51_4(KeyValuePair<Vector2Int, RogueTileData> x) { }

		internal bool <MoveNext>b__61_0(RogueTile x) { }

		internal bool <OnMovedToTile>b__63_0(RogueTile x) { }

		internal bool <PlayCompassClickedFx>b__69_0(RogueTile x) { }

		internal bool <PlayInitLoadingAnimation>b__128_0(RogueTile x) { }

		internal bool <RefreshTiles>b__54_0(RogueTile x) { }

		internal bool <RefreshTiles>b__54_1(KeyValuePair<Vector2Int, RogueTile> x) { }

		internal bool <RefreshTiles>b__54_3(RogueTile x) { }

		internal bool <RefreshTiles>b__54_4(RogueTile x) { }

		internal bool <RefreshTiles>b__54_5(RogueTile x) { }

		internal bool <ResetView>b__115_0(RogueTile x) { }

		internal bool <SetLegendaryTileFxAsync>b__67_0(RogueTile x) { }

		internal bool <SetTilePropAnimStates>b__56_0(KeyValuePair<Vector2Int, RogueTile> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass50_0
	{
		public int loadingTileCount; //Field offset: 0x10
		public Action <>9__0; //Field offset: 0x18

		public <>c__DisplayClass50_0() { }

		internal void <CreateTiles>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public RogueTile moveTile; //Field offset: 0x10
		public RogueMap <>4__this; //Field offset: 0x18

		public <>c__DisplayClass54_0() { }

		internal bool <RefreshTiles>b__2(RogueTile x) { }

	}

	[CompilerGenerated]
	private sealed class <BossPreview>d__125 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTile startTile; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <BossPreview>d__125(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <CreateTile>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTileData tileData; //Field offset: 0x28
		public float hexGridOffset; //Field offset: 0x30
		public Action onCompleted; //Field offset: 0x38
		private RogueTile <rogueTile>5__2; //Field offset: 0x40
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateTiles>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTileSaveData[] mapSaveData; //Field offset: 0x28
		private <>c__DisplayClass50_0 <>8__1; //Field offset: 0x30
		private List<Task> <tileLoadTasks>5__2; //Field offset: 0x38
		private RogueData <rogueData>5__3; //Field offset: 0x40
		private Vector3[] <points>5__4; //Field offset: 0x48
		private Int32[] <indices>5__5; //Field offset: 0x50
		private Enumerator<Vector2Int, RogueTile> <>7__wrap5; //Field offset: 0x58
		private YieldAwaiter <>u__1; //Field offset: 0x70
		private int <x>5__7; //Field offset: 0x74
		private float <hexOffsetter>5__8; //Field offset: 0x78
		private int <y>5__9; //Field offset: 0x7C
		private RogueTileData <tileData>5__10; //Field offset: 0x80
		private TaskAwaiter <>u__2; //Field offset: 0x88

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <CutScene>d__123 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public IEnumerator task; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <CutScene>d__123(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <GenerateMapAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetAdjacentTiles>d__73 : IEnumerable<RogueTile>, IEnumerable, IEnumerator<RogueTile>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private RogueTile <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private RogueTile tile; //Field offset: 0x28
		public RogueTile <>3__tile; //Field offset: 0x30
		public RogueMap <>4__this; //Field offset: 0x38
		private Vector2Int <coords>5__2; //Field offset: 0x40

		private override RogueTile System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.UI_New.Legends.RogueTile>.Current
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
		public <GetAdjacentTiles>d__73(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<RogueTile> System.Collections.Generic.IEnumerable<Assets.Scripts.Unity.UI_New.Legends.RogueTile>.GetEnumerator() { }

		[DebuggerHidden]
		private override RogueTile System.Collections.Generic.IEnumerator<Assets.Scripts.Unity.UI_New.Legends.RogueTile>.get_Current() { }

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
	private struct <OnMovedToTile>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTile toTile; //Field offset: 0x28
		public bool canAutoMove; //Field offset: 0x30
		private RogueTile <tileToMoveTo>5__2; //Field offset: 0x38
		private RogueTile <bossTile>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayActionTileAsync>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTile tile; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayBossDefeatedAnim>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayCompassClickedFx>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		private RogueTile <playerPosTile>5__2; //Field offset: 0x28
		private GameObject <fxObj>5__3; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayGameTileAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTile tile; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayInitLoadingAnimation>d__128 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		private bool <hasBeatenBoss>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetLegendaryTileFxAsync>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		private RogueTile[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private RogueTile <tile>5__4; //Field offset: 0x38
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetTileSelectableFxAsync>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		private RogueTile[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private RogueTile <tile>5__4; //Field offset: 0x38
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowMovementSelectableFx>d__66 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTile tile; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <SpawnBossAndWait>d__127 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public RogueMap <>4__this; //Field offset: 0x20
		public RogueTile bossTile; //Field offset: 0x28
		public float waitForSeconds; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <SpawnBossAndWait>d__127(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class CinematicEvent : MulticastDelegate
	{

		public CinematicEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int phase, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int phase) { }

	}

	private enum Direction
	{
		North = 0,
		NorthEast = 1,
		SouthEast = 2,
		South = 3,
		SouthWest = 4,
		NorthWest = 5,
	}

	private static readonly int kEnvMatColor; //Field offset: 0x0
	private const int kCinematicPhaseStart = 0; //Field offset: 0x0
	private const int kCinematicPhaseEnd = 1; //Field offset: 0x0
	private static readonly int kEnvMatSway; //Field offset: 0x4
	private static readonly int kEnvMatWobble; //Field offset: 0x8
	public GameObject tilesContainer; //Field offset: 0x20
	[SerializeField]
	private PrefabReference tilePrefab; //Field offset: 0x28
	[SerializeField]
	private Material environmentMaterial; //Field offset: 0x30
	[SerializeField]
	private int darkFallOffStart; //Field offset: 0x38
	[SerializeField]
	private int darkFallOffBandWidth; //Field offset: 0x3C
	[SerializeField]
	private List<Color> graduatedDarkColors; //Field offset: 0x40
	[SerializeField]
	private GameObject tileSelectableFxContainer; //Field offset: 0x48
	[SerializeField]
	private GameObject tileLegendaryFxContainer; //Field offset: 0x50
	[SerializeField]
	private PrefabReference tileSelectableFxPrefab; //Field offset: 0x58
	[SerializeField]
	private PrefabReference tileSelectableMovingFxPrefab; //Field offset: 0x60
	[SerializeField]
	private PrefabReference tileSelectableFxSpawnPrefab; //Field offset: 0x68
	[SerializeField]
	private PrefabReference tileSelectableFxActionPrefab; //Field offset: 0x70
	[SerializeField]
	private PrefabReference tileSelectableFxBossPrefab; //Field offset: 0x78
	[SerializeField]
	private PrefabReference legendaryTileFxPrefab; //Field offset: 0x80
	[SerializeField]
	private RogueMonkeyMovement rogueMonkey; //Field offset: 0x88
	[SerializeField]
	private PrefabReference compassClickedFx; //Field offset: 0x90
	[SerializeField]
	private GameObject selectionFXObj; //Field offset: 0x98
	[SerializeField]
	private float compassClickedDelay; //Field offset: 0xA0
	[SerializeField]
	private float bossDeathAnimTime; //Field offset: 0xA4
	[SerializeField]
	private float tileInteractDelay; //Field offset: 0xA8
	private List<GameObject> activeSelectableFx; //Field offset: 0xB0
	private List<GameObject> activeLegendaryFx; //Field offset: 0xB8
	private Dictionary<Vector2Int, RogueTile> activeTiles; //Field offset: 0xC0
	private RogueTile currentPositionTile; //Field offset: 0xC8
	[HideInInspector]
	public RogueMapScreen rogueMapScreen; //Field offset: 0xD0
	private readonly BossType[] bossRushBosses; //Field offset: 0xD8
	private readonly BossType[] bannedBosses; //Field offset: 0xE0
	private readonly Dictionary<UInt64, Material> environmentMaterials; //Field offset: 0xE8
	public Dictionary<Vector2Int, RogueTileData> activeTileDatas; //Field offset: 0xF0
	private Rect mapRect; //Field offset: 0xF8
	private IRandomAdapter rand; //Field offset: 0x108
	private readonly int maxTileLoadTasks; //Field offset: 0x110
	private readonly int maxTileDestroyTasks; //Field offset: 0x114
	private GameObject collisionMesh; //Field offset: 0x118
	private RogueTile selectedMiniPopupTile; //Field offset: 0x120
	[SerializeField]
	private float smallPopupTime; //Field offset: 0x128
	private float smallPopupTimer; //Field offset: 0x12C
	private bool isShowingCompassFx; //Field offset: 0x130
	public bool inputEnabled; //Field offset: 0x131
	private float clickTimer; //Field offset: 0x134
	private bool touchStarted; //Field offset: 0x138
	private Vector3 touchStartPos; //Field offset: 0x13C
	private bool isOverUI; //Field offset: 0x148
	private float zoomAmount; //Field offset: 0x14C
	private bool wasTwoFinger; //Field offset: 0x150
	private float zoomDelta; //Field offset: 0x154
	private int focussedSpawnTile; //Field offset: 0x158
	[SerializeField]
	private RogueMapCameraRig camRig; //Field offset: 0x160
	[SerializeField]
	private float pinchSpeedMultiplier; //Field offset: 0x168
	[SerializeField]
	private float mouseWheelSmoothingMul; //Field offset: 0x16C
	[SerializeField]
	private Vector3 focusOffset; //Field offset: 0x170
	[SerializeField]
	private float bossZoomHeight; //Field offset: 0x17C
	private bool isInCutscene; //Field offset: 0x180
	[SerializeField]
	private float groundPlaneHeight; //Field offset: 0x184

	private int GridSize
	{
		private get { } //Length: 82
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private LocalizationManager Locs
	{
		private get { } //Length: 48
	}

	private RogueData RogueData
	{
		private get { } //Length: 71
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	private static RogueMap() { }

	public RogueMap() { }

	[CompilerGenerated]
	private bool <CreateTileDatas>b__51_1(BossType x) { }

	[CompilerGenerated]
	private bool <CreateTileDatas>b__51_3(KeyValuePair<Vector2Int, RogueTileData> x) { }

	[CompilerGenerated]
	private bool <CreateTileDatas>b__51_5(RogueBloonModifierData x) { }

	[CompilerGenerated]
	private bool <GetMapData>b__53_0(RogueMapTemplate x) { }

	[CompilerGenerated]
	private bool <SetTileSelectableFxAsync>b__65_0(RogueTile x) { }

	public static bool AutoPlayTileType(RogueTileType type) { }

	private void Awake() { }

	[IteratorStateMachine(typeof(<BossPreview>d__125))]
	private IEnumerator BossPreview(RogueTile startTile) { }

	private bool CanSelectTile(RogueTile tile) { }

	private bool CanTypeBeLegendary(RogueTileType type) { }

	private bool CheckIfGameOver() { }

	private Color ColorAtDistance(int dist) { }

	private bool CompareTileIDs(RogueTile tileA, RogueTile tileB) { }

	[AsyncStateMachine(typeof(<CreateTile>d__52))]
	private Task CreateTile(RogueTileData tileData, float hexGridOffset, Action onCompleted) { }

	private Dictionary<Vector2Int, RogueTileData> CreateTileDatas(RogueTileSaveData[] saveData) { }

	[AsyncStateMachine(typeof(<CreateTiles>d__50))]
	private Task CreateTiles(RogueTileSaveData[] mapSaveData) { }

	[IteratorStateMachine(typeof(<CutScene>d__123))]
	private IEnumerator CutScene(IEnumerator task) { }

	public static void DestroyChildrenWithTag(Transform transform, string name) { }

	private bool DoesTileLeadToEnd(RogueTile tile) { }

	private static ulong EnvironmentMaterialHash(Color colour, float sway, float wobble) { }

	private Material FindMaterial(int dist, RogueEnvironment environment) { }

	private float FocusOnTile(RogueTile tile, bool instant = false, bool force = false, bool allowBossZoom = true) { }

	[AsyncStateMachine(typeof(<GenerateMapAsync>d__49))]
	public Task GenerateMapAsync() { }

	private int get_GridSize() { }

	private LegendsDataModel get_LegendsData() { }

	private LocalizationManager get_Locs() { }

	private RogueData get_RogueData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public List<RogueTileData> GetAdjacentTileDatas(Vector2Int coords, Dictionary<Vector2Int, RogueTileData> tileDatas) { }

	[IteratorStateMachine(typeof(<GetAdjacentTiles>d__73))]
	public IEnumerable<RogueTile> GetAdjacentTiles(RogueTile tile) { }

	private Vector2Int GetCoordsFromDirection(Vector2Int c, Direction direction) { }

	private RogueTile GetFinalBossTile() { }

	private RogueMapTemplate GetMapData() { }

	private void GetMouseInput() { }

	private List<RogueTileData> GetNextStandardTileData(RogueTileData tile, List<RogueTileData> excludeList, Dictionary<Vector2Int, RogueTileData> tileDatas) { }

	private Vector2 GetTileCanvasPosition(RogueTile tile) { }

	public RogueTileData GetTileDataFromCoords(Vector2Int coords, Dictionary<Vector2Int, RogueTileData> tileDatas) { }

	public RogueTile GetTileFromCoords(Vector2Int coords) { }

	private List<RogueTile> GetTileGroup(RogueTile tile) { }

	public Vector3 GetTileScreenPosition(RogueTile tile) { }

	public Vector3 GetTileViewportPosition(RogueTile tile) { }

	private Vector3 GetWorldPosition() { }

	private bool HasBeatenFinalBoss() { }

	public void HidePlayerObj() { }

	public static bool IsActionTileType(RogueTileType type) { }

	private static bool IsBoss(RogueTile tile) { }

	public bool IsTerrainTileType(RogueTileType type) { }

	private bool IsTileNextToBoss(RogueTile tile, out RogueTile bossTile) { }

	public bool IsTilePlayable(RogueTile tile) { }

	public void MoveNext(bool canAutoMove) { }

	private void MoveToTile(RogueTile tile, bool canAutoMove) { }

	private void OnCinematicEvent(int phase) { }

	[AsyncStateMachine(typeof(<OnMovedToTile>d__63))]
	private Task OnMovedToTile(RogueTile toTile, bool canAutoMove) { }

	[AsyncStateMachine(typeof(<PlayActionTileAsync>d__59))]
	private Task PlayActionTileAsync(RogueTile tile) { }

	[AsyncStateMachine(typeof(<PlayBossDefeatedAnim>d__55))]
	private Task PlayBossDefeatedAnim() { }

	[AsyncStateMachine(typeof(<PlayCompassClickedFx>d__69))]
	private Task PlayCompassClickedFx() { }

	[AsyncStateMachine(typeof(<PlayGameTileAsync>d__60))]
	public Task PlayGameTileAsync(RogueTile tile) { }

	[AsyncStateMachine(typeof(<PlayInitLoadingAnimation>d__128))]
	public Task PlayInitLoadingAnimation() { }

	private void PlaySound(RogueTileType tileType) { }

	public void RefreshTiles() { }

	public void ResetView() { }

	[AsyncStateMachine(typeof(<SetLegendaryTileFxAsync>d__67))]
	private Task SetLegendaryTileFxAsync() { }

	public void SetSelectionFx(RogueTile tile) { }

	private void SetTilePropAnimStates() { }

	[AsyncStateMachine(typeof(<SetTileSelectableFxAsync>d__65))]
	private Task SetTileSelectableFxAsync() { }

	[AsyncStateMachine(typeof(<ShowMovementSelectableFx>d__66))]
	private Task ShowMovementSelectableFx(RogueTile tile) { }

	private void SpawnBoss(RogueTile bossTile = null, bool instant = false) { }

	[IteratorStateMachine(typeof(<SpawnBossAndWait>d__127))]
	private IEnumerator SpawnBossAndWait(RogueTile bossTile, float waitForSeconds) { }

	public void TileClicked(RogueTile tile) { }

	public void ToggleInputEnabled(bool isEnabled) { }

	public static bool TypeEarnsTokenAfterGame(RogueTileType type) { }

	public static bool TypeHasMap(RogueTileType type) { }

	public static bool TypeMoveable(RogueTileType type) { }

	public static bool TypePlayable(RogueTileType type) { }

	private void Update() { }

	private void UpdateDescriptionPopup() { }

}

