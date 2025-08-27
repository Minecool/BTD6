namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public static class ContestedTerritoryGameBoard
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContestedTerritoryIslandTile, Boolean> <>9__5_0; //Field offset: 0x8
		public static Func<Task`1<Boolean>, Boolean> <>9__5_2; //Field offset: 0x10
		public static Func<Task`1<Boolean>, Boolean> <>9__5_3; //Field offset: 0x18
		public static Func<Task`1<Boolean>, Boolean> <>9__5_1; //Field offset: 0x20
		public static Func<Task, Boolean> <>9__10_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <BuildAndAttachTo>b__5_0(ContestedTerritoryIslandTile x) { }

		internal bool <BuildAndAttachTo>b__5_1(Task<Boolean> x) { }

		internal bool <BuildAndAttachTo>b__5_2(Task<Boolean> x) { }

		internal bool <BuildAndAttachTo>b__5_3(Task<Boolean> x) { }

		internal bool <ToggleColourblindMode>b__10_0(Task x) { }

	}

	[CompilerGenerated]
	private struct <BuildAndAttachTo>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public GameObject parent; //Field offset: 0x20
		public float rotation; //Field offset: 0x28
		public EventName currentEvent; //Field offset: 0x2C
		private List<Task`1<Boolean>> <buildTileTasks>5__2; //Field offset: 0x30
		private IEnumerator<ContestedTerritoryIslandTile> <>7__wrap2; //Field offset: 0x38
		private ContestedTerritoryIslandTile <tile>5__4; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48
		private PlaceableAsset[] <>7__wrap4; //Field offset: 0x50
		private int <>7__wrap5; //Field offset: 0x58
		private PlaceableAsset <placeable>5__7; //Field offset: 0x60
		private TaskAwaiter<Boolean[]> <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BuildGameTile>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryIslandTile islandTile; //Field offset: 0x20
		public GameObject parent; //Field offset: 0x28
		public float rotation; //Field offset: 0x30
		public EventName currentEvent; //Field offset: 0x34
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreatePlaceable>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public PlaceableAsset placeable; //Field offset: 0x20
		public GameObject parent; //Field offset: 0x28
		public float rotation; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ToggleColourblindMode>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private List<Task> <reloadColourblindModeTasks>5__2; //Field offset: 0x28
		private Enumerator<Int32, ContestedTerritoryGameTile> <>7__wrap2; //Field offset: 0x30
		private KeyValuePair<Int32, ContestedTerritoryGameTile> <tile>5__4; //Field offset: 0x58
		private YieldAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly Dictionary<Int32, Single> TeamIndexRotation; //Field offset: 0x0
	private static int homeTileId; //Field offset: 0x8
	public static Dictionary<Int32, ContestedTerritoryGameTile> gameTiles; //Field offset: 0x10
	public static Vector3 homeIslandPosition; //Field offset: 0x18
	public static bool isColourblindMode; //Field offset: 0x24

	private static ContestedTerritoryGameBoard() { }

	[AsyncStateMachine(typeof(<BuildAndAttachTo>d__5))]
	public static Task<Boolean> BuildAndAttachTo(GameObject parent, float rotation, EventName currentEvent = 0) { }

	[AsyncStateMachine(typeof(<BuildGameTile>d__11))]
	private static Task<Boolean> BuildGameTile(ContestedTerritoryIslandTile islandTile, GameObject parent, float rotation, EventName currentEvent = 0) { }

	public static Vector3 ConvertHexCoordinateSpaceToWorldSpace(float x, float y) { }

	[AsyncStateMachine(typeof(<CreatePlaceable>d__12))]
	private static Task<Boolean> CreatePlaceable(PlaceableAsset placeable, GameObject parent, float rotation) { }

	public static Vector3 GetCameraFocusForTeam() { }

	public static float GetCameraRotationForTeam() { }

	public static bool IsBuilt() { }

	[AsyncStateMachine(typeof(<ToggleColourblindMode>d__10))]
	public static void ToggleColourblindMode() { }

}

