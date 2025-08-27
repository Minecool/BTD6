namespace NinjaKiwi.GUTS.Utils.BTD6;

[Extension]
public static class CtMapGenerator
{
	[CompilerGenerated]
	private sealed class <>c__12
	{
		public static readonly <>c__12<T, T2> <>9; //Field offset: 0x0
		public static Func<T, Boolean> <>9__12_0; //Field offset: 0x0
		public static Func<T, Boolean> <>9__12_1; //Field offset: 0x0
		public static Func<T, Double> <>9__12_2; //Field offset: 0x0

		private static <>c__12`2() { }

		public <>c__12`2() { }

		internal bool <GenerateMap>b__12_0(T x) { }

		internal bool <GenerateMap>b__12_1(T x) { }

		internal double <GenerateMap>b__12_2(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__21
	{
		public static readonly <>c__21<T> <>9; //Field offset: 0x0
		public static Func<T, Boolean> <>9__21_0; //Field offset: 0x0

		private static <>c__21`1() { }

		public <>c__21`1() { }

		internal bool <RollBaseTileValues>b__21_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__24
	{
		public static readonly <>c__24<T> <>9; //Field offset: 0x0
		public static Func<T, Boolean> <>9__24_0; //Field offset: 0x0

		private static <>c__24`1() { }

		public <>c__24`1() { }

		internal bool <GetRandomisedTiles>b__24_0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__28
	{
		public static readonly <>c__28<T> <>9; //Field offset: 0x0
		public static Func<T, KeyValuePair`2<T, Single>> <>9__28_0; //Field offset: 0x0

		private static <>c__28`1() { }

		public <>c__28`1() { }

		internal KeyValuePair<T, Single> <AllocateTiles>b__28_0(T tile) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public float centralAreaRange; //Field offset: 0x0

		public <>c__DisplayClass22_0`1() { }

		internal bool <IsValidMap>b__0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public int x; //Field offset: 0x0
		public int y; //Field offset: 0x0

		public <>c__DisplayClass25_0`1() { }

		internal bool <FindTile>b__0(T t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public IEnumerable<T> excludedTiles; //Field offset: 0x0

		public <>c__DisplayClass26_0`1() { }

		internal bool <GetNeighbours>b__0(T x) { }

	}

	public static readonly Int32[] TeamStartingIndexes; //Field offset: 0x0
	private const int NegativeX = 10000000; //Field offset: 0x0
	private const int FactorX = 10000; //Field offset: 0x0
	private const int NegativeY = 1000; //Field offset: 0x0
	private const int FactorY = 1; //Field offset: 0x0
	private static readonly Dictionary<Int32, Int32> StartingAreaTileValues; //Field offset: 0x8
	[CompilerGenerated]
	private static readonly IReadOnlyDictionary<Int32, String> <TileCodes>k__BackingField; //Field offset: 0x10

	public static IReadOnlyDictionary<Int32, String> TileCodes
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	private static CtMapGenerator() { }

	private static double AllocateTiles(int count, CtTileType tileType, Random randomiser, double totalProbability, List<T> allTiles, List<T> emptyTiles) { }

	private static List<Int32> BreakIdIntoReversedDigits(int id) { }

	private static void CacheStartAreaTiles(int teamIndex, int teamStartAreaRange, T startingTile, List<T> allTiles, Dictionary<Int32, StartAreaTiles`1<T>> startAreaTiles) { }

	public static int ConvertCoordinatesToId(int x, int y) { }

	public static ValueTuple<Int32, Int32> ConvertIdToCoordinates(int id) { }

	private static ValueTuple<T[], Dictionary`2<Int32, StartAreaTiles`1<T2>>> CreateStartingAreas(Btd6CtSettings ctSettings, List<T2> allTiles) { }

	public static int DistanceToCenter(int x, int y) { }

	public static T FindTeamIndexStartingTile(int teamIndex, IEnumerable<T> allTiles, int mapSize) { }

	[Extension]
	public static T FindTile(IEnumerable<T> tiles, int x, int y) { }

	private static ValueTuple<List`1<T>, Dictionary`2<Int32, Int32[]>> GenerateAllTiles(int mapSize, bool generateTilesNeighbours) { }

	public static ValueTuple<List`1<T>, T2[], Dictionary`2<Int32, Int32[]>> GenerateMap(string eventId, Btd6CtSettings ctSettings, bool generateTilesNeighbours = false) { }

	[CompilerGenerated]
	public static IReadOnlyDictionary<Int32, String> get_TileCodes() { }

	[Extension]
	public static List<T> GetNeighbours(T source, IEnumerable<T> tiles, IEnumerable<T> excludedTiles = null) { }

	[Extension]
	private static T[] GetRandomisedTiles(IEnumerable<T> tiles) { }

	private static List<ContestedTerritoryRelicType> GetRandomRelicKnowledge(Random random, int maxCount) { }

	private static int GetTeamProximityScore(int teamIndex, Dictionary<Int32, StartAreaTiles`1<T>> cachedStartAreaTiles) { }

	public static float GetZipfProbability(int rank) { }

	private static bool IsNull(T obj) { }

	private static bool IsValid(int x, int y, int mapSize) { }

	private static bool IsValidMap(List<T> allTiles, Btd6CtSettings ctSettings, Dictionary<Int32, StartAreaTiles`1<T>> cachedStartAreaTiles) { }

	private static void RollBaseTileValues(List<T> allTiles, List<ContestedTerritoryRelicType> relicTypes, int eventSeed, CtMapGenerationSettings mapGenerationSettings) { }

}

