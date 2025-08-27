namespace Assets.Scripts.ContestedTerritory;

public static class ContestedTerritoryMap
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContestedTerritoryTeamDetails, Boolean> <>9__32_0; //Field offset: 0x8
		public static Func<ContestedTerritoryIslandTile, Boolean> <>9__33_0; //Field offset: 0x10
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"tileId", "capturedTime"}])]
		public static Func<ValueTuple`2<Int32, DateTime>, DateTime> <>9__33_1; //Field offset: 0x18
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"tileId", "capturedTime"}])]
		public static Func<ValueTuple`2<Int32, DateTime>, Int32> <>9__33_2; //Field offset: 0x20
		public static Func<ContestedTerritoryIslandTile, Boolean> <>9__34_0; //Field offset: 0x28
		public static Func<ContestedTerritoryIslandTile, ContestedTerritoryRelicType> <>9__35_0; //Field offset: 0x30
		public static Func<ContestedTerritoryRelicType, Boolean> <>9__35_1; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateRulesAndAssignRelicItems>b__34_0(ContestedTerritoryIslandTile x) { }

		internal ContestedTerritoryRelicType <GetRelics>b__35_0(ContestedTerritoryIslandTile x) { }

		internal bool <GetRelics>b__35_1(ContestedTerritoryRelicType x) { }

		internal bool <SynchroniseTeams>b__32_0(ContestedTerritoryTeamDetails x) { }

		internal bool <SynchroniseTileCaptureStates>b__33_0(ContestedTerritoryIslandTile x) { }

		internal DateTime <SynchroniseTileCaptureStates>b__33_1(ValueTuple<Int32, DateTime> x) { }

		internal int <SynchroniseTileCaptureStates>b__33_2(ValueTuple<Int32, DateTime> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public int id; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <GetTileById>b__0(ContestedTerritoryIslandTile x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public string teamId; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <GetTeamIndexById>b__0(ContestedTerritoryTeamDetails x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public GuildInfo teamInfo; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal bool <SynchroniseTeams>b__1(ContestedTerritoryTeamDetails x) { }

	}

	[CompilerGenerated]
	private struct <GenerateMap>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Btd6CtSettings> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetRelics>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<ContestedTerritoryRelicType[]> <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TileMarkerSelected>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public int tileId; //Field offset: 0x20
		private CtTileFocusResult <result>5__2; //Field offset: 0x28
		private TaskAwaiter<CtTileFocusResult> <>u__1; //Field offset: 0x30
		private IEnumerator<ContestedTerritoryIslandTile> <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40
		private Enumerator<Int32> <>7__wrap3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public static readonly Int32[] TeamStartingIndexes; //Field offset: 0x0
	public static Action OnMapReset; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <HasBeenSynchronisedWithServer>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private static ContestedTerritoryTeamDetails[] <Teams>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private static IReadOnlyCollection<ContestedTerritoryIslandTile> <Tiles>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static Btd6CtSettings <CtSettings>k__BackingField; //Field offset: 0x28
	private static string mapsGuildId; //Field offset: 0x30

	private static CtEvent CtEvent
	{
		private get { } //Length: 138
	}

	public private static Btd6CtSettings CtSettings
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public private static bool HasBeenSynchronisedWithServer
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public static bool IsValidMap
	{
		 get { } //Length: 332
	}

	public static CtMapGenerationSettings MapGenerationSettings
	{
		 get { } //Length: 142
	}

	public private static ContestedTerritoryTeamDetails[] Teams
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public private static IReadOnlyCollection<ContestedTerritoryIslandTile> Tiles
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	private static ContestedTerritoryMap() { }

	[AsyncStateMachine(typeof(<GenerateMap>d__26))]
	public static Task GenerateMap() { }

	private static void GenerateRulesAndAssignRelicItems(List<ContestedTerritoryIslandTile> allTiles, CtMapGenerationSettings mapGenerationSettings) { }

	private static CtEvent get_CtEvent() { }

	[CompilerGenerated]
	public static Btd6CtSettings get_CtSettings() { }

	[CompilerGenerated]
	public static bool get_HasBeenSynchronisedWithServer() { }

	public static bool get_IsValidMap() { }

	public static CtMapGenerationSettings get_MapGenerationSettings() { }

	[CompilerGenerated]
	public static ContestedTerritoryTeamDetails[] get_Teams() { }

	[CompilerGenerated]
	public static IReadOnlyCollection<ContestedTerritoryIslandTile> get_Tiles() { }

	[AsyncStateMachine(typeof(<GetRelics>d__35))]
	public static Task<ContestedTerritoryRelicType[]> GetRelics() { }

	public static int GetTeamIndexById(string teamId) { }

	public static ContestedTerritoryIslandTile GetTileById(int id) { }

	public static void InitialiseFocusMarkers(IEnumerable<Int32> tileIds) { }

	public static void Reset() { }

	[CompilerGenerated]
	private static void set_CtSettings(Btd6CtSettings value) { }

	[CompilerGenerated]
	private static void set_HasBeenSynchronisedWithServer(bool value) { }

	[CompilerGenerated]
	private static void set_Teams(ContestedTerritoryTeamDetails[] value) { }

	[CompilerGenerated]
	private static void set_Tiles(IReadOnlyCollection<ContestedTerritoryIslandTile> value) { }

	private static List<Int32> SynchroniseTeams(ContestedTerritoryTeamDetails[] teams) { }

	private static ValueTuple<List`1<Int32>, List`1<Int32>> SynchroniseTileCaptureStates() { }

	public static ContestedTerritoryRefreshResult SynchroniseWithServerData(Nullable<Int32> lastTilePlayed = null, bool lastTilePlayedWasCaptured = false) { }

	[AsyncStateMachine(typeof(<TileMarkerSelected>d__31))]
	public static Task<Boolean> TileMarkerSelected(int tileId) { }

}

